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

namespace MFASB.UsersManagement
{
    public partial class ViewUsers : Form
    {
        CustomizeControls cc = new CustomizeControls();
        Users user = new Users();

        public ViewUsers()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {            
            cc.CustomizeUsersListView(listView1);
            user.GetUser(listView1);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUser anu = new AddNewUser();
            anu.Show();
        }
    }
}
