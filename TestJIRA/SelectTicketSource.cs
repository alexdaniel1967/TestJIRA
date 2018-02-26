using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atlassian.Jira;

namespace TestJIRA
{
    
    public partial class SelectTicketSource : Form
    {

        public SelectTicketSource()
        {
            InitializeComponent();
        }
        

        private void SelectTicketSource_Load(object sender, EventArgs e)
        {

        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            if (rbJira.Checked)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else if (rbServiceNow.Checked)
            {
            }
            else if (rbTFS.Checked)
            {
            }
        }
    }
}
