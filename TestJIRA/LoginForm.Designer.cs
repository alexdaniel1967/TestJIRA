namespace TestJIRA
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtJiraUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTFS = new System.Windows.Forms.RadioButton();
            this.rbServiceNow = new System.Windows.Forms.RadioButton();
            this.rbJira = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(142, 74);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(159, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(142, 198);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(69, 22);
            this.cmdSubmit.TabIndex = 4;
            this.cmdSubmit.Text = "Submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_ClickAsync);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(248, 198);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 22);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtJiraUrl
            // 
            this.txtJiraUrl.Location = new System.Drawing.Point(142, 151);
            this.txtJiraUrl.Name = "txtJiraUrl";
            this.txtJiraUrl.Size = new System.Drawing.Size(273, 20);
            this.txtJiraUrl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ticket Source URL";
            // 
            // rbTFS
            // 
            this.rbTFS.AutoSize = true;
            this.rbTFS.Location = new System.Drawing.Point(278, 37);
            this.rbTFS.Name = "rbTFS";
            this.rbTFS.Size = new System.Drawing.Size(45, 17);
            this.rbTFS.TabIndex = 11;
            this.rbTFS.TabStop = true;
            this.rbTFS.Text = "TFS";
            this.rbTFS.UseVisualStyleBackColor = true;
            this.rbTFS.Click += new System.EventHandler(this.rbTFS_Click);
            // 
            // rbServiceNow
            // 
            this.rbServiceNow.AutoSize = true;
            this.rbServiceNow.Location = new System.Drawing.Point(189, 37);
            this.rbServiceNow.Name = "rbServiceNow";
            this.rbServiceNow.Size = new System.Drawing.Size(83, 17);
            this.rbServiceNow.TabIndex = 10;
            this.rbServiceNow.TabStop = true;
            this.rbServiceNow.Text = "ServiceNow";
            this.rbServiceNow.UseVisualStyleBackColor = true;
            this.rbServiceNow.Click += new System.EventHandler(this.rbServiceNow_Click);
            // 
            // rbJira
            // 
            this.rbJira.AutoSize = true;
            this.rbJira.Location = new System.Drawing.Point(142, 37);
            this.rbJira.Name = "rbJira";
            this.rbJira.Size = new System.Drawing.Size(41, 17);
            this.rbJira.TabIndex = 9;
            this.rbJira.TabStop = true;
            this.rbJira.Text = "Jira";
            this.rbJira.UseVisualStyleBackColor = true;
            this.rbJira.Click += new System.EventHandler(this.rbJira_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ticket Source";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 252);
            this.Controls.Add(this.rbTFS);
            this.Controls.Add(this.rbServiceNow);
            this.Controls.Add(this.rbJira);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJiraUrl);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login Ticket Source";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.TextBox txtJiraUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTFS;
        private System.Windows.Forms.RadioButton rbServiceNow;
        private System.Windows.Forms.RadioButton rbJira;
        private System.Windows.Forms.Label label4;
    }
}