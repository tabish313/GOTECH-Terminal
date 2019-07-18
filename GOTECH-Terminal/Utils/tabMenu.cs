using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
using GOTECH.Home;
using GOTECH.Help;

namespace GOTECH.Utils
{
    public partial class tabMenu : UserControl
    {
        public tabMenu()
        {

            InitializeComponent();
            if (Program.IsDesignMode()) return;

            VSReactive<int>.Subscribe("menu", e => tabControl1.SelectedIndex = e);
        }

        private void MainTab_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("MainTab", int.Parse(((Control)sender).Tag.ToString()));
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UserSetting stng = new UserSetting();
            stng.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Import imp = new Import();
            imp.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export exp = new Export();
            exp.ShowDialog();
        }

    }
}
