using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Course_work_3._0;

namespace Course_Work_3._0
{
    public partial class Form2 : Form
    {
        public Form2(string function)
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            txtBox_Function.Text = function;
            comboBox1.Items.AddRange(new string[] {"Spline", "Line", "Point"});
        }
        Axis ax = new Axis();
        Axis ay = new Axis();
        public double xright;
        public double xleft;
        public double yright;
        public double yleft;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                default_values();
                string func = txtBox_Function.Text;
                double A = Convert.ToDouble(txtBox_A.Text);
                double B = Convert.ToDouble(txtBox_B.Text);
                double h = Convert.ToDouble(txtBox_h.Text);
                double x, y;
                chart1.Series[0].Points.Clear();
                ax.Title = "X";
                chart1.ChartAreas[0].AxisX = ax;
                ay.Title = "Y";
                chart1.ChartAreas[0].AxisY = ay;
                x = A;
                xleft = A;
                xright = B;
                yleft = Math.Round(ModuleFunction.func(xleft, func), 5);
                yright = Math.Round(ModuleFunction.func(xright, func), 5);
                ModuleFileWork.GraphResults(func, h, null, null);
                while (x < B + h)
                {
                    y = Math.Round(ModuleFunction.func(x, func), 5);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    ModuleFileWork.GraphResults(null, 0, x, y);
                    x += h;
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Error");
            }
        }

        private void txtBox_A_TextChanged(object sender, EventArgs e)
        {
            ModuleFunction.check_dot(txtBox_A.Text);
        }

        private void txtBox_Function_TextChanged(object sender, EventArgs e)
        {
            ModuleFunction.check_dot(txtBox_Function.Text);
        }

        private void txtBox_B_TextChanged(object sender, EventArgs e)
        {
            ModuleFunction.check_dot(txtBox_B.Text);
        }

        private void txtBox_h_TextChanged(object sender, EventArgs e)
        {
            ModuleFunction.check_dot(txtBox_h.Text);
        }

        public void default_values()
        {
            ax.Maximum = Double.NaN;
            ay.Maximum = Double.NaN;
            ax.Minimum = Double.NaN;
            ay.Minimum = Double.NaN;
            txtBox_Xmin.Text = "";
            txtBox_Xmax.Text = "";
            txtBox_Ymin.Text = "";
            txtBox_Ymax.Text = "";
        }

        private void txtBox_Xmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBox_Xmin.Text != "")
                {
                    ax.Minimum = Convert.ToDouble(txtBox_Xmin.Text);
                }
                else
                {
                    ax.Maximum = Double.NaN;
                }
            }
        }

        private void txtBox_Xmax_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtBox_Xmax.Text != "")
                {
                    ax.Maximum = Convert.ToDouble(txtBox_Xmax.Text);
                }
                else
                {
                    ax.Maximum = Double.NaN;
                }
            }
        }

        private void txtBox_Ymin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtBox_Ymin.Text != "")
                {
                    ay.Minimum = Convert.ToDouble(txtBox_Ymin.Text);
                }
                else
                {
                    ay.Minimum = Double.NaN;
                }
            }
        }

        private void txtBox_Ymax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBox_Ymax.Text != "")
                {
                    ay.Maximum = Convert.ToDouble(txtBox_Ymax.Text);
                }
                else
                {
                    ay.Maximum = Double.NaN;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            chart1.Series[0].BorderWidth = Convert.ToInt32(numericUpDown1.Text);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            chart1.Series[0].MarkerSize = Convert.ToInt32(numericUpDown2.Text);
        }

        private void btn_black_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Color = Color.Black;
        }

        private void btn_Fuchsia_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Color = Color.Fuchsia;
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Color = Color.Red;
        }

        private void btn_gold_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Color = Color.Gold;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Spline":
                {
                    chart1.Series[0].ChartType = SeriesChartType.Spline;
                }
                    break;
                case "Line":
                {
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                }
                    break;
                case "Point":
                {
                    chart1.Series[0].ChartType = SeriesChartType.Point;
                }
                    break;
                default: chart1.Series[0].ChartType = SeriesChartType.Spline;
                    break;
            }
        }
    }
}
