using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Business
{
    public partial class GoalPanel : UserControl
    {
        private string _GoalNo= "Goal {#}";

        private string _GoalsName = "Goal Name";


        public string GoalId
        {
            get
            {
                return _GoalNo;
            }
            set
            {
                _GoalNo = value;
                label1.Text = value;
            }
        }

        public string SubGoalName
        {
            get
            {
                return _GoalsName;
            }
            set
            {
                _GoalsName = value;
                labelGoalName.Text = value;
            }
        }

        public GoalPanel()
        {
            InitializeComponent();
        }
    }
}
