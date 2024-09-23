namespace EjemploTipodeDatos
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
            grpDatos1 = new GroupBox();
            label3 = new Label();
            bttnAceptar = new Button();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label1 = new Label();
            label2 = new Label();
            grpDatos1.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos1
            // 
            grpDatos1.Controls.Add(label3);
            grpDatos1.Controls.Add(bttnAceptar);
            grpDatos1.Controls.Add(txtEdad);
            grpDatos1.Controls.Add(lblEdad);
            grpDatos1.Controls.Add(txtDNI);
            grpDatos1.Controls.Add(lblDNI);
            grpDatos1.Controls.Add(txtNombre);
            grpDatos1.Controls.Add(lblNombre);
            grpDatos1.Location = new Point(216, 119);
            grpDatos1.Name = "grpDatos1";
            grpDatos1.Size = new Size(370, 188);
            grpDatos1.TabIndex = 0;
            grpDatos1.TabStop = false;
            grpDatos1.Text = "Tus Datos";
            grpDatos1.Enter += grpDatos1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 150);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 7;
            label3.Text = " ";
            label3.Click += label3_Click;
            // 
            // bttnAceptar
            // 
            bttnAceptar.Location = new Point(279, 150);
            bttnAceptar.Name = "bttnAceptar";
            bttnAceptar.Size = new Size(75, 23);
            bttnAceptar.TabIndex = 6;
            bttnAceptar.Text = "Aceptar";
            bttnAceptar.UseVisualStyleBackColor = true;
            bttnAceptar.Click += bttnAceptar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(84, 89);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(29, 23);
            txtEdad.TabIndex = 5;
            txtEdad.TextChanged += textBox1_TextChanged_1;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(18, 92);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(84, 58);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 3;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(18, 61);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(84, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 346);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 336);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grpDatos1);
            Name = "Form1";
            Text = "EjemploTipodeDatos";
            Load += Form1_Load_1;
            grpDatos1.ResumeLayout(false);
            grpDatos1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatos1;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtEdad;
        private Label lblEdad;
        private Button bttnAceptar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
