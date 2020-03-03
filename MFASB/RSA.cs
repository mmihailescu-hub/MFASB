using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFASB
{
    public partial class RSA : Form
    {

        GeneratePrimeNumbers gpn = new GeneratePrimeNumbers();
        int modulusN = 0;
        int phiN = 0;
        int p = 0;
        int q = 0;

        public RSA()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string txtSetGetP
        {
            set { this.txtPrimeNumberP.Text = value; }
            get { return this.txtPrimeNumberP.Text; }
        }

        public string txtSetGetQ
        {
            set { this.txtPrimeNumberQ.Text = value; }
            get { return this.txtPrimeNumberQ.Text; }
        }

        public string SetModulusN
        {
            set { this.txtModulusN.Text = value; }
            get { return this.txtModulusN.Text; }
        }

        public string SetPhiN
        {
            set { this.txtPhiN.Text = value; }
            get { return this.txtPhiN.Text; }
        }


        public int ComputeRSAModulusN()
        {
            p = Convert.ToInt32(txtPrimeNumberP.Text);
            q = Convert.ToInt32(txtPrimeNumberQ.Text);
            modulusN =  p * q;
            return modulusN;
        }

        public int ComputePhiN()
        {
            phiN = (p - 1) * (q - 1);
            return phiN;
        }

        

        private void btnGeneratePrimeNumber_Click(object sender, EventArgs e)
        {
            gpn.Show(this);
        }

        private void RSA_Load(object sender, EventArgs e)
        {

        }

        private void sieveOfEratosthenesToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            SieveOfEratosthenes sieve = new SieveOfEratosthenes();
            sieve.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
