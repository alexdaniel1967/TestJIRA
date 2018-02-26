namespace TestJIRA
{
    partial class SelectTicketSource
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
            this.cmdSelect = new System.Windows.Forms.Button();
            this.rbJira = new System.Windows.Forms.RadioButton();
            this.rbServiceNow = new System.Windows.Forms.RadioButton();
            this.rbTFS = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ticket Source";
            // 
            // cmdSelect
            // 
            this.cmdSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelect.Location = new System.Drawing.Point(65, 154);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(124, 29);
            this.cmdSelect.TabIndex = 4;
            this.cmdSelect.Text = "Select";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // rbJira
            // 
            this.rbJira.AutoSize = true;
            this.rbJira.Location = new System.Drawing.Point(65, 65);
            this.rbJira.Name = "rbJira";
            this.rbJira.Size = new System.Drawing.Size(41, 17);
            this.rbJira.TabIndex = 5;
            this.rbJira.TabStop = true;
            this.rbJira.Text = "Jira";
            this.rbJira.UseVisualStyleBackColor = true;
            // 
            // rbServiceNow
            // 
            this.rbServiceNow.AutoSize = true;
            this.rbServiceNow.Location = new System.Drawing.Point(65, 89);
            this.rbServiceNow.Name = "rbServiceNow";
            this.rbServiceNow.Size = new System.Drawing.Size(83, 17);
            this.rbServiceNow.TabIndex = 6;
            this.rbServiceNow.TabStop = true;
            this.rbServiceNow.Text = "ServiceNow";
            this.rbServiceNow.UseVisualStyleBackColor = true;
            // 
            // rbTFS
            // 
            this.rbTFS.AutoSize = true;
            this.rbTFS.Location = new System.Drawing.Point(65, 113);
            this.rbTFS.Name = "rbTFS";
            this.rbTFS.Size = new System.Drawing.Size(45, 17);
            this.rbTFS.TabIndex = 7;
            this.rbTFS.TabStop = true;
            this.rbTFS.Text = "TFS";
            this.rbTFS.UseVisualStyleBackColor = true;
            // 
            // SelectTicketSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 221);
            this.Controls.Add(this.rbTFS);
            this.Controls.Add(this.rbServiceNow);
            this.Controls.Add(this.rbJira);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.label1);
            this.Name = "SelectTicketSource";
            this.Text = "Ticket Source";
            this.Load += new System.EventHandler(this.SelectTicketSource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.RadioButton rbJira;
        private System.Windows.Forms.RadioButton rbServiceNow;
        private System.Windows.Forms.RadioButton rbTFS;
    }
}

