namespace EjemploTipodeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpDatos1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            int edad;
            String dni;
            String nombre;
            char letra;

            edad = Convert.ToInt32(txtEdad.Text);
            nombre = txtNombre.Text;
            dni = txtDNI.Text;
            letra = Convert.ToChar(dni.Substring(8, 1));

            string mensaje;
            if (edad < 18)
            {
                mensaje = "eres menor de edad";
            }
            else
                mensaje = "eres mayor de edad";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach(Control c in  grpDatos1.Controls )
            {
                if (c.GetType().Name == "TextBox")
                {
                    c.ForeColor = Color.Red;
                }
            
            }
        }
    }
}
