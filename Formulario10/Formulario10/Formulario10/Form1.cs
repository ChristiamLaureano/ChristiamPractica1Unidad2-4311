using System.Net.Mail;

namespace Formulario10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            string nombre = "Christiam";
            string Matricula = "LR-2024-005000";

            MessageBox.Show($"Hola, soy {nombre} y {Matricula}", "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
