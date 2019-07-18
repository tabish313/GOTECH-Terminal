using GOTECH.Crypto;
using GOTECH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Home
{
    public partial class SearchBox : Form
    {
        private DbEntities db;

        private bool saving = false;

        private FolderBrowserDialog folderBrowser;

        private BackgroundWorker bw;

        private int COURSE_ID = 0;


        public SearchBox(string Mode, int Id)
        {
            InitializeComponent();

            switch (Mode)
            {
                case "Students":
                    InitializeStudents(Id);
                    break;
                case "Courses":
                    InitializeCourse(Id);
                    COURSE_ID = Id;
                    break;
            }
        }

        private void SearchBox_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeStudents(int Id)
        {
            this.Size = new System.Drawing.Size(423, 378);
            this.tabControl1.Size = new System.Drawing.Size(439, 362);
            tabControl1.SelectedIndex = 0;


            var std = Lists.StudentsList.Where(c => c.ID == Id).FirstOrDefault();

            this.LabelText.Text = Gulipso.DataDecrypt(std.Name) + " (" + std.Student_Id + ")";

            txtStdId.Text = std.Student_Id;
            txtStdName.Text = Gulipso.DataDecrypt(std.Name);
            txtStdFName.Text = Gulipso.DataDecrypt(std.FatherName);
            txtStdEmail.Text = Gulipso.DataDecrypt(std.Email);
            txtStdContact.Text = Gulipso.DataDecrypt(std.Contact);

            btnDelete.Click += new EventHandler(btnStudentDelete_Click);
        }

        private void InitializeCourse(int Id)
        {
            this.Size = new System.Drawing.Size(423, 477);
            this.tabControl1.Size = new System.Drawing.Size(431, 395);
            tabControl1.SelectedIndex = 1;

            var course = Lists.CoursesList.Where(c => c.ID == Id).FirstOrDefault();
            this.LabelText.Text = course.CourseName + " (" + course.CourseCode + ")";

            txtCourseCode.Text = course.CourseCode;
            txtCourseName.Text = course.CourseName;
            txtCourseDate.Text = course.EntryDate;
            txtCourseTrainerName.Text = course.Trainer;
            txtCourseDuration.Text = course.Status;

            txtCourseOutline.Text = course.CourseName + " (" + course.CourseCode + ")" + course.outline_file_type;

            btnDelete.Click += new EventHandler(btnCourseDelete_Click);
        }

        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            DeleteCourse(txtCourseCode.Text);
        }

        #region DeleteCourse
        private void DeleteCourse(string COURSE_CODE)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete this course? \r\nAll students saved in this course will be deleted.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {
                var course = db.Courses.Where(c => c.CourseCode == COURSE_CODE).FirstOrDefault();

                foreach (Data.Students item in db.Students.Where(c => c.Course_Id == COURSE_ID))
                {
                    db.Entry(item).State = EntityState.Deleted;
                }

                db.Entry(course).State = EntityState.Deleted;
                db.SaveChanges();

                DbEntities dbrefresh = new DbEntities();
                Lists.CoursesList = dbrefresh.Courses.ToList();
                Lists.StudentsList = dbrefresh.Students.ToList();
            }
            else
            {
                return;
            }
        }


        #endregion

        private void ListsRefresh()
        {
            var context = ((IObjectContextAdapter)db).ObjectContext;
            var refreshableObjects = db.ChangeTracker.Entries().Select(c => c.Entity).ToList();
            context.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, refreshableObjects);

            Lists.StudentsList = db.Students.ToList();
            Lists.TrainersList = db.Trainers.ToList();
            Lists.CoursesList = db.Courses.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Student from this course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {
                var std = db.Students.Where(c => c.Student_Id == txtStdId.Text).FirstOrDefault();
                db.Entry(std).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                ListsRefresh();
            }
        }

        private void btnCVSave_Click(object sender, EventArgs e)
        {
            folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                bw = new BackgroundWorker();
                bw.DoWork += bw_DoWork;
                bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                if (!bw.IsBusy)
                {
                    btnClose.Enabled = false;
                    CloseButton.Enabled = false;
                    progress1.Visible = true;
                    bw.RunWorkerAsync();
                }
            }
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnClose.Enabled = true;
            CloseButton.Enabled = true;
            progress1.LoaderText = "Saved!";
            progress1.LoaderImage = Properties.Resources.Submit_01;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var course = Lists.CoursesList.Where(c => c.ID == COURSE_ID).FirstOrDefault();

                SaveCV(folderBrowser.SelectedPath, course.CourseName + " (" + course.CourseCode + ") Outline", course.outline_file_type, course.Outline);
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        public void SaveCV(string folderPath, string fileName, string fileExtension, byte[] fileBytes)
        {
            using (Stream file = File.OpenWrite(String.Format(@"{0}\{1}{2}", folderPath, fileName, fileExtension)))
            {
                file.Write(fileBytes, 0, fileBytes.Length);
            }
        }

        private void tabpageStudents_Click(object sender, EventArgs e)
        {

        }
    }
}