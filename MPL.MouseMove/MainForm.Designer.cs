﻿
namespace MPL.MouseMove
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartStopButton = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_Sep = new System.Windows.Forms.ToolStripSeparator();
            this.FileMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartStopButton
            // 
            this.StartStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartStopButton.Location = new System.Drawing.Point(101, 127);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 4;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ToolsMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(276, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip2";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu_Start,
            this.FileMenu_Stop,
            this.FileMenu_Sep,
            this.FileMenu_Exit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "&File";
            // 
            // FileMenu_Start
            // 
            this.FileMenu_Start.Name = "FileMenu_Start";
            this.FileMenu_Start.Size = new System.Drawing.Size(98, 22);
            this.FileMenu_Start.Text = "&Start";
            // 
            // FileMenu_Stop
            // 
            this.FileMenu_Stop.Name = "FileMenu_Stop";
            this.FileMenu_Stop.Size = new System.Drawing.Size(98, 22);
            this.FileMenu_Stop.Text = "S&top";
            // 
            // FileMenu_Sep
            // 
            this.FileMenu_Sep.Name = "FileMenu_Sep";
            this.FileMenu_Sep.Size = new System.Drawing.Size(95, 6);
            // 
            // FileMenu_Exit
            // 
            this.FileMenu_Exit.Name = "FileMenu_Exit";
            this.FileMenu_Exit.Size = new System.Drawing.Size(98, 22);
            this.FileMenu_Exit.Text = "E&xit";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsMenu_Options});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(48, 20);
            this.ToolsMenu.Text = "&Tools";
            // 
            // ToolsMenu_Options
            // 
            this.ToolsMenu_Options.Name = "ToolsMenu_Options";
            this.ToolsMenu_Options.Size = new System.Drawing.Size(125, 22);
            this.ToolsMenu_Options.Text = "&Options...";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 34);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(252, 37);
            this.Title.TabIndex = 1;
            this.Title.Text = "MouseMove";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Copyright
            // 
            this.Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Copyright.Location = new System.Drawing.Point(12, 101);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(252, 23);
            this.Copyright.TabIndex = 3;
            this.Copyright.Text = "Copyright (c) 2021 Martin Parkin";
            this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Link
            // 
            this.Link.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Link.Location = new System.Drawing.Point(12, 75);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(252, 26);
            this.Link.TabIndex = 2;
            this.Link.TabStop = true;
            this.Link.Text = "https://github/memiamap/MPL.MouseMove";
            this.Link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 162);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(292, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(292, 200);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MPL Mouse Move";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_Start;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_Stop;
        private System.Windows.Forms.ToolStripSeparator FileMenu_Sep;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu_Options;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.LinkLabel Link;
    }
}

