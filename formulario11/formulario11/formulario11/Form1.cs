namespace formulario11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha seleccionada: " + dtpFecha.Value.ToString("dd/MM/yyyy");
        }
    }
}
