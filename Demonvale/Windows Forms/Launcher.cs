using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Demonvale.Windows_Forms
{
    public partial class Launcher : Form
    {
        static RegistryKey reg = Registry.CurrentUser.CreateSubKey("Demonvale");
        public Launcher()
        {
            InitializeComponent();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            reg.SetValue("lastMenuOption", 0);
            Application.Exit();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            reg.SetValue("lastMenuOption", 1);
            Application.Exit();
        }
    }
}
