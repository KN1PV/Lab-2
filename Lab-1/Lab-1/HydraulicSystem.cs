using SampleModel.Blocks;
using System;

namespace lab1
{
    public class HydraulicSystem
    {
        public double D1 { get; } = 0.3;
        public double D2 { get; } = 0.2;
        public double AlphaIn1 { get; } = 0.0583;
        public double AlphaIn2 { get; } = 0.0583;
        public double AlphaOut2 { get; } = 0.0183;
        public double DIn1 { get; } = 0.01;
        public double DIn2 { get; } = 0.019;
        public double DOut1 { get; } = 0.02;
        public double DOut2 { get; } = 0.02;
        public double D1_2 { get; } = 0.02;
        public double PIn1 { get; } = 1.0;
        public double PIn2 { get; } = 0.5;
        public double POut1 { get; } = 0.05;
        public double POut2 { get; } = 0.05;
        //public double X1 { get { return x1; } set { x1 = LimitBlock.Transfer(value); } }
        //public double X2 { get { return x2; } set { x2 = LimitBlock.Transfer(value); } }
        //public double XOut1 { get { return xOut1; } set { xOut1 = LimitBlock.Transfer(value); } }

        //private double x1;
        //private double x2;
        //private double xOut1;
        private LimitBlock LimitBlock { get; } = new LimitBlock(0, 100);

        private double _gin1 = 100;
        private double _gin2 = 100;
        private double _gout1 = 90;
        public double Gin1
        {
            get => _gin1;
            set => _gin1 = Math.Clamp(value, 0, 100);
        }
        public double Gin2
        {
            get => _gin2;
            set => _gin2 = Math.Clamp(value, 0, 100);
        }
        public double Gout1
        {
            get => _gout1;
            set => _gout1 = Math.Clamp(value, 0, 100);
        }

        public double Z1 { get; set; } = 0.2;
        public double Z2 { get; set; } = 0.1;

        public double Alpha1_2 { get; private set; }
        public double AlphaOut1 { get; private set; }

        public HydraulicSystem()
        {
            UpdateCoefficients();
        }

        public void UpdateCoefficients()
        {
            double sqrtZ1Z2 = Math.Sqrt(Math.Max(0, Z1 - Z2));
            double sqrtZ1POut2 = Math.Sqrt(Math.Max(0, Z1 - POut2));
            double sqrtZ2POut1 = Math.Sqrt(Math.Max(0, Z2 - POut1));

            double numeratorAlpha1_2 = (AlphaIn1 * (Gin1 / 100)) * (Math.PI * Math.Pow(DIn1, 2) / 4) * Math.Sqrt(PIn1)
                                     - AlphaOut2 * (Math.PI * Math.Pow(DOut2, 2) / 4) * sqrtZ1POut2;
            double denominatorAlpha1_2 = (Math.PI * Math.Pow(D1_2, 2) / 4) * sqrtZ1Z2;
            Alpha1_2 = denominatorAlpha1_2 != 0 ? numeratorAlpha1_2 / denominatorAlpha1_2 : 0;

            double numeratorAlphaOut1 = (AlphaIn2 * (Gin2 / 100)) * (Math.PI * Math.Pow(DIn2, 2) / 4) * Math.Sqrt(PIn2)
                                      + Alpha1_2 * (Math.PI * Math.Pow(D1_2, 2) / 4) * sqrtZ1Z2;
            double denominatorAlphaOut1 = (Math.PI * Math.Pow(DOut1, 2) / 4) * sqrtZ2POut1;
            AlphaOut1 = denominatorAlphaOut1 != 0 ? numeratorAlphaOut1 / denominatorAlphaOut1 : 0;
        }

        public double[] CalculateDerivatives(double[] z, double[] d)
        {
            double z1 = Math.Max(0, z[0]);
            double z2 = Math.Max(0, z[1]);

            double GIn1 = (AlphaIn1 * (Gin1 / 100)) * (Math.PI * Math.Pow(d[0], 2) / 4) * Math.Sqrt(PIn1);
            double GIn2 = (AlphaIn2 * (Gin2 / 100)) * (Math.PI * Math.Pow(d[1], 2) / 4) * Math.Sqrt(PIn2);
            double GOut1 = (AlphaOut1 * (Gout1 / 100)) * (Math.PI * Math.Pow(d[2], 2) / 4) * Math.Sqrt(Math.Max(0, z2 - POut1));
            double GOut2 = AlphaOut2 * (Math.PI * Math.Pow(DOut2, 2) / 4) * Math.Sqrt(Math.Max(0, z1 - POut2));
            double G1_2 = Alpha1_2 * (Math.PI * Math.Pow(D1_2, 2) / 4) * Math.Sqrt(Math.Max(0, z1 - z2));

            double dV1_dt = GIn1 - G1_2 - GOut2;
            double dV2_dt = G1_2 + GIn2 - GOut1;

            double dz1_dt = dV1_dt / (Math.PI * Math.Pow(D1, 2) / 4);
            double dz2_dt = dV2_dt / (Math.PI * Math.Pow(D2, 2) / 4);

            return new[] { dz1_dt, dz2_dt };
        }
    }
}