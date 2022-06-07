using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Course_work_3._0
{
    internal static class ModuleFunction
    {
        public static double func(double x, string myfunc)
        {
            Function mxFunction = new Function($"f(x) = {myfunc}");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Expression MxExpression = new Expression($"f({x})", mxFunction);
            return MxExpression.calculate();
        }

        public static void check_dot(string str)
        {
            if (str.EndsWith(","))
            {
                MessageBox.Show("Используйте точку", "Синтаксическая ошибка");
            }
        }

    }
}

