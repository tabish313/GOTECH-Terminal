using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Business
{
    public partial class BusinessGoals : Form
    {
        private CultureInfo enUS = new CultureInfo("en-US");
        public BusinessGoals()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFormValidated)
            {
                Goals goals = new Goals();

                goals.Name = txtName.Text;
                if (radioMonth.Checked)
                {
                    goals.Duration = txtDuration.Text + " " + radioMonth.Text;
                }

                if (radioYears.Checked)
                {
                    goals.Duration = txtDuration.Text + " " + radioYears.Text;
                }
                goals.StartDate = txtStartDate.Text;
                goals.EndDate = txtEndDate.Text;
                goals.Percentage = int.Parse(txtPercentage.Text);

                var newLinesRegex = new Regex(@"\r\n|\n|\r", RegexOptions.Singleline);
                var lines = newLinesRegex.Split(txtInfo.Text);

                string info = string.Join(",", lines);

                goals.Info = info;

                BusinessLists.GoalsList.Add(goals);
                this.Close();
            }
            else
            {
                MessageBox.Show("Something wents wrong! Form is not Validated!", "Error - Go TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int ou;
        DateTime startDateTime;
        DateTime EndDateTime;
        public bool IsFormValidated
        {
            get
            {


                int temp;
                bool StartDateCheck = DateTime.TryParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None, out startDateTime);
                bool EndDateCheck = DateTime.TryParseExact(txtEndDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None, out EndDateTime);
                bool PercentCheck = int.TryParse(txtPercentage.Text, out temp);

                if (txtName.Text != "" && txtDuration.Text != "" && StartDateCheck && EndDateCheck && PercentCheck && txtInfo.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void txtStartDate_OnValueChanged(object sender, EventArgs e)
        {
            bool StartDateCheck = DateTime.TryParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None, out startDateTime);
            if (txtDuration.Text != "")
            {
                if (StartDateCheck)
                {
                    DateTime StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS);
                    if (ou != null)
                    {
                        if (radioMonth.Checked)
                        {
                            txtEndDate.Text = StartDate.AddMonths(ou).ToString("dd/MM/yyyy");
                        }

                        if (radioYears.Checked)
                        {
                            txtEndDate.Text = StartDate.AddYears(ou).ToString("dd/MM/yyyy");
                        }
                    }
                }
            }
        }


        private void txtDuration_OnValueChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtDuration.Text, out ou)))
            {
                txtDuration.Text = "";
            }
            else
            {
                bool StartDateCheck = DateTime.TryParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None, out startDateTime);
                if (StartDateCheck)
                {
                    DateTime StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS);
                    if (radioMonth.Checked)
                    {
                        txtEndDate.Text = StartDate.AddMonths(ou).ToString("dd/MM/yyyy");
                    }

                    if (radioYears.Checked)
                    {
                        txtEndDate.Text = StartDate.AddYears(ou).ToString("dd/MM/yyyy");
                    }
                }
            }
        }

        private void radioMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMonth.Checked)
            {
                bool StartDateCheck = DateTime.TryParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None, out startDateTime);
                if (StartDateCheck)
                {
                    DateTime StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS);
                    txtEndDate.Text = StartDate.AddMonths(ou).ToString("dd/MM/yyyy");
                }
            }
        }

        private void radioYears_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYears.Checked)
            {
                bool StartDateCheck = DateTime.TryParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS, DateTimeStyles.None, out startDateTime);
                if (StartDateCheck)
                {
                    DateTime StartDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", enUS);
                    txtEndDate.Text = StartDate.AddYears(ou).ToString("dd/MM/yyyy");
                }
            }
        }
    }
}