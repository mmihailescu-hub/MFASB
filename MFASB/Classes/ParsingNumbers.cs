using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFASB.Classes
{
    class ParsingNumbers
    {
        //string number = ""; //** variable used only for numbers such as 2^5

        //** used for numbers which has the form of 2^5
        double firstPart = 0.0;
        double secondPart = 0.0;

        //** the limit used for p and q
        int limit = 0;

        public void ParseNumbers(string number, TextBox txtNumber)
        {            
            if (number.Contains("^"))
            {
                string[] numbers_parts = new string[] { };
                numbers_parts = number.Split('^');

                firstPart = Convert.ToDouble(numbers_parts[0]);
                secondPart = Convert.ToDouble(numbers_parts[1]);

                txtNumber.AppendText(" = " + Math.Pow(firstPart, secondPart).ToString());
            }
            else
            {
                //limit = Convert.ToInt32(txtNumber.Text);
               // txtNumber.Text = limit.ToString();
                //MessageBox.Show(txtNumber.Text);
            }
        }

       public void GenerateSieveOfEratosthenes(int upperBound, TextBox txtSieve)
        {
           int upperBoundSquareRoot = (int) Math.Sqrt(upperBound);
           bool[] isComposite = new bool[upperBound + 1];

           for (int m = 2; m <= upperBoundSquareRoot; m++) 
           {
                if (!isComposite[m]) 
                {
                        txtSieve.AppendText(m + " ");

                        for (int k = m * m; k <= upperBound; k += m)
                            isComposite[k] = true;
                }
           }

           for (int m = upperBoundSquareRoot; m <= upperBound; m++)
                if (!isComposite[m])
                    txtSieve.AppendText(m + " ");
        }
    }
}
