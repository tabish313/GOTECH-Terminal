using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOTECH.Data;
using KimtToo.VisualReactive;
using GOTECH.Utils;
using GOTECH.Course;
using System.Collections;
using System.Threading;
using GOTECH.Students;
using System.Data.Entity;
using GOTECH.Trainer;
using GOTECH.Crypto;
using System.Data.Entity.Infrastructure;
using GOTECH.Business;
using System.IO;

namespace GOTECH.Home
{
    public partial class Dashboard : Form
    {
        public List<Users> users = null;

        public List<Courses> CoursesList = null;

        public List<Trainers> TrainersList = null;

        public List<Data.Students> StudentsList = null;

        private System.Windows.Forms.Timer tm;

        private System.Timers.Timer tmr;

        private DbEntities db;

        int tempPerc = 0;

        //public Dashboard(List<Users> usr)
        public Dashboard()
        {
            InitializeComponent();

            labelMainHeading.Focus();
            panelMainMenu.Size = new System.Drawing.Size(50, 642);

            this.panelHider.Height = 28;

            int height = SystemInformation.VirtualScreen.Height;
            int width = SystemInformation.VirtualScreen.Width;

            this.Size = new Size(width - 20, height - 50);

            CloseButton.Location = new Point(width - 20 - 30, 5);
            MinimizeButton.Location = new Point(width - 20 - 50, 5);

            businessMainProgress.LabelVisible = businessSubProgress.LabelVisible = CurrentGoalProgress.LabelVisible = CurrentSubGoalProgress.LabelVisible = true;

            VSReactive<int>.Subscribe("MainTab", e => tabMain.SelectedIndex = e);




            //this.users = usr;


        }

