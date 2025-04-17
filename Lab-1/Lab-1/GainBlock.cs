namespace lab1
{
    public class GainBlock : BaseBlock
    {
        public double Gain { get; set; }

        public GainBlock(double gain)
        {
            Gain = gain;
        }

        public override double Transfer(double x)
        {
            return Gain * x;
        }
    }
}