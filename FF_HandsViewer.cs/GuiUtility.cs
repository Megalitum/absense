using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace BindSense.cs
{
	struct GuiUtility
	{
		public static void ShowError(string errorMessage)
		{
			MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static bool ShowConfirmation(string confirmMessage)
		{
			return MessageBox.Show(confirmMessage, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}

		public static void ShowInformation(string informationMessage)
		{
			MessageBox.Show(informationMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
