using GOTECH.Data;
using GOTECH.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Business
{
    public partial class UpdateCurrentGoals : Form
    {
        private DbEntities db = new DbEntities();

        private BackgroundWorker bw;

        public UpdateCurrentGoals()
        {
            InitializeComponent();
        }

        private void CurrentGoalsSub()
        {
            var GoalsInfo = Lists.GoalsList.ToList();

            ArrayList GoalsArray = new ArrayList();
            ArrayList CheckArray = new ArrayList();

            foreach (var item in Lists.GoalsInfoList.Where(c => c.Goal_Id == FetchCurrentGoalId))
            {
                GoalsArray.Add(item.Info);
                CheckArray.Add(item.Completed);
            }

            for (int i = 0; i <= GoalsArray.Count - 1; i++)
            {
                CurrentGoals curg = new CurrentGoals();
                curg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
                curg.Checked = bool.Parse(CheckArray[i].ToString());
                if(!curg.Checked)
                {
                    curg.CheckEnabled = true;
                }
                curg.GoalName = GoalsArray[i].ToString();
                curg.Dock = System.Windows.Forms.DockStyle.Top;
                curg.Location = new System.Drawing.Point(3, 3);
                curg.Name = string.Format("CurrentGoal{0}", i.ToString());
                curg.Size = new System.Drawing.Size(308, 30);
                curg.TabIndex = 0;

                flowLayoutPanelCurrent.Controls.Add(curg);
            }
        }

        private int FetchCurrentGoalId
        {

            get
            {
                var currentDateTime = DateTime.Now;

                DateTime Starttemp = DateTime.Now;

                DateTime Endtemp = DateTime.Now;

                ArrayList GoalStartDateArray = new ArrayList();

                ArrayList GoalEndDateArray = new ArrayList();

                foreach (var item in Lists.GoalsList)
                {
                    GoalStartDateArray.Add(item.StartDate);
                    GoalEndDateArray.Add(item.EndDate);
                }

                for (int i = 0; i <= GoalStartDateArray.Count - 1; i++)
                {
                    DateTime GoalStartDateTime = DateTime.Parse(GoalStartDateArray[i].ToString());

                    DateTime GoalEndDateTime = DateTime.Parse(GoalEndDateArray[i].ToString());

                    if (GoalStartDateTime > currentDateTime || currentDateTime < GoalEndDateTime)
                    {
                        Starttemp = GoalStartDateTime;
                        Endtemp = GoalEndDateTime;
                        break;
                    }
                }

                int GoalId = Lists.GoalsList.Where(c => c.StartDate == Starttemp && c.EndDate == Endtemp).Select(c => c.ID).FirstOrDefault();

                return GoalId;
            }
        }

        private void UpdateCurrentGoals_Load(object sender, EventArgs e)
        {
            CurrentGoalsSub();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            if(!bw.IsBusy)
            {
                btnSave.Enabled = false;
                progress1.Visible = true;
                bw.RunWorkerAsync();
            }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var length = Lists.GoalsInfoList.Where(c => c.Goal_Id == FetchCurrentGoalId).ToList();


            ArrayList idArray = new ArrayList();

            foreach(var item in Lists.GoalsInfoList.Where(c=>c.Goal_Id==FetchCurrentGoalId))
            {
                idArray.Add(item.ID);
            }

            for (int i = 1; i <= length.Count; i++)
            {
                int id = int.Parse(idArray[i - 1].ToString());
                var upd = db.GoalsInfo.Where(c => c.Goal_Id == FetchCurrentGoalId && c.ID==id).FirstOrDefault();
                CurrentGoals curg = flowLayoutPanelCurrent.Controls.Find(string.Format("CurrentGoal{0}",(i-1).ToString()), true).FirstOrDefault() as CurrentGoals;
                upd.Completed = curg.Checked;

                db.Entry(upd).State = EntityState.Modified;
            }
            db.SaveChanges();

            DbEntities dbrefresh = new DbEntities();
            Lists.GoalsInfoList = db.GoalsInfo.ToList();
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSave.Enabled = true;
            progress1.Visible = false;
            this.Close();
        }

        
    }
}
