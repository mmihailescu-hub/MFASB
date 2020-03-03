using MFASB.Classes;
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
    public partial class ApplicationActivity : Form
    {
        Audit aud = new Audit();

        public ApplicationActivity()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ApplicationActivity_Load(object sender, EventArgs e)
        {
            aud.LoadAudit(listBox1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
