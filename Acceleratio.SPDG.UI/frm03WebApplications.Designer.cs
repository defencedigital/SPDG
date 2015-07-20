﻿namespace Acceleratio.SPDG.UI
{
    partial class frm03WebApplications
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
            this.radioCreateNewWebApp = new System.Windows.Forms.RadioButton();
            this.cboUseExistingWebApp = new System.Windows.Forms.ComboBox();
            this.radioUseExistingWebApp = new System.Windows.Forms.RadioButton();
            this.trackCreateNewWebApplication = new System.Windows.Forms.TrackBar();
            this.lblCreateNewApps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackCreateNewWebApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // ucSteps1
            // 
            this.ucSteps1.Location = new System.Drawing.Point(0, 103);
            this.ucSteps1.Name = "ucSteps1";
            this.ucSteps1.Size = new System.Drawing.Size(238, 368);
            this.ucSteps1.TabIndex = 7;
            // 
            // radioCreateNewWebApp
            // 
            this.radioCreateNewWebApp.AutoSize = true;
            this.radioCreateNewWebApp.Location = new System.Drawing.Point(265, 115);
            this.radioCreateNewWebApp.Name = "radioCreateNewWebApp";
            this.radioCreateNewWebApp.Size = new System.Drawing.Size(165, 17);
            this.radioCreateNewWebApp.TabIndex = 8;
            this.radioCreateNewWebApp.TabStop = true;
            this.radioCreateNewWebApp.Text = "Create new Web Applications";
            this.radioCreateNewWebApp.UseVisualStyleBackColor = true;
            this.radioCreateNewWebApp.CheckedChanged += new System.EventHandler(this.radioCreateNewWebApp_CheckedChanged);
            // 
            // cboUseExistingWebApp
            // 
            this.cboUseExistingWebApp.FormattingEnabled = true;
            this.cboUseExistingWebApp.Location = new System.Drawing.Point(265, 240);
            this.cboUseExistingWebApp.Name = "cboUseExistingWebApp";
            this.cboUseExistingWebApp.Size = new System.Drawing.Size(401, 21);
            this.cboUseExistingWebApp.TabIndex = 11;
            // 
            // radioUseExistingWebApp
            // 
            this.radioUseExistingWebApp.AutoSize = true;
            this.radioUseExistingWebApp.Location = new System.Drawing.Point(265, 215);
            this.radioUseExistingWebApp.Name = "radioUseExistingWebApp";
            this.radioUseExistingWebApp.Size = new System.Drawing.Size(83, 17);
            this.radioUseExistingWebApp.TabIndex = 9;
            this.radioUseExistingWebApp.TabStop = true;
            this.radioUseExistingWebApp.Text = "Use Existing";
            this.radioUseExistingWebApp.UseVisualStyleBackColor = true;
            this.radioUseExistingWebApp.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // trackCreateNewWebApplication
            // 
            this.trackCreateNewWebApplication.Location = new System.Drawing.Point(257, 140);
            this.trackCreateNewWebApplication.Name = "trackCreateNewWebApplication";
            this.trackCreateNewWebApplication.Size = new System.Drawing.Size(389, 45);
            this.trackCreateNewWebApplication.TabIndex = 10;
            this.trackCreateNewWebApplication.ValueChanged += new System.EventHandler(this.trackCreateNewWebApplication_ValueChanged);
            // 
            // lblCreateNewApps
            // 
            this.lblCreateNewApps.AutoSize = true;
            this.lblCreateNewApps.Location = new System.Drawing.Point(652, 144);
            this.lblCreateNewApps.Name = "lblCreateNewApps";
            this.lblCreateNewApps.Size = new System.Drawing.Size(13, 13);
            this.lblCreateNewApps.TabIndex = 12;
            this.lblCreateNewApps.Text = "0";
            // 
            // frm03WebApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.lblCreateNewApps);
            this.Controls.Add(this.trackCreateNewWebApplication);
            this.Controls.Add(this.cboUseExistingWebApp);
            this.Controls.Add(this.radioUseExistingWebApp);
            this.Controls.Add(this.radioCreateNewWebApp);
            this.Controls.Add(this.ucSteps1);
            this.Name = "frm03WebApplications";
            this.Text = "frm03WebApplications";
            this.Load += new System.EventHandler(this.frm03WebApplications_Load);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnHelp, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.ucSteps1, 0);
            this.Controls.SetChildIndex(this.radioCreateNewWebApp, 0);
            this.Controls.SetChildIndex(this.radioUseExistingWebApp, 0);
            this.Controls.SetChildIndex(this.cboUseExistingWebApp, 0);
            this.Controls.SetChildIndex(this.trackCreateNewWebApplication, 0);
            this.Controls.SetChildIndex(this.lblCreateNewApps, 0);
            ((System.ComponentModel.ISupportInitialize)(this.trackCreateNewWebApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucSteps ucSteps1;
        private System.Windows.Forms.RadioButton radioCreateNewWebApp;
        private System.Windows.Forms.ComboBox cboUseExistingWebApp;
        private System.Windows.Forms.RadioButton radioUseExistingWebApp;
        private System.Windows.Forms.TrackBar trackCreateNewWebApplication;
        private System.Windows.Forms.Label lblCreateNewApps;
    }
}