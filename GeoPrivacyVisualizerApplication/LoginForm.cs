using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using GeoPrivacyVisualizerApplication.Properties;

namespace GeoPrivacyVisualizerApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login();
            }
        }

        private void login()
        {
            bool signedIn = signInUser(txtUsername.Text, txtPassword.Text);
            if (!signedIn)
            {
                MessageBox.Show("Username or password is incorrect!");
                return;
            }
            MainForm frm = new MainForm();
            frm.username = txtUsername.Text;
            frm.pathToFiles = Settings.Default.FolderPath + txtUsername.Text +  "\\";
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private bool signInUser(string username, string password)
        {
            var strLines = File.ReadLines(Settings.Default.FolderPath + "Users.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[0].Equals(username) && line.Split(',')[1].Equals(password))
                    return true;
            }
            return false;
        }
    }
}
