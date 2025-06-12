namespace Formulario8
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
            btnContador = new Button();
            lblContador = new Label();
            SuspendLayout();
            // 
            // btnContador
            // 
            btnContador.Location = new Point(311, 186);
            btnContador.Name = "btnContador";
            btnContador.Size = new Size(75, 23);
            btnContador.TabIndex = 0;
            btnContador.Text = "button1";
            btnContador.UseVisualStyleBackColor = true;
            btnContador.Click += btnContador_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(332, 88);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(38, 15);
            lblContador.TabIndex = 1;
            lblContador.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblContador);
            Controls.Add(btnContador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContador;
        private Label lblContador;
    }
}
