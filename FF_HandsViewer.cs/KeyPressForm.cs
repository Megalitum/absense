using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BindSense.cs
{
    public partial class KeyPressForm : Form
    {
        public string Key { get; set; }
        public KeyPressForm()
        {
            InitializeComponent();
        }

        private void KeyPressForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key = e.KeyChar.ToString();
            this.Close();
        }
    }
}
