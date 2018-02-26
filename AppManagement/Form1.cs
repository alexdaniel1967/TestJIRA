using System;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Atlassian.Jira;
using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using Microsoft.Alm.Authentication;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TestJIRA;

namespace AppManagement
{
    public partial class Form1 : Form
    {
        public static string pUrl = "";
        public static string pUsername = "";
        public static string pPassword = "";
        public static string pTicketSource = "";

        Jira jiraConnection;
        Issue pCurrentIssue;
        private string _LocalGitPath = @"C:\Test"; //"https://github.com/alexdaniel1967/TestHarness";
        private string _UserName = "alxdaniel";
        private string _Password = "abcxyz";

        public Form1()
        {
            InitializeComponent();
        }

        private async void cmdQuery_ClickAsync(object sender, EventArgs e)
        {
            if (pTicketSource == "JIRA")
            {
                // create a connection to JIRA using the Rest client
                jiraConnection = Jira.CreateRestClient(pUrl, pUsername, pPassword);

                // use LINQ syntax to retrieve issues
                var issues = from i in jiraConnection.Issues.Queryable
                                 // where i.Assignee == txtUser.Text
                             orderby i.Created
                             select i;
                //DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[] {
                    new DataColumn("Assigned to", typeof(string)),
                    new DataColumn("Created on",typeof(string)),
                    new DataColumn("Description",typeof(string)),
                    new DataColumn("Project", typeof(string)),
                    new DataColumn("Priority", typeof(string)),
                    new DataColumn("Status", typeof(string)),
                    new DataColumn("Key", typeof(string))});

                foreach (Issue issue in issues)
                {
                    DataRow dr = dt.NewRow();

                    dr[0] = issue.Assignee;
                    dr[1] = issue.Created.ToString();
                    dr[2] = issue.Description;
                    dr[3] = issue.Project;
                    dr[4] = issue.Priority;
                    dr[5] = issue.Status;
                    dr[6] = issue.Key;
                    dt.Rows.Add(dr);
                    dataGridView1.DataSource = dt;

                    pCurrentIssue = issue;

                };

                // Save current issue for status update purpose


                /* string str = "Environment: " + issue.Environment + " Jira: " + issue.Jira + " Jira Identifier: " + issue.JiraIdentifier + " Key: " + issue.Key;
                 string str1 = "Type: " + issue.Type + " Summary: " + issue.Summary + " Resolution: " + issue.Resolution + " Reporter: " + issue.Reporter;
                 MessageBox.Show(str + " "  + str1); */
            }
            else if (pTicketSource == "SERVICENOW")
            {
                Uri sNowURI = new Uri(pUrl); //https://dev46293.service-now.com/api/now/v1/table/incident
                HttpClient rest = new HttpClient();


                rest.BaseAddress = sNowURI;

                rest.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                         "Basic",
                          Convert.ToBase64String(
                             System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", pUsername, pPassword))));

                rest.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await rest.GetAsync(sNowURI);
                if (response.IsSuccessStatusCode)
                {
                    var contents = await response.Content.ReadAsStringAsync();
                    Results results = JsonConvert.DeserializeObject<Results>(contents);
                    var results1 = results.Results1
                    .Select(r => new
                    {
                        AssignedTo = r.AssignedTo == null ? "" : r.AssignedTo.Value,
                        SysCreatedOn = r.SysCreatedOn,
                        Description = r.Description,
                        Project = r.AssignmentGroup == null ? "" : r.AssignmentGroup.Value,
                        Priority = r.Priority,
                        Status = r.IncidentState
                    }).ToList();

                    dataGridView1.DataSource = results1;
                }
            }
            else if (pTicketSource == "TFS")
            {
            }
        }
                 
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private  void cmdUpdateStatus_Click(object sender, EventArgs e)
        {
            updateStatus();
        }

