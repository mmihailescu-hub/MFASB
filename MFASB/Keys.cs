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
    public partial class Keys : Form
    {
        private string[] keyRSAFiles = Directory.GetFiles(@"E:\OneDrive\Proiecte\Visual Studio 2013\MFASB\MFASB\Keys\RSA\");
        private string[] keyDSAFiles = Directory.GetFiles(@"E:\OneDrive\Proiecte\Visual Studio 2013\MFASB\MFASB\Keys\DSA");

        public Keys()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Keys_Load(object sender, EventArgs e)
        {
            tvKeys.Nodes.Add("RSA Keys");
            tvKeys.Nodes.Add("DSA Keys");

            foreach (string keyRSA in keyRSAFiles)
            {
                tvKeys.Nodes[0].Nodes.Add(Path.GetFileName(keyRSA.ToString()));
            }

            foreach (string keyDSA in keyDSAFiles)
            {
                tvKeys.Nodes[1].Nodes.Add(Path.GetFileName(keyDSA.ToString()));
                //tvKeys.Nodes[1].Nodes.Add(keyDSA.ToString());
            }

            tvKeys.ExpandAll();
        }

        private void tvKeys_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtKeyContent.Clear();
            TreeNode node = tvKeys.SelectedNode;

            string nodeValue = node.Text;
            string keyRSAPath = @"E:\OneDrive\Proiecte\Visual Studio 2013\MFASB\MFASB\Keys\RSA\" + node.Text;
            string keyDSAPath = @"E:\OneDrive\Proiecte\Visual Studio 2013\MFASB\MFASB\Keys\DSA\" + node.Text;

            if(node.Parent.Text == "RSA Keys")
            {
                string[] lines = System.IO.File.ReadAllLines(keyRSAPath);
                foreach (string line in lines)
                {
                    txtKeyContent.AppendText(line);
                }
            }

            if (node.Parent.Text == "DSA Keys")
            {
                string[] lines = System.IO.File.ReadAllLines(keyDSAPath);
                foreach (string line in lines)
                {
                    txtKeyContent.AppendText(line);
                }
            }
        }        
    }
}
