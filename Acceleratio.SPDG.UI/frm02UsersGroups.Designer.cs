﻿namespace Acceleratio.SPDG.UI
{
    partial class frm02UsersGroups
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
            this.ucSteps1 = new Acceleratio.SPDG.UI.ucSteps();
            this.chkGenerateUsers = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGroups = new System.Windows.Forms.Label();
            this.lblNumUsers = new System.Windows.Forms.Label();
            this.trackNumberOfSecGroups = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackNumberOfUsers = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOrganizationalUnit = new System.Windows.Forms.ComboBox();
            this.cboDomains = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackNumberOfSecGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackNumberOfUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // ucSteps1
            // 
            this.ucSteps1.Location = new System.Drawing.Point(0, 135);
            this.ucSteps1.Name = "ucSteps1";
            this.ucSteps1.Size = new System.Drawing.Size(235, 480);
            this.ucSteps1.TabIndex = 7;
            // 
            // chkGenerateUsers
            // 
            this.chkGenerateUsers.AutoSize = true;
            this.chkGenerateUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkGenerateUsers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chkGenerateUsers.Location = new System.Drawing.Point(268, 193);
            this.chkGenerateUsers.Name = "chkGenerateUsers";
            this.chkGenerateUsers.Size = new System.Drawing.Size(313, 19);
            this.chkGenerateUsers.TabIndex = 8;
            this.chkGenerateUsers.Text = "Generate Users and Security Groups in Active Directory";
            this.chkGenerateUsers.UseVisualStyleBackColor = true;
            this.chkGenerateUsers.CheckedChanged += new System.EventHandler(this.chkGenerateUsers_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGroups);
            this.groupBox1.Controls.Add(this.lblNumUsers);
            this.groupBox1.Controls.Add(this.trackNumberOfSecGroups);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackNumberOfUsers);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboOrganizationalUnit);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(268, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 314);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Location = new System.Drawing.Point(567, 228);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(13, 15);
            this.lblGroups.TabIndex = 7;
            this.lblGroups.Text = "0";
            // 
            // lblNumUsers
            // 
            this.lblNumUsers.AutoSize = true;
            this.lblNumUsers.Location = new System.Drawing.Point(567, 144);
            this.lblNumUsers.Name = "lblNumUsers";
            this.lblNumUsers.Size = new System.Drawing.Size(13, 15);
            this.lblNumUsers.TabIndex = 6;
            this.lblNumUsers.Text = "0";
            // 
            // trackNumberOfSecGroups
            // 
            this.trackNumberOfSecGroups.LargeChange = 1;
            this.trackNumberOfSecGroups.Location = new System.Drawing.Point(10, 225);
            this.trackNumberOfSecGroups.Maximum = 20;
            this.trackNumberOfSecGroups.Name = "trackNumberOfSecGroups";
            this.trackNumberOfSecGroups.Size = new System.Drawing.Size(546, 45);
            this.trackNumberOfSecGroups.TabIndex = 5;
            this.trackNumberOfSecGroups.ValueChanged += new System.EventHandler(this.trackNumberOfSecGroups_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Security Groups to create:";
            // 
            // trackNumberOfUsers
            // 
            this.trackNumberOfUsers.LargeChange = 1;
            this.trackNumberOfUsers.Location = new System.Drawing.Point(10, 141);
            this.trackNumberOfUsers.Maximum = 100;
            this.trackNumberOfUsers.Name = "trackNumberOfUsers";
            this.trackNumberOfUsers.Size = new System.Drawing.Size(546, 45);
            this.trackNumberOfUsers.TabIndex = 3;
            this.trackNumberOfUsers.ValueChanged += new System.EventHandler(this.trackNumberOfUsers_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of users to create:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Organizational Unit:";
            // 
            // cboOrganizationalUnit
            // 
            this.cboOrganizationalUnit.FormattingEnabled = true;
            this.cboOrganizationalUnit.Location = new System.Drawing.Point(18, 65);
            this.cboOrganizationalUnit.Name = "cboOrganizationalUnit";
            this.cboOrganizationalUnit.Size = new System.Drawing.Size(531, 23);
            this.cboOrganizationalUnit.TabIndex = 0;
            // 
            // cboDomains
            // 
            this.cboDomains.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboDomains.FormattingEnabled = true;
            this.cboDomains.Location = new System.Drawing.Point(580, 152);
            this.cboDomains.Name = "cboDomains";
            this.cboDomains.Size = new System.Drawing.Size(237, 23);
            this.cboDomains.TabIndex = 10;
            this.cboDomains.Leave += new System.EventHandler(this.cboDomains_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(265, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Use this domain to create SharePoint users and groups: ";
            // 
            // frm02UsersGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDomains);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkGenerateUsers);
            this.Controls.Add(this.ucSteps1);
            this.Name = "frm02UsersGroups";
            this.Text = "frm02UsersGroups";
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblDescription, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.ucSteps1, 0);
            this.Controls.SetChildIndex(this.chkGenerateUsers, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cboDomains, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackNumberOfSecGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackNumberOfUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucSteps ucSteps1;
        private System.Windows.Forms.CheckBox chkGenerateUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOrganizationalUnit;
        private System.Windows.Forms.TrackBar trackNumberOfSecGroups;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackNumberOfUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDomains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Label lblNumUsers;
    }
}