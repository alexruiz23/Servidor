namespace EjemploPoo
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
            grpDatos = new GroupBox();
            textdni = new TextBox();
            texttelefono = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textnombre = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            grpDatos.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(textdni);
            grpDatos.Controls.Add(texttelefono);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(textnombre);
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(92, 62);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(393, 125);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = " Datos Alumno";
            // 
            // textdni
            // 
            textdni.Location = new Point(87, 80);
            textdni.Name = "textdni";
            textdni.Size = new Size(125, 23);
            textdni.TabIndex = 5;
            // 
            // texttelefono
            // 
            texttelefono.Location = new Point(87, 51);
            texttelefono.Name = "texttelefono";
            texttelefono.Size = new Size(125, 23);
            texttelefono.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 83);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "Dni";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 51);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefono";
            // 
            // textnombre
            // 
            textnombre.Location = new Point(87, 22);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(168, 23);
            textnombre.TabIndex = 1;
            textnombre.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(96, 109);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(53, 31);
            button1.Name = "button1";
            button1.Size = new Size(96, 49);
            button1.TabIndex = 6;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(562, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(145, 164);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(92, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpDatos);
            Name = "Form1";
            Text = "Form1";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox textnombre;
        private Label label1;
        private ListBox listBox1;
        private Label label3;
        private Label label2;
        private TextBox textdni;
        private TextBox texttelefono;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
