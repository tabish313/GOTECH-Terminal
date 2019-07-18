using GOTECH.Data;
using GOTECH.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Business
{
    public partial class NewBusinessPlan : Form
    {
        private BackgroundWorker bw;

        public NewBusinessPlan()
        {
            InitializeComponent();
            this.txtStartDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void NewBusinessPlan_Load(object sender, EventArgs e)
        {
            bw = new BackgroundWorker();
            bw.DoWork+=bw_DoWork;
            bw.RunWorkerCompleted+=bw_RunWorkerCompleted;
            
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progress1.Visible = false;
            btnSave.Enabled = true;
            DialogResult result = MessageBox.Show("Set Up Business Plans successful! \r\nRestart this app to take effect!", "GO TECH Terminal", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            int ID = 1;
            BusinessPlans plan = new BusinessPlans();

            if (radioMonth.Checked)
            {
                plan.Duration = txtBusinessDuration.Text + " " + radioMonth.Text;
            }

            if (radioYears.Checked)
            {
                plan.Duration = txtBusinessDuration.Text + " " + radioYears.Text;
            }
            plan.StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None);
            plan.EndDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None);


            DbEntities db = new DbEntities();

            foreach (var item in BusinessLists.GoalsList)
            {
                Data.Goals gl = new Data.Goals();
                gl.Name = item.Name;
                gl.Duration = item.Duration;
                gl.Percentage = item.Percentage;
                gl.StartDate = DateTime.ParseExact(item.StartDate, "dd/MM/yyyy", enUS, DateTimeStyles.None);
                gl.EndDate = DateTime.ParseExact(item.EndDate, "dd/MM/yyyy", enUS, DateTimeStyles.None);

                string[] infos = item.Info.Split(',');

                for (int i = 0; i <= infos.Length - 1; i++)
                {
                    if (infos[i] != "")
                    {
                        Data.GoalsInfo info = new GoalsInfo();
                        info.Name = item.Name;
                        info.Goal_Id = ID;
                        info.Info = infos[i].ToString();
                        db.GoalsInfo.Add(info);
                    }
                }
                ID++;
                db.Goals.Add(gl);
            }
            db.BusinessPlans.Add(plan);
            db.SaveChanges();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BusinnesGoals()
        {
            var GoalsInfo = BusinessLists.GoalsList;

            ArrayList GoalsArray = new ArrayList();

            foreach (var item in GoalsInfo)
            {
                GoalsArray.Add(item.Name);
            }

            for (int i = 0; i <= GoalsArray.Count - 1; i++)
            {
                GoalPanel curg = new GoalPanel();
                curg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
                curg.SubGoalName = GoalsArray[i].ToString();
                curg.Location = new System.Drawing.Point(3, 3);
                curg.GoalId = "Goal " + (i + 1).ToString();
                curg.Name = string.Format("CurrentGoal{0}", i.ToString());
                curg.Size = new System.Drawing.Size(370, 30);
                curg.TabIndex = 0;

                flowLayoutPanel1.Controls.Add(curg);
            }
        }

        private void NewBusinessPlan_Activated(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (BusinessLists.GoalsList != null)
            {
                this.BusinnesGoals();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BusinessGoals gaol = new BusinessGoals();
            gaol.ShowDialog();
        }

        CultureInfo enUS = new CultureInfo("en-US");

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (IsFormValidated)
            {
                if (!bw.IsBusy)
                {
                    progress1.Visible = true;
                    btnSave.Enabled = false;
                    bw.RunWorkerAsync();
                }

            }
            else
            {
                MessageBox.Show("Error while saving business plans! Form is not Validated!", "Error - Go TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsFormValidated
        {
            get
            {
               
                DateTime startDateTime;
                DateTime EndDateTime;
                bool StartDateCheck = DateTime.TryParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None, out startDateTime);
                bool EndDateCheck = DateTime.TryParseExact(txtEndDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None, out EndDateTime);

                if (txtBusinessDuration.Text != "" && StartDateCheck && EndDateCheck && BusinessLists.GoalsList != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        int ou;
        private void txtBusinessDuration_OnValueChanged(object sender, EventArgs e)
        {
            
            if (!(int.TryParse(txtBusinessDuration.Text, out ou)))
            {
                txtBusinessDuration.Text = "";
            }
            else
            {
                if (radioMonth.Checked)
                {
                    txtEndDate.Text = DateTime.Now.AddMonths(ou).ToString("dd/MM/yyyy");
                }

                if (radioYears.Checked)
                {
                    txtEndDate.Text = DateTime.Now.AddYears(ou).ToString("dd/MM/yyyy");
                }
            }

            if(txtBusinessDuration.Text=="")
            {
                txtEndDate.Text = "";
            }
        }

        private void radioYears_CheckedChanged(object sender, EventArgs e)
        {
            if(radioYears.Checked)
            {
                if(txtBusinessDuration.Text!="")
                {
                    txtEndDate.Text = DateTime.Now.AddYears(ou).ToString("dd/MM/yyyy");
                }
            }
        }

        private void radioMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMonth.Checked)
            {
                if (txtBusinessDuration.Text != "")
                {
                    txtEndDate.Text = DateTime.Now.AddMonths(ou).ToString("dd/MM/yyyy");
                }
            }
        }

    }
}