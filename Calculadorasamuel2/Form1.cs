using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadorasamuel2
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero1_Click_Click(object sender, EventArgs e)
        {
            txtTela.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtTela.Text += botao.Text;
        }
    }
}
