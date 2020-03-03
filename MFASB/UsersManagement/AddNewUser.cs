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

namespace MFASB.UsersManagement
{
    public partial class AddNewUser : Form
    {
        Biometrics biom = new Biometrics();

        public AddNewUser()
        {
            InitializeComponent();
            this.CenterToScreen();

            biom.AddBiometricsCharacteristics(cboTypeOfBiometrics);
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
