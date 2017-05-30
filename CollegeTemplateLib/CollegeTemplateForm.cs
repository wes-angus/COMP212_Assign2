using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CollegeTemplateLib
{
    public partial class CollegeTemplateForm : Form
    {
        public CollegeTemplateForm()
        {
            InitializeComponent();
        }

        private void cenColLinkLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/wesley-angus-887a99b1/");
        }
    }
}
