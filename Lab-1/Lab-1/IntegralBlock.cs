namespace lab1
{
    public class IntegralBlock : BaseBlock
    {
        private double sum = 0;
        private double prev = 0;
        private double dt;

        public IntegralBlock(double dt)
        {
            this.dt = dt;
        }

        public override double Transfer(double x)
        {
            sum += (prev + x) * dt / 2;
            prev = x;
            return sum;
        }

        public void Reset()
        {
            sum = 0;
            prev = 0;
        }
    }
}