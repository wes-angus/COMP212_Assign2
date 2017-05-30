using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginControl
{
    public partial class LoginUserControl : UserControl
    {
        //private string username;
        //private string password;

        public string Username
        {
            get
            {
                return userBox.Text;
            }
        }

        public string Password
        {
            get
            {
                return pWordBox.Text;
            }
        }

        public LoginUserControl()
        {
            InitializeComponent();
        }
    }
}
