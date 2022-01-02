using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Visor.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Visor.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Visor.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Visor.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Visor.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Visor.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Visor.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Visor.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Visor.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Visor.Text += btn9.Text;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            Visor.Text += btnVirgula.Text;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (subVisor.Text.Contains('='))
            {
                subVisor.Text = Visor.Text;
                Visor.Text = string.Empty;
            }
            if(subVisor.TextLength >= 1)
            {
                Calcular();
                subVisor.Text += " + ";
            }
            else
            {
                subVisor.Text = Visor.Text + " + ";
                Visor.Text = string.Empty;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (subVisor.Text.Contains('='))
            {
                subVisor.Text = Visor.Text;
                Visor.Text = string.Empty;
            }
            if (subVisor.TextLength >= 1)
            {
                Calcular();
                subVisor.Text += " - ";
            }
            else
            {
                subVisor.Text = Visor.Text + " - ";
                Visor.Text = string.Empty;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (subVisor.Text.Contains('='))
            {
                subVisor.Text = Visor.Text;
                Visor.Text = string.Empty;
            }
            if (subVisor.TextLength >= 1)
            {
                Calcular();
                subVisor.Text += " x ";
            }
            else
            {
                subVisor.Text = Visor.Text + " x ";
                Visor.Text = string.Empty;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (subVisor.Text.Contains('='))
            {
                subVisor.Text = Visor.Text;
                Visor.Text = string.Empty;
            }
            if (subVisor.TextLength >= 1)
            {
                Calcular();
                subVisor.Text += " ÷ ";

            }
            else
            {
                subVisor.Text = Visor.Text + " ÷ ";
                Visor.Text = string.Empty;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Visor.Text = string.Empty;
            subVisor.Text = string.Empty;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string resultado;
            if (subVisor.Text.Contains('+'))
            {
                resultado = Somar().ToString();
                subVisor.Text += Visor.Text + " = ";
                Visor.Text = resultado;
                
            }
            else if (subVisor.Text.Contains('-'))
            {
                resultado = Subtrair().ToString();
                subVisor.Text += Visor.Text + " = "; 
                Visor.Text = resultado;
            }
            else if (subVisor.Text.Contains('x'))
            {
                resultado = Multiplicar().ToString();
                subVisor.Text += Visor.Text + " = ";
                Visor.Text = resultado;
            }
            else if (subVisor.Text.Contains('÷'))
            {
                resultado = Dividir().ToString();
                subVisor.Text += Visor.Text + " = ";
                Visor.Text = resultado;
            }
        }

        public void Calcular()
        {
            if (subVisor.Text.Contains('+'))
            {
                subVisor.Text = Somar().ToString();
                Visor.Text = string.Empty;
            }
            else if (subVisor.Text.Contains('-'))
            {
                subVisor.Text = Subtrair().ToString();
                Visor.Text = string.Empty;
            }
            else if (subVisor.Text.Contains('x'))
            {
                subVisor.Text = Multiplicar().ToString();
                Visor.Text = string.Empty;
            }
            else if (subVisor.Text.Contains('÷'))
            {
                subVisor.Text = Dividir().ToString();
                Visor.Text = string.Empty;
            }
        }

        public double Somar()
        {
            string[] num1 = subVisor.Text.Split('+');
            double num;

            if (string.IsNullOrEmpty(num1[0]))
                num = (-Convert.ToDouble(num1[1])) + Convert.ToDouble(Visor.Text);
            else
                num = Convert.ToDouble(num1[0]) + Convert.ToDouble(Visor.Text);
            return num;
        }

        public double Subtrair()
        {
            string[] num1 = subVisor.Text.Split('-');
            double num;

            if (string.IsNullOrEmpty(num1[0]))
                num = (-Convert.ToDouble(num1[1])) - Convert.ToDouble(Visor.Text);
            else
                num = Convert.ToDouble(num1[0]) - Convert.ToDouble(Visor.Text);
            return num;
        }

        public double Multiplicar()
        {
            string[] num1 = subVisor.Text.Split('x');
            double num;

            if (string.IsNullOrEmpty(num1[0]))
                num = (-Convert.ToDouble(num1[1])) * Convert.ToDouble(Visor.Text);
            else
                num = Convert.ToDouble(num1[0]) * Convert.ToDouble(Visor.Text);
            return num;
        }

        public double Dividir()
        {
            string[] num1 = subVisor.Text.Split('÷');
            double num;

            if (string.IsNullOrEmpty(num1[0]))
                num = (-Convert.ToDouble(num1[1])) / Convert.ToDouble(Visor.Text);
            else
                num = Convert.ToDouble(num1[0]) / Convert.ToDouble(Visor.Text);
            return num;
        }
    }
}
