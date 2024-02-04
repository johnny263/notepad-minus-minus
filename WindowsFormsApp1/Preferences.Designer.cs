﻿namespace NotePadMinusMinus
{
	partial class Preferences
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
            OptionListBox = new System.Windows.Forms.ListBox();
            ColorSelect = new System.Windows.Forms.ColorDialog();
            SettingTabPanel = new System.Windows.Forms.Panel();
            discordrpcpanel = new System.Windows.Forms.Panel();
            showname = new System.Windows.Forms.CheckBox();
            enablerpc = new System.Windows.Forms.CheckBox();
            loadsetting = new System.Windows.Forms.Button();
            savesetting = new System.Windows.Forms.Button();
            Hint = new System.Windows.Forms.Label();
            SettingTabPanel.SuspendLayout();
            discordrpcpanel.SuspendLayout();
            SuspendLayout();
            // 
            // OptionListBox
            // 
            OptionListBox.FormattingEnabled = true;
            OptionListBox.ItemHeight = 19;
            OptionListBox.Items.AddRange(new object[] { "Settings", "Discord RPC", "Experimentals" });
            OptionListBox.Location = new System.Drawing.Point(12, 11);
            OptionListBox.Name = "OptionListBox";
            OptionListBox.Size = new System.Drawing.Size(151, 403);
            OptionListBox.TabIndex = 0;
            OptionListBox.SelectedIndexChanged += OnOptionListBoxChange;
            // 
            // SettingTabPanel
            // 
            SettingTabPanel.Controls.Add(discordrpcpanel);
            SettingTabPanel.Controls.Add(loadsetting);
            SettingTabPanel.Controls.Add(savesetting);
            SettingTabPanel.Location = new System.Drawing.Point(169, 14);
            SettingTabPanel.Name = "SettingTabPanel";
            SettingTabPanel.Size = new System.Drawing.Size(609, 400);
            SettingTabPanel.TabIndex = 3;
            SettingTabPanel.Visible = false;
            // 
            // discordrpcpanel
            // 
            discordrpcpanel.Controls.Add(showname);
            discordrpcpanel.Controls.Add(enablerpc);
            discordrpcpanel.Location = new System.Drawing.Point(0, 0);
            discordrpcpanel.Name = "discordrpcpanel";
            discordrpcpanel.Size = new System.Drawing.Size(609, 400);
            discordrpcpanel.TabIndex = 4;
            // 
            // showname
            // 
            showname.AutoSize = true;
            showname.Location = new System.Drawing.Point(18, 50);
            showname.Name = "showname";
            showname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            showname.Size = new System.Drawing.Size(144, 23);
            showname.TabIndex = 1;
            showname.Text = "Show File Name";
            showname.UseVisualStyleBackColor = true;
            // 
            // enablerpc
            // 
            enablerpc.AutoSize = true;
            enablerpc.Location = new System.Drawing.Point(18, 21);
            enablerpc.Name = "enablerpc";
            enablerpc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            enablerpc.Size = new System.Drawing.Size(77, 23);
            enablerpc.TabIndex = 0;
            enablerpc.Text = "Enable";
            enablerpc.UseVisualStyleBackColor = true;
            enablerpc.CheckedChanged += enablerpc_CheckedChanged;
            // 
            // loadsetting
            // 
            loadsetting.Location = new System.Drawing.Point(18, 61);
            loadsetting.Name = "loadsetting";
            loadsetting.Size = new System.Drawing.Size(118, 29);
            loadsetting.TabIndex = 1;
            loadsetting.Text = "Load Settings";
            loadsetting.UseVisualStyleBackColor = true;
            loadsetting.Click += loadsetting_Click;
            // 
            // savesetting
            // 
            savesetting.Location = new System.Drawing.Point(18, 15);
            savesetting.Name = "savesetting";
            savesetting.Size = new System.Drawing.Size(118, 29);
            savesetting.TabIndex = 0;
            savesetting.Text = "Save Settings";
            savesetting.UseVisualStyleBackColor = true;
            savesetting.Click += savesetting_Click;
            // 
            // Hint
            // 
            Hint.AutoSize = true;
            Hint.Location = new System.Drawing.Point(12, 422);
            Hint.Name = "Hint";
            Hint.Size = new System.Drawing.Size(51, 19);
            Hint.TabIndex = 2;
            Hint.Text = "label1";
            // 
            // Preferences
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Hint);
            Controls.Add(SettingTabPanel);
            Controls.Add(OptionListBox);
            Name = "Preferences";
            Text = "Preferences";
            SettingTabPanel.ResumeLayout(false);
            discordrpcpanel.ResumeLayout(false);
            discordrpcpanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox OptionListBox;
		private System.Windows.Forms.ColorDialog ColorSelect;
        private System.Windows.Forms.Panel SettingTabPanel;
        private System.Windows.Forms.Button loadsetting;
        private System.Windows.Forms.Button savesetting;
        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.Panel discordrpcpanel;
        private System.Windows.Forms.CheckBox showname;
        private System.Windows.Forms.CheckBox enablerpc;
    }
}