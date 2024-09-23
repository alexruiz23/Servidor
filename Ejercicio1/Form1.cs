namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            int horas = Convert.ToInt32(txt1.Text);
            int salario = Convert.ToInt32(txt2.Text);

            int resultado=horas*salario;

            txt3.Text = resultado.ToString();



        }
    }
}
