using CollegeTemplateLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTest
{
    public partial class LoginForm : CollegeTemplateForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(loginUserControl1.Username) && !string.IsNullOrWhiteSpace(loginUserControl1.Password))
            {
                MessageBox.Show("You have logged in using\n username: " + loginUserControl1.Username + "\n password: " + loginUserControl1.Password);
            }
            else
            {
                MessageBox.Show("Please enter both a username and password!");
            }
        }
    }
}
