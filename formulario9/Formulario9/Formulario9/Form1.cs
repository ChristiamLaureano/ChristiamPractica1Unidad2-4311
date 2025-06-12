namespace Formulario9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); 

            if (!double.TryParse(txtEntrada.Text, out _))
            {
                errorProvider1.SetError(txtEntrada, "por favor, introduce un numero valido ");

            }

            else
            {
                MessageBox.Show("!Entrada Valida! Es un numero.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
