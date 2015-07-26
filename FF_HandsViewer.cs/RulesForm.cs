using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindSense.cs
{
	public partial class RulesForm : Form
	{
		private void setupRulesDataGridView()
		{
			// Allow adding and deleting only programmatically
			this.rulesDataGridView.AllowUserToAddRows = false;
            this.rulesDataGridView.AllowUserToDeleteRows = false;

            // Gesture column setup
			DataGridViewTextBoxColumn gestureColumn = new DataGridViewTextBoxColumn();
			gestureColumn.HeaderText = "Gesture";
            gestureColumn.ReadOnly = true;
			this.rulesDataGridView.Columns.Add(gestureColumn);

			// Key column setup
			DataGridViewButtonColumn keyColumn = new DataGridViewButtonColumn();
			keyColumn.HeaderText = "Key";
			this.rulesDataGridView.Columns.Add(keyColumn);
		}

		public RulesForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.setupRulesDataGridView();

			// Load rules from file
			foreach (KeyValuePair<string, string> rule in Rules.Read())
			{
				this.rulesDataGridView.Rows.Add(rule.Key, rule.Value);
			}
		}

        private void rulesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                this.Enabled = false;
                KeyPressForm keyPressForm = new KeyPressForm();
                keyPressForm.Show();
                keyPressForm.FormClosed += ((_sender, _e) => {
                    senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = keyPressForm.Key;
                    this.Enabled = true;
                });
            }
        }

		private void applyChangesLabel_Click(object sender, EventArgs e)
		{
			// Update rules
            Rules.Clear();
            
			foreach (DataGridViewRow rule in this.rulesDataGridView.Rows)
			{
                if (rule.Cells[1].Value != null)
				{
                    Rules.SetGesture(
                        rule.Cells[0].Value.ToString(),
                        rule.Cells[1].Value.ToString()
                    );
				}
			}

			// And save to file
			Rules.Write();
		}

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}