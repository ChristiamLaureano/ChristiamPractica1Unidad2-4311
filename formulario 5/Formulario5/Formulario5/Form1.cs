namespace Formulario5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seleccionado = groupBox1.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (seleccionado != null)
            {
                labelResultado.Text = "Has seleccionado:" + seleccionado.Text;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
