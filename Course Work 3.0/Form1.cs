using System;
using System.Windows.Forms;
using Course_work_3._0;

namespace Course_Work_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
        public void Clear()
        {
            listBox_ChebErr.Items.Clear();
            listBox_GaussErr.Items.Clear();
            listBox_ChebishevAnsw.Items.Clear();
            listBox_GaussAnsw.Items.Clear();

            listBox_ChebishevAnsw.Items.Add("Метод Чебышева:");
            listBox_GaussAnsw.Items.Add("Метод Гаусса:");
            listBox_ChebErr.Items.Add("погрешность метода Чебышева:");
            listBox_GaussErr.Items.Add("погрешность метода Гаусса:");
        }

        private void btn_FindSolution_Click(object sender, EventArgs e)
        {
            if (txtBox_formula.Text != "" && txtBox_Lower.Text != "" && txtBox_Upper.Text != "")
            {
                try
                {
                    Clear();
                    double A = Convert.ToDouble(txtBox_Lower.Text);
                    double B = Convert.ToDouble(txtBox_Upper.Text);
                    string function = txtBox_formula.Text;
                    double[] res = ModuleMethods.Chebishev(A, B, function);
                    double[] res2 = ModuleMethods.Gauss(A, B, function);
                    for (int i = 0; i < res.Length; i++)
                    {
                        listBox_ChebishevAnsw.Items.Add($"кол-во узлов = {ModuleMethods.n[i]} : {res[i]}");
                        listBox_GaussAnsw.Items.Add($"кол-во узлов = {ModuleMethods.n[i]} : {res2[i]}");
                    }
                    double[] err1 = ModuleMethods.MethodsErrors(res, res2[3]);
                    double[] err2 = ModuleMethods.MethodsErrors(res2, res2[3]);
                    for (int i = 0; i < res2.Length; i++)
                    {
                        listBox_ChebErr.Items.Add(err1[i]);
                        listBox_GaussErr.Items.Add(err2[i]);
                    }
                    ModuleFileWork.MethodResults(function, res, res2, err1, err2, ModuleMethods.n, A, B);
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность введенных данных", "Error");
                }

            }
            else
            {
                MessageBox.Show("Введите подынтегральное выражение/пределы интегрирования", "Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox_formula.Text != "")
            {
                Form2 newForm2 = new Form2(txtBox_formula.Text);
                newForm2.Show();
            }
            else
            {
                MessageBox.Show("Заполните поле функции!", "Error");
            }
        }

        //public static void check_box(string str)
        //{
        //    double num;
        //    bool isnum = double.TryParse(str, out num);
        //    if (!isnum)
        //    {
        //        MessageBox.Show("Введите число!", "Error");
        //    }
        //}

        private void txtBox_formula_TextChanged(object sender, EventArgs e)
        {
            ModuleFunction.check_dot(txtBox_formula.Text);
        }

        private void txtBox_Upper_TextChanged(object sender, EventArgs e)
        {
            ModuleFunction.check_dot(txtBox_Upper.Text);
        }

        private void txtBox_Lower_TextChanged(object sender, EventArgs e)
        {
            ModuleFunction.check_dot(txtBox_Lower.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBox_formula.Text = null;
            txtBox_Lower.Text = null;
            txtBox_Upper.Text = null;
            listBox_ChebErr.Items.Clear();
            listBox_ChebishevAnsw.Items.Clear();
            listBox_GaussAnsw.Items.Clear();
            listBox_GaussErr.Items.Clear();
        }
    }
}
