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
    public partial class Form1 : Form
    {
        string operador;
        double num1, num2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Double.Parse(display.Text); // Converte um texto para número
            display.Clear();
            //display.Text = num1.ToString() + "D"; // Converte um número para texto
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Double.Parse(display.Text); // Converte um texto para número
            display.Clear();
            //display.Text = num1.ToString() + "D"; // Converte um número para texto

        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Double.Parse(display.Text); // Converte um texto para número
            display.Clear();
            //display.Text = num1.ToString() + "D"; // Converte um número para texto
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            operador = "x";
            num1 = Double.Parse(display.Text); // Converte um texto para número
            display.Clear();
            //display.Text = num1.ToString() + "D"; // Converte um número para texto
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "Programado por: Lorenzo dos Santos; Data: 21/07/2020";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(display.TextLength > 1)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(display.Text); // Converte um texto para número

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "x":
                    resultado = num1 * num2;
                    break;
            }

            display.Text = resultado.ToString(); //Converte um número a texto (String)
        }
    }
}
