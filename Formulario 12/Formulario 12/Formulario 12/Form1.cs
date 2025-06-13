namespace Formulario_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblResultado.Text = fahrenheit.ToString("F2");
            }
            else
            {

                errorProvider1.SetError(txtCelsius, "Por favor Ingrese Una Temperatura Valida En celsius");
            }

        }
    }
}
