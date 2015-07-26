namespace BindSense.cs
{
	partial class RulesForm
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
            this.applyChangesLabel = new System.Windows.Forms.Button();
            this.rulesDataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // applyChangesLabel
            // 
            this.applyChangesLabel.Location = new System.Drawing.Point(24, 697);
            this.applyChangesLabel.Margin = new System.Windows.Forms.Padding(6);
            this.applyChangesLabel.Name = "applyChangesLabel";
            this.applyChangesLabel.Size = new System.Drawing.Size(226, 62);
            this.applyChangesLabel.TabIndex = 6;
            this.applyChangesLabel.Text = "apply changes";
            this.applyChangesLabel.UseVisualStyleBackColor = true;
            this.applyChangesLabel.Click += new System.EventHandler(this.applyChangesLabel_Click);
            // 
            // rulesDataGridView
            // 
            this.rulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesDataGridView.Location = new System.Drawing.Point(24, 23);
            this.rulesDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.rulesDataGridView.Name = "rulesDataGridView";
            this.rulesDataGridView.Size = new System.Drawing.Size(491, 653);
            this.rulesDataGridView.TabIndex = 7;
            this.rulesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rulesDataGridView_CellContentClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(298, 697);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(217, 62);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 777);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rulesDataGridView);
            this.Controls.Add(this.applyChangesLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RulesForm";
            this.Text = "Bind Sense";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Button applyChangesLabel;
        private System.Windows.Forms.DataGridView rulesDataGridView;
        private System.Windows.Forms.Button exitButton;
	}
}

