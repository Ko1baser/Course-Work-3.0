using System.Windows.Forms;


namespace Course_Work_3._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_formula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Upper = new System.Windows.Forms.TextBox();
            this.txtBox_Lower = new System.Windows.Forms.TextBox();
            this.btn_FindSolution = new System.Windows.Forms.Button();
            this.listBox_GaussAnsw = new System.Windows.Forms.ListBox();
            this.listBox_ChebishevAnsw = new System.Windows.Forms.ListBox();
            this.listBox_ChebErr = new System.Windows.Forms.ListBox();
            this.listBox_GaussErr = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_formula
            // 
            this.txtBox_formula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_formula.Location = new System.Drawing.Point(68, 24);
            this.txtBox_formula.Name = "txtBox_formula";
            this.txtBox_formula.Size = new System.Drawing.Size(196, 26);
            this.txtBox_formula.TabIndex = 0;
            this.txtBox_formula.TextChanged += new System.EventHandler(this.txtBox_formula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "верхний предел интегрирования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "нижний предел интегрирования";
            // 
            // txtBox_Upper
            // 
            this.txtBox_Upper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Upper.Location = new System.Drawing.Point(10, 62);
            this.txtBox_Upper.Name = "txtBox_Upper";
            this.txtBox_Upper.Size = new System.Drawing.Size(86, 26);
            this.txtBox_Upper.TabIndex = 5;
            this.txtBox_Upper.TextChanged += new System.EventHandler(this.txtBox_Upper_TextChanged);
            // 
            // txtBox_Lower
            // 
            this.txtBox_Lower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Lower.Location = new System.Drawing.Point(10, 89);
            this.txtBox_Lower.Name = "txtBox_Lower";
            this.txtBox_Lower.Size = new System.Drawing.Size(86, 26);
            this.txtBox_Lower.TabIndex = 6;
            this.txtBox_Lower.TextChanged += new System.EventHandler(this.txtBox_Lower_TextChanged);
            // 
            // btn_FindSolution
            // 
            this.btn_FindSolution.Location = new System.Drawing.Point(10, 121);
            this.btn_FindSolution.Name = "btn_FindSolution";
            this.btn_FindSolution.Size = new System.Drawing.Size(86, 20);
            this.btn_FindSolution.TabIndex = 7;
            this.btn_FindSolution.Text = "Рассчитать";
            this.btn_FindSolution.UseVisualStyleBackColor = true;
            this.btn_FindSolution.Click += new System.EventHandler(this.btn_FindSolution_Click);
            // 
            // listBox_GaussAnsw
            // 
            this.listBox_GaussAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_GaussAnsw.FormattingEnabled = true;
            this.listBox_GaussAnsw.ItemHeight = 16;
            this.listBox_GaussAnsw.Location = new System.Drawing.Point(270, 134);
            this.listBox_GaussAnsw.Name = "listBox_GaussAnsw";
            this.listBox_GaussAnsw.Size = new System.Drawing.Size(260, 100);
            this.listBox_GaussAnsw.TabIndex = 13;
            // 
            // listBox_ChebishevAnsw
            // 
            this.listBox_ChebishevAnsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_ChebishevAnsw.FormattingEnabled = true;
            this.listBox_ChebishevAnsw.ItemHeight = 16;
            this.listBox_ChebishevAnsw.Location = new System.Drawing.Point(270, 24);
            this.listBox_ChebishevAnsw.Name = "listBox_ChebishevAnsw";
            this.listBox_ChebishevAnsw.Size = new System.Drawing.Size(260, 100);
            this.listBox_ChebishevAnsw.TabIndex = 12;
            // 
            // listBox_ChebErr
            // 
            this.listBox_ChebErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_ChebErr.FormattingEnabled = true;
            this.listBox_ChebErr.ItemHeight = 16;
            this.listBox_ChebErr.Location = new System.Drawing.Point(536, 24);
            this.listBox_ChebErr.Name = "listBox_ChebErr";
            this.listBox_ChebErr.Size = new System.Drawing.Size(260, 100);
            this.listBox_ChebErr.TabIndex = 14;
            // 
            // listBox_GaussErr
            // 
            this.listBox_GaussErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_GaussErr.FormattingEnabled = true;
            this.listBox_GaussErr.ItemHeight = 16;
            this.listBox_GaussErr.Location = new System.Drawing.Point(536, 134);
            this.listBox_GaussErr.Name = "listBox_GaussErr";
            this.listBox_GaussErr.Size = new System.Drawing.Size(260, 100);
            this.listBox_GaussErr.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "Построить график функции на определенном интервале";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "F(x) =";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 20);
            this.button2.TabIndex = 18;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 251);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_GaussErr);
            this.Controls.Add(this.listBox_ChebErr);
            this.Controls.Add(this.listBox_GaussAnsw);
            this.Controls.Add(this.listBox_ChebishevAnsw);
            this.Controls.Add(this.btn_FindSolution);
            this.Controls.Add(this.txtBox_Lower);
            this.Controls.Add(this.txtBox_Upper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_formula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtBox_Upper;
        private TextBox txtBox_Lower;
        private Button btn_FindSolution;
        private ListBox listBox_GaussAnsw;
        private ListBox listBox_ChebishevAnsw;
        private ListBox listBox_ChebErr;
        private ListBox listBox_GaussErr;
        private Button button1;
        private Label label3;
        public TextBox txtBox_formula;
        private Button button2;
    }
}

