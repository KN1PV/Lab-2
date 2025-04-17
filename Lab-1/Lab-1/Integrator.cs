using System;
using System.Linq;

namespace lab1
{
    public static class Integrator
    {
        public static double[] RungeKutta4(Func<double[], double[], double[]> derivatives, double[] y0, double t0, double tEnd, double h, double[] parameters)
        {
            int steps = (int)((tEnd - t0) / h);
            double[] y = (double[])y0.Clone();
            double t = t0;

            for (int i = 0; i < steps; i++)
            {
                double[] k1 = derivatives(y, parameters);
                double[] yTemp = y.Zip(k1, (yi, ki) => yi + 0.5 * h * ki).ToArray();
                double[] k2 = derivatives(yTemp, parameters);
                yTemp = y.Zip(k2, (yi, ki) => yi + 0.5 * h * ki).ToArray();
                double[] k3 = derivatives(yTemp, parameters);
                yTemp = y.Zip(k3, (yi, ki) => yi + h * ki).ToArray();
                double[] k4 = derivatives(yTemp, parameters);

                for (int j = 0; j < y.Length; j++)
                {
                    y[j] += h / 6.0 * (k1[j] + 2 * k2[j] + 2 * k3[j] + k4[j]);
                }
            }
            return y;
        }
    }
}