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
	public partial class GesturesForm : Form
	{
		private BindableEntity gestures = new BindableEntity(
			events: new HashSet<string> {
				"click",
				"fist",
				"full_pinch",
				"swipe_down",
				"swipe_up",
				"swipe_left",
				"swipe_right",
				"tap",
				"thumb_up",
				"thumb_down",
				"two_fingers_pinch_open",
				"v_sign",
				"wave"
			},
			serializationFilepath: "gestures.dat"
		);

		// Just for demo
		private volatile bool started = false;
		private Thread demoThread;

		private void FillAvailableApps()
		{
			List<string> availableProcesses = WinApiUtility.AvailableAppNames();
			this.availableApplicationsComboBox.Items.AddRange(availableProcesses.ToArray());
		}

		private void PrepareBindsDataGridView()
		{
			// Allow adding, deleting only programmatically
			this.bindsDataGridView.AllowUserToAddRows = false;
			this.bindsDataGridView.AllowUserToDeleteRows = false;

			// But allow ordering and resizing
			this.bindsDataGridView.AllowUserToResizeColumns = true;
			this.bindsDataGridView.AllowUserToOrderColumns = true;

			// Gesture column setup
			DataGridViewTextBoxColumn gestureColumn = new DataGridViewTextBoxColumn();
			gestureColumn.Name = "gesture";
			gestureColumn.HeaderText = "Gesture";
			gestureColumn.ReadOnly = true;
			this.bindsDataGridView.Columns.Add(gestureColumn);

			// Key stroke column setup
			DataGridViewTextBoxColumn keyStrokeColumn = new DataGridViewTextBoxColumn();
			keyStrokeColumn.Name = "key stroke";
			keyStrokeColumn.HeaderText = "Key stroke";
			keyStrokeColumn.ReadOnly = false;
			this.bindsDataGridView.Columns.Add(keyStrokeColumn);
		}

		public GesturesForm()
		{
			InitializeComponent();
		}

		private void GesturesForm_Load(object sender, EventArgs e)
		{
			this.FillAvailableApps();
			this.PrepareBindsDataGridView();

			// Fill data grid view
			foreach (string gestureName in this.gestures.Events)
				this.bindsDataGridView.Rows.Add(gestureName, null);

			// Load data into entity
			this.gestures.Load();

			// Load presets if present
			this.presetComboBox.Items.AddRange(this.gestures.Presets.ToArray());

			// Disable stop button
			this.stopEventSourceButton.Enabled = false;
		}

		private void GesturesForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.gestures.Save();
			if (this.started)
				stopEventSourceButton_Click(this, null);
		}

		private void bindsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			// Update entity
			var row = this.bindsDataGridView.Rows[e.RowIndex];
			this.gestures.Bind(
				appName: this.availableApplicationsComboBox.Text,
				eventName: row.Cells["gesture"].Value.ToString(),
				keyStroke: row.Cells["key stroke"].Value.ToString()
			);
		}

		private void availableApplicationsComboBox_TextChanged(object sender, EventArgs e)
		{
			// Update data grid view
			string currentApp = this.availableApplicationsComboBox.Text;
			this.gestures.AddApp(currentApp);
			this.bindsDataGridView.Rows.Clear();
			foreach (KeyValuePair<string, string> kvp in this.gestures.EventsMap(currentApp))
				this.bindsDataGridView.Rows.Add(kvp.Key, kvp.Value);
		}

		private void applyPresetButton_Click(object sender, EventArgs e)
		{
			string presetName = this.presetComboBox.Text;
			if (string.IsNullOrEmpty(presetName))
			{
				GuiUtility.ShowError("Choose preset!");
				return;
			}

			string currentApp = this.availableApplicationsComboBox.Text;
			if (string.IsNullOrEmpty(presetName))
			{
				GuiUtility.ShowError("Choose app!");
				return;
			}

			// Update entity
			this.gestures.ApplyPreset(currentApp, presetName);

			// Update data grid view
			this.bindsDataGridView.Rows.Clear();
			foreach (KeyValuePair<string, string> kvp in this.gestures.EventsMapPreset(presetName))
				this.bindsDataGridView.Rows.Add(kvp.Key, kvp.Value);
		}

		private void deletePresetButton_Click(object sender, EventArgs e)
		{
			string presetName = this.presetComboBox.Text;
			if (string.IsNullOrEmpty(presetName))
			{
				GuiUtility.ShowError("Choose preset!");
				return;
			}

			this.gestures.RemovePreset(presetName);

			// Update preset list
			this.presetComboBox.Items.Clear();
			this.presetComboBox.Items.AddRange(this.gestures.Presets.ToArray());

			// Notify preset deleted
			GuiUtility.ShowInformation(string.Format("Successfully deleted preset '{0}'", presetName));
		}

		private void saveChangesButton_Click(object sender, EventArgs e)
		{
			this.gestures.Save();
			GuiUtility.ShowInformation("Successfully saved on disk");
		}

		private void savePresetButton_Click(object sender, EventArgs e)
		{
			// Check preset name has at least 1 non-space character
			string presetName = this.savePresetTextBox.Text.Trim();
			if (string.IsNullOrEmpty(presetName))
			{
				GuiUtility.ShowError("A preset name must contain a non-space character!");
				this.savePresetTextBox.Clear();
				return;
			}
			
			// Ask whether to override preset if present
			if (
				!this.gestures.Presets.Contains(presetName) ||
				GuiUtility.ShowConfirmation(string.Format("Override preset '{0}' ?", presetName)))
			{
				string currentApp = this.availableApplicationsComboBox.Text;
				this.gestures.AddPreset(
					presetName, 
					this.gestures.EventsMap(currentApp).ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
				);
			}

			// Update preset list
			this.presetComboBox.Items.Clear();
			this.presetComboBox.Items.AddRange(this.gestures.Presets.ToArray());

			// Clear textbox and notify preset added
			this.savePresetTextBox.Clear();
			GuiUtility.ShowInformation(string.Format("Successfully added/overriden preset '{0}'", presetName));
		}

		private void startEventSourceButton_Click(object sender, EventArgs e)
		{
			this.startEventSourceButton.Enabled = false;
			this.stopEventSourceButton.Enabled = true;

			// Raise "event" "swipe_up" every sec
			this.started = true;
			this.demoThread = new Thread(() => {
				while (this.started)
				{
					this.gestures.Raise("swipe_up");
					Thread.Sleep(1000);
				}
			});
			this.demoThread.Start();
			while (!this.demoThread.IsAlive);
			Thread.Sleep(0);
		}

		private void stopEventSourceButton_Click(object sender, EventArgs e)
		{
			this.started = false;
			this.demoThread.Join();
			this.startEventSourceButton.Enabled = true;
			this.stopEventSourceButton.Enabled = false;
		}
	}
}