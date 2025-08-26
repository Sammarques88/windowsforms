using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Samuel
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Evaluate()
        {
            if (operationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            result /= secondNumber;
                        else
                        {
                            btnTela.Text = "Error";
                            return;
                        }
                        break;
                }

                btnTela.Text = result.ToString();
                currentInput = "";
                operationPending = false;
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            btnTela.Text = currentInput;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "+";
            operationPending = true;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "-";
            operationPending = true;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "*";
            operationPending = true;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "/";
            operationPending = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            btnTela.Text = "";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                btnTela.Text = currentInput;
            }
        }
    }
}