        void tmr_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate()
            {
                labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                labelDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            }));
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            tm = new System.Windows.Forms.Timer();
            tm.Enabled = true;
            tm.Interval = 2;
            tm.Tick += tm_Tick;
            tm.Start();
        }

        void tm_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.050;
            }
            else
            {
                tm.Stop();
                Application.Exit();

            }
        }

        bool menuExpanded = false;

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if (panelMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!menuExpanded)
                {
                    menuExpanded = true;
                    panelMainMenu.Width = 200;
                }
            }
            else
            {
                if (menuExpanded)
                {
                    menuExpanded = false;
                    panelMainMenu.Visible = false;
                    panelMainMenu.Width = 50;
                    bunifuTransition1.Show(panelMainMenu);
                }
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            mouseDetect.Start();
            tmr = new System.Timers.Timer();
            tmr.Enabled = true;
            tmr.Interval = 1000;
            tmr.Elapsed += tmr_Elapsed;
            tmr.Start();


            if (IsBusinessPlanAvailable)
            {
                panelbusiness.Visible = true;
                panelNoBusiness.Visible = false;
                BusinnesGoals();
                BusinessPlansOverview();
                CurrentGoalsSub();
                AllPlans();
                tempPerc = CurrentGoalPercentage;
                businessMainProgress.Value = businessSubProgress.Value = BusinessPlanPercentage;
            }
            else
            {

                panelbusiness.Visible = false;
                panelNoBusiness.Visible = true;
                businessMainProgress.Value = businessSubProgress.Value = 0;
            }

            db = new DbEntities();

            CoursesList = Lists.CoursesList;
            TrainersList = Lists.TrainersList;
            StudentsList = Lists.StudentsList;



            #region Silver Grid Aligning
            DataGridViewImageColumn cell = (DataGridViewImageColumn)dataGridViewCourse.Columns[8];
            cell.Image = Properties.Resources.Garbage_Closed;
            cell.ImageLayout = DataGridViewImageCellLayout.Zoom;


            dataGridViewCourse.Columns["Revenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCourse.Columns["Students"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCourse.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridViewCourse.Columns["Revenue"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCourse.Columns["Students"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCourse.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            #endregion

            #region Gold Grid Aligning
            DataGridViewImageColumn cellGold = (DataGridViewImageColumn)dataGridViewGold.Columns[8];
            cellGold.Image = Properties.Resources.Garbage_Closed;
            cellGold.ImageLayout = DataGridViewImageCellLayout.Zoom;


            dataGridViewGold.Columns["GoldRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewGold.Columns["GoldStudents"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewGold.Columns["GoldStatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridViewGold.Columns["GoldRevenue"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewGold.Columns["GoldStudents"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewGold.Columns["GoldStatus"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            #endregion

            #region Premium Grid Aligning
            DataGridViewImageColumn cellPremium = (DataGridViewImageColumn)dataGridViewPremium.Columns[8];
            cellPremium.Image = Properties.Resources.Garbage_Closed;
            cellPremium.ImageLayout = DataGridViewImageCellLayout.Zoom;


            dataGridViewPremium.Columns["PremiumRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPremium.Columns["PremiumStudents"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPremium.Columns["PremiumStatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridViewPremium.Columns["PremiumRevenue"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPremium.Columns["PremiumStudents"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPremium.Columns["PremiumStatus"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            #endregion

            DataGridViewImageColumn cellOverviewCourseDel = (DataGridViewImageColumn)dataGridViewCourseOverview.Columns[8];
            cellOverviewCourseDel.Image = Properties.Resources.Garbage_Closed;
            cellOverviewCourseDel.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn cellOverviewCourseUpd = (DataGridViewImageColumn)dataGridViewCourseOverview.Columns[9];
            cellOverviewCourseUpd.Image = Properties.Resources.Data_Edit_White_padding_10px;
            cellOverviewCourseUpd.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewImageColumn cellOverviewTrainerDel = (DataGridViewImageColumn)dataGridViewTrainers.Columns[6];
            cellOverviewTrainerDel.Image = Properties.Resources.Garbage_Closed;
            cellOverviewTrainerDel.ImageLayout = DataGridViewImageCellLayout.Zoom;

            SilverDataGridCells();
            GoldrDataGridCells();
            PremiumDataGridCells();

            CourseOverviewDataGridCells();

            StudentGridCells();

            TrainerGridCells();
        }

        private void sideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr.Dispose();
            tmr.Stop();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabPagCourseOverview)
            {
                label10.Focus();
            }
        }

        #region Add Course Buttons
        AddCourse frmadd;
        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            frmadd = new AddCourse("Silver");
            frmadd.ShowInTaskbar = false;
            bool IsFormOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddCourse")
                {
                    IsFormOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!IsFormOpen)
            {
                frmadd.ShowDialog();
                RefreshAll();
            }

        }

        private void btnAddCourseGold_Click(object sender, EventArgs e)
        {
            frmadd = new AddCourse("Gold");
            frmadd.ShowInTaskbar = false;
            bool IsFormOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddCourse")
                {
                    IsFormOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!IsFormOpen)
            {
                frmadd.ShowDialog();
                RefreshAll();
            }
        }

        private void btnAddCoursePremium_Click(object sender, EventArgs e)
        {
            frmadd = new AddCourse("Premium");
            frmadd.ShowInTaskbar = false;
            bool IsFormOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddCourse")
                {
                    IsFormOpen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (!IsFormOpen)
            {
                frmadd.ShowDialog();
                RefreshAll();
            }
        }
        #endregion

        #region Form Activated
        private void Dashboard_Activated(object sender, EventArgs e)
        {
            this.RefreshAll();
            labelMainHeading.Focus();



            if (IsBusinessPlanAvailable)
            {
                panelbusiness.Visible = true;
                panelNoBusiness.Visible = false;
                btnNewBusiness.Visible = false;
                btnDelete.Visible = true;

                if (tempPerc != CurrentGoalPercentage)
                {
                    CurrentGoalsSub();
                    tempPerc = CurrentGoalPercentage;
                }

                CurrentGoalProgress.Value = CurrentSubGoalProgress.Value = CurrentGoalPercentage;
                businessMainProgress.Value = businessSubProgress.Value = BusinessPlanPercentage;
            }
            else
            {

                panelbusiness.Visible = false;
                panelNoBusiness.Visible = true;
                btnDelete.Visible = false;
                btnNewBusiness.Location = btnDelete.Location;
                btnNewBusiness.Visible = true;
                CurrentGoalProgress.Value = CurrentSubGoalProgress.Value = 0;
                businessMainProgress.Value = businessSubProgress.Value = 0;
            }
        }
        #endregion

        #region RefreshAll
        private void RefreshAll()
        {
            this.CoursesList = Lists.CoursesList;
            this.TrainersList = Lists.TrainersList;
            this.StudentsList = Lists.StudentsList;

            panelInfoCourses.Count = Lists.CoursesList.Count.ToString();

            panelInfoTrainers.Count = Lists.TrainersList.Count.ToString();

            panelInfoStudents.Count = Lists.StudentsList.Count.ToString();

            int totalCertified = 0;

            if (Lists.CoursesList.Count > 0)
            {
                foreach (var std in Lists.StudentsList)
                {
                    var certified = Lists.CoursesList.Where(c => c.ID == std.Course_Id).FirstOrDefault();

                    if (certified.Status == "Certified")
                    {
                        totalCertified += 1;
                    }
                }
            }

            panelInfoCertified.Count = totalCertified.ToString();

            SilverDataGridCells();
            GoldrDataGridCells();
            PremiumDataGridCells();
            CourseOverviewDataGridCells();
            StudentGridCells();
            TrainerGridCells();
        }
        #endregion

        #region Grid Cursor Hand
        private void dataGridViewCourse_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewCourse.Columns[e.ColumnIndex].HeaderText == "Delete" || dataGridViewCourse.Columns[e.ColumnIndex].HeaderText == "Course Code" || dataGridViewCourse.Columns[e.ColumnIndex].HeaderText == "Course Name" || dataGridViewCourse.Columns[e.ColumnIndex].HeaderText == "Trainer Name" || dataGridViewCourse.Columns[e.ColumnIndex].HeaderText == "Students")
            {
                dataGridViewCourse.Cursor = Cursors.Hand;
            }
            else
                dataGridViewCourse.Cursor = Cursors.Default;
        }

        private void dataGridViewCourse_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCourse.Cursor = Cursors.Default;
        }

        private void dataGridViewGold_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewGold.Cursor = Cursors.Default;
        }

        private void dataGridViewGold_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewGold.Columns[e.ColumnIndex].HeaderText == "Delete" || dataGridViewGold.Columns[e.ColumnIndex].HeaderText == "Course Code" || dataGridViewGold.Columns[e.ColumnIndex].HeaderText == "Course Name" || dataGridViewGold.Columns[e.ColumnIndex].HeaderText == "Trainer Name" || dataGridViewGold.Columns[e.ColumnIndex].HeaderText == "Students")
            {
                dataGridViewGold.Cursor = Cursors.Hand;
            }
            else
                dataGridViewGold.Cursor = Cursors.Default;
        }

        private void dataGridViewPremium_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPremium.Cursor = Cursors.Default;
        }

        private void dataGridViewPremium_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPremium.Columns[e.ColumnIndex].HeaderText == "Delete" || dataGridViewPremium.Columns[e.ColumnIndex].HeaderText == "Course Code" || dataGridViewPremium.Columns[e.ColumnIndex].HeaderText == "Course Name" || dataGridViewPremium.Columns[e.ColumnIndex].HeaderText == "Trainer Name" || dataGridViewPremium.Columns[e.ColumnIndex].HeaderText == "Students")
            {
                dataGridViewPremium.Cursor = Cursors.Hand;
            }
            else
                dataGridViewPremium.Cursor = Cursors.Default;
        }

        private void dataGridViewCourseOverview_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCourseOverview.Columns[e.ColumnIndex].HeaderText == "Delete" || dataGridViewCourseOverview.Columns[e.ColumnIndex].HeaderText == "Update" || dataGridViewCourseOverview.Columns[e.ColumnIndex].HeaderText == "Course Code" || dataGridViewCourseOverview.Columns[e.ColumnIndex].HeaderText == "Course Name" || dataGridViewCourseOverview.Columns[e.ColumnIndex].HeaderText == "Trainer Name" || dataGridViewCourseOverview.Columns[e.ColumnIndex].HeaderText == "Students")
            {
                dataGridViewCourseOverview.Cursor = Cursors.Hand;
            }
            else
                dataGridViewCourseOverview.Cursor = Cursors.Default;
        }

        private void dataGridViewCourseOverview_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCourseOverview.Cursor = Cursors.Default;
        }


        private void dataGridViewTrainers_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTrainers.Columns[e.ColumnIndex].HeaderText == "Trainer Name" || dataGridViewTrainers.Columns[e.ColumnIndex].HeaderText == "CV" || dataGridViewTrainers.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                dataGridViewTrainers.Cursor = Cursors.Hand;
            }
            else
                dataGridViewTrainers.Cursor = Cursors.Default;
        }

        private void dataGridViewTrainers_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewTrainers.Cursor = Cursors.Default;
        }
        #endregion

        #region GridCells
        private void SilverDataGridCells()
        {
            dataGridViewCourse.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList codeList = new ArrayList();
            ArrayList CNameList = new ArrayList();
            ArrayList TNameList = new ArrayList();
            ArrayList EDateList = new ArrayList();
            ArrayList RevenList = new ArrayList();
            ArrayList StudentList = new ArrayList();
            ArrayList StatusList = new ArrayList();

            foreach (Courses item in CoursesList.Where(c => c.Mode == "Silver"))
            {
                idList.Add(item.ID);
                codeList.Add(item.CourseCode);
                CNameList.Add(item.CourseName);
                TNameList.Add(item.Trainer);
                EDateList.Add(item.EntryDate);
                RevenList.Add(item.Revenue.ToString());
                var totalstd = StudentsList.Where(c => c.Course_Id == item.ID).ToList().ToArray().Length;
                StudentList.Add(totalstd);
                StatusList.Add(item.Status);
            }

            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridViewCourse.Rows.Add();

                dataGridViewCourse.Rows[n].Cells[0].Value = idList[i];
                dataGridViewCourse.Rows[n].Cells[1].Value = codeList[i].ToString();
                dataGridViewCourse.Rows[n].Cells[2].Value = CNameList[i].ToString();
                dataGridViewCourse.Rows[n].Cells[3].Value = TNameList[i].ToString();
                dataGridViewCourse.Rows[n].Cells[4].Value = EDateList[i].ToString();
                dataGridViewCourse.Rows[n].Cells[5].Value = RevenList[i].ToString();
                dataGridViewCourse.Rows[n].Cells[6].Value = StudentList[i].ToString();
                dataGridViewCourse.Rows[n].Cells[7].Value = StatusList[i].ToString();
            }
        }

        private void GoldrDataGridCells()
        {
            dataGridViewGold.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList codeList = new ArrayList();
            ArrayList CNameList = new ArrayList();
            ArrayList TNameList = new ArrayList();
            ArrayList EDateList = new ArrayList();
            ArrayList RevenList = new ArrayList();
            ArrayList StudentList = new ArrayList();
            ArrayList StatusList = new ArrayList();

            foreach (Courses item in CoursesList.Where(c => c.Mode == "Gold"))
            {
                idList.Add(item.ID);
                codeList.Add(item.CourseCode);
                CNameList.Add(item.CourseName);
                TNameList.Add(item.Trainer);
                RevenList.Add(item.Revenue.ToString());
                EDateList.Add(item.EntryDate);
                var totalstd = StudentsList.Where(c => c.Course_Id == item.ID).ToList().ToArray().Length;
                StudentList.Add(totalstd);
                StatusList.Add(item.Status);
            }

            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridViewGold.Rows.Add();

                dataGridViewGold.Rows[n].Cells[0].Value = idList[i];
                dataGridViewGold.Rows[n].Cells[1].Value = codeList[i].ToString();
                dataGridViewGold.Rows[n].Cells[2].Value = CNameList[i].ToString();
                dataGridViewGold.Rows[n].Cells[3].Value = TNameList[i].ToString();
                dataGridViewGold.Rows[n].Cells[4].Value = EDateList[i].ToString();
                dataGridViewGold.Rows[n].Cells[5].Value = RevenList[i].ToString();
                dataGridViewGold.Rows[n].Cells[6].Value = StudentList[i].ToString();
                dataGridViewGold.Rows[n].Cells[7].Value = StatusList[i].ToString();
            }
        }

        private void PremiumDataGridCells()
        {
            dataGridViewPremium.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList codeList = new ArrayList();
            ArrayList CNameList = new ArrayList();
            ArrayList TNameList = new ArrayList();
            ArrayList EDateList = new ArrayList();
            ArrayList RevenList = new ArrayList();
            ArrayList StudentList = new ArrayList();
            ArrayList StatusList = new ArrayList();

            foreach (Courses item in CoursesList.Where(c => c.Mode == "Premium"))
            {
                idList.Add(item.ID);
                codeList.Add(item.CourseCode);
                CNameList.Add(item.CourseName);
                TNameList.Add(item.Trainer);
                EDateList.Add(item.EntryDate);
                RevenList.Add(item.Revenue.ToString());
                var totalstd = StudentsList.Where(c => c.Course_Id == item.ID).ToList().ToArray().Length;
                StudentList.Add(totalstd.ToString());
                StatusList.Add(item.Status);
            }

            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridViewPremium.Rows.Add();

                dataGridViewPremium.Rows[n].Cells[0].Value = idList[i];
                dataGridViewPremium.Rows[n].Cells[1].Value = codeList[i].ToString();
                dataGridViewPremium.Rows[n].Cells[2].Value = CNameList[i].ToString();
                dataGridViewPremium.Rows[n].Cells[3].Value = TNameList[i].ToString();
                dataGridViewPremium.Rows[n].Cells[4].Value = EDateList[i].ToString();
                dataGridViewPremium.Rows[n].Cells[5].Value = RevenList[i].ToString();
                dataGridViewPremium.Rows[n].Cells[6].Value = StudentList[i].ToString();
                dataGridViewPremium.Rows[n].Cells[7].Value = StatusList[i].ToString();
            }
        }

        private void CourseOverviewDataGridCells()
        {
            dataGridViewCourseOverview.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList codeList = new ArrayList();
            ArrayList CNameList = new ArrayList();
            ArrayList TNameList = new ArrayList();
            ArrayList EDateList = new ArrayList();
            ArrayList RevenList = new ArrayList();
            ArrayList StudentList = new ArrayList();
            ArrayList StatusList = new ArrayList();

            foreach (Courses item in CoursesList)
            {
                idList.Add(item.ID);
                codeList.Add(item.CourseCode);
                CNameList.Add(item.CourseName);
                TNameList.Add(item.Trainer);
                EDateList.Add(item.EntryDate);
                RevenList.Add(item.Revenue.ToString());
                var totalstd = StudentsList.Where(c => c.Course_Id == item.ID).ToList().ToArray().Length;
                StudentList.Add(totalstd.ToString());
                StatusList.Add(item.Status);
            }

            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridViewCourseOverview.Rows.Add();

                dataGridViewCourseOverview.Rows[n].Cells[0].Value = idList[i];
                dataGridViewCourseOverview.Rows[n].Cells[1].Value = codeList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[2].Value = CNameList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[3].Value = TNameList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[4].Value = EDateList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[5].Value = RevenList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[6].Value = StudentList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[7].Value = StatusList[i].ToString();
            }
        }

        private void StudentGridCells()
        {
            dataGridViewStudents.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList std_id_List = new ArrayList();
            ArrayList std_name_List = new ArrayList();
            ArrayList std_fname_List = new ArrayList();
            ArrayList std_cnic_List = new ArrayList();
            ArrayList std_contact_List = new ArrayList();
            ArrayList std_email_List = new ArrayList();
            ArrayList std_enroll_List = new ArrayList();

            foreach (Data.Students item in Lists.StudentsList)
            {
                idList.Add(item.ID);
                std_id_List.Add(item.Student_Id);
                std_name_List.Add(Gulipso.DataDecrypt(item.Name));
                std_fname_List.Add(Gulipso.DataDecrypt(item.FatherName));
                std_cnic_List.Add(Gulipso.DataDecrypt(item.CNIC));
                std_contact_List.Add(Gulipso.DataDecrypt(item.Contact));
                std_email_List.Add(Gulipso.DataDecrypt(item.Email));

                var course = Lists.CoursesList.Where(c => c.ID == item.Course_Id).FirstOrDefault();
                std_enroll_List.Add(course.CourseCode);
            }

            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridViewStudents.Rows.Add();

                dataGridViewStudents.Rows[n].Cells[0].Value = idList[i];
                dataGridViewStudents.Rows[n].Cells[1].Value = std_id_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[2].Value = std_name_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[3].Value = std_fname_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[4].Value = std_cnic_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[5].Value = std_contact_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[6].Value = std_email_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[7].Value = std_enroll_List[i].ToString();
            }
        }

        private void TrainerGridCells()
        {
            dataGridViewTrainers.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList t_name_List = new ArrayList();
            ArrayList t_Role_List = new ArrayList();
            ArrayList t_mode_List = new ArrayList();
            ArrayList t_value_List = new ArrayList();
            ArrayList t_CV_List = new ArrayList();

            foreach (Data.Trainers item in Lists.TrainersList)
            {
                idList.Add(item.ID);
                t_name_List.Add(item.Name);
                t_Role_List.Add(item.Role);
                t_mode_List.Add(item.Mode);
                t_value_List.Add(item.ModeValue);
                t_CV_List.Add(String.Format("{0}-{1}{2}", item.Name, "CV", item.cv_file_type));
            }

            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridViewTrainers.Rows.Add();

                dataGridViewTrainers.Rows[n].Cells[0].Value = idList[i].ToString();
                dataGridViewTrainers.Rows[n].Cells[1].Value = t_name_List[i].ToString();
                dataGridViewTrainers.Rows[n].Cells[2].Value = t_Role_List[i].ToString();
                dataGridViewTrainers.Rows[n].Cells[3].Value = t_mode_List[i].ToString();
                dataGridViewTrainers.Rows[n].Cells[4].Value = t_value_List[i].ToString();
                dataGridViewTrainers.Rows[n].Cells[5].Value = t_CV_List[i].ToString();
            }
        }

        #endregion

        #region Grid Content Click Event

        private void dataGridViewCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && e.RowIndex >= 0)
            {
                string course_name = dataGridViewCourse.Rows[e.RowIndex].Cells[2].Value.ToString();

                SearchBox box = new SearchBox("Courses", Lists.CoursesList.Where(c => c.CourseName == course_name).Select(c => c.ID).FirstOrDefault());
                box.ShowDialog();
            }

            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                string trainer_name = dataGridViewCourse.Rows[e.RowIndex].Cells[3].Value.ToString();

                var check = Lists.TrainersList.Where(c => c.Name == trainer_name).FirstOrDefault();

                if (check != null)
                {
                    ViewTrainerInfo info = new ViewTrainerInfo(trainer_name);
                    info.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Record of this trainer not found!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                int course_id = int.Parse(dataGridViewCourse.Rows[e.RowIndex].Cells[0].Value.ToString());
                string course_name = dataGridViewCourse.Rows[e.RowIndex].Cells[1].Value.ToString();
                ViewCourseStudents coursestd = new ViewCourseStudents(course_id, course_name + " Students");
                coursestd.ShowDialog();
            }

            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                int course_id = int.Parse(dataGridViewCourse.Rows[e.RowIndex].Cells[0].Value.ToString());

                DeleteCourse(course_id, dataGridViewCourse, e);
            }


        }

        private void dataGridViewGold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && e.RowIndex >= 0)
            {
                string course_name = dataGridViewGold.Rows[e.RowIndex].Cells[2].Value.ToString();

                SearchBox box = new SearchBox("Courses", Lists.CoursesList.Where(c => c.CourseName == course_name).Select(c => c.ID).FirstOrDefault());
                box.ShowDialog();
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                int course_id = int.Parse(dataGridViewGold.Rows[e.RowIndex].Cells[0].Value.ToString());
                string course_name = dataGridViewGold.Rows[e.RowIndex].Cells[1].Value.ToString();
                ViewCourseStudents coursestd = new ViewCourseStudents(course_id, course_name + " Students");
                coursestd.ShowDialog();
            }
            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                int course_id = int.Parse(dataGridViewGold.Rows[e.RowIndex].Cells[0].Value.ToString());

                DeleteCourse(course_id, dataGridViewGold, e);
            }

            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                string trainer_name = dataGridViewGold.Rows[e.RowIndex].Cells[3].Value.ToString();

                var check = Lists.TrainersList.Where(c => c.Name == trainer_name).FirstOrDefault();

                if (check != null)
                {
                    ViewTrainerInfo info = new ViewTrainerInfo(trainer_name);
                    info.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Record of this trainer not found!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewPremium_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && e.RowIndex >= 0)
            {
                string course_name = dataGridViewPremium.Rows[e.RowIndex].Cells[2].Value.ToString();

                SearchBox box = new SearchBox("Courses", Lists.CoursesList.Where(c => c.CourseName == course_name).Select(c => c.ID).FirstOrDefault());
                box.ShowDialog();
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                int course_id = int.Parse(dataGridViewPremium.Rows[e.RowIndex].Cells[0].Value.ToString());
                string course_name = dataGridViewPremium.Rows[e.RowIndex].Cells[1].Value.ToString();
                ViewCourseStudents coursestd = new ViewCourseStudents(course_id, course_name + " Students");
                coursestd.ShowDialog();
            }
            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                int course_id = int.Parse(dataGridViewPremium.Rows[e.RowIndex].Cells[0].Value.ToString());

                DeleteCourse(course_id, dataGridViewPremium, e);
            }

            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                string trainer_name = dataGridViewPremium.Rows[e.RowIndex].Cells[3].Value.ToString();

                var check = Lists.TrainersList.Where(c => c.Name == trainer_name).FirstOrDefault();

                if (check != null)
                {
                    ViewTrainerInfo info = new ViewTrainerInfo(trainer_name);
                    info.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Record of this trainer not found!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewCourseOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 1 || e.ColumnIndex == 2) && e.RowIndex >= 0)
            {
                string course_name = dataGridViewCourseOverview.Rows[e.RowIndex].Cells[2].Value.ToString();

                SearchBox box = new SearchBox("Courses", Lists.CoursesList.Where(c => c.CourseName == course_name).Select(c => c.ID).FirstOrDefault());
                box.ShowDialog();
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                int course_id = int.Parse(dataGridViewCourseOverview.Rows[e.RowIndex].Cells[0].Value.ToString());
                string course_name = dataGridViewCourseOverview.Rows[e.RowIndex].Cells[1].Value.ToString();
                ViewCourseStudents coursestd = new ViewCourseStudents(course_id, course_name + " Students");
                coursestd.ShowDialog();
            }


            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                string trainer_name = dataGridViewCourseOverview.Rows[e.RowIndex].Cells[3].Value.ToString();

                var check = Lists.TrainersList.Where(c => c.Name == trainer_name).FirstOrDefault();

                if (check != null)
                {
                    ViewTrainerInfo info = new ViewTrainerInfo(trainer_name);
                    info.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Record of this trainer not found!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                int course_id = int.Parse(dataGridViewCourseOverview.Rows[e.RowIndex].Cells[0].Value.ToString());

                DeleteCourse(course_id, dataGridViewCourseOverview, e);
            }

            if (e.ColumnIndex == 9 && e.RowIndex >= 0)
            {
                int course_id = int.Parse(dataGridViewCourseOverview.Rows[e.RowIndex].Cells[0].Value.ToString());

                Courses course = Lists.CoursesList.Where(c => c.ID == course_id).FirstOrDefault();

                ModifyCourse mdCourse = new ModifyCourse(course);
                mdCourse.ShowDialog();

            }
        }

        private void dataGridViewTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                string trainer_name = dataGridViewTrainers.Rows[e.RowIndex].Cells[1].Value.ToString();

                var check = Lists.TrainersList.Where(c => c.Name == trainer_name).FirstOrDefault();

                if (check != null)
                {
                    ViewTrainerInfo info = new ViewTrainerInfo(trainer_name);
                    info.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Record of this trainer not found!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridViewTrainers.Rows[e.RowIndex].Cells[0].Value.ToString());

                SaveCV(id);
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridViewTrainers.Rows[e.RowIndex].Cells[0].Value.ToString());

                DeleteTrainer(id);
            }
        }
        #endregion

        #region DeleteCourse
        private void DeleteCourse(int COURSE_ID, DataGridView DataGridView, DataGridViewCellEventArgs e)
        {
            int course_id = int.Parse(DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            DialogResult result = MessageBox.Show("Are you sure you want to delete this course? \r\nAll students saved in this course will be deleted.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {
                var course = db.Courses.Where(c => c.ID == COURSE_ID).FirstOrDefault();

                foreach (Data.Students item in db.Students.Where(c => c.Course_Id == COURSE_ID))
                {
                    db.Entry(item).State = EntityState.Deleted;
                }

                db.Entry(course).State = EntityState.Deleted;
                db.SaveChanges();

                DbEntities dbrefresh = new DbEntities();
                Lists.CoursesList = dbrefresh.Courses.ToList();
                Lists.StudentsList = dbrefresh.Students.ToList();

                this.RefreshAll();
            }
            else
            {
                return;
            }
        }


        #endregion

        private void DeleteTrainer(int id)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Trainer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {
                var train = db.Trainers.Where(c => c.ID == id).FirstOrDefault();

                db.Entry(train).State = EntityState.Deleted;
                db.SaveChanges();

                DbEntities dbrefresh = new DbEntities();
                Lists.CoursesList = dbrefresh.Courses.ToList();
                Lists.StudentsList = dbrefresh.Students.ToList();
                Lists.TrainersList = dbrefresh.Trainers.ToList();
                this.RefreshAll();
            }
            else
            {
                return;
            }
        }

        private void SaveCV(int id)
        {
            try
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                DialogResult result = folderBrowser.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var trainer = Lists.TrainersList.Where(c => c.ID == id).FirstOrDefault();

                    using (Stream file = File.OpenWrite(String.Format(@"{0}\{1}{2}", folderBrowser.SelectedPath, trainer.Name.ToString() + " CV", trainer.cv_file_type)))
                    {
                        file.Write(trainer.CV, 0, trainer.CV.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured while saving! \r\n" + ex.Message.ToString(), "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region TextBox Search Placeholder
        private void txtboxSearch_Enter(object sender, EventArgs e)
        {

            if (txtboxSearch.Text == "Search...")
            {
                txtboxSearch.Text = "";
            }


        }

        private void txtboxSearch_Leave(object sender, EventArgs e)
        {
            if (txtboxSearch.Text == "")
            {
                txtboxSearch.Text = "Search...";
            }
        }
        #endregion

        private void panelInfoStudents_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                name = Gulipso.DataEncrypt(txtboxSearch.Text);
            }
            catch (Exception)
            {
                name = txtboxSearch.Text;
            }

            var std = StudentsList.Where(c => c.Name == name || c.Student_Id == txtboxSearch.Text).FirstOrDefault();

            if (std == null)
            {
                var train = TrainersList.Where(c => c.Name == txtboxSearch.Text).FirstOrDefault();
                if (train == null)
                {
                    var course = CoursesList.Where(c => c.CourseCode == txtboxSearch.Text || c.CourseName == txtboxSearch.Text).FirstOrDefault();
                    if (course == null)
                    {
                        MessageBox.Show("NO Result found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SearchBox box = new SearchBox("Courses", course.ID);
                        box.ShowDialog();
                    }
                }
                else
                {
                    ViewTrainerInfo trainerinf = new ViewTrainerInfo(txtboxSearch.Text);
                    trainerinf.ShowDialog();
                }
            }
            else
            {
                SearchBox box = new SearchBox("Students", std.ID);
                box.ShowDialog();
            }
        }

        private void txtboxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
            }
        }

        #region Course Overview Seacrch PlaceHolder

        private void txtboxCourseSearch_Enter(object sender, EventArgs e)
        {
            if (txtboxCourseSearch.Text == "Search...")
            {
                txtboxCourseSearch.Text = "";
            }
        }



        private void txtboxCourseSearch_Leave(object sender, EventArgs e)
        {
            if (txtboxCourseSearch.Text == "")
            {
                txtboxCourseSearch.Text = "Search...";
            }
        }


        #endregion


        private string SEARCHMODE = "";
        private void btnCourseSearch_Click(object sender, EventArgs e)
        {

            if (txtboxCourseSearch.Text != "")
            {
                try
                {
                    var CheckCode = Lists.CoursesList.Where(c => c.CourseCode == txtboxCourseSearch.Text).FirstOrDefault();
                    if (CheckCode != null)
                    {
                        SEARCHMODE = "Code";
                        SearchCourse(SEARCHMODE);
                    }
                    else
                    {
                        var checkName = Lists.CoursesList.Where(c => c.CourseName == txtboxCourseSearch.Text).FirstOrDefault();
                        if (checkName != null)
                        {
                            SEARCHMODE = "Name";
                            SearchCourse(SEARCHMODE);
                        }
                        else
                        {
                            var checkTrainer = Lists.CoursesList.Where(c => c.Trainer == txtboxCourseSearch.Text).FirstOrDefault();
                            if (checkTrainer != null)
                            {
                                SEARCHMODE = "Trainer";
                                SearchCourse(SEARCHMODE);
                            }
                            else
                            {
                                MessageBox.Show("Error: No Result Found!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured while searching! \r\n" + ex.Message.ToString(), "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void SearchCourse(string Mode)
        {
            dataGridViewCourseOverview.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList codeList = new ArrayList();
            ArrayList CNameList = new ArrayList();
            ArrayList TNameList = new ArrayList();
            ArrayList EDateList = new ArrayList();
            ArrayList RevenList = new ArrayList();
            ArrayList StudentList = new ArrayList();
            ArrayList StatusList = new ArrayList();

            switch (Mode)
            {
                case "Code":
                    foreach (Courses item in CoursesList.Where(c => c.CourseCode == txtboxCourseSearch.Text))
                    {
                        idList.Add(item.ID);
                        codeList.Add(item.CourseCode);
                        CNameList.Add(item.CourseName);
                        TNameList.Add(item.Trainer);
                        EDateList.Add(item.EntryDate);
                        RevenList.Add(item.Revenue.ToString());
                        var totalstd = StudentsList.Where(c => c.Course_Id == item.ID).ToList().ToArray().Length;
                        StudentList.Add(totalstd.ToString());
                        StatusList.Add(item.Status);
                    }
                    break;

                case "Name":
                    foreach (Courses item in CoursesList.Where(c => c.CourseName == txtboxCourseSearch.Text))
                    {
                        idList.Add(item.ID);
                        codeList.Add(item.CourseCode);
                        CNameList.Add(item.CourseName);
                        TNameList.Add(item.Trainer);
                        EDateList.Add(item.EntryDate);
                        RevenList.Add(item.Revenue.ToString());
                        var totalstd = StudentsList.Where(c => c.Course_Id == item.ID).ToList().ToArray().Length;
                        StudentList.Add(totalstd.ToString());
                        StatusList.Add(item.Status);
                    }
                    break;
                case "Trainer":
                    foreach (Courses item in CoursesList.Where(c => c.Trainer == txtboxCourseSearch.Text))
                    {
                        idList.Add(item.ID);
                        codeList.Add(item.CourseCode);
                        CNameList.Add(item.CourseName);
                        TNameList.Add(item.Trainer);
                        EDateList.Add(item.EntryDate);
                        RevenList.Add(item.Revenue.ToString());
                        var totalstd = StudentsList.Where(c => c.Course_Id == item.ID).ToList().ToArray().Length;
                        StudentList.Add(totalstd.ToString());
                        StatusList.Add(item.Status);
                    }
                    break;
            }



            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridViewCourseOverview.Rows.Add();

                dataGridViewCourseOverview.Rows[n].Cells[0].Value = idList[i];
                dataGridViewCourseOverview.Rows[n].Cells[1].Value = codeList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[2].Value = CNameList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[3].Value = TNameList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[4].Value = EDateList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[5].Value = RevenList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[6].Value = StudentList[i].ToString();
                dataGridViewCourseOverview.Rows[n].Cells[7].Value = StatusList[i].ToString();
            }
        }

        private void BusinnesGoals()
        {

            var GoalsList = Lists.GoalsList;

            ArrayList GoalsArray = new ArrayList();
            ArrayList StartArray = new ArrayList();
            ArrayList endarray = new ArrayList();
            foreach (var item in Lists.GoalsList)
            {
                GoalsArray.Add(item.Name);
                StartArray.Add(item.StartDate.ToString("dd/MMM/yyyy"));
                endarray.Add(item.EndDate.ToString("dd/MMM/yyyy"));
            }

            for (int i = 0; i <= GoalsArray.Count - 1; i++)
            {
                GOTECH.Utils.BusinessGoals bsn = new GOTECH.Utils.BusinessGoals();
                bsn.Name = String.Format("BusinessGoal{0}", i.ToString());
                bsn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
                bsn.Dock = System.Windows.Forms.DockStyle.Top;
                bsn.GoalId = String.Format("Goal {0}:", (i + 1).ToString());
                bsn.GoalName = GoalsArray[i].ToString();
                bsn.StartEndDate = String.Format("{0} - {1}", StartArray[i].ToString(), endarray[i].ToString());
                bsn.Location = new System.Drawing.Point(3, 3);
                bsn.Size = new System.Drawing.Size(309, 50);
                bsn.TabIndex = 0;

                flowLayoutGoals.Controls.Add(bsn);
            }
        }

        private void CurrentGoalsSub()
        {
            flowLayoutPanelCurrent.Controls.Clear();
            var GoalsInfo = Lists.GoalsInfoList;

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
                curg.CheckEnabled = false;
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

        private void BusinessPlansOverview()
        {
            var item = Lists.BusinessPlansList.Where(c => c.ID == 1).FirstOrDefault();

            lblbusinessDuration.Text = item.Duration;

            lblbusinessStart.Text = item.StartDate.ToString("dd/MMM/yyyy");

            lblbusinessEnd.Text = item.EndDate.ToString("dd/MMM/yyyy");

            var current_item = Lists.GoalsList.Where(c => c.ID == FetchCurrentGoalId).FirstOrDefault();

            lblCurrentGoalDuration.Text = current_item.Duration;

            lblCurrentGoalStartDate.Text = current_item.StartDate.ToString("dd/MMM/yyyy");

            lblCurrentGoalEndDate.Text = current_item.EndDate.ToString("dd/MMM/yyyy");
        }

        private int BusinessPlanPercentage
        {
            get
            {

                // Total Percentage 
                int total = 0;

                foreach (var item in Lists.GoalsList)
                {
                    total += item.Percentage;
                }
                //end total percentage


                int done = 0;

                foreach (var item in Lists.GoalsList)
                {
                    if (item.ID == FetchCurrentGoalId)
                    {
                        done += ((CurrentGoalPercentage * item.Percentage) / 100);
                    }

                    if (item.ID < FetchCurrentGoalId)
                    {
                        done += item.Percentage;
                    }

                    if (item.ID > FetchCurrentGoalId)
                    {
                        done += 0;
                    }

                }

                return ((done * 100) / total);
            }
        }

        private int CurrentGoalPercentage
        {
            get
            {
                int current_goal_done_perc = (((Lists.GoalsInfoList.Where(c => c.Goal_Id == FetchCurrentGoalId && c.Completed == true).ToArray().Length) * 100) / (Lists.GoalsInfoList.Where(c => c.Goal_Id == FetchCurrentGoalId).ToArray().Length));
                return current_goal_done_perc;
            }
        }

        private void btnNewBusiness_Click(object sender, EventArgs e)
        {
            NewBusinessPlan plan = new NewBusinessPlan();
            plan.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this business plan? \r\nAll goals saved in this plan will be deleted.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {

                IEnumerable<BusinessPlans> list = db.BusinessPlans.ToList();
                IEnumerable<Data.Goals> list1 = db.Goals.ToList();
                IEnumerable<GoalsInfo> list2 = db.GoalsInfo.ToList();

                db.BusinessPlans.RemoveRange(list);
                db.Goals.RemoveRange(list1);
                db.GoalsInfo.RemoveRange(list2);
                db.SaveChanges();

                DialogResult result1 = MessageBox.Show("Business Plan deletion successful! \r\nRestart this app to take effect!.", "GO TECH Terminal", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result1 == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private bool IsBusinessPlanAvailable
        {
            get
            {
                if (Lists.BusinessPlansList.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxStudentsSearch.Text != "")
            {
                try
                {
                    var CheckCode = Lists.StudentsList.Where(c => c.Student_Id == txtBoxStudentsSearch.Text).FirstOrDefault();
                    if (CheckCode != null)
                    {
                        SEARCHMODE = "ID";
                        SearchStudent(SEARCHMODE);
                    }
                    else
                    {
                        var checkName = Lists.StudentsList.Where(c => c.Name == Gulipso.DataEncrypt(txtBoxStudentsSearch.Text)).FirstOrDefault();
                        if (checkName != null)
                        {
                            SEARCHMODE = "Name";
                            SearchStudent(SEARCHMODE);
                        }
                        else
                        {
                            var checkEmail = Lists.StudentsList.Where(c => c.Email == Gulipso.DataEncrypt(txtBoxStudentsSearch.Text)).FirstOrDefault();
                            if (checkEmail != null)
                            {
                                SEARCHMODE = "Email";
                                SearchStudent(SEARCHMODE);
                            }
                            else
                            {
                                var checkCourseCode = Lists.CoursesList.Where(c => c.CourseCode == txtBoxStudentsSearch.Text).FirstOrDefault();
                                if (checkCourseCode != null)
                                {
                                    SEARCHMODE = "CourseCode";
                                    SearchStudent(SEARCHMODE);
                                }
                                else
                                {
                                    MessageBox.Show("Error: No Result Found!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured while searching! \r\n" + ex.Message.ToString(), "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: Field can't be empty!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchStudent(string mode)
        {
            dataGridViewStudents.Rows.Clear();
            ArrayList idList = new ArrayList();
            ArrayList std_id_List = new ArrayList();
            ArrayList std_name_List = new ArrayList();
            ArrayList std_fname_List = new ArrayList();
            ArrayList std_cnic_List = new ArrayList();
            ArrayList std_contact_List = new ArrayList();
            ArrayList std_email_List = new ArrayList();
            ArrayList std_enroll_List = new ArrayList();


            switch (mode)
            {
                case "ID":
                    foreach (Data.Students item in Lists.StudentsList.Where(c => c.Student_Id == txtBoxStudentsSearch.Text))
                    {
                        idList.Add(item.ID);
                        std_id_List.Add(item.Student_Id);
                        std_name_List.Add(Gulipso.DataDecrypt(item.Name));
                        std_fname_List.Add(Gulipso.DataDecrypt(item.FatherName));
                        std_cnic_List.Add(Gulipso.DataDecrypt(item.CNIC));
                        std_contact_List.Add(Gulipso.DataDecrypt(item.Contact));
                        std_email_List.Add(Gulipso.DataDecrypt(item.Email));

                        var course = Lists.CoursesList.Where(c => c.ID == item.Course_Id).FirstOrDefault();
                        std_enroll_List.Add(course.CourseCode);
                    }
                    break;

                case "Name":
                    foreach (Data.Students item in Lists.StudentsList.Where(c => c.Name == Gulipso.DataEncrypt(txtBoxStudentsSearch.Text)))
                    {
                        idList.Add(item.ID);
                        std_id_List.Add(item.Student_Id);
                        std_name_List.Add(Gulipso.DataDecrypt(item.Name));
                        std_fname_List.Add(Gulipso.DataDecrypt(item.FatherName));
                        std_cnic_List.Add(Gulipso.DataDecrypt(item.CNIC));
                        std_contact_List.Add(Gulipso.DataDecrypt(item.Contact));
                        std_email_List.Add(Gulipso.DataDecrypt(item.Email));

                        var course = Lists.CoursesList.Where(c => c.ID == item.Course_Id).FirstOrDefault();
                        std_enroll_List.Add(course.CourseCode);
                    }
                    break;

                case "Email":
                    foreach (Data.Students item in Lists.StudentsList.Where(c => c.Email == Gulipso.DataEncrypt(txtBoxStudentsSearch.Text)))
                    {
                        idList.Add(item.ID);
                        std_id_List.Add(item.Student_Id);
                        std_name_List.Add(Gulipso.DataDecrypt(item.Name));
                        std_fname_List.Add(Gulipso.DataDecrypt(item.FatherName));
                        std_cnic_List.Add(Gulipso.DataDecrypt(item.CNIC));
                        std_contact_List.Add(Gulipso.DataDecrypt(item.Contact));
                        std_email_List.Add(Gulipso.DataDecrypt(item.Email));

                        var course = Lists.CoursesList.Where(c => c.ID == item.Course_Id).FirstOrDefault();
                        std_enroll_List.Add(course.CourseCode);
                    }
                    break;

                case "CourseCode":
                    foreach (Data.Students item in Lists.StudentsList.Where(c => c.Course_Id == Lists.CoursesList.Where(d => d.CourseCode == txtBoxStudentsSearch.Text).Select(d => d.ID).FirstOrDefault()))
                    {
                        idList.Add(item.ID);
                        std_id_List.Add(item.Student_Id);
                        std_name_List.Add(Gulipso.DataDecrypt(item.Name));
                        std_fname_List.Add(Gulipso.DataDecrypt(item.FatherName));
                        std_cnic_List.Add(Gulipso.DataDecrypt(item.CNIC));
                        std_contact_List.Add(Gulipso.DataDecrypt(item.Contact));
                        std_email_List.Add(Gulipso.DataDecrypt(item.Email));

                        var course = Lists.CoursesList.Where(c => c.ID == item.Course_Id).FirstOrDefault();
                        std_enroll_List.Add(course.CourseCode);
                    }
                    break;
            }


            int n = 0;
            for (int i = 0; i <= idList.ToArray().Length - 1; i++)
            {
                n = dataGridViewStudents.Rows.Add();

                dataGridViewStudents.Rows[n].Cells[0].Value = idList[i];
                dataGridViewStudents.Rows[n].Cells[1].Value = std_id_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[2].Value = std_name_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[3].Value = std_fname_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[4].Value = std_cnic_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[5].Value = std_contact_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[6].Value = std_email_List[i].ToString();
                dataGridViewStudents.Rows[n].Cells[7].Value = std_enroll_List[i].ToString();
            }
        }

        private void dataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string std_id = dataGridViewStudents.Rows[e.RowIndex].Cells[1].Value.ToString();


            Data.Students std = Lists.StudentsList.Where(c => c.Student_Id == std_id).FirstOrDefault();

            StudentInfo stdinfo = new StudentInfo(std);
            stdinfo.ShowDialog();
        }

        private void btnUpdateCurrentGoals_Click(object sender, EventArgs e)
        {
            UpdateCurrentGoals gls = new UpdateCurrentGoals();
            gls.ShowDialog();
        }

        private void AllPlans()
        {
            for (int i = 0; i <= Lists.GoalsList.Count - 1; i++)
            {
                PlanBox pln = new PlanBox();
                pln.Location = new System.Drawing.Point(20, 20);
                pln.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
                pln.Name = "planBox" + (i.ToString());
                pln.Size = new System.Drawing.Size(315, 250);

                string[] goalArray = Lists.GoalsInfoList.Where(c => c.Goal_Id == (i + 1)).Select(c => c.Info).ToArray();

                bool[] CompleteArray = Lists.GoalsInfoList.Where(c => c.Goal_Id == (i + 1)).Select(c => c.Completed).ToArray();


                var pl = Lists.GoalsList.Where(c => c.ID == (i + 1)).FirstOrDefault();

                pln.DatePart = "Druration: " + pl.StartDate.ToString("dd/MM/yyyy") + " to " + pl.EndDate.ToString("dd/MM/yyyy");

                pln.GoalText = "Goal " + (i + 1).ToString();

                pln.GoalsList = goalArray;

                pln.Completed = CompleteArray;

                flowLayoutPanelMain.Controls.Add(pln);
            }
        }
    }
}