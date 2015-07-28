using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BindSense.cs
{
    public partial class MainForm : Form
    {
        //private Thread trackingThread;
        //private PXCMSession realSession = PXCMSession.CreateInstance();
        public MainForm()
        {
            InitializeComponent();

            // REMOVE THIS!!
            //testToolStripMenuItem_Click(this, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.trayIcon.Visible = true;
            //trackingThread = new Thread(() =>
            //{
            //    new GestureService(realSession, appMatcher).Run();
            //});
            //trackingThread.Start();
        }

        // Test toolstrip
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PXCMSession realSession = null;
            realSession = PXCMSession.CreateInstance();
            if (realSession != null)
            {
                // Optional steps to send feedback to Intel Corporation to understand how often each SDK sample is used.
                PXCMMetadata md = realSession.QueryInstance<PXCMMetadata>();
                if (md != null)
                {
                    string sample_name = "Hands Viewer CS";
                    md.AttachBuffer(1297303632, System.Text.Encoding.Unicode.GetBytes(sample_name));
                }

                this.contextMenuStrip.Enabled = false;
                TestForm testForm = new TestForm(realSession);
                testForm.Show();
                testForm.FormClosed += ((_sender, _e) =>
                {
                    this.contextMenuStrip.Enabled = true;
                    realSession.Dispose();

                    // REMOVE THIS!!!
                    //Application.Exit();
                });
            }
        }

		// Gestures toolstip
		private void gesturesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.contextMenuStrip.Enabled = false;
			GesturesForm gesturesForm = new GesturesForm();
			gesturesForm.Show();
			gesturesForm.FormClosed += ((_sender, _e) =>
			{
				this.contextMenuStrip.Enabled = true;
			});
		}

		// Exit toolstrip
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.trayIcon.Visible = false;
            Application.Exit();
        }
    }
}