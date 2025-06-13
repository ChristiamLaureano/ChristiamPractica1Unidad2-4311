using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_16
{
    public partial class Form1 : Form
    {
        private string input = ""; 
        private string operador = ""; 
        private double resultado = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            {
                input = "";
                operador = "";
                resultado = 0;
                textBox1.Text = "0";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            {
                Button btn = (Button)sender;
                input += btn.Text;
                textBox1.Text = input;
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (input != "")
            {
                operador = btn.Text;
                resultado = double.Parse(input); 
                input = ""; 
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (input != "")
            {
                operador = btn.Text;
                resultado = double.Parse(input); 
                input = ""; 
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (input != "")
            {
                operador = btn.Text;
                resultado = double.Parse(input); 
                input = ""; 
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (input != "")
            {
                operador = btn.Text;
                resultado = double.Parse(input);
                input = ""; 
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (input != "" && operador != "")
            {
                double numero = double.Parse(input);

                switch (operador)
                {
                    case "+":
                        resultado += numero;
                        break;
                    case "-":
                        resultado -= numero;
                        break;
                    case "*":
                        resultado *= numero;
                        break;
                    case "/":
                        if (numero != 0)
                        {
                            resultado /= numero;
                        }
                        else
                        {
                            MessageBox.Show("Error: División por cero.");
                            resultado = 0;
                        }
                        break;
                }
                textBox1.Text = resultado.ToString();
                input = ""; 
                operador = ""; 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
