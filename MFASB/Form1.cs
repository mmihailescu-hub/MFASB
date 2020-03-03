using MFASB.Classes;
using MFASB.UsersManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFASB
{
    public partial class Form1 : Form
    {
        const int arrowWidth = 8;
        bool IsConnection = false;  //** daca exista conexiune sau nu
        bool IsConnected;           //** daca ne-am conectat cu succes la baza de date sau nu

        Biometrics bio = new Biometrics();
        Database db = new Database();
        Algorithms alg = new Algorithms();

        private enum MyKeys { key1, key2, key3 };

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bio.AddBiometricsCharacteristics(cboBiometricCharacteristics);
            if (MFASBSettings.Default.ConnectionDB == "")       //** daca avem o baza de date incarcata
                IsConnection = false;                           //** false - incarcam una
            else
            {
                IsConnection = true;                            //** true - numai incarcam si ne conectam la baza de date
                IsConnected = db.ConnectToDatabase(MFASBSettings.Default.ConnectionDB);
                if(IsConnected == true)
                {
                   // MessageBox.Show("You have connected with success to the previous database. The database is: " + MFASBSettings.Default.ConnectionDB);
                    label7.Enabled = true;
                    pictureBox5.Enabled = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sieveOfEratosthenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SieveOfEratosthenes se = new SieveOfEratosthenes();
            se.Show();
        }

        private void rSADemonstrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            rsa.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        #region Drawing
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), arrowWidth);
            pen.StartCap = LineCap.Square;
            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, 0, 7, 120, 7);            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), arrowWidth);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.Square;
            e.Graphics.DrawLine(pen, 7, 0, 7, 170); 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), arrowWidth);
            pen.StartCap = LineCap.Square;
            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, 7, 0, 7, 120);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), arrowWidth);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.Square;
            e.Graphics.DrawLine(pen, 7, 0, 7, 120);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), arrowWidth);
            pen.StartCap = LineCap.Square;
            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, 0, 7, 85, 7);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), arrowWidth);
            pen.StartCap = LineCap.Square;
            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, 0, 7, 120, 7);  
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), arrowWidth);
            pen.StartCap = LineCap.Square;
            pen.EndCap = LineCap.Square;
            e.Graphics.DrawLine(pen, 7, 0, 7, 435);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), arrowWidth);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.Square;
            e.Graphics.DrawLine(pen, 0, 7, 1050, 7);
        }
        #endregion

        private void commandShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandShell cs = new CommandShell();
            cs.Show();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsers vu = new ViewUsers();
            vu.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewUser anu = new AddNewUser();
            anu.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string myFileDb = string.Empty;            

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Load database with users";
            ofd.InitialDirectory = @"E:\Proiecte\Visual Studio 2013\MFASB\MFASB\Database\";
            ofd.Filter = "Microsoft Access Database (*.accdb)|*.accdb";           

            if (IsConnection == false)
            {
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        myFileDb = ofd.FileName.ToString();
                        MFASBSettings.Default.ConnectionDB = myFileDb;
                        MFASBSettings.Default.Save();
                        db.ConnectToDatabase(MFASBSettings.Default.ConnectionDB);
                        MFASBSettings.Default.IsConnectedToDb = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("There is already a connection to a database. Do you wish to change the database?", "Changing the connection to the database", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    DialogResult result = ofd.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            myFileDb = ofd.FileName.ToString();
                            MFASBSettings.Default.ConnectionDB = myFileDb;
                            MFASBSettings.Default.Save();
                            db.ConnectToDatabase(MFASBSettings.Default.ConnectionDB);
                            MFASBSettings.Default.IsConnectedToDb = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                        }
                    }
                }
                else
                {

                }
            }
        }

        private void applicationActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationActivity aa = new ApplicationActivity();
            aa.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            txtTokenID.Text = alg.GeneratePassCode(6);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTokenID.Text == "")
                {
                    //MessageBox.Show("You need to generate a Token ID before you can continue with generating the Passcode");
                    throw new ArgumentNullException("You need to generate a Token ID before you can continue with generating the Passcode");
                }
                txtMobileTokenID.Text = txtTokenID.Text;
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void panel5_Click(object sender, EventArgs e)
        {           
               
        }

        private void keysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Keys key = new Keys();
            key.Show();
        }
    }
}