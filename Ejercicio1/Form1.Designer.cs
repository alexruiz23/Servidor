namespace Ejercicio1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            bttn1 = new Button();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(bttn1);
            grp1.Controls.Add(txt3);
            grp1.Controls.Add(txt2);
            grp1.Controls.Add(txt1);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(49, 57);
            grp1.Name = "grp1";
            grp1.Size = new Size(518, 331);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "salario";
            grp1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 97);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Horas Trabajadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 174);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Salario Ph";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 131);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Salario Total";
            // 
            // txt1
            // 
            txt1.Location = new Point(157, 94);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 3;
            txt1.TextChanged += textBox1_TextChanged;
            // 
            // txt2
            // 
            txt2.Location = new Point(157, 166);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 4;
            txt2.TextChanged += textBox2_TextChanged;
            // 
            // txt3
            // 
            txt3.Location = new Point(361, 128);
            txt3.Name = "txt3";
            txt3.Size = new Size(100, 23);
            txt3.TabIndex = 5;
            // 
            // bttn1
            // 
            bttn1.Location = new Point(225, 245);
            bttn1.Name = "bttn1";
            bttn1.Size = new Size(75, 23);
            bttn1.TabIndex = 6;
            bttn1.Text = "Operacion";
            bttn1.UseVisualStyleBackColor = true;
            bttn1.Click += bttn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private Label label2;
        private Label label1;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txt1;
        private Label label3;
        private Button bttn1;
    }
}
