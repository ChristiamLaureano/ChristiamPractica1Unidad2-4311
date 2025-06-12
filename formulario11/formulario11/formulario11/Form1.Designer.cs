namespace formulario11
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
            dtpFecha = new DateTimePicker();
            btnMostrarFecha = new Button();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(190, 28);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 0;
            // 
            // btnMostrarFecha
            // 
            btnMostrarFecha.Location = new Point(251, 171);
            btnMostrarFecha.Name = "btnMostrarFecha";
            btnMostrarFecha.Size = new Size(75, 23);
            btnMostrarFecha.TabIndex = 1;
            btnMostrarFecha.Text = "button1";
            btnMostrarFecha.UseVisualStyleBackColor = true;
            btnMostrarFecha.Click += button1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(270, 91);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFecha);
            Controls.Add(btnMostrarFecha);
            Controls.Add(dtpFecha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Button btnMostrarFecha;
        private Label lblFecha;
    }
}
