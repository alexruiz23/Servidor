
using System.Drawing.Text;
using Interfaces.modelos;
namespace Interfaces
{
    public partial class Form1 : Form
    {
        private List<Pais> L_Paises = new List<Pais>();
        private int pos_actual;
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            L_Paises.Add(new Pais(txt1.Text,txt2.Text));
            listBox1.Items.Add(txt1.Text);

        }
        private void listBox1_SelectedIndexChanged(Object sender, EventArgs e)
        {
         //pos_actual= buscarPais(listBox1.text)
            //L_PaiseS.RemoveAt( pos_actual);
            //listBox1.Items.RemoveAt(pos_actual);

            string nombre = listBox1.Text;
            Pais p = new Pais(nombre);
            int posicion = L_Paises.IndexOf(p);
            //version corta
            // int posicion = listBox1.SelectedIndex;
            if (posicion == -1)
            {
                MessageBox.Show("no esta");
            }
            else
            {
                txt1.Text = L_Paises[posicion].Nombre;
                txt2.Text = L_Paises[posicion].Saludo;
            }
         
          
        }
        private int buscarPais(string nombre)
        {
            Pais p = new Pais(nombre);
            int posicion = L_Paises.IndexOf(p);
            return posicion;
        }
    }
}
