using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFASB.Classes
{
    class Database
    {
        Audit aud = new Audit();
        OleDbConnection myConnection = null;

        public bool ConnectToDatabase(string pathToDb)
        {
            bool IsConnected = false;
            
            myConnection = new OleDbConnection();

            myConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + 
                                            @"Data Source=" + MFASBSettings.Default.ConnectionDB;

            //** tot sirul pentru conexiune folosit mai sus se va salva in setarile aplicatiei in ConnectionString
            MFASBSettings.Default.ConnectionString = myConnection.ConnectionString;

            try
            {
                myConnection.Open();
                IsConnected = true;
                aud.AddToFile(myConnection, IsConnected.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source. Original error: " + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }

            return IsConnected;
        }

        public void AddNewPerson()
        {
            if(MFASBSettings.Default.IsConnectedToDb == true)
            {
                myConnection = new OleDbConnection();
            }
        }

        public bool CheckPassword(string password, string password_confirm)
        {
            bool PasswordIsSimilar = true;

            return PasswordIsSimilar;
        }
    }
}
