using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFASB.Classes
{
    class CustomizeControls
    {
        public void CustomizeUsersListView(ListView lvUsers)
        {
            lvUsers.View = View.Details;
            lvUsers.FullRowSelect = true;

            lvUsers.Columns.Add("ID");
            lvUsers.Columns.Add("UserID");
            lvUsers.Columns.Add("Surname");
            lvUsers.Columns.Add("Forename");
            lvUsers.Columns.Add("E-mail");
            lvUsers.Columns.Add("User name");
            lvUsers.Columns.Add("Type of biometric");            
        }
    }
}
