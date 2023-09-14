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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MnuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this program ?",
                "Closing Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MnuToolbar_Click(object sender, EventArgs e)
        {
            if (MnuToolbar.Checked == true)
            {
                toolStrip1.Show();
            }
            else
            {
                toolStrip1.Hide();
            }
        }

        private void MnuStatusbar_Click(object sender, EventArgs e)
        {
            if (MnuStatusbar.Checked == true)
            {
                statusStrip1.Show();
            }
            else
            {
                statusStrip1.Hide();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            statusStrip1.Show();
            toolStrip1.Show();
            MnuStatusbar.Checked = true;
            MnuToolbar.Checked = true;
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();

            //lets show the frmAbout
            frmAbout.Show();
            frmAbout.MdiParent = this;
            frmAbout.Left = (this.Width - frmAbout.Width) / 2;
            frmAbout.Top = (this.Height - frmAbout.Height) / 2;
        }

        private void MnuUserManual_Click(object sender, EventArgs e)
        {
            frmUserManual frmUserManual = new frmUserManual();

            //lets show the frmUserManual
            frmUserManual.Show();
            frmUserManual.MdiParent = this;
            frmUserManual.Left = (this.Width - frmUserManual.Width) / 2;
            frmUserManual.Top = (this.Height - frmUserManual.Height) / 2;
        }

        private void MnuStandardCal_Click(object sender, EventArgs e)
        {
            frmStandard frmstandard = new frmStandard();

            //lets show the frmAbout
            frmstandard.Show();
            frmstandard.MdiParent = this;
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            frmStandard frmstandard = new frmStandard();

            //lets show the frmAbout
            frmstandard.Show();
            frmstandard.MdiParent = this;
        }

        private void MnuScientificCal_Click(object sender, EventArgs e)
        {
            frmScientific frmscientific = new frmScientific();

            //lets show the frmscientific
            frmscientific.Show();
            frmscientific.MdiParent = this;

        }

        private void btnScientific_Click(object sender, EventArgs e)
        {
            frmScientific frmscientific = new frmScientific();

            //lets show the frmscientific
            frmscientific.Show();
            frmscientific.MdiParent = this;

        }

        private void MnuLocal_Click(object sender, EventArgs e)
        {
            frmChange frmChange = new frmChange();

            frmChange.Show();
            
            frmChange.MdiParent = this;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmChange frmChange = new frmChange();

            frmChange.Show();
            frmChange.MdiParent = this;
        }
    }
}
