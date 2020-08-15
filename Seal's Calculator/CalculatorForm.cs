using Seal_s_Calculator.DiscordRpcDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seal_s_Calculator
{
    public partial class CalculatorForm : Form
    {
        private decimal FirstnumberDecimal = 0.0m;
        private decimal SecondnumberDecimal = 0.0m;
        private string operatorString = "+";
        private decimal ResultDecimal = 0.0m;
        public string no1, constfun;

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        public CalculatorForm()
        {
            InitializeComponent();
            no1 = "";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(9);
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(8);
        }

        private void RemoveZero(int number)
        {
            if (valuetextBox.Text == operatorString || valuetextBox.Text == "0")
                valuetextBox.Text = number.ToString();
            else
                valuetextBox.Text += number.ToString();
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(7);
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(6);
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(5);
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(4);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(3);
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(2);
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(1);
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            RemoveZero(0);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            valuetextBox.Clear();
            resulttextBox.Clear();
            valuetextBox.Text = "0";
            FirstnumberDecimal = 0.0m;
            SecondnumberDecimal = 0.0m;
            ResultDecimal = 0.0m;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!valuetextBox.Text.Contains("."))
                valuetextBox.Text += ".";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            SuppliedOperator("+");
        }

        private void SuppliedOperator(string _OperatorString)
        {
            operatorString = _OperatorString;
            FirstnumberDecimal = Decimal.Parse(valuetextBox.Text);
            valuetextBox.Text = _OperatorString;
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            SuppliedOperator("-");
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            SuppliedOperator("*");
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            SuppliedOperator("/");
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            SecondnumberDecimal = Decimal.Parse(valuetextBox.Text);

            switch (operatorString)
            {
                case "+":
                    ResultDecimal = FirstnumberDecimal + SecondnumberDecimal;

                    break;
                case "-":
                    ResultDecimal = FirstnumberDecimal - SecondnumberDecimal;
                    break;
                case "/":
                    ResultDecimal = FirstnumberDecimal / SecondnumberDecimal;

                    break;
                case "*":
                    ResultDecimal = FirstnumberDecimal * SecondnumberDecimal;

                    break;
                case "%":
                    ResultDecimal = FirstnumberDecimal % SecondnumberDecimal;

                    break;
                case "x^y":
                    valuetextBox.Text =
                    Convert.ToString(System.Math.Pow(Convert.ToDouble(no1),
                    Convert.ToDouble(valuetextBox.Text)));
                    break;
            }
            string a = FirstnumberDecimal.ToString();
            string b = SecondnumberDecimal.ToString();
            valuetextBox.Text = a + operatorString + b;
            resulttextBox.Text = ResultDecimal.ToString();
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            SuppliedOperator("%");
        }

        private void squarerootBtn_Click(object sender, EventArgs e)
        {
            string a =
            Convert.ToString(System.Math.Sqrt(Convert.ToDouble(valuetextBox.Text)));
            valuetextBox.Text = "√" + valuetextBox.Text;
            resulttextBox.Text = a;
        }

        private void sinBtn_Click(object sender, EventArgs e)
        {
            string a =
            Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) *
            (Convert.ToDouble(valuetextBox.Text))));
            valuetextBox.Text = "Sin(" + valuetextBox.Text + ")";
            resulttextBox.Text = a;
        }

        private void cosBtn_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI)
            / 180) * (Convert.ToDouble(valuetextBox.Text))));
            valuetextBox.Text = "Cos(" + valuetextBox.Text + ")";
            resulttextBox.Text = a;
        }

        private void tanBtn_Click(object sender, EventArgs e)
        {
            string a =
            Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) *
            (Convert.ToDouble(valuetextBox.Text))));
            valuetextBox.Text = "Tan(" + valuetextBox.Text + ")";
            resulttextBox.Text = a;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(System.Math.Log10(Convert.ToDouble(valuetextBox.Text)));
            valuetextBox.Text = "Log(" + valuetextBox.Text + ")";
            resulttextBox.Text = a;
        }

        private void lnBtn_Click(object sender, EventArgs e)
        {
            string a =
            Convert.ToString(System.Math.Log(Convert.ToDouble(valuetextBox.Text)));
            valuetextBox.Text = "ln(" + valuetextBox.Text + ")";
            resulttextBox.Text = a;
        }

        private void piBtn_Click(object sender, EventArgs e)
        {
            string a = "3.141592654";
            valuetextBox.Text = "π";
            resulttextBox.Text = a;
        }

        private void xraise3Btn_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(Convert.ToInt32(valuetextBox.Text) *
            Convert.ToInt32(valuetextBox.Text) * Convert.ToInt32(valuetextBox.Text));
            valuetextBox.Text = valuetextBox.Text + "^3";
            resulttextBox.Text = a;
        }

        private void xraiseYBtn_Click(object sender, EventArgs e)
        {
            no1 = valuetextBox.Text;
            valuetextBox.Text = "";
            constfun = "x^y";
        }

        private void nFactorialBtn_Click(object sender, EventArgs e)
        {
            int var1 = 1;
            for (int i = 1; i <= Convert.ToInt16(valuetextBox.Text); i++)
            {
                var1 = var1 * i;
            }
            resulttextBox.Text = Convert.ToString(var1);
        }

        private void oneDivXBtn_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(Convert.ToDouble(1.0 /
            Convert.ToDouble(valuetextBox.Text)));
            valuetextBox.Text = "1/" + valuetextBox.Text;
            resulttextBox.Text = a;
        }

        private void xraise2Btn_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(Convert.ToInt32(valuetextBox.Text) *
            Convert.ToInt32(valuetextBox.Text));
            valuetextBox.Text = valuetextBox.Text + "^2";
            resulttextBox.Text = a;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("720378659793272983", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("720378659793272983", ref this.handlers, true, null);
            this.presence.details = "Calculating";
            this.presence.state = "";
            this.presence.largeImageKey = "seal2";
            this.presence.smallImageKey = "";
            this.presence.largeImageText = "";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void plusMinBtn_Click(object sender, EventArgs e)
        {
            if (!valuetextBox.Text.Contains("-"))
                valuetextBox.Text = "-" + valuetextBox.Text;
            else
                valuetextBox.Text = valuetextBox.Text.Trim('-');
        }
    }
}

