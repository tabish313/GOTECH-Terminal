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
    public partial class PlanBox : UserControl
    {
        private string _text = "";

        private string[] _goals = null;

        private bool[] _completed = null;

        private string _date = "";

        public string GoalText
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                labelGoals.Text = value;
            }
        }

        public string DatePart
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                label1.Text = value;
            }
        }

        public string[] GoalsList
        {
            get
            {
                return _goals;
            }
            set
            {
                _goals = value;
                if (GoalsList != null)
                {
                    for (int i = 0; i <= GoalsList.Length - 1; i++)
                    {
                        CurrentGoals curg = new CurrentGoals();
                        curg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
                        
                        curg.CheckEnabled = false;
                        curg.GoalName = value[i].ToString();
                        curg.Dock = System.Windows.Forms.DockStyle.Top;
                        curg.Location = new System.Drawing.Point(3, 3);
                        curg.Name = string.Format("CurrentGoal{0}", i.ToString());
                        curg.Size = new System.Drawing.Size(308, 30);
                        curg.TabIndex = 0;

                        flowLayoutPanelGoals.Controls.Add(curg);
                    }
                }
            }
        }

        public bool[] Completed
        {
            get
            {
                return _completed;
            }
            set
            {
                _completed = value;

                if (value != null)
                {
                    for (int i = 0; i <= GoalsList.Length - 1; i++)
                    {
                        CurrentGoals curg = this.flowLayoutPanelGoals.Controls.Find(string.Format("CurrentGoal{0}", i.ToString()), true).FirstOrDefault() as CurrentGoals;
                        curg.Checked = value[i];
                    }
                }
            }
        }

        public PlanBox()
        {
            InitializeComponent();
            Goals();
        }

        private void Goals()
        {
           
        }
    }
}
