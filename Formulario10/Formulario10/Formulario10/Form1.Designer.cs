﻿namespace Formulario10
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
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(259, 109);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(143, 23);
            btnSaludo.TabIndex = 0;
            btnSaludo.Text = "Mostrar saludo";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaludo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSaludo;
    }
}
