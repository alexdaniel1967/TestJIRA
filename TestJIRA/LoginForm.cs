using System;
using System.Windows.Forms;


namespace TestJIRA
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void cmdSubmit_ClickAsync(object sender, EventArgs e)
        {
            Form1 jirafrm = new Form1();

            Form1.pUsername = txtUser.Text;
            Form1.pPassword = txtPassword.Text;
            Form1.pUrl = txtJiraUrl.Text;

            if (rbJira.Checked)
            {
                Form1.pTicketSource = "JIRA";
            }
            else if (rbServiceNow.Checked)
            {
                Form1.pTicketSource = "SERVICENOW";
            }
            else if (rbTFS.Checked)
            {
                Form1.pTicketSource = "TFS";
            }
            jirafrm.Show();
            this.Hide();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbJira_Click(object sender, EventArgs e)
        {
            txtUser.Text = "kprasad5";
            txtPassword.Text = "";
            txtJiraUrl.Text = "https://jira.csc.com";
        }

        private void rbServiceNow_Click(object sender, EventArgs e)
        {            
            txtUser.Text = "admin";
            txtPassword.Text = "Change@123";
            txtJiraUrl.Text = "https://dev46293.service-now.com/api/now/v1/table/incident";

        }

        private void rbTFS_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtJiraUrl.Text = "";
        }
    }
}
