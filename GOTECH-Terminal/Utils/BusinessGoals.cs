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
    public partial class BusinessGoals : UserControl
    {
        private string _GoalID = "Goal {#}";

        private string _GoalsName = "Goal Name";

        private string _startendDate = "Start-End";

        public string GoalId
        {
            get
            {
                return _GoalID;
            }
            set
            {
                _GoalID = value;
                labelGoalNo.Text = value;
            }
        }

        public string StartEndDate
        {
            get
            {
                return _startendDate;
            }
            set
            {
                _startendDate = value;
                labelStartendDate.Text = value;
            }
        }

        public string GoalName
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

        public BusinessGoals()
        {
            InitializeComponent();
        }
    }
}
