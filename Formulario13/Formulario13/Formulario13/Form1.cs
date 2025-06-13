namespace Formulario13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Proceso completado.", "Información de Progreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
