using System;

namespace Course_work_3._0
{
    internal static class ModuleMethods
    {
        public static int[] n = new[] { 2, 3, 4, 5 };

        public static double[,] xi_Chebishev = new double[,]
        {
            {0.577350, -0.577350, 0.0, 0.0, 0.0},
            {0.707107, 0.0, -0.707107, 0.0, 0.0},
            {0.794654, 0.187592, -0.187592, -0.794654, 0.0},
            {0.832498, 0.374541, 0, -0.374541, -0.832498}
        };

        public static double[,] xi_Gauss = new double[,]
        {
            {-0.577350269, 0.577350269, 0.0, 0.0, 0.0},
            {-0.774596669, 0.0, 0.774596669, 0.0, 0.0},
            {-0.861136312, -0.339981044, 0.339981044, 0.861136312, 0.0},
            {-0.906179846, -0.538469310, 0.0, 0.538469310, 0.906179846}
        };

        public static double[,] wi_Gauss = new double[,]
        {
            {1.0, 1.0, 0.0, 0.0, 0.0},
            {0.555555556, 0.888888889, 0.555555556, 0.0, 0.0},
            {0.347854845, 0.652145155, 0.652145155, 0.347854845, 0.0},
            {0.236926885, 0.478628670, 0.568888889, 0.478628670, 0.236926885}
        };

        public static double X_func(double xi, double a, double b)
        {
            return (b + a) / 2 + (b - a) / 2 * xi;
        }

        public static double E_func(double xi, double a, double b)
        {
            return (b + a) / 2 + (b - a) / 2 * xi;
        }


        public static double[] Chebishev(double A, double B, string funcion)
        {
            double[] answCheb = new double[n.Length];
            double Cn, xi;
            for (int i = 0; i < n.Length; i++)
            {
                double[] X_i = new double[n[i]];
                for (int j = 0; j < n[i]; j++)
                {
                    X_i[j] = X_func(xi_Chebishev[i, j], A, B);
                }

                Cn = (B - A) / n[i];

                double sum = 0;

                for (int j = 0; j < n[i]; j++)
                {
                    sum += ModuleFunction.func(X_i[j], funcion);
                }
                answCheb[i] = Math.Round(Cn * sum, 11);
            }
            return answCheb;
        }

        public static double[] Gauss(double A, double B, string funcion)
        {
            double[] answGauss = new double[n.Length];
            double Cn = (B - A) / 2;
            for (int i = 0; i < n.Length; i++)
            {
                double[] Ei = new double[n[i]];
                for (int j = 0; j < n[i]; j++)
                {
                    Ei[j] = E_func(xi_Gauss[i, j], A, B);
                }
                double sum = 0;
                for (int j = 0; j < n[i]; j++)
                {
                    sum += wi_Gauss[i, j] * ModuleFunction.func(Ei[j], funcion);
                }
                answGauss[i] = Math.Round(Cn * sum, 11);
            }
            return answGauss;
        }

        public static double[] MethodsErrors(double[] res, double ideal_value)
        {
            double[] err = new double[res.Length];
            for (int i = 0; i < res.Length; i++)
            {
                err[i] = Math.Abs(res[i] - ideal_value);
            }
            return err;
        }
    }
}