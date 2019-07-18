using Bunifu.Framework.UI;
using GOTECH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Course
{
    public partial class AddCourse : Form
    {
        #region Variables
        private bool Newtrainer = true;

        private int CourseID = 0;

        private byte[] byteOutline = null;

        private byte[] byteCV = null;

        private byte[] byteProfile = null;

        private DbEntities db;

        private BackgroundWorker bw;

        private string TrainerName = "";

        private string CourseMode="";

        private string CourseDuration = "";

        private Timer tm;

        private OpenFileDialog openfileOut;

        private OpenFileDialog openfileCV;

        private OpenFileDialog openfileProfile;

        private string CV_TYPE = "";

        private string trainer_role = "";

        private string trainer_mode = "";

        private string[] items = null;

        private string OUTLINE_FILE_TYPE = "";

        private bool SAVED = false;

        #endregion

        #region Constructor
        public AddCourse(string courseMode)
        {
            InitializeComponent();
            this.CourseMode = courseMode;
            this.labelText.Text = String.Format("Add {0} Course", courseMode);

            
            switch(courseMode)
            {
                    
                case "Silver":

                    ComboCourseDuration.Items.Add("01 Week");
                    ComboCourseDuration.Items.Add("02 Week");
                    ComboCourseDuration.Items.Add("03 Week");

                    ComboCourseDuration.SelectedItem = "01 Week";
                    break;
                case "Gold":
                    ComboCourseDuration.Items.Add("01 Month");
                    ComboCourseDuration.Items.Add("1.5 Month (45 days)");

                    ComboCourseDuration.SelectedItem = "01 Month";
                    break;
                case "Premium":
                    ComboCourseDuration.Items.Add("03 Months");
                    ComboCourseDuration.Items.Add("04 Months");

                    ComboCourseDuration.SelectedItem = "03 Months";
                    break;
            }

            db = new DbEntities();
            bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted+=bw_RunWorkerCompleted;
        }
        #endregion

        #region Close Button
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Button NextClick
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedIndex <= 1)
            {
                tabControlMain.SelectedIndex += 1;
            }
            else
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to add a new course?", "Confirmation - GO TECT TERMINAL", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (confirmation == DialogResult.Yes)
                {
                    if (!bw.IsBusy)
                    {
                        bw.RunWorkerAsync();
                        btnNext.Enabled = false;
                    }
                }
            }
        }
        #endregion

        #region Background Worker bw
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnNext.Enabled = true;
            if (SAVED)
            {
                btnNext.Text = "Saved";
            }
            else
            {
                btnNext.Text = "Save";
            }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            AddNewCourse();
        }
        #endregion

        #region From Load
        private void AddCourse_Load(object sender, EventArgs e)
        {
            foreach(var item in Lists.TrainersList)
            {
                comboExistsingList.Items.Add(item.Name);
            }

            try
            {
                var check = Lists.CoursesList.Last();
                CourseID = check.ID + 1;
            }
            catch(Exception)
            {
                CourseID = 1;
            }

            txtCourseId.Text = CourseID.ToString();

            CourseDuration = ComboCourseDuration.SelectedItem.ToString();
        }
        #endregion

        #region ComboBox SelectedValueChanged
        private void customComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Height = 370;
            labelDrop.Visible = txtNewTrainerModeValue.Visible = false;

            if ((string)ComboNewTrainerMode.SelectedItem == "Income")
            {
                labelDrop.Text = "Income:";
            }
            else
            {
                labelDrop.Text = "Share:";
            }

            trainer_mode = ComboNewTrainerMode.SelectedItem.ToString();
            
            tm = new Timer();
            tm.Interval = 10;
            tm.Enabled = true;
            tm.Tick += tm_Tick;
            tm.Start();
        }

        private void ComboNewTrainerRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            trainer_role = ComboNewTrainerRole.SelectedItem.ToString();
        }

        #endregion

        #region Timer Tick
        void tm_Tick(object sender, EventArgs e)
        {
            labelDrop.Visible = txtNewTrainerModeValue.Visible = true;
            if (this.Height <= 420)
            {
                this.Height += 2;
            }
            if (this.Height == 420)
            {
                tm.Stop();
            }
        }
        #endregion

        #region Button Outline Upload
        private void btnOutlineUpload_Click(object sender, EventArgs e)
        {
            openfileOut = new OpenFileDialog();
            openfileOut.Title = "Select outline to upload";
            openfileOut.Filter = "txt files (*.txt)|*.txt|docx files (*.docx)|*.docx|pdf files (*.pdf)|*.pdf*";
            DialogResult result = openfileOut.ShowDialog();
            if (result == DialogResult.OK)
            {
                byteOutline = ConvertToBytes(openfileOut.FileName);
                txtCourseOutline.Text = Path.GetFileName(openfileOut.FileName);
                OUTLINE_FILE_TYPE = Path.GetExtension(openfileOut.FileName);
            }
        }
        #endregion

        #region Button CV Upload
        private void btnCVUpload_Click(object sender, EventArgs e)
        {
            openfileCV = new OpenFileDialog();
            openfileCV.Title = "Select CV to upload";
            openfileCV.Filter = "pdf files (*.pdf)|*.pdf|docx files (*.docx)|*.docx*";
            DialogResult result = openfileCV.ShowDialog();
            if (result == DialogResult.OK)
            {
                byteCV = ConvertToBytes(openfileCV.FileName);
                txtNewTrainerCV.Text= Path.GetFileName(openfileCV.FileName);
                CV_TYPE = Path.GetExtension(openfileCV.FileName);
            }
        }
        #endregion

        #region Button Profile Upload
        private void btnProfileUpload_Click(object sender, EventArgs e)
        {
            openfileProfile = new OpenFileDialog();
            openfileProfile.Title = "Select profile to upload";
            openfileProfile.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png*";
            DialogResult result = openfileProfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                byteProfile = ConvertToBytes(openfileProfile.FileName);
                txtNewTrainerProfile.Text= Path.GetFileName(openfileProfile.FileName);
            }
        }
        #endregion

        #region ConvertToBytes
        private byte[] ConvertToBytes(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                // Create a byte array of file stream length
                byte[] bytes = System.IO.File.ReadAllBytes(filename);
                //Read block of bytes from stream into the byte array
                fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
                //Close the File Stream
                fs.Close();
                return bytes; //return the byte data
            }
        }
        #endregion

        #region ConvertToFile
        private void ConvertToFile(string savePath, string filename, byte[] bytes)
        {
            File.WriteAllBytes(savePath + @"\" + filename, bytes.ToArray());
        }
        #endregion

        #region ImageToByte
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        #endregion

        #region Button Trainer New Click
        private void btnTrainNew_Click(object sender, EventArgs e)
        {
            if (tabControlTrainer.SelectedIndex == 1)
            {
                tabControlTrainer.SelectedIndex = 0;
                btnTrainExisting.BackColor = this.tabTrainerNew.BackColor;
                btnTrainNew.BackColor = Color.FromArgb(192, 192, 1);
                Newtrainer = true;
            }
        }
        #endregion

        #region Button Trainer Existing Click
        private void btnTrainExisting_Click(object sender, EventArgs e)
        {
            if (this.Height == 420)
            {

                labelDrop.Visible = txtNewTrainerModeValue.Visible = false;
                tm = new Timer();
                tm.Interval = 10;
                tm.Enabled = true;
                tm.Tick += tmMin_tick;
                tm.Start();

            }

            if (tabControlTrainer.SelectedIndex == 0)
            {
                tabControlTrainer.SelectedIndex = 1;
                btnTrainNew.BackColor = this.tabTrainerNew.BackColor;
                btnTrainExisting.BackColor = Color.FromArgb(192, 192, 1);
                Newtrainer = false;
            }
        }
        #endregion

        #region Timer Tick Event
        private void tmMin_tick(object sender, EventArgs e)
        {
            if (this.Height > 370)
            {
                this.Height -= 2;
            }
            if (this.Height == 370)
            {
                tm.Stop();
            }
        }
        #endregion

        #region Tab Control Main SelectedIndexChanged
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControlMain.Refresh();
            if (tabControlMain.SelectedIndex == 2)
            {
                btnNext.Text = "Save";
            }
             
            
        }
        #endregion

        #region Function AddNewCourse()
        private void AddNewCourse()
        {
            if(byteOutline!=null)
            {
                if (Newtrainer)
                {

                    if (byteCV != null)
                    {
                        //Courses Start
                        Courses course = new Courses();
                        course.CourseCode = txtCourseCode.Text;
                        course.CourseName = txtCourseName.Text;
                        course.Duration = CourseDuration;
                        course.EntryDate = txtCourseEntry.Text;
                        course.Status = "Pending";
                         course.Trainer = txtNewTrainerName.Text;
                         course.Mode = CourseMode;
                         course.outline_file_type = OUTLINE_FILE_TYPE;
                         course.Revenue = 0;

                        course.Outline = byteOutline;

                        Trainers trainer = new Trainers();
                        trainer.Name = txtNewTrainerName.Text;
                        trainer.Role = trainer_role;
                        trainer.CV = byteCV;

                        if(byteProfile!=null)
                        {
                            trainer.Profile = byteProfile;
                        }
                        else
                        {
                            trainer.Profile = ImageToByte((Bitmap)Properties.Resources.profile_sample1);
                        }

                        trainer.Mode = trainer_mode;

                        trainer.ModeValue = txtNewTrainerModeValue.Text;
                        trainer.cv_file_type = CV_TYPE;
                        db.Courses.Add(course);
                        db.Trainers.Add(trainer);
                        db.SaveChanges();
                        this.RefreshLists();
                        SAVED = true;
                    }
                    else
                    {
                        MessageBox.Show("Please upload a trainer CV!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    //New Existing Trainer Side
                    //Courses Start
                    Courses course = new Courses();
                    course.CourseCode = txtCourseCode.Text;
                    course.CourseName = txtCourseName.Text;
                    course.Duration = CourseDuration;
                    course.EntryDate = txtCourseEntry.Text;
                    course.Status = "Pending";
                    course.Trainer = TrainerName;
                    course.Mode = CourseMode;
                    course.outline_file_type = OUTLINE_FILE_TYPE;
                    course.Revenue = 0;

                    course.Outline = byteOutline;
                    //Courses End

                    db.Courses.Add(course);
                    db.SaveChanges();
                    this.RefreshLists();
                    SAVED = true;
                }
            }
            else
            {
                MessageBox.Show("Please upload a course outline!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        #region comboExistsingList_SelectedValueChanged
        private void comboExistsingList_SelectedValueChanged(object sender, EventArgs e)
        {
            var find = db.Trainers.Where(c => c.Name==comboExistsingList.SelectedItem.ToString()).Select(c => c.Profile).FirstOrDefault();

            
            using (var ms = new MemoryStream(find))
            {
                ExistingTrainerImage.Image = Image.FromStream(ms);
            }
            TrainerName = comboExistsingList.SelectedItem.ToString();
        }
        #endregion

        #region RefreshLists
        private void RefreshLists()
        {
            db.Dispose();
            DbEntities dbrefresh = new DbEntities();
            Lists.CoursesList = dbrefresh.Courses.ToList();
            Lists.TrainersList = dbrefresh.Trainers.ToList();
        }
        #endregion

        #region AddCourse_FormClosing Event
        private void AddCourse_FormClosing(object sender, FormClosedEventArgs e)
        {
            this.RefreshLists();
        }
         #endregion

        private void ComboCourseDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseDuration = ComboCourseDuration.SelectedItem.ToString();
        }



    }
}