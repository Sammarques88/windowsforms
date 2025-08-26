using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorasamuel3
{
    public partial class Form1 : Form
    {

        public decimal Resultado {  get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
                
            }
            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }
}
