namespace Formulario4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        {
            string texto1 = textBox1.Text.Trim();
            string texto2 = textBox2.Text.Trim();

            if (int.TryParse(texto1, out int num1) && int.TryParse(texto2, out int num2))
            {
                int suma = num1 + num2;
                label1.Text = "Resultado: " + suma.ToString();
            }
            
        }

    }
}
}
