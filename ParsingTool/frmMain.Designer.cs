namespace ParsingTool
{
    partial class frmMain
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openShowFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnInterface = new System.Windows.Forms.Button();
            this.grpBoxView = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusParsingProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuFile.SuspendLayout();
            this.grpBoxView.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(652, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.openToolStripMenuItem.Text = "Open ...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openShowFileDialog
            // 
            this.openShowFileDialog.Filter = "Text files (*.txt)|*.txt";
            this.openShowFileDialog.Title = "Select the file to parse ";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(60, 146);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(130, 23);
            this.btnParse.TabIndex = 1;
            this.btnParse.Text = "Parse File";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnInterface
            // 
            this.btnInterface.Location = new System.Drawing.Point(104, 38);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(214, 23);
            this.btnInterface.TabIndex = 3;
            this.btnInterface.Text = "View Interface Values";
            this.btnInterface.UseVisualStyleBackColor = true;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // grpBoxView
            // 
            this.grpBoxView.Controls.Add(this.btnInterface);
            this.grpBoxView.Location = new System.Drawing.Point(233, 108);
            this.grpBoxView.Name = "grpBoxView";
            this.grpBoxView.Size = new System.Drawing.Size(362, 100);
            this.grpBoxView.TabIndex = 4;
            this.grpBoxView.TabStop = false;
            this.grpBoxView.Text = "View";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusParsingProgress});
            this.statusStrip.Location = new System.Drawing.Point(0, 298);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(652, 22);
            this.statusStrip.TabIndex = 5;
            // 
            // statusParsingProgress
            // 
            this.statusParsingProgress.Name = "statusParsingProgress";
            this.statusParsingProgress.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 320);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpBoxView);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parsing Tool";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.grpBoxView.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openShowFileDialog;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.GroupBox grpBoxView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusParsingProgress;
    }
}

