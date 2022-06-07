using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_3._0
{
    internal class ModuleFileWork
    {
        public static void MethodResults(string function, double[] res, double[] res2,
            double[] err, double[] err2, int[] n, double a, double b)
        {
            string localtTime = DateTime.Now.ToLongTimeString();
            string path = "Methods_Results.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(localtTime);
                writer.WriteLine($"F(x) = {function}");
                writer.WriteLine($"Верхний предел интегрирования {b}");
                writer.WriteLine($"Нижний предел интегрирования {a}");
                writer.WriteLine("Метод Чебышева:");
                for (int i = 0; i < n.Length; i++)
                {
                    writer.WriteLine($"Кол-во узлов = {n[i]} : {res[i]}\tОшибка : {err[i]}");
                }
                writer.WriteLine("Метод Гаусса:");
                for (int i = 0; i < n.Length; i++)
                {
                    writer.WriteLine($"Кол-во узлов = {n[i]} : {res2[i]}\tОшибка : {err2[i]}");
                }
                writer.WriteLine();
            }
        }

        public static void GraphResults(string function, double h, object x, object y)
        {
            string localtTime = DateTime.Now.ToLongTimeString();
            string path = "Graph_Results.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                if (function != null && h != 0)
                {
                    writer.WriteLine();
                    writer.WriteLine(localtTime);
                    writer.WriteLine($"F(x) = {function}, h = {h}");
                }

                if (x != null && y != null)
                {
                    writer.WriteLine($"x = {x}; y = {y}");
                }
            }
        }
    }
}
