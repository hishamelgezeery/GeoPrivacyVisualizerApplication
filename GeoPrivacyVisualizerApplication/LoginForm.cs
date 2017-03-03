using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        private void Form5_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                login();
            }
        }

        private void login()
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }
    }
}
