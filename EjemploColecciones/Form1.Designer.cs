namespace EjemploColecciones
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
            groupBox1 = new GroupBox();
            lstPaises = new ListBox();
            groupBox2 = new GroupBox();
            bttEdit = new Button();
            bttRemove = new Button();
            bttAdd = new Button();
            txtSaludo = new TextBox();
            label2 = new Label();
            txtPais = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstPaises);
            groupBox1.Location = new Point(266, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Paises";
            // 
            // lstPaises
            // 
            lstPaises.FormattingEnabled = true;
            lstPaises.ItemHeight = 15;
            lstPaises.Location = new Point(22, 22);
            lstPaises.Name = "lstPaises";
            lstPaises.Size = new Size(187, 109);
            lstPaises.TabIndex = 0;
            lstPaises.SelectedIndexChanged += lstPaises_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bttEdit);
            groupBox2.Controls.Add(bttRemove);
            groupBox2.Controls.Add(bttAdd);
            groupBox2.Controls.Add(txtSaludo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtPais);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(18, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(224, 158);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Introduce datos";
            // 
            // bttEdit
            // 
            bttEdit.Location = new Point(143, 105);
            bttEdit.Name = "bttEdit";
            bttEdit.Size = new Size(37, 26);
            bttEdit.TabIndex = 6;
            bttEdit.Text = "x";
            bttEdit.UseVisualStyleBackColor = true;
            bttEdit.Click += bttEdit_Click;
            // 
            // bttRemove
            // 
            bttRemove.Location = new Point(94, 105);
            bttRemove.Name = "bttRemove";
            bttRemove.Size = new Size(37, 26);
            bttRemove.TabIndex = 5;
            bttRemove.Text = "-";
            bttRemove.UseVisualStyleBackColor = true;
            bttRemove.Click += bttRemove_Click;
            // 
            // bttAdd
            // 
            bttAdd.Location = new Point(45, 105);
            bttAdd.Name = "bttAdd";
            bttAdd.Size = new Size(37, 26);
            bttAdd.TabIndex = 4;
            bttAdd.Text = "+";
            bttAdd.UseVisualStyleBackColor = true;
            bttAdd.Click += bttAdd_Click;
            // 
            // txtSaludo
            // 
            txtSaludo.Location = new Point(63, 57);
            txtSaludo.Name = "txtSaludo";
            txtSaludo.Size = new Size(138, 23);
            txtSaludo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Saludo";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(63, 28);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(138, 23);
            txtPais.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 31);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "País";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 229);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstPaises;
        private GroupBox groupBox2;
        private Button bttEdit;
        private Button bttRemove;
        private Button bttAdd;
        private TextBox txtSaludo;
        private Label label2;
        private TextBox txtPais;
        private Label label1;
    }
}
