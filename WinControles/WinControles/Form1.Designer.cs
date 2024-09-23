namespace WinControles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            grp1 = new GroupBox();
            bttn1 = new Button();
            l3 = new Label();
            l2 = new Label();
            l1 = new Label();
            t3 = new TextBox();
            t2 = new TextBox();
            t1 = new TextBox();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(bttn1);
            grp1.Controls.Add(l3);
            grp1.Controls.Add(l2);
            grp1.Controls.Add(l1);
            grp1.Controls.Add(t3);
            grp1.Controls.Add(t2);
            grp1.Controls.Add(t1);
            grp1.Location = new Point(191, 89);
            grp1.Name = "grp1";
            grp1.Size = new Size(418, 209);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "Salario por hora";
            // 
            // bttn1
            // 
            bttn1.Location = new Point(326, 171);
            bttn1.Name = "bttn1";
            bttn1.Size = new Size(75, 23);
            bttn1.TabIndex = 6;
            bttn1.Text = "SEND";
            bttn1.UseVisualStyleBackColor = true;
            bttn1.Click += button1_Click;
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(251, 52);
            l3.Name = "l3";
            l3.Size = new Size(59, 15);
            l3.TabIndex = 5;
            l3.Text = "Resultado";
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Location = new Point(21, 94);
            l2.Name = "l2";
            l2.Size = new Size(90, 15);
            l2.TabIndex = 4;
            l2.Text = "Salario por hora";
            l2.Click += label2_Click;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(21, 54);
            l1.Name = "l1";
            l1.Size = new Size(95, 15);
            l1.TabIndex = 3;
            l1.Text = "Horas trabajadas";
            l1.Click += label1_Click;
            // 
            // t3
            // 
            t3.Location = new Point(251, 70);
            t3.Name = "t3";
            t3.Size = new Size(100, 23);
            t3.TabIndex = 2;
            // 
            // t2
            // 
            t2.Location = new Point(136, 91);
            t2.Name = "t2";
            t2.Size = new Size(82, 23);
            t2.TabIndex = 1;
            // 
            // t1
            // 
            t1.Location = new Point(136, 51);
            t1.Name = "t1";
            t1.Size = new Size(82, 23);
            t1.TabIndex = 0;
            t1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private TextBox t3;
        private TextBox t2;
        private TextBox t1;
        private Label l1;
        private Label l2;
        private Button bttn1;
        private Label l3;
    }
}
