using MFASB.Classes;
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

namespace MFASB
{
    public partial class SieveOfEratosthenes : Form
    {
        ParsingNumbers pn = new ParsingNumbers();

        public SieveOfEratosthenes()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtSieve.Clear();

            int upperBound = Convert.ToInt32(txtNumber.Text);

            pn.GenerateSieveOfEratosthenes(upperBound, txtSieve);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "E:\\sieve.txt";
            string text = txtSieve.Text;

            if (text != "")
            {
                try
                {
                    FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);                   

                    sw.WriteLine(text);
                    sw.Close();

                    MessageBox.Show("The sieve has been saved with success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something was not ok with the saving process. The error is: " + ex.ToString());
                }                
            }
            else
            {
                MessageBox.Show("You should have some numbers before saving the file!");
                return;
            }
        }
    }
}
