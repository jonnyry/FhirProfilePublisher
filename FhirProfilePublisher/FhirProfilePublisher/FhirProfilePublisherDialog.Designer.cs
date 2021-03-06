﻿namespace FhirProfilePublisher
{
    partial class FhirProfilePublisherDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FhirProfilePublisherDialog));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.cbOpenBrowser = new System.Windows.Forms.CheckBox();
            this.tbBrowseOutputPath = new System.Windows.Forms.Button();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.tbGenerate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tbFileList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClearFileList = new System.Windows.Forms.Button();
            this.tbBrowseForFiles = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTemplateHtml = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPageTitlePrefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFootingText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHeadingText = new System.Windows.Forms.TextBox();
            this.tbIndexPageHtml = new System.Windows.Forms.TextBox();
            this.pnlBottom.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.cbOpenBrowser);
            this.pnlBottom.Controls.Add(this.tbBrowseOutputPath);
            this.pnlBottom.Controls.Add(this.tbOutputPath);
            this.pnlBottom.Controls.Add(this.lblOutputPath);
            this.pnlBottom.Controls.Add(this.tbGenerate);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 669);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(20, 10, 20, 0);
            this.pnlBottom.Size = new System.Drawing.Size(1047, 108);
            this.pnlBottom.TabIndex = 2;
            // 
            // cbOpenBrowser
            // 
            this.cbOpenBrowser.AutoSize = true;
            this.cbOpenBrowser.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOpenBrowser.Checked = true;
            this.cbOpenBrowser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOpenBrowser.Location = new System.Drawing.Point(603, 78);
            this.cbOpenBrowser.Name = "cbOpenBrowser";
            this.cbOpenBrowser.Size = new System.Drawing.Size(568, 50);
            this.cbOpenBrowser.TabIndex = 4;
            this.cbOpenBrowser.Text = "Open generated HTML in browser";
            this.cbOpenBrowser.UseVisualStyleBackColor = true;
            // 
            // tbBrowseOutputPath
            // 
            this.tbBrowseOutputPath.Location = new System.Drawing.Point(738, 37);
            this.tbBrowseOutputPath.Name = "tbBrowseOutputPath";
            this.tbBrowseOutputPath.Size = new System.Drawing.Size(102, 28);
            this.tbBrowseOutputPath.TabIndex = 3;
            this.tbBrowseOutputPath.Text = "Choose...";
            this.tbBrowseOutputPath.UseVisualStyleBackColor = true;
            this.tbBrowseOutputPath.Click += new System.EventHandler(this.tbBrowseOutputPath_Click);
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputPath.BackColor = System.Drawing.Color.White;
            this.tbOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOutputPath.Location = new System.Drawing.Point(24, 39);
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.ReadOnly = true;
            this.tbOutputPath.Size = new System.Drawing.Size(708, 52);
            this.tbOutputPath.TabIndex = 2;
            this.tbOutputPath.Text = "C:\\Users\\jonny\\Desktop";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.AutoSize = true;
            this.lblOutputPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOutputPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputPath.Location = new System.Drawing.Point(20, 10);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblOutputPath.Size = new System.Drawing.Size(216, 56);
            this.lblOutputPath.TabIndex = 1;
            this.lblOutputPath.Text = "Output path";
            // 
            // tbGenerate
            // 
            this.tbGenerate.Location = new System.Drawing.Point(900, 56);
            this.tbGenerate.Name = "tbGenerate";
            this.tbGenerate.Size = new System.Drawing.Size(127, 40);
            this.tbGenerate.TabIndex = 0;
            this.tbGenerate.Text = "Generate HTML";
            this.tbGenerate.UseVisualStyleBackColor = true;
            this.tbGenerate.Click += new System.EventHandler(this.tbGenerate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 669);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlCenter);
            this.tabPage1.Controls.Add(this.pnlTop);
            this.tabPage1.Location = new System.Drawing.Point(10, 62);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tbFileList);
            this.pnlCenter.Controls.Add(this.label2);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(3, 86);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.pnlCenter.Size = new System.Drawing.Size(1021, 508);
            this.pnlCenter.TabIndex = 5;
            // 
            // tbFileList
            // 
            this.tbFileList.AllowDrop = true;
            this.tbFileList.BackColor = System.Drawing.Color.White;
            this.tbFileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFileList.Location = new System.Drawing.Point(20, 56);
            this.tbFileList.Multiline = true;
            this.tbFileList.Name = "tbFileList";
            this.tbFileList.ReadOnly = true;
            this.tbFileList.Size = new System.Drawing.Size(981, 432);
            this.tbFileList.TabIndex = 7;
            this.tbFileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFileList_DragDrop);
            this.tbFileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbFileList_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Size = new System.Drawing.Size(224, 56);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input file list";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.tbClearFileList);
            this.pnlTop.Controls.Add(this.tbBrowseForFiles);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1021, 83);
            this.pnlTop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(977, 92);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note 1 - Files must contain StructureDefinition or ValueSet XML.\r\nNote 2 - The fi" +
    "le list box below supports drag and drop of files.";
            // 
            // tbClearFileList
            // 
            this.tbClearFileList.Location = new System.Drawing.Point(153, 27);
            this.tbClearFileList.Name = "tbClearFileList";
            this.tbClearFileList.Size = new System.Drawing.Size(127, 40);
            this.tbClearFileList.TabIndex = 4;
            this.tbClearFileList.Text = "Clear list";
            this.tbClearFileList.UseVisualStyleBackColor = true;
            this.tbClearFileList.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // tbBrowseForFiles
            // 
            this.tbBrowseForFiles.Location = new System.Drawing.Point(20, 27);
            this.tbBrowseForFiles.Name = "tbBrowseForFiles";
            this.tbBrowseForFiles.Size = new System.Drawing.Size(127, 40);
            this.tbBrowseForFiles.TabIndex = 3;
            this.tbBrowseForFiles.Text = "Browse for files...";
            this.tbBrowseForFiles.UseVisualStyleBackColor = true;
            this.tbBrowseForFiles.Click += new System.EventHandler(this.tbBrowse_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(10, 62);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1027, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Template HTML";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTemplateHtml);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1021, 591);
            this.panel1.TabIndex = 7;
            // 
            // tbTemplateHtml
            // 
            this.tbTemplateHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTemplateHtml.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemplateHtml.Location = new System.Drawing.Point(5, 149);
            this.tbTemplateHtml.Multiline = true;
            this.tbTemplateHtml.Name = "tbTemplateHtml";
            this.tbTemplateHtml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTemplateHtml.Size = new System.Drawing.Size(1011, 437);
            this.tbTemplateHtml.TabIndex = 3;
            this.tbTemplateHtml.Text = resources.GetString("tbTemplateHtml.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 144);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 322);
            this.label7.TabIndex = 0;
            this.label7.Text = "Variables available:\r\n\r\n%TITLE%\r\n%PAGE_HEADER%\r\n%CONTENT%\r\n%VERSION%\r\n%DATE_GENER" +
    "ATED%";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbPageTitlePrefix);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbFootingText);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbHeadingText);
            this.tabPage2.Controls.Add(this.tbIndexPageHtml);
            this.tabPage2.Location = new System.Drawing.Point(10, 62);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1027, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Index page content";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 46);
            this.label6.TabIndex = 7;
            this.label6.Text = "Page title suffix";
            // 
            // tbPageTitlePrefix
            // 
            this.tbPageTitlePrefix.Location = new System.Drawing.Point(156, 46);
            this.tbPageTitlePrefix.Name = "tbPageTitlePrefix";
            this.tbPageTitlePrefix.Size = new System.Drawing.Size(763, 52);
            this.tbPageTitlePrefix.TabIndex = 6;
            this.tbPageTitlePrefix.Text = " - Endeavour FHIR Implementation Guide";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 46);
            this.label5.TabIndex = 5;
            this.label5.Text = "Index page HTML";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "Footing text";
            // 
            // tbFootingText
            // 
            this.tbFootingText.Enabled = false;
            this.tbFootingText.Location = new System.Drawing.Point(156, 77);
            this.tbFootingText.Name = "tbFootingText";
            this.tbFootingText.Size = new System.Drawing.Size(763, 52);
            this.tbFootingText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heading text";
            // 
            // tbHeadingText
            // 
            this.tbHeadingText.Location = new System.Drawing.Point(156, 15);
            this.tbHeadingText.Name = "tbHeadingText";
            this.tbHeadingText.Size = new System.Drawing.Size(763, 52);
            this.tbHeadingText.TabIndex = 1;
            this.tbHeadingText.Text = "FHIR Implementation Guide (Draft)";
            // 
            // tbIndexPageHtml
            // 
            this.tbIndexPageHtml.Location = new System.Drawing.Point(32, 139);
            this.tbIndexPageHtml.Multiline = true;
            this.tbIndexPageHtml.Name = "tbIndexPageHtml";
            this.tbIndexPageHtml.Size = new System.Drawing.Size(887, 355);
            this.tbIndexPageHtml.TabIndex = 0;
            this.tbIndexPageHtml.Text = resources.GetString("tbIndexPageHtml.Text");
            // 
            // FhirProfilePublisherDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 777);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "FhirProfilePublisherDialog";
            this.Text = "FHIR Profile Publisher";
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button tbGenerate;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.TextBox tbOutputPath;
        private System.Windows.Forms.Button tbBrowseOutputPath;
        private System.Windows.Forms.CheckBox cbOpenBrowser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.TextBox tbFileList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbClearFileList;
        private System.Windows.Forms.Button tbBrowseForFiles;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbIndexPageHtml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFootingText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHeadingText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPageTitlePrefix;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTemplateHtml;
    }
}

