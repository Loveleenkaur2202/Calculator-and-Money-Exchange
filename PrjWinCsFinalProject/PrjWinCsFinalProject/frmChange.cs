using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjWinCsFinalProject
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }


        struct Country
        {
            public string Name;
            public string Currency;
            public string Value;
            public string ValueDollars;
        }
        static Country[] tabCountry = new Country[50];
        static Int16 nbCountries;

        private void ReadFile()
        {
            StreamReader myfile = new StreamReader("Rates.txt");
            Int16 i = 0;
            while (myfile.EndOfStream == false)
            {
                tabCountry[i].Name = myfile.ReadLine();
                tabCountry[i].Currency = myfile.ReadLine();
                tabCountry[i].Value = myfile.ReadLine();
                tabCountry[i].ValueDollars = myfile.ReadLine();


                //at the same rime, fill the cboQuestions with the questions
                
                cboCountry.Items.Add(tabCountry[i].Name);
                i++;
            }
            nbCountries = i;

        }
        private void frmChange_Load(object sender, EventArgs e)
        {
            lblInputCurrency.Text = "";
            ReadFile();
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = cboCountry.SelectedIndex.ToString();

            Int32 indx = cboCountry.SelectedIndex;


            radConvertToCurrency.Text = "From USD to " + tabCountry[indx].Currency;
            lblValueCurrency.Text = "1 US Dollar = " + tabCountry[indx].ValueDollars + tabCountry[indx].Currency;
            lblValueDollar.Text = "1 " + tabCountry[indx].Currency + " = " + tabCountry[indx].Value + " US Dollar";
            radConvertToDollar.Text = "From " + tabCountry[indx].Currency + " to USD";
            
            lblInputCurrency.Text = ((radConvertToCurrency.Checked) == true) ? "US Dollar" : tabCountry[indx].Currency.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblInputCurrency.Text = "";
            lblValueCurrency.Text = "";
            lblValueDollar.Text = "";
            txtInputValue.Text = "";
            lblOutput.Text = "";
            radConvertToCurrency.Checked = false;
            radConvertToDollar.Text = "";
            radConvertToCurrency.Text = "";
            radConvertToDollar.Checked = false;
            cboCountry.Text = "";

        }

        private void txtInputValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            if (txtInputValue.Text == "")
            {
                MessageBox.Show("Please enter a value to convert");
                txtInputValue.Focus();
                return;
            }
            Single i = Convert.ToSingle(txtInputValue.Text);
           double convert;
           if(cboCountry.SelectedItem.ToString()=="France"&&radConvertToCurrency.Checked == true)
            {
                convert = i * 0.9615;
                lblOutput.Text = convert.ToString() + " Euro";
            }
           else if(cboCountry.SelectedItem.ToString() == "Canada" && radConvertToCurrency.Checked == true)
            {
                convert = i * 1.34;
                lblOutput.Text = convert.ToString() + " C.N. Dollars";
            }
            else if (cboCountry.SelectedItem.ToString() == "England" && radConvertToCurrency.Checked == true)
            {
                convert = i * 0.826;
                lblOutput.Text = convert.ToString() + " Pounds";
            }
            else if (cboCountry.SelectedItem.ToString() == "Japan" && radConvertToCurrency.Checked == true)
            {
                convert = i * 138.89;
                lblOutput.Text = convert.ToString() + " Yen";
            }
            else if (cboCountry.SelectedItem.ToString() == "India" && radConvertToCurrency.Checked == true)
            {
                convert = i * 83.34;
                lblOutput.Text = convert.ToString() + " Rupees";
            }
           else if(cboCountry.SelectedItem.ToString() == "France" && radConvertToDollar.Checked == true)
            {
                convert = i*1.04;
                lblOutput.Text = convert.ToString() + " USD";
            }
           else if(cboCountry.SelectedItem.ToString() == "Canada" && radConvertToDollar.Checked == true)
            {
                convert = i*0.75;
                lblOutput.Text = convert.ToString() + " USD";
            }
           else if(cboCountry.SelectedItem.ToString() == "England" && radConvertToDollar.Checked == true)
            {
                convert = i*1.21;
                lblOutput.Text = convert.ToString() + " USD";
            }
           else if(cboCountry.SelectedItem.ToString() == "Japan" && radConvertToDollar.Checked == true)
            {
                convert =i*0.0072;
                lblOutput.Text = convert.ToString() + " USD";
            }
            else if(cboCountry.SelectedItem.ToString() == "India" && radConvertToDollar.Checked == true)
            {
                convert = i*0.012;
                lblOutput.Text = convert.ToString() + " USD";
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

            this.Dispose();
            //return;
        }
    }
}
