using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFASB.Classes
{
    class Users
    {
        public void GetUser(ListView lvUsers)
        {
            //** MFASBSettings.Default.ConnectionString - folosit pentru a salva string-ul de conectare la baza de date            
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Proiecte\Visual Studio 2013\MFASB\MFASB\Database\MFASBAccess.accdb");
            string sql = "SELECT ID, UserId, Surname, Forename, UserName, BiometricCharacteristicType FROM [User]";
            //string sql = "SELECT * FROM [User]";

            OleDbCommand cmd = new OleDbCommand(sql, conn);

            conn.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetInt32(0).ToString());
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetString(2));
                lvi.SubItems.Add(reader.GetString(3));
                lvi.SubItems.Add(reader.GetString(4));
                lvi.SubItems.Add(reader.GetString(5));
                lvUsers.Items.Add(lvi);
            }
            reader.Close();
            conn.Close();
        }
    }
}
