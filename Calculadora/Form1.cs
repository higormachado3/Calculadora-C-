using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "5";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                txt_resultado.Text = Convert.ToString(valor1 + valor2);

            }else if(operacao == "Subtracao")
            {
                txt_resultado.Text = Convert.ToString(valor1 - valor2);
            }else if(operacao == "Multiplicacao")
            {
                txt_resultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txt_resultado.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
            txt_resultado.Text = "";
            operacao = "Subtracao";
            Lb_operacao.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
            txt_resultado.Text = "";
            operacao = "Multiplicacao";
            Lb_operacao.Text = "X";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
            txt_resultado.Text = "";
            operacao = "Divisao";
            Lb_operacao.Text = "÷";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            Lb_operacao.Text = "";
       
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
            txt_resultado.Text = "";
            operacao = "SOMA";
            Lb_operacao.Text = "+";
        }
    }
}
