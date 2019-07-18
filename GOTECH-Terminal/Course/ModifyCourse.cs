using GOTECH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Course
{
    public partial class ModifyCourse : Form
    {
        private Data.Courses COURSE = null;

        private BackgroundWorker bw;

        private DbEntities db;

        private string Status = "Pending";

        public ModifyCourse(Data.Courses Course)
        {
            InitializeComponent();
            this.COURSE = Course;


            txtCourseCode.Text = COURSE.CourseCode;
            txtCourseName.Text = COURSE.CourseName;
            txtCourseStd.Text = Lists.StudentsList.Where(c => c.Course_Id == COURSE.ID).ToArray().Length.ToString();
            txtCourseRevenue.Text = COURSE.Revenue.ToString();

            ComboCourseStatus.SelectedItem = COURSE.Status;

            progress1.LoaderText = "Saving";
            progress1.LoaderImage = Properties.Resources.loader_white;

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
                progress1.LoaderText = "Saving";
                progress1.LoaderImage = Properties.Resources.loader_white;
                progress1.Visible = true;
                bw.RunWorkerAsync();
            }
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSave.Enabled = true;
            progress1.LoaderText = "Saved";
            progress1.LoaderImage = Properties.Resources.Submit_01_White_padding_10px;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Courses crs = Lists.CoursesList.Where(c => c.ID == COURSE.ID).FirstOrDefault();

            crs.Revenue = int.Parse(txtCourseRevenue.Text);

            crs.Status = Status;

            db.Entry(crs).State = EntityState.Modified;
            db.SaveChanges();

            DbEntities dbrefresh = new DbEntities();
            Lists.CoursesList = dbrefresh.Courses.ToList();
            dbrefresh.Dispose();
        }

        private void ModifyCourse_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
        }

        private void ComboCourseStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status = ComboCourseStatus.SelectedItem.ToString();
        }
    }
}
