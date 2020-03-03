using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFASB.Classes;

namespace MFASB
{
    public partial class GeneratePrimeNumbers : Form
    {
        Algorithms algorithm = new Algorithms();
        ParsingNumbers pn = new ParsingNumbers();
        MillerRabinAlgorithm mra = new MillerRabinAlgorithm();

        public GeneratePrimeNumbers()
        {
            InitializeComponent();
            this.CenterToScreen();

            txtLowerLimitP.Enabled = false;
            txtUpperLimitP.Enabled = false;
            txtUpperLimitQ.Enabled = false;
            txtLowerLimitQ.Enabled = false;            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneratePrimeNumbers_Load(object sender, EventArgs e)
        {            
            algorithm.AddPrimalityAlgorithms(cboAlgorithms);
        }

        private void cboAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLowerLimitP.Enabled = true;
            txtUpperLimitP.Enabled = true;
            txtUpperLimitQ.Enabled = true;
            txtLowerLimitQ.Enabled = true;

            txtLowerLimitP.Focus();
        }

        private void btnGeneratePrimeNumbers_Click(object sender, EventArgs e)
        {
            pn.ParseNumbers(txtLowerLimitP.Text, txtLowerLimitP);
            pn.ParseNumbers(txtUpperLimitP.Text, txtUpperLimitP);
            pn.ParseNumbers(txtLowerLimitQ.Text, txtLowerLimitQ);
            pn.ParseNumbers(txtUpperLimitQ.Text, txtUpperLimitQ);

            txtResultP.Text = algorithm.GenerateNumber(Convert.ToInt32(txtLowerLimitP.Text), Convert.ToInt32(txtUpperLimitP.Text)).ToString();
            txtResultQ.Text = algorithm.GenerateNumber(Convert.ToInt32(txtLowerLimitQ.Text), Convert.ToInt32(txtUpperLimitQ.Text)).ToString();      
        }

        private void GeneratePrimeNumbers_FormClosed(object sender, FormClosedEventArgs e)
        {
            RSA frmRSA = (RSA)this.Owner;

            frmRSA.txtSetGetP = txtResultP.Text;
            frmRSA.txtSetGetQ = txtResultQ.Text;

            frmRSA.SetModulusN = frmRSA.ComputeRSAModulusN().ToString();
            frmRSA.SetPhiN = frmRSA.ComputePhiN().ToString() ;

        }

        private void btnApplyPrimes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
