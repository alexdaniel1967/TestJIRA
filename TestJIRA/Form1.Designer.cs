namespace TestJIRA
{
    partial class Form1
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
            this.cmdQuery = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdUpdateStatus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdOpenPrj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdQuery
            // 
            this.cmdQuery.Location = new System.Drawing.Point(116, 283);
            this.cmdQuery.Name = "cmdQuery";
            this.cmdQuery.Size = new System.Drawing.Size(158, 32);
            this.cmdQuery.TabIndex = 0;
            this.cmdQuery.Text = "Query Tickets";
            this.cmdQuery.UseVisualStyleBackColor = true;
            this.cmdQuery.Click += new System.EventHandler(this.cmdQuery_ClickAsync);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(116, 40);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(158, 20);
            this.txtUser.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 181);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By User";
            // 
            // cmdUpdateStatus
            // 
            this.cmdUpdateStatus.Location = new System.Drawing.Point(676, 286);
            this.cmdUpdateStatus.Name = "cmdUpdateStatus";
            this.cmdUpdateStatus.Size = new System.Drawing.Size(225, 29);
            this.cmdUpdateStatus.TabIndex = 4;
            this.cmdUpdateStatus.Text = "Update Status";
            this.cmdUpdateStatus.UseVisualStyleBackColor = true;
            this.cmdUpdateStatus.Click += new System.EventHandler(this.cmdUpdateStatus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdOpenPrj
            // 
            this.cmdOpenPrj.Location = new System.Drawing.Point(369, 283);
            this.cmdOpenPrj.Name = "cmdOpenPrj";
            this.cmdOpenPrj.Size = new System.Drawing.Size(195, 32);
            this.cmdOpenPrj.TabIndex = 6;
            this.cmdOpenPrj.Text = "Open Project";
            this.cmdOpenPrj.UseVisualStyleBackColor = true;
            this.cmdOpenPrj.Click += new System.EventHandler(this.cmdOpenPrj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 381);
            this.Controls.Add(this.cmdOpenPrj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdUpdateStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cmdQuery);
            this.Name = "Form1";
            this.Text = "Test JIRA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdQuery;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdUpdateStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdOpenPrj;
    }
}

