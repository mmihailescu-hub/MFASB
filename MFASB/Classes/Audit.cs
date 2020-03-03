using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFASB.Classes
{
    class Audit
    {
        string fileName = @"E:\Proiecte\Visual Studio 2013\MFASB\MFASB\Audit\audit.txt";

        public void AddToFile(object eventApplication, string value)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(eventApplication.GetType().ToString() + "; " + eventApplication.GetType().Name.ToString() + "; " + value.ToString() + "; " + DateTime.Now.ToString());

                sw.Close();

                //MessageBox.Show("The sieve has been saved with success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something was not ok with the saving process. The error is: " + ex.ToString());
            }
        }    
    
        public void LoadAudit(ListBox lbAudits)
        {
            int counter = 0;
            string line = string.Empty;
            StreamReader file = new StreamReader(fileName);

            while((line = file.ReadLine()) != null)
            {
                lbAudits.Items.Add(line.ToString());
                counter++;
            }

            file.Close();
        }
    }
}
