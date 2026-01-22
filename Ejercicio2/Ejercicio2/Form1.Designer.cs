namespace Ejercicio2
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            txt2 = new TextBox();
            label1 = new Label();
            txt1 = new TextBox();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(button3);
            grp1.Controls.Add(button2);
            grp1.Controls.Add(button1);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(txt2);
            grp1.Controls.Add(label1);
            grp1.Controls.Add(txt1);
            grp1.Location = new Point(72, 67);
            grp1.Name = "grp1";
            grp1.Size = new Size(550, 280);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "tabla de clasificacion";
            grp1.Enter += grp1_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(153, 216);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Derrota";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(311, 216);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Victoria";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(225, 170);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 4;
            button1.Text = "Empezar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 57);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 3;
            label2.Text = "Contador de Partidos";
            // 
            // txt2
            // 
            txt2.Location = new Point(311, 75);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 2;
            txt2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 57);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Equipo";
            label1.Click += label1_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(128, 75);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 0;
            txt1.TextChanged += textBox1_TextChanged;
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
        private Label label1;
        private TextBox txt1;
        private Label label2;
        private TextBox txt2;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
