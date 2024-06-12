﻿// FreeMove -- Move directories without breaking shortcuts or installations 
//    Copyright(C) 2020  Luca De Martini

//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.

//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.

//    You should have received a copy of the GNU General Public License
//    along with this program.If not, see<http://www.gnu.org/licenses/>.

namespace FreeMove
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.button_BrowseFrom = new System.Windows.Forms.Button();
            this.button_BrowseTo = new System.Windows.Forms.Button();
            this.textBox_To = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_Move = new System.Windows.Forms.Button();
            this.chkBox_originalHidden = new System.Windows.Forms.CheckBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOnProgramStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PermissionCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkBox_createDest = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_From
            // 
            resources.ApplyResources(this.textBox_From, "textBox_From");
            this.textBox_From.Name = "textBox_From";
            // 
            // button_BrowseFrom
            // 
            resources.ApplyResources(this.button_BrowseFrom, "button_BrowseFrom");
            this.button_BrowseFrom.Name = "button_BrowseFrom";
            this.button_BrowseFrom.UseVisualStyleBackColor = true;
            this.button_BrowseFrom.Click += new System.EventHandler(this.Button_BrowseFrom_Click);
            // 
            // button_BrowseTo
            // 
            resources.ApplyResources(this.button_BrowseTo, "button_BrowseTo");
            this.button_BrowseTo.Name = "button_BrowseTo";
            this.button_BrowseTo.UseVisualStyleBackColor = true;
            this.button_BrowseTo.Click += new System.EventHandler(this.Button_BrowseTo_Click);
            // 
            // textBox_To
            // 
            resources.ApplyResources(this.textBox_To, "textBox_To");
            this.textBox_To.Name = "textBox_To";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // button_Move
            // 
            resources.ApplyResources(this.button_Move, "button_Move");
            this.button_Move.Name = "button_Move";
            this.button_Move.UseVisualStyleBackColor = true;
            this.button_Move.Click += new System.EventHandler(this.Button_Move_Click);
            // 
            // chkBox_originalHidden
            // 
            resources.ApplyResources(this.chkBox_originalHidden, "chkBox_originalHidden");
            this.chkBox_originalHidden.Name = "chkBox_originalHidden";
            this.chkBox_originalHidden.UseVisualStyleBackColor = true;
            // 
            // button_Close
            // 
            resources.ApplyResources(this.button_Close, "button_Close");
            this.button_Close.Name = "button_Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdateToolStripMenuItem,
            this.PermissionCheckToolStripMenuItem,
            this.safeModeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkNowToolStripMenuItem,
            this.checkOnProgramStartToolStripMenuItem});
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            resources.ApplyResources(this.checkForUpdateToolStripMenuItem, "checkForUpdateToolStripMenuItem");
            // 
            // checkNowToolStripMenuItem
            // 
            this.checkNowToolStripMenuItem.Name = "checkNowToolStripMenuItem";
            resources.ApplyResources(this.checkNowToolStripMenuItem, "checkNowToolStripMenuItem");
            this.checkNowToolStripMenuItem.Click += new System.EventHandler(this.CheckNowToolStripMenuItem_Click);
            // 
            // checkOnProgramStartToolStripMenuItem
            // 
            this.checkOnProgramStartToolStripMenuItem.Name = "checkOnProgramStartToolStripMenuItem";
            resources.ApplyResources(this.checkOnProgramStartToolStripMenuItem, "checkOnProgramStartToolStripMenuItem");
            this.checkOnProgramStartToolStripMenuItem.Click += new System.EventHandler(this.CheckOnProgramStartToolStripMenuItem_Click);
            // 
            // PermissionCheckToolStripMenuItem
            // 
            this.PermissionCheckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.fastToolStripMenuItem,
            this.fullToolStripMenuItem});
            this.PermissionCheckToolStripMenuItem.Name = "PermissionCheckToolStripMenuItem";
            resources.ApplyResources(this.PermissionCheckToolStripMenuItem, "PermissionCheckToolStripMenuItem");
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            resources.ApplyResources(this.noneToolStripMenuItem, "noneToolStripMenuItem");
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.NoneToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Checked = true;
            this.fastToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            resources.ApplyResources(this.fastToolStripMenuItem, "fastToolStripMenuItem");
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.FastToolStripMenuItem_Click);
            // 
            // fullToolStripMenuItem
            // 
            this.fullToolStripMenuItem.Name = "fullToolStripMenuItem";
            resources.ApplyResources(this.fullToolStripMenuItem, "fullToolStripMenuItem");
            this.fullToolStripMenuItem.Click += new System.EventHandler(this.FullToolStripMenuItem_Click);
            // 
            // safeModeToolStripMenuItem
            // 
            this.safeModeToolStripMenuItem.Checked = true;
            this.safeModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.safeModeToolStripMenuItem.Name = "safeModeToolStripMenuItem";
            resources.ApplyResources(this.safeModeToolStripMenuItem, "safeModeToolStripMenuItem");
            this.safeModeToolStripMenuItem.Click += new System.EventHandler(this.SafeModeToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAnIssueToolStripMenuItem,
            this.gitHubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            // 
            // reportAnIssueToolStripMenuItem
            // 
            this.reportAnIssueToolStripMenuItem.Name = "reportAnIssueToolStripMenuItem";
            resources.ApplyResources(this.reportAnIssueToolStripMenuItem, "reportAnIssueToolStripMenuItem");
            this.reportAnIssueToolStripMenuItem.Click += new System.EventHandler(this.ReportAnIssueToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            resources.ApplyResources(this.gitHubToolStripMenuItem, "gitHubToolStripMenuItem");
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.GitHubToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // chkBox_createDest
            // 
            resources.ApplyResources(this.chkBox_createDest, "chkBox_createDest");
            this.chkBox_createDest.Checked = true;
            this.chkBox_createDest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_createDest.Name = "chkBox_createDest";
            this.chkBox_createDest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBox_createDest);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.chkBox_originalHidden);
            this.Controls.Add(this.button_Move);
            this.Controls.Add(this.button_BrowseTo);
            this.Controls.Add(this.textBox_To);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_BrowseFrom);
            this.Controls.Add(this.textBox_From);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_From;
        private System.Windows.Forms.Button button_BrowseFrom;
        private System.Windows.Forms.Button button_BrowseTo;
        private System.Windows.Forms.TextBox textBox_To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_Move;
        private System.Windows.Forms.CheckBox chkBox_originalHidden;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAnIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOnProgramStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PermissionCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem;
        public System.Windows.Forms.CheckBox chkBox_createDest;
    }
}

