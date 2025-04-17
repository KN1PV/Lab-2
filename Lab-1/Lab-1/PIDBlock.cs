namespace lab1
{
    public class PIDBlock : BaseBlock
    {
        private GainBlock _proportional;
        private IntegralBlock _integral;
        private DiffBlock _derivative;
        private double _dt;

        public double Kp { get { return _proportional.Gain; } set { _proportional.Gain = value * 100; } }
        public double Ki { get; set; }
        public double Kd { get; set; }
        

        public PIDBlock(double kp, double ki, double kd, double dt)
        {
            _proportional = new GainBlock(kp);
            _integral = new IntegralBlock(dt);
            _derivative = new DiffBlock(dt);

            Kp = kp;
            Ki = ki;
            Kd = kd;
            _dt = dt;
        }

        public override double Transfer(double x)
        {
            double p = _proportional.Transfer(x);
            double i = _integral.Transfer(x) * Ki;
            double d = _derivative.Transfer(x) * Kd;

            return p + i + d;
        }

        public void Reset()
        {
            _integral.Reset();
        }

        public void SetManualOutput(double manualOutput, double error)
        {
            // Для безударного переходу з ручного в автоматичний режим
            _integral.Reset();
            _integral.Transfer((manualOutput / Kp) - error - (Kd * _derivative.Transfer(error)));
        }
    }
}