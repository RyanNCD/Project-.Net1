using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementWinApp_NguyenCongDanh
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<DefaultAccountSettings>();
            string email = adminDefaultSettings.Email;
            string password = adminDefaultSettings.Password;
            string role = adminDefaultSettings.Role;
            if (txtEmail.Text.Equals(email) & txtPassword.Text.Equals(password))
            {
                frmProjectManagement frmProjectManagement = new frmProjectManagement();
                frmProjectManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }
    }
}
