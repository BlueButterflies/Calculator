using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //For Menu Standard 
        double result = 0;
        string operation = "";
        bool isEnterValue = false;

        //For Menu Temperature
        float iCelsius, iFahrenheit, iKevin;
        char symbols;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 271;
            this.Height = 400;
            txtBox.Width = 230;
        }

        private void standardMenu_Click(object sender, EventArgs e)
        {
            this.Width = 271;
            this.Height = 400;
            txtBox.Width = 230;

            this.Text = "Standard";
        }

        private void scientificMenu_Click(object sender, EventArgs e)
        {
            this.Text = "Scientific";

            this.Width = 522;
            this.Height = 400;
            txtBox.Width = 494;

            boxMultiplication.Visible = false;
            boxTemperature.Visible = false;

            txtBox.Visible = true;
            btnRemove.Visible = true;
            btnClear.Visible = true;
            btnReturn0.Visible = true;
            btnPlusMinus.Visible = true;
            btnPoint.Visible = true;
            btnPlus.Visible = true;
            btnMinus.Visible = true;
            btnDivision.Visible = true;
            btnEquals.Visible = true;
            btnMultiplication.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn3.Visible = true;
            btn2.Visible = true;
            btn1.Visible = true;
            btn0.Visible = true;
            btnPi.Visible = true;
            btnSqrt.Visible = true;
            btnSin.Visible = true;
            btnTan.Visible = true;
            btnTanh.Visible = true;
            btnSinh.Visible = true;
            btnX2.Visible = true;
            btnX3.Visible = true;
            btnDec.Visible = true;
            btnCos.Visible = true;
            btnCosh.Visible = true;
            btnHex.Visible = true;
            btnInX.Visible = true;
            btnLog.Visible = true;
            btn1X.Visible = true;
            btnOct.Visible = true;
            btnMod.Visible = true;
            btnExp.Visible = true;
            btnBin.Visible = true;
            btnPrecent.Visible = true;
        }

        private void temperatureMenu_Click(object sender, EventArgs e)
        {
            this.Text = "Temperature";

            this.Width = 390;
            this.Height = 398;

            boxTemperature.Visible = true;

            txtEnter.Focus();

            txtBox.Visible = false;
            btnRemove.Visible = false;
            btnClear.Visible = false;
            btnReturn0.Visible = false;
            btnPlusMinus.Visible = false;
            btnPoint.Visible = false;
            btnPlus.Visible = false;
            btnMinus.Visible = false;
            btnDivision.Visible = false;
            btnEquals.Visible = false;
            btnMultiplication.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn9.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
            btn3.Visible = false;
            btn2.Visible = false;
            btn1.Visible = false;
            btn0.Visible = false;
            btnPi.Visible = false;
            btnSqrt.Visible = false;
            btnSin.Visible = false;
            btnTan.Visible = false;
            btnTanh.Visible = false;
            btnSinh.Visible = false;
            btnX2.Visible = false;
            btnX3.Visible = false;
            btnDec.Visible = false;
            btnCos.Visible = false;
            btnCosh.Visible = false;
            btnHex.Visible = false;
            btnInX.Visible = false;
            btnLog.Visible = false;
            btn1X.Visible = false;
            btnOct.Visible = false;
            btnMod.Visible = false;
            btnExp.Visible = false;
            btnBin.Visible = false;
            btnPrecent.Visible = false;
            boxMultiplication.Visible = false;

            boxTemperature.Location = new Point(12, 42);
        }

        private void multiplicationMenu_Click(object sender, EventArgs e)
        {
            this.Text = "Multiplication";

            this.Width = 280;
            this.Height = 450;

            boxMultiplication.Visible = true;
            listForMultiplication.Visible = true;
            btnMultiply.Visible = true;
            btnResetMultiply.Visible = true;

            txtMultiply.Focus();

            txtBox.Visible = false;
            btnRemove.Visible = false;
            btnClear.Visible = false;
            btnReturn0.Visible = false;
            btnPlusMinus.Visible = false;
            btnPoint.Visible = false;
            btnPlus.Visible = false;
            btnMinus.Visible = false;
            btnDivision.Visible = false;
            btnEquals.Visible = false;
            btnMultiplication.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn9.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
            btn3.Visible = false;
            btn2.Visible = false;
            btn1.Visible = false;
            btn0.Visible = false;
            boxTemperature.Visible = false;

            boxMultiplication.Location = new Point(12, 42);
        }

        #region Menu Standard Operations
        private void buttons_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "0") || (isEnterValue))
            {
                txtBox.Text = "";
            }

            isEnterValue = false;

            Button numbers = (Button)sender;

            if (numbers.Text == ".")
            {
                if (!txtBox.Text.Contains("."))
                {
                    txtBox.Text = txtBox.Text + numbers.Text;
                }
            }
            else
            {
                txtBox.Text = txtBox.Text + numbers.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
            label.Text = "";
        }

        private void btnReturn0_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
            label.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1, 1);
            }

            if (txtBox.Text == "")
            {
                txtBox.Text = "0";
            }
        }

        private void ArithmeticOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operation = button.Text;
            result = double.Parse(txtBox.Text);
            txtBox.Text = "";

            label.Text = Convert.ToString(result) + " " + operation;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            label.Text = " ";

            switch (operation)
            {
                case "+":
                    txtBox.Text = (result + double.Parse(txtBox.Text)).ToString();
                    break;
                case "-":
                    txtBox.Text = (result - double.Parse(txtBox.Text)).ToString();
                    break;
                case "*":
                    txtBox.Text = (result * double.Parse(txtBox.Text)).ToString();
                    break;
                case "/":
                    txtBox.Text = (result / double.Parse(txtBox.Text)).ToString();
                    break;
                case "Mod":
                    txtBox.Text = (result % double.Parse(txtBox.Text)).ToString();
                    break;
                case "Exp":
                    double i = double.Parse(txtBox.Text);
                    double q = result;
                    txtBox.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtBox.Text);

            if (num > 0)
            {
                txtBox.Text = Convert.ToString("-" + num);
            }

            if (num < 0)
            {
                txtBox.Text = Convert.ToString(Math.Abs(num));
            }
        }
        #endregion

        #region Menu Scientific Operations
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtBox.Text = "3.1415926535897932384626433832795‬";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double iLog = double.Parse(txtBox.Text);
            iLog = Math.Log10(iLog);

            label.Text = Convert.ToString("Log" + "(" + txtBox.Text + ")");
            txtBox.Text = Convert.ToString(iLog);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = double.Parse(txtBox.Text);
            sqrt = Math.Sqrt(sqrt);

            label.Text = Convert.ToString("Sqrt" + "(" + txtBox.Text + ")");
            txtBox.Text = Convert.ToString(sqrt);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sinh = double.Parse(txtBox.Text);
            sinh = Math.Sinh(sinh);

            label.Text = Convert.ToString("Sinh" + "(" + txtBox.Text + ")");
            txtBox.Text = Convert.ToString(sinh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = double.Parse(txtBox.Text);
            sin = Math.Sin(sin);

            label.Text = Convert.ToString("Sin" + "(" + txtBox.Text + ")");
            txtBox.Text = Convert.ToString(sin);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double cosh = double.Parse(txtBox.Text);
            cosh = Math.Cosh(cosh);

            label.Text = Convert.ToString("Cosh" + "(" + txtBox.Text + ")");
            txtBox.Text = Convert.ToString(cosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = double.Parse(txtBox.Text);
            cos = Math.Cos(cos);

            label.Text = Convert.ToString("Cos" + "(" + txtBox.Text + ")");
            txtBox.Text = Convert.ToString(cos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double tanh = double.Parse(txtBox.Text);
            tanh = Math.Tanh(tanh);

            label.Text = Convert.ToString("Tanh" + "(" + txtBox.Text + ")");
            txtBox.Text = Convert.ToString(tanh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = double.Parse(txtBox.Text);
            tan = Math.Tan(tan);

            label.Text = Convert.ToString("Tan" + "(" + txtBox.Text + ")");
            txtBox.Text = Convert.ToString(tan);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtBox.Text);

            txtBox.Text = Convert.ToString(num, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtBox.Text);

            txtBox.Text = Convert.ToString(num, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtBox.Text);

            txtBox.Text = Convert.ToString(num, 8);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtBox.Text);

            txtBox.Text = Convert.ToString(num);
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtBox.Text) * Convert.ToDouble(txtBox.Text);


            txtBox.Text = Convert.ToString(num);
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtBox.Text) * Convert.ToDouble(txtBox.Text) * Convert.ToDouble(txtBox.Text);


            txtBox.Text = Convert.ToString(num);
        }

        private void btn1X_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(1.0 / Convert.ToDouble(txtBox.Text));


            txtBox.Text = Convert.ToString(num);
        }

        private void btnInX_Click(object sender, EventArgs e)
        {
            double inX = double.Parse(txtBox.Text);
            inX = Math.Log(inX);

            label.Text = Convert.ToString("In x" + "(" + txtBox.Text + ")");
            txtBox.Text = Convert.ToString(inX);
        }

        private void btnPrecent_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtBox.Text) / Convert.ToDouble(100);

            txtBox.Text = Convert.ToString(num);
        }
        #endregion

        #region Menu Temperature Operations
        private void celsiusFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            symbols = 'C';
        }

        private void fahrenheitCelsius_CheckedChanged(object sender, EventArgs e)
        {
            symbols = 'F';
        }

        private void kevin_CheckedChanged(object sender, EventArgs e)
        {
            symbols = 'K';
        }

        private void btnCovert_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                switch (symbols)
                {
                    case 'C':
                        iCelsius = float.Parse(txtEnter.Text);
                        txtResult.Text = (((9 * iCelsius) / 5) + 32).ToString();
                        break;
                    case 'F':
                        iFahrenheit = float.Parse(txtEnter.Text);
                        txtResult.Text = (((iFahrenheit - 32) * 5) / 9).ToString();
                        break;
                    case 'K':
                        iKevin = float.Parse(txtEnter.Text);
                        txtResult.Text = ((((9 * iKevin) / 5) + 32) + 273.15).ToString();
                        break;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEnter.Text = "";
            txtResult.Text = "";

            celsiusFahrenheit.Checked = false;
            fahrenheitCelsius.Checked = false;
            kevin.Checked = false;
        }

        #endregion

        #region Menu Multiply Operations
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int numForMultiply = Convert.ToInt32(txtMultiply.Text);

            for (int i = 1; i < 13; i++)
            {
                listForMultiplication.Items.Add(i + "*" + numForMultiply + "=" + (numForMultiply * i));
            }
        }

        private void btnResetMultiply_Click(object sender, EventArgs e)
        {
            txtMultiply.Text = "";
            listForMultiplication.Items.Clear();
        }

        #endregion

        #region Menu Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

    }
}

