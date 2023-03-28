
namespace WindowsFormsApp2_1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.doubleRes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelRes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(290, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(313, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio1.Location = new System.Drawing.Point(3, 26);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(149, 41);
            this.radio1.TabIndex = 2;
            this.radio1.TabStop = true;
            this.radio1.Text = "x^2 + 3";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.Radio_Changed);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio2.Location = new System.Drawing.Point(3, 73);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(149, 41);
            this.radio2.TabIndex = 3;
            this.radio2.TabStop = true;
            this.radio2.Text = "cos(x)";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.Radio_Changed);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio3.Location = new System.Drawing.Point(3, 120);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(149, 41);
            this.radio3.TabIndex = 4;
            this.radio3.TabStop = true;
            this.radio3.Text = "x^2 + 3x";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.Radio_Changed);
            // 
            // doubleRes
            // 
            this.doubleRes.AutoSize = true;
            this.doubleRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubleRes.Location = new System.Drawing.Point(468, 3);
            this.doubleRes.Name = "doubleRes";
            this.doubleRes.Size = new System.Drawing.Size(149, 17);
            this.doubleRes.TabIndex = 5;
            this.doubleRes.Text = "double result";
            this.doubleRes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(468, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(158, 117);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(0, 13);
            this.labelRes.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.radio3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radio1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radio2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.doubleRes, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelRes, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(447, 152);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22223F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 213);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 213);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(636, 252);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.CheckBox doubleRes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