        private  void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.CurrentRow.Selected)
            {
               
            }
        }

        private async void updateStatus() 
        {
            var updates = new WorkflowTransitionUpdates() { Comment = "--- Comment with transition ---" };
            await pCurrentIssue.WorkflowTransitionAsync("Done", updates);
            // await issue.WorkflowTransitionAsync("TO DO", updates);
            MessageBox.Show("Issue Status Changed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            
        }

        private void cmdOpenPrj_Click(object sender, EventArgs e)
        {
            //CheckoutBranch("alex");
            //FetchAll();
            //FetchLatestGITFiles();

            if (dataGridView1.CurrentRow != null)
            { 
                int currentRow = dataGridView1.CurrentRow.Index;
           
                string[] projectDetails = new string[2];
                projectDetails = getProjectPath(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                startInfo.FileName = projectDetails[0];  // Visual Studio
                startInfo.Arguments = projectDetails[1]; //  solutionPath;

                process.StartInfo = startInfo;
                process.Start();
            }
            else
            {
                MessageBox.Show("Please select a project in the grid and click Open Project Button");
            }
        }

        public void FetchLatestGITFiles()
        {
            var secrets = new SecretStore("git");
            var auth = new BasicAuthentication(secrets);
            var creds = auth.GetCredentials(new TargetUri("https://github.com"));

            var options = new CloneOptions
            {
                CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials
                {
                    Username = "alxdaniel",
                    Password = "abcxyz"
                },
            };
            // Clone everything from https://github.com/alexdaniel1967/TestHarness to C:\Test folder
            Repository.Clone("https://github.com/alexdaniel1967/TestHarness", @"C:\Test", options);
        }

        private string[] getProjectPath(string projectKey)
        {
            string[] configDetails = new string[2];
            string JiraConfig = "..\\..\\JIRA.Config";
            string[] readText = System.IO.File.ReadAllLines(JiraConfig);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
                string[] splitArray = s.Split(',');
                if (splitArray[0] == projectKey)
                {
                    configDetails[0] = splitArray[1];  // Solution path
                    configDetails[1] = splitArray[2];  // Visual Studio path
                    break;
                }
            }

           // configDetails[1] = readText[0];
           // configDetails[0] = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\Common7\\IDE\\devenv.exe";

            return configDetails;
        }



        public void FetchAll()
        {
            using (var repo = new Repository(_LocalGitPath))
            {
                foreach (Remote remote in repo.Network.Remotes)
                {
                    FetchOptions options = new FetchOptions
                    {
                        CredentialsProvider = new CredentialsHandler((url, usernameFromUrl, types) => new UsernamePasswordCredentials()
                        {
                            Username = _UserName,
                            Password = _Password
                        })
                    };
                    repo.Network.Fetch(remote, options);
                }
            }
        }

        public string CheckoutBranch(string branchName)
        {
            using (var repo = new Repository(_LocalGitPath))
            {
                var trackingBranch = repo.Branches[branchName];

                if (trackingBranch.IsRemote)
                {
                    branchName = branchName.Replace("origin/", string.Empty);

                    var branch = repo.CreateBranch(branchName, trackingBranch.Tip);
                    repo.Branches.Update(branch, b => b.TrackedBranch = trackingBranch.CanonicalName);
                    Commands.Checkout(repo, branch, new CheckoutOptions { CheckoutModifiers = CheckoutModifiers.Force });
                }
                else
                {
                    Commands.Checkout(repo, trackingBranch, new CheckoutOptions { CheckoutModifiers = CheckoutModifiers.Force });
                }
                return branchName;
            }
        }

        public void PullBranch(string branchName)
        {
            using (var repo = new Repository(_LocalGitPath))
            {
                PullOptions options = new PullOptions();

                options.MergeOptions = new MergeOptions();
                options.MergeOptions.FailOnConflict = true;

                options.FetchOptions = new FetchOptions();
                options.FetchOptions.CredentialsProvider = new CredentialsHandler((url, usernameFromUrl, types) => new UsernamePasswordCredentials()
                {
                    Username = _UserName,
                    Password = _Password
                });
                repo.Network.Pull(new Signature(_UserName, _Password, new DateTimeOffset(DateTime.Now)), options);
            }
        }

    }
}
