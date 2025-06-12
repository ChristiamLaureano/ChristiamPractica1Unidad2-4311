namespace Formulario7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarElemento_Click(object sender, EventArgs e)
        {
           
            string elementoAAgregar = txtNuevoElemento.Text;

            if (!string.IsNullOrWhiteSpace(elementoAAgregar))
            {

                lstElementos.Items.Add(elementoAAgregar);

                txtNuevoElemento.Clear();
                txtNuevoElemento.Focus();
            }

            else 

                MessageBox.Show("Por favor, ingrese un elemento para añadir.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        private void txtNuevoElemento_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}