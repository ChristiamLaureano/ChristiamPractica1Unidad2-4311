namespace Formulario7
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
            btnAgregarElemento = new Button();
            lstElementos = new ListBox();
            txtNuevoElemento = new TextBox();
            SuspendLayout();
            // 
            // btnAgregarElemento
            // 
            btnAgregarElemento.Location = new Point(252, 215);
            btnAgregarElemento.Name = "btnAgregarElemento";
            btnAgregarElemento.Size = new Size(75, 23);
            btnAgregarElemento.TabIndex = 1;
            btnAgregarElemento.Text = "button1";
            btnAgregarElemento.UseVisualStyleBackColor = true;
            btnAgregarElemento.Click += btnAgregarElemento_Click;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 15;
            lstElementos.Location = new Point(325, 65);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 2;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(148, 89);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(100, 23);
            txtNuevoElemento.TabIndex = 3;
            txtNuevoElemento.TextChanged += txtNuevoElemento_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevoElemento);
            Controls.Add(lstElementos);
            Controls.Add(btnAgregarElemento);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregarElemento;
        private ListBox lstElementos;
        private TextBox txtNuevoElemento;
    }
}
