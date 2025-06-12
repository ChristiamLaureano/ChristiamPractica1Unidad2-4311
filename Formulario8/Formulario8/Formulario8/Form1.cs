namespace Formulario8
{
    public partial class Form1 : Form
    {

        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnContador_Click(object sender, EventArgs e)
        {
            contador++;


            lblContador.Text = $"Contador: {contador}";
        }
    }
}
