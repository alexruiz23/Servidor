using EjemploPoo.Modelos;
namespace EjemploPoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListaClase = new Alumno[2];
            
        }
        Alumno[] ListaClase;
        int numAlumnos;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textnombre.Text == "" || texttelefono.Text == "" || textdni.Text == "")
                MessageBox.Show("Campos obligatorios", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try{
                    ListaClase[numAlumnos] = new Alumno(textnombre.Text, texttelefono.Text, textdni.Text);
                    numAlumnos++;
                }catch(System.IndexOutOfRangeException ex)
                {
                    MessageBox.Show("Caja completa","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    button1.Enabled = false;
                }
                cleanCajas(grpDatos);
                textnombre.Focus();
            }
        }
        public void cleanCajas(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c.GetType().Name == "TextBox")
                {
                    c.Text = "";
                }
                

                
            }
        }
    }
}
