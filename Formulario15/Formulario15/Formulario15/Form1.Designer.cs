namespace Formulario15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            txtContenido = new TextBox();
            btnGuardar = new Button();
            btnAbrir = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtContenido
            // 
            txtContenido.Dock = DockStyle.Fill;
            txtContenido.Location = new Point(0, 0);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ScrollBars = ScrollBars.Both;
            txtContenido.Size = new Size(800, 450);
            txtContenido.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(8, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar archivo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(147, 8);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(104, 23);
            btnAbrir.TabIndex = 2;
            btnAbrir.Text = "Abrir archivo";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbrir);
            Controls.Add(btnGuardar);
            Controls.Add(txtContenido);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TextBox txtContenido;
        private Button btnGuardar;
        private Button btnAbrir;
    }
}
