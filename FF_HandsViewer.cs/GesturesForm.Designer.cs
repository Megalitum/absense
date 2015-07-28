namespace BindSense.cs
{
	partial class GesturesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GesturesForm));
			this.bindsDataGridView = new System.Windows.Forms.DataGridView();
			this.availableApplicationsComboBox = new System.Windows.Forms.ComboBox();
			this.availableProcessesLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.savePresetButton = new System.Windows.Forms.Button();
			this.applyPresetButton = new System.Windows.Forms.Button();
			this.savePresetTextBox = new System.Windows.Forms.TextBox();
			this.presetComboBox = new System.Windows.Forms.ComboBox();
			this.choosePresetLabel = new System.Windows.Forms.Label();
			this.deletePresetButton = new System.Windows.Forms.Button();
			this.stopEventSourceButton = new System.Windows.Forms.Button();
			this.startEventSourceButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.saveChangesButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.bindsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// bindsDataGridView
			// 
			this.bindsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bindsDataGridView.Location = new System.Drawing.Point(12, 12);
			this.bindsDataGridView.Name = "bindsDataGridView";
			this.bindsDataGridView.Size = new System.Drawing.Size(311, 366);
			this.bindsDataGridView.TabIndex = 8;
			this.bindsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.bindsDataGridView_CellValueChanged);
			// 
			// availableApplicationsComboBox
			// 
			this.availableApplicationsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.availableApplicationsComboBox.FormattingEnabled = true;
			this.availableApplicationsComboBox.Location = new System.Drawing.Point(329, 27);
			this.availableApplicationsComboBox.Name = "availableApplicationsComboBox";
			this.availableApplicationsComboBox.Size = new System.Drawing.Size(186, 21);
			this.availableApplicationsComboBox.TabIndex = 10;
			this.availableApplicationsComboBox.TextChanged += new System.EventHandler(this.availableApplicationsComboBox_TextChanged);
			// 
			// availableProcessesLabel
			// 
			this.availableProcessesLabel.AutoSize = true;
			this.availableProcessesLabel.Location = new System.Drawing.Point(326, 11);
			this.availableProcessesLabel.Name = "availableProcessesLabel";
			this.availableProcessesLabel.Size = new System.Drawing.Size(109, 13);
			this.availableProcessesLabel.TabIndex = 11;
			this.availableProcessesLabel.Text = "Available applications";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(264, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 12;
			// 
			// savePresetButton
			// 
			this.savePresetButton.Location = new System.Drawing.Point(329, 249);
			this.savePresetButton.Name = "savePresetButton";
			this.savePresetButton.Size = new System.Drawing.Size(184, 32);
			this.savePresetButton.TabIndex = 13;
			this.savePresetButton.Text = "save preset";
			this.savePresetButton.UseVisualStyleBackColor = true;
			this.savePresetButton.Click += new System.EventHandler(this.savePresetButton_Click);
			// 
			// applyPresetButton
			// 
			this.applyPresetButton.Location = new System.Drawing.Point(329, 159);
			this.applyPresetButton.Name = "applyPresetButton";
			this.applyPresetButton.Size = new System.Drawing.Size(89, 32);
			this.applyPresetButton.TabIndex = 14;
			this.applyPresetButton.Text = "apply";
			this.applyPresetButton.UseVisualStyleBackColor = true;
			this.applyPresetButton.Click += new System.EventHandler(this.applyPresetButton_Click);
			// 
			// savePresetTextBox
			// 
			this.savePresetTextBox.Location = new System.Drawing.Point(330, 223);
			this.savePresetTextBox.Name = "savePresetTextBox";
			this.savePresetTextBox.Size = new System.Drawing.Size(183, 20);
			this.savePresetTextBox.TabIndex = 15;
			// 
			// presetComboBox
			// 
			this.presetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.presetComboBox.FormattingEnabled = true;
			this.presetComboBox.Location = new System.Drawing.Point(330, 132);
			this.presetComboBox.Name = "presetComboBox";
			this.presetComboBox.Size = new System.Drawing.Size(186, 21);
			this.presetComboBox.TabIndex = 16;
			// 
			// choosePresetLabel
			// 
			this.choosePresetLabel.AutoSize = true;
			this.choosePresetLabel.Location = new System.Drawing.Point(329, 116);
			this.choosePresetLabel.Name = "choosePresetLabel";
			this.choosePresetLabel.Size = new System.Drawing.Size(75, 13);
			this.choosePresetLabel.TabIndex = 17;
			this.choosePresetLabel.Text = "Choose preset";
			// 
			// deletePresetButton
			// 
			this.deletePresetButton.Location = new System.Drawing.Point(424, 159);
			this.deletePresetButton.Name = "deletePresetButton";
			this.deletePresetButton.Size = new System.Drawing.Size(92, 32);
			this.deletePresetButton.TabIndex = 18;
			this.deletePresetButton.Text = "delete";
			this.deletePresetButton.UseVisualStyleBackColor = true;
			this.deletePresetButton.Click += new System.EventHandler(this.deletePresetButton_Click);
			// 
			// stopEventSourceButton
			// 
			this.stopEventSourceButton.Location = new System.Drawing.Point(329, 346);
			this.stopEventSourceButton.Name = "stopEventSourceButton";
			this.stopEventSourceButton.Size = new System.Drawing.Size(184, 32);
			this.stopEventSourceButton.TabIndex = 19;
			this.stopEventSourceButton.Text = "stop event source";
			this.stopEventSourceButton.UseVisualStyleBackColor = true;
			this.stopEventSourceButton.Click += new System.EventHandler(this.stopEventSourceButton_Click);
			// 
			// startEventSourceButton
			// 
			this.startEventSourceButton.Location = new System.Drawing.Point(329, 308);
			this.startEventSourceButton.Name = "startEventSourceButton";
			this.startEventSourceButton.Size = new System.Drawing.Size(184, 32);
			this.startEventSourceButton.TabIndex = 20;
			this.startEventSourceButton.Text = "start event source";
			this.startEventSourceButton.UseVisualStyleBackColor = true;
			this.startEventSourceButton.Click += new System.EventHandler(this.startEventSourceButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(332, 57);
			this.label2.MaximumSize = new System.Drawing.Size(180, 2);
			this.label2.MinimumSize = new System.Drawing.Size(180, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 2);
			this.label2.TabIndex = 21;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(333, 204);
			this.label3.MaximumSize = new System.Drawing.Size(180, 2);
			this.label3.MinimumSize = new System.Drawing.Size(180, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 2);
			this.label3.TabIndex = 22;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(332, 294);
			this.label4.MaximumSize = new System.Drawing.Size(180, 2);
			this.label4.MinimumSize = new System.Drawing.Size(180, 2);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 2);
			this.label4.TabIndex = 23;
			this.label4.Text = "label4";
			// 
			// saveChangesButton
			// 
			this.saveChangesButton.Location = new System.Drawing.Point(330, 66);
			this.saveChangesButton.Name = "saveChangesButton";
			this.saveChangesButton.Size = new System.Drawing.Size(184, 32);
			this.saveChangesButton.TabIndex = 24;
			this.saveChangesButton.Text = "save changes";
			this.saveChangesButton.UseVisualStyleBackColor = true;
			this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(333, 107);
			this.label5.MaximumSize = new System.Drawing.Size(180, 2);
			this.label5.MinimumSize = new System.Drawing.Size(180, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(180, 2);
			this.label5.TabIndex = 25;
			this.label5.Text = "label5";
			// 
			// GesturesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 391);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.saveChangesButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.startEventSourceButton);
			this.Controls.Add(this.stopEventSourceButton);
			this.Controls.Add(this.deletePresetButton);
			this.Controls.Add(this.choosePresetLabel);
			this.Controls.Add(this.presetComboBox);
			this.Controls.Add(this.savePresetTextBox);
			this.Controls.Add(this.applyPresetButton);
			this.Controls.Add(this.savePresetButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.availableProcessesLabel);
			this.Controls.Add(this.availableApplicationsComboBox);
			this.Controls.Add(this.bindsDataGridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(540, 430);
			this.MinimumSize = new System.Drawing.Size(540, 430);
			this.Name = "GesturesForm";
			this.Text = "Bind Gestures";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GesturesForm_FormClosed);
			this.Load += new System.EventHandler(this.GesturesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindsDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView bindsDataGridView;
		private System.Windows.Forms.ComboBox availableApplicationsComboBox;
		private System.Windows.Forms.Label availableProcessesLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button savePresetButton;
		private System.Windows.Forms.Button applyPresetButton;
		private System.Windows.Forms.TextBox savePresetTextBox;
		private System.Windows.Forms.ComboBox presetComboBox;
		private System.Windows.Forms.Label choosePresetLabel;
		private System.Windows.Forms.Button deletePresetButton;
		private System.Windows.Forms.Button stopEventSourceButton;
		private System.Windows.Forms.Button startEventSourceButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button saveChangesButton;
		private System.Windows.Forms.Label label5;

	}
}