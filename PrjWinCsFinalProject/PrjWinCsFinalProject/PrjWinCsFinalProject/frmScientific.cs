using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrjWinCsFinalProject
{
    public partial class frmScientific : Form
    {

        double fstNum, secNum;
        string operators;
        public frmScientific()
        {
            InitializeComponent();
        }


        private void btnMemoryClear_Click(object sender, EventArgs e)
        {

        }

        private void btnMemoryRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnMemorySave_Click(object sender, EventArgs e)
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

        private void btnMemorySubtract_Click(object sender, EventArgs e)
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

        private void frmScientific_Load(object sender, EventArgs e)
        {
            btnMemoryClear.Enabled = false;
            btnMemoryRemove.Enabled = false;
            btnMemory.Enabled = false;
            
            btnCube.Hide();
            btnCubeRoot.Hide();
            btn2Power.Hide();
            btnLogy.Hide();
            btnEx.Hide();
            btnRoot.Hide();
            btnRoot.Enabled = false;
            btnLogy.Enabled = false;
            btnEx.Enabled = false;
            btnExp.Enabled = false;
            btnE.Enabled = false;
            btnOpenBracket.Enabled = false;
            btnCloseBracket.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtUpper.Text = "";
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

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double square = Convert.ToDouble(txtDisplay.Text);
            txtUpper.Text = "sqr(" + square + ")";
            square = Convert.ToDouble(Math.Pow(square, 2));
            txtDisplay.Text = square.ToString();
        }

        private void btnSquarRoot_Click(object sender, EventArgs e)
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

        private void btnDivision_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "/";
            txtDisplay.Text = "";

            txtUpper.Text = Convert.ToString(fstNum) + " " + operators;
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

        private void btnInverse_Click(object sender, EventArgs e)
        {
            Double result = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * result);
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

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "*";
            txtDisplay.Text = "";

            txtUpper.Text = Convert.ToString(fstNum) + " " + operators;
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "-";
            txtDisplay.Text = "";

            txtUpper.Text = Convert.ToString(fstNum) + " " + operators;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "+";

            txtDisplay.Text = "";

            txtUpper.Text = Convert.ToString(fstNum) + " " + operators;
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

                case "%":
                    txtUpper.Text += Convert.ToString(secNum) + " ";
                    txtDisplay.Text = (fstNum % secNum).ToString();
                    break;
                case "x^y":
                    txtUpper.Text += Convert.ToString(secNum) + " ";
                    txtDisplay.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(fstNum), Convert.ToDouble(txtDisplay.Text)));
                    break;
                case "10^y":
                    txtUpper.Text += Convert.ToString(secNum) + " ";
                    txtDisplay.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(10), Convert.ToDouble(txtDisplay.Text)));
                    break;
                case "2^x":
                    txtUpper.Text += Convert.ToString(secNum) + " ";
                    txtDisplay.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(2), Convert.ToDouble(txtDisplay.Text)));
                    break;
                default:
                    break;

            }
        }

        private void btn2ndFunction_Click(object sender, EventArgs e)
        {
            btnCube.Show();
            btnCubeRoot.Show();
            btn2Power.Show();
            btnLogy.Show();
            btnEx.Show();
            btnRoot.Show();
           

        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            double cube = Convert.ToDouble(txtDisplay.Text);
            txtUpper.Text = "cube(" + cube + ")";
            cube = Convert.ToDouble(Math.Pow(cube, 3));
            txtDisplay.Text = cube.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "%";
            txtDisplay.Text = "";

            txtUpper.Text = Convert.ToString(fstNum) + " " + operators;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(txtDisplay.Text);
            txtUpper.Text = "log(" + log + ")";
            log = Convert.ToDouble(Math.Log10(log));
            txtDisplay.Text =log.ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            double result = Math.PI;
            txtDisplay.Text = result.ToString();
        }

        private void btnFictorial_Click(object sender, EventArgs e)
        {
            double number, fact;
            number = Convert.ToDouble(txtDisplay.Text);
            fact = number;
            txtUpper.Text = "fac(" + number + ")";
            for (double i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            txtDisplay.Text = fact.ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {

        }

        private void btnAbsolute_Click(object sender, EventArgs e)
        {
            Double result = Convert.ToDouble(txtDisplay.Text);
            if(result < 0)
            {
                txtDisplay.Text = Convert.ToString(-1 * result);
            }
            else
            {
                txtDisplay.Text = Convert.ToString(1 * result);
            }
           
        }

        private void btnOpenBracket_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnOpenBracket.Text;
        }

        private void btnCloseBracket_Click(object sender, EventArgs e)
        {

            txtDisplay.Text += btnCloseBracket.Text;
        }

        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            double cuberoot = Convert.ToSingle(txtDisplay.Text);

            if (Convert.ToDouble(txtDisplay.Text) < 0)
            {
                txtDisplay.Text = "Invalid input";

            }
            else
            {
                txtUpper.Text = "∛x(" + cuberoot + ")";
                cuberoot = Convert.ToDouble(Math.Ceiling(Math.Pow(cuberoot,(double) 1/3)));
                txtDisplay.Text = cuberoot.ToString();
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            fstNum = Convert.ToDouble(txtDisplay.Text);
            operators = "x^y";
            txtDisplay.Text = "";
           
            
            txtUpper.Text = Convert.ToString(fstNum) + "^ " ;
        }

        private void btnNaturalLog_Click(object sender, EventArgs e)
        {
            double ln = Convert.ToDouble(txtDisplay.Text);
            txtUpper.Text = "ln(" + ln + ")";
            ln = Convert.ToDouble(Math.Log(ln));
            txtDisplay.Text = ln.ToString();

        }

        private void btn10Power_Click(object sender, EventArgs e)
        {
            
            operators = "10^y";
            txtDisplay.Text = "";


            txtUpper.Text =  "10^ ";
        }

        private void btn2Power_Click(object sender, EventArgs e)
        {
            operators = "2^x";
            txtDisplay.Text = "";


            txtUpper.Text = "2^ ";

        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnLogy_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEx_Click(object sender, EventArgs e)
        {

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
    }
}
