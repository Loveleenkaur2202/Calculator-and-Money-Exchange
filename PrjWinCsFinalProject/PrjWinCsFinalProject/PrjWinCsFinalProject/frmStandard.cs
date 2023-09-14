using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjWinCsFinalProject
{
    public partial class frmStandard : Form
    {
        double fstNum, secNum;
        string operators;

        public frmStandard()
        {
            InitializeComponent();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
               txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (btnDecimal.Text == ".")
            {
                if (btnDecimal.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + btnDecimal.Text;
                }
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "+";
            
            txtDisplay.Text = "";
            //txtUpper.Text = Convert.ToString(result) + " " + operators;
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "-";
            txtDisplay.Text = "";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "*";
            txtDisplay.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "/";
            txtDisplay.Text = "";
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            Double result = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * result);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtUpper.Text = "";
            
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtUpper.Text = "";
            string f, s;
            f = Convert.ToString(fstNum);
            s = Convert.ToString(secNum);
            f = "";
            s = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            { 
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }
        
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double reciprocal = Convert.ToDouble(txtDisplay.Text);
            if (Convert.ToDouble(txtDisplay.Text) == 0)
            {
                txtDisplay.Text = "Cannot divide by Zero";

            }
            else
            {
                reciprocal = 1 / reciprocal;

                txtDisplay.Text = reciprocal.ToString();

            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double percentage = Convert.ToDouble(txtDisplay.Text);
            percentage = percentage / 100; ;
            txtDisplay.Text = percentage.ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {

            double square = Convert.ToDouble(txtDisplay.Text);
            txtUpper.Text = "sqr(" + square + ")";
            square = Convert.ToDouble(Math.Pow(square, 2));
            txtDisplay.Text = square.ToString();
            
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            btnMemoryClear.Enabled = true;
            btnMemoryRemove.Enabled = true;
            btnMemory.Enabled = true;
        }

        private void btnMemorySubtract_Click(object sender, EventArgs e)
        {
            btnMemoryClear.Enabled = true;
            btnMemoryRemove.Enabled = true;
            btnMemory.Enabled = true;
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            btnMemoryClear.Enabled = true;
            btnMemoryRemove.Enabled = true;
            btnMemory.Enabled = true;
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            btnMemoryClear.Enabled = false;
            btnMemoryRemove.Enabled = false;
            btnMemory.Enabled = false;
        }

        private void btnUnderRoot_Click(object sender, EventArgs e)
        {
            double underroot = Convert.ToSingle(txtDisplay.Text);
            
            if (Convert.ToDouble(txtDisplay.Text) < 0)
            {
                txtDisplay.Text = "Invalid input";

            }
            else
            {
                txtUpper.Text = "√(" + underroot + ")";
                underroot = Convert.ToDouble(Math.Sqrt(underroot));
                txtDisplay.Text = underroot.ToString();
            }
        }

        private void frmStandard_Load(object sender, EventArgs e)
        {
            btnMemoryClear.Enabled = false;
            btnMemoryRemove.Enabled = false;
            btnMemory.Enabled = false;
            
        }

        private void btnAddition_Click_1(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "+";

            txtDisplay.Text = "";
            
            txtUpper.Text = Convert.ToString(fstNum) + " " + operators;
        }

        private void btnSubstraction_Click_1(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "-";
            txtDisplay.Text = "";

            txtUpper.Text = Convert.ToString(fstNum) + " " + operators;
        }

        private void btnMultiplication_Click_1(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "*";
            txtDisplay.Text = "";

            txtUpper.Text = Convert.ToString(fstNum) + " " + operators;
        }

        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "/";
            txtDisplay.Text = "";

            txtUpper.Text = Convert.ToString(fstNum) + " " + operators;
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {

        }

        private void btnMemoryRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secNum = Convert.ToDouble(txtDisplay.Text);

            switch (operators)
            {
                case "+":

                    txtUpper.Text += Convert.ToString(secNum) + " ";
                    txtDisplay.Text = (fstNum + secNum).ToString();
                    
                    break;
                case "-":

                    txtUpper.Text += Convert.ToString(secNum) + " ";
                    txtDisplay.Text = (fstNum - secNum).ToString();
                    break;
                case "*":
                    txtUpper.Text += Convert.ToString(secNum) + " ";
                    txtDisplay.Text = (fstNum * secNum).ToString();
                    break;
                case "/":
                    txtUpper.Text += Convert.ToString(secNum) + " ";
                    if (secNum != 0)
                    {
                        txtDisplay.Text = (fstNum / secNum).ToString();
                    }
                    else
                    {
                        if (fstNum == 0)
                        {
                            txtDisplay.Text = "Result is Undefined";
                        }
                        else
                        {
                            txtDisplay.Text = "Cannot divide by Zero";
                        }
                    }
                    break;
               


                default:
                    break;

            }



        }
    }
}
