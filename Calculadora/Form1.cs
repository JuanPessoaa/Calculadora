using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, soma;
            num1 = int.Parse(textBox1.Text);//converte string da textbox para valor numérico
            num2 = int.Parse(textBox2.Text);//convert.toint32
            soma = num1 + num2;
            label4.Text = soma.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, soma;
            num1 = int.Parse(textBox1.Text);//converte string da textbox para valor numérico
            num2 = int.Parse(textBox2.Text);//convert.toint32
            soma = num1 - num2;
            label4.Text = soma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, soma;
            num1 = int.Parse(textBox1.Text);//converte string da textbox para valor numérico
            num2 = int.Parse(textBox2.Text);//convert.toint32
            soma = num1 * num2;
            label4.Text = soma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, soma;
            num1 = int.Parse(textBox1.Text);//converte string da textbox para valor numérico
            num2 = int.Parse(textBox2.Text);//convert.toint32
            soma = num1 / num2;
            label4.Text = soma.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

//X ALGORITIMO

//X LER DOIS NUMEROS E EFETUAR AS 4 OPERAÇÕES ENTRE ELES.

//X O TEMANHO DO FORMULÁRIO DEVERÁ SER 1024 X 768

//X O USUARIO NÃO PODERÁ REDIMENSIONAR O FORMULÁRIO

//escolha uma imagem para o formulário;

//X Atribua a transparencia aos botões;

//X o titulo do formulário deverá ser "CALCULADORA"

//X na label do resultado, coloque efeito de profundidade;

//X retire as possibilidades de minimizar e maximizar o formulário;

//X O FORMULÁRIO DEVERÁ SER EXECUTADO NO CENTRO DA TELA

//ÍCONES NOS BOTÕES

//ICONE NO FORMULARIO

//ICONE NO PROJETO

//X BOTOES DE LIMPAR E SAIR

//X CONFIGURE A TECLA ESC


