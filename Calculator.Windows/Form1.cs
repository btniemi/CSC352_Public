using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Logic;

namespace Calculator.Windows
{
    public partial class Form1 : Form
    {

//create the form or the calculator instance visually 
        public Form1()
        {
            InitializeComponent();
        }


//what the button prints out
        private void btnNum1_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += " + ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += " - ";
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += " * ";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += " / ";
        }
        private void btnExpoent_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += " ^ ";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text = string.Empty;
        }
        private void btnLeftParen_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += " ( ";
        }
        private void btnRightParen_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += " ) ";
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Text += ".";
        }






        private void btnEquals_Click(object sender, EventArgs e)
        {
            // save to history
            string rpn = Parser.ConvertToRPN(this.textBoxInput.Text);
            this.history.Text += "\n" + Parser.ConvertToInfix(rpn) + "\r";

            //Evaluate RPN
            double result = Evaluate.EvaluateRPN(rpn);

            this.textBoxInput.Text = result.ToString();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool wasHandled = false;
            if (keyData == Keys.Enter)
            {
                wasHandled = true;
            }
            return wasHandled;
        }


        //switch case for how buttons operate
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"Recieved {e.KeyCode}");

            switch (e.KeyCode)
            {
                case Keys.D0:
                    {
                        if (e.Shift)
                        {
                            btnLeftParen_Click(sender, e);
                        }
                        else
                        {
                            btnNum0_Click(sender, e);
                        }
                        break;
                    }
                case Keys.NumPad0:
                    {
                        btnNum0_Click(sender, e);
                        break;
                    }
                case Keys.D1:
                case Keys.NumPad1:
                    {
                        btnNum1_Click(sender, e);
                        break;
                    }
                case Keys.D2:
                case Keys.NumPad2:
                    {
                        btnNum2_Click(sender, e);
                        break;
                    }
                case Keys.D3:
                case Keys.NumPad3:
                    {
                        btnNum3_Click(sender, e);
                        break;
                    }
                case Keys.D4:
                case Keys.NumPad4:
                    {
                        btnNum4_Click(sender, e);
                        break;
                    }
                case Keys.D5:
                case Keys.NumPad5:
                    {
                        btnNum5_Click(sender, e);
                        break;
                    }
                case Keys.D6:
                case Keys.NumPad6:
                    {
                        btnNum6_Click(sender, e);
                        break;
                    }
                case Keys.D7:
                case Keys.NumPad7:
                    {
                        btnNum7_Click(sender, e);
                        break;
                    }
                case Keys.D8:
                    {
                        if (e.Shift)
                        {
                            //Multiply
                            btnMultiple_Click(sender, e);

                        }
                        else
                        {
                            btnNum8_Click(sender, e);
                        }
                        break;
                    }
                case Keys.NumPad8:
                    {
                        btnNum8_Click(sender, e);
                        break;
                    }
                case Keys.D9:
                    {
                        if (e.Shift)
                        {
                            btnRightParen_Click(sender, e);
                        }
                        else
                        {
                            btnNum9_Click(sender, e);
                        }
                        break;
                    }
                case Keys.NumPad9:
                    {
                        btnNum9_Click(sender, e);
                        break;
                    }
                case Keys.Oemplus:
                    {
                        if (e.Shift)
                        {
                            // Addition
                            btnPlus_Click(sender, e);
                        }
                        else
                        {
                            // Equals
                            btnEquals_Click(sender, e);
                        }
                        break;
                    }
                case Keys.Return:
                    {
                        btnEquals_Click(this, e);
                        e.Handled = true;
                        break;
                    }
                case Keys.Add:
                    {
                        btnPlus_Click(sender, e);
                    }
                    break;
                case Keys.Subtract:
                    {
                        btnMinus_Click(sender, e);
                    }
                    break;
                case Keys.Multiply:
                    {
                        btnMultiple_Click(sender, e);
                    }
                    break;
                case Keys.Divide:
                    {
                        btnDivision_Click(sender, e);
                    }
                    break;
                case Keys.OemPeriod:
                    {
                        btnDecimal_Click(sender, e);
                    }
                    break;
                case Keys.Decimal:
                    {
                        btnDecimal_Click(sender, e);
                    }
                    break;
                case Keys.Delete:
                    {
                        btnClear_Click(sender, e);
                    }
                    break;
                default:
                    {
                        //Do Nothing
                        break;
                    }
            }
        }


    }
}
