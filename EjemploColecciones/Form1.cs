using EjemploColecciones.excepciones;
using EjemploColecciones.modelos;

namespace EjemploColecciones
{
    public partial class Form1 : Form
    {

        private List<Pais> l_Paises = new List<Pais>();
        private int pos_Actual;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            try
            {
                validar_Datos();
                l_Paises.Add(new Pais(txtPais.Text, txtSaludo.Text));
                lstPaises.Items.Add(txtPais.Text);
            }
            catch (DatosErrorExcepcion er)
            {
                MessageBox.Show(er.Message,"ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Versión largaaaa
            if (lstPaises.SelectedIndex == -1)
                return;
            pos_Actual = buscarPais(lstPaises.Text);
            //Pais p=new Pais(lstPaises.Text);           
            //Versión corta
            //int posicion = lstPaises.SelectedIndex;

            if (pos_Actual == -1)
                MessageBox.Show("No está");
            else
            {
                txtPais.Text = l_Paises[pos_Actual].Nombre;
                txtSaludo.Text = l_Paises[pos_Actual].Saludo;
            }
        }

        private void bttRemove_Click(object sender, EventArgs e)
        {
            l_Paises.RemoveAt(pos_Actual);
            lstPaises.Items.RemoveAt(pos_Actual);
            txtPais.Clear();
            txtSaludo.Clear();

        }

        private int buscarPais(string nombre)
        {
            Pais p = new Pais(nombre);
            int posicion = l_Paises.IndexOf(p);
            return posicion;

        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            l_Paises[pos_Actual].Saludo = txtSaludo.Text;
            l_Paises[pos_Actual].Nombre=txtPais.Text;
            lstPaises.Items[pos_Actual] = txtPais.Text;
        }

        private void validar_Datos() 
        {
            if (txtPais.Text == "" || txtSaludo.Text == "")
                throw new DatosErrorExcepcion("DATOS DE ENTRADA OBLIGADA");
            if (buscarPais(txtPais.Text) != -1)
                throw new DatosErrorExcepcion("PAIS EXISTENTE EN LA LISTA");
        }
    }
}
