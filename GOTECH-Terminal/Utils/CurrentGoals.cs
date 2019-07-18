using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Utils
{
    public partial class CurrentGoals : UserControl
    {
        private string _goal = "Name";

        private bool Completed = false;

        private bool _CheckEnabled = true;

        public string GoalName
        {
            get
            {
                return _goal;
            }
            set
            {
                _goal = value;
                labelGoalName.Text = value;
            }
        }

        public bool CheckEnabled
        {
            get
            {
                return _CheckEnabled;
            }
            set
            {
                _CheckEnabled = value;
                Checkbox.Enabled = value;
            }
        }

        public bool Checked
        {
           get
            {
                return Completed;
            }
            set
            {
                Completed = value;
                Checkbox.Checked = value;
            }
        }

        public CurrentGoals()
        {
            InitializeComponent();
        }

        private void Checkbox_OnChange(object sender, EventArgs e)
        {
            Checked = Checkbox.Checked;
        }

    }
}
