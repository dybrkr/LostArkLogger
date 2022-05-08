﻿namespace LostArkLogger
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.loggedPacketCountLabel = new System.Windows.Forms.Label();
            this.weblink = new System.Windows.Forms.LinkLabel();
            this.overlayEnabled = new System.Windows.Forms.CheckBox();
            this.logEnabled = new System.Windows.Forms.CheckBox();
            this.sniffModeLabel = new System.Windows.Forms.Label();
            this.debugLog = new System.Windows.Forms.CheckBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.checkUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loggedPacketCountLabel
            // 
            this.loggedPacketCountLabel.AutoSize = true;
            this.loggedPacketCountLabel.Location = new System.Drawing.Point(11, 9);
            this.loggedPacketCountLabel.Name = "loggedPacketCountLabel";
            this.loggedPacketCountLabel.Size = new System.Drawing.Size(100, 13);
            this.loggedPacketCountLabel.TabIndex = 2;
            this.loggedPacketCountLabel.Text = "Logged Packets : 0";
            // 
            // weblink
            // 
            this.weblink.AutoSize = true;
            this.weblink.Location = new System.Drawing.Point(152, 9);
            this.weblink.Name = "weblink";
            this.weblink.Size = new System.Drawing.Size(60, 13);
            this.weblink.TabIndex = 4;
            this.weblink.TabStop = true;
            this.weblink.Text = "by shalzuth";
            this.weblink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.weblink_LinkClicked);
            // 
            // overlayEnabled
            // 
            this.overlayEnabled.AutoSize = true;
            this.overlayEnabled.Checked = true;
            this.overlayEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overlayEnabled.Location = new System.Drawing.Point(12, 31);
            this.overlayEnabled.Name = "overlayEnabled";
            this.overlayEnabled.Size = new System.Drawing.Size(62, 17);
            this.overlayEnabled.TabIndex = 5;
            this.overlayEnabled.Text = "Overlay";
            this.overlayEnabled.UseVisualStyleBackColor = true;
            this.overlayEnabled.CheckedChanged += new System.EventHandler(this.overlayEnabled_CheckedChanged);
            // 
            // logEnabled
            // 
            this.logEnabled.AutoSize = true;
            this.logEnabled.Checked = true;
            this.logEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logEnabled.Location = new System.Drawing.Point(12, 55);
            this.logEnabled.Name = "logEnabled";
            this.logEnabled.Size = new System.Drawing.Size(44, 17);
            this.logEnabled.TabIndex = 6;
            this.logEnabled.Text = "Log";
            this.logEnabled.UseVisualStyleBackColor = true;
            this.logEnabled.CheckedChanged += new System.EventHandler(this.logEnabled_CheckedChanged);
            // 
            // sniffModeLabel
            // 
            this.sniffModeLabel.AutoSize = true;
            this.sniffModeLabel.Location = new System.Drawing.Point(149, 31);
            this.sniffModeLabel.Name = "sniffModeLabel";
            this.sniffModeLabel.Size = new System.Drawing.Size(61, 13);
            this.sniffModeLabel.TabIndex = 8;
            this.sniffModeLabel.Text = "rawsockets";
            this.sniffModeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // debugLog
            // 
            this.debugLog.AutoSize = true;
            this.debugLog.Location = new System.Drawing.Point(80, 31);
            this.debugLog.Name = "debugLog";
            this.debugLog.Size = new System.Drawing.Size(58, 17);
            this.debugLog.TabIndex = 9;
            this.debugLog.Text = "Debug";
            this.debugLog.UseVisualStyleBackColor = true;
            this.debugLog.CheckedChanged += new System.EventHandler(this.debugLog_CheckedChanged);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(166, 59);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(46, 13);
            this.versionLabel.TabIndex = 10;
            this.versionLabel.Text = "v1.0.0.0";
            // 
            // checkUpdate
            // 
            this.checkUpdate.Location = new System.Drawing.Point(62, 54);
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(98, 23);
            this.checkUpdate.TabIndex = 11;
            this.checkUpdate.Text = "Check Update";
            this.checkUpdate.UseVisualStyleBackColor = true;
            this.checkUpdate.Click += new System.EventHandler(this.checkUpdate_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 84);
            this.Controls.Add(this.checkUpdate);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.debugLog);
            this.Controls.Add(this.sniffModeLabel);
            this.Controls.Add(this.logEnabled);
            this.Controls.Add(this.overlayEnabled);
            this.Controls.Add(this.weblink);
            this.Controls.Add(this.loggedPacketCountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Lost Ark Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label loggedPacketCountLabel;
        private System.Windows.Forms.LinkLabel weblink;
        private System.Windows.Forms.CheckBox overlayEnabled;
        public System.Windows.Forms.CheckBox logEnabled;
        public System.Windows.Forms.Label sniffModeLabel;
        private System.Windows.Forms.CheckBox debugLog;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button checkUpdate;
    }
}

