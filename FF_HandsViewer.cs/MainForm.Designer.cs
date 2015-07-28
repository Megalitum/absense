namespace BindSense.cs
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gesturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// trayIcon
			// 
			this.trayIcon.ContextMenuStrip = this.contextMenuStrip;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "trayIcon";
			this.trayIcon.Visible = true;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.gesturesToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.testToolStripMenuItem.Text = "Test";
			this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
			// 
			// gesturesToolStripMenuItem
			// 
			this.gesturesToolStripMenuItem.Name = "gesturesToolStripMenuItem";
			this.gesturesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.gesturesToolStripMenuItem.Text = "Gestures";
			this.gesturesToolStripMenuItem.Click += new System.EventHandler(this.gesturesToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 229);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Opacity = 0D;
			this.ShowInTaskbar = false;
			this.Text = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gesturesToolStripMenuItem;
    }
}