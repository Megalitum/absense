namespace BindSense.cs
{
    partial class KeyPressForm
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
            this.pressKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pressKeyLabel
            // 
            this.pressKeyLabel.AutoSize = true;
            this.pressKeyLabel.Location = new System.Drawing.Point(60, 57);
            this.pressKeyLabel.Name = "pressKeyLabel";
            this.pressKeyLabel.Size = new System.Drawing.Size(440, 25);
            this.pressKeyLabel.TabIndex = 0;
            this.pressKeyLabel.Text = "Press key you want bind to gesture specified";
            // 
            // KeyPressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 137);
            this.Controls.Add(this.pressKeyLabel);
            this.Name = "KeyPressForm";
            this.Text = "Bind Sense";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pressKeyLabel;
    }
}