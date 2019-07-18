using GOTECH.Crypto;
using GOTECH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Students
{
    public partial class NewStudent : Form
    {
        #region Vaiables
        private string Student_ID = "";

        private int Course_ID;

        private string COURSE_CODE = "";

        private DbEntities db;

        private BackgroundWorker bw;

        private string Student_Name = "";

        private string Student_FName = "";

        private string Student_CNIC = "";

        private string Student_Email = "";

        private string Student_Contact = "";

        #endregion

        #region Constructor
        public NewStudent(int COURSE_ID)
        {
            InitializeComponent();
            this.Course_ID = COURSE_ID;
        }
        #endregion

        #region Close Button Click
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Form Load
        private void NewStudent_Load(object sender, EventArgs e)
        {
            db = new DbEntities();


            txtStdId.Text = Student_ID = Generate_Student_ID();

        }
        #endregion

        #region Button Save Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStdName.Text != "" && txtStdFname.Text != "" && txtStdEmail.Text != "" && txtStdContact.Text != "" && txtStdCNIC.Text!="")
            {
                if (IsEmailValid(txtStdEmail.Text))
                {
                    if (isNumberValid(txtStdContact.Text))
                    {
                        if (IsCNICValid(txtStdCNIC.Text))
                        {
                            Student_Name = Regex.Replace(txtStdName.Text, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
                            Student_FName = Regex.Replace(txtStdFname.Text, @"(^\w)|(\s\w)", m => m.Value.ToUpper());

                            Student_Name = Gulipso.DataEncrypt(Student_Name);
                            Student_FName = Gulipso.DataEncrypt(Student_FName);
                            Student_Email = Gulipso.DataEncrypt(txtStdEmail.Text);
                            Student_Contact = Gulipso.DataEncrypt(txtStdContact.Text);
                            Student_CNIC = Gulipso.DataEncrypt(txtStdCNIC.Text);

                            bw = new BackgroundWorker();
                            bw.DoWork += bw_DoWork;
                            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                            if (!bw.IsBusy)
                            {
                                btnSave.Enabled = false;
                                btnSave.Text = "Saving";
                                bw.RunWorkerAsync();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student's CNIC is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contact number is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Background Completed Event
        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSave.Enabled = true;

            this.RefreshData();
            progress1.Visible = true;
            btnSave.Text = "Save";
        }
        #endregion

        #region BackgroundWorker DoWork
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Data.Students std = new Data.Students()
                {
                    Name = Student_Name,
                    FatherName = Student_FName,
                    Email = Student_Email,
                    Contact = Student_Contact,
                    Course_Id = Course_ID,
                    Student_Id = Student_ID,
                    CNIC=Student_CNIC
                };

                db.Students.Add(std);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region RefreshData
        private void RefreshData()
        {
            DbEntities dbrefresh = new DbEntities();
            Lists.StudentsList = dbrefresh.Students.ToList();
            dbrefresh.Dispose();
            txtStdId.Text = Student_ID = Generate_Student_ID();
            txtStdName.Text = "";
            txtStdFname.Text = "";
            txtStdEmail.Text = "";
            txtStdContact.Text = "";
        }
        #endregion

        #region txtstdname OnValueChanged Event
        private void txtStdName_OnValueChanged(object sender, EventArgs e)
        {
            if (progress1.Visible)
            {
                progress1.Visible = false;
            }
        }
        #endregion

        #region IsEmailValid Module
        public bool IsEmailValid(string emailaddress)
        {
            bool isEmail = false;
            try
            {
                isEmail = Regex.IsMatch(emailaddress, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

                return isEmail;
            }
            catch (FormatException)
            {
                return isEmail;
            }
        }
        #endregion

        #region Isnumbervalid Module
        public bool isNumberValid(string contact)
        {
            bool valid = false;

            long num;

            string[] dailers ={"0331","0332","0333","0334","0335","0336","0337",
                              "0300","0301","0302","0303","0304","0305","0306","0307","0308",
                               "0320","0321","0322",
                             "0340","0341","0342","0343","0344","0345","0346","0347","0348","0349",
                             "0310","0311","0312","0313","0314","0315","0316","0317"};
            try
            {
                for (int i = 0; i <= dailers.Length - 1; i++)
                {
                    if (contact.StartsWith(dailers[i].ToString()))
                    {
                        if (contact.Length == 11)
                        {
                            if (Int64.TryParse(contact, out num))
                            {
                                valid = true;
                                break;
                            }
                            else
                            {
                                valid = false;
                                break;
                            }
                        }
                        else
                        {
                            valid = false;
                            break;
                        }
                    }
                }
                return valid;

            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Student Id Generator
        public string Generate_Student_ID()
        {
            string retr = "";
            COURSE_CODE = Lists.CoursesList.Where(c => c.ID == Course_ID).Select(c => c.CourseCode).FirstOrDefault();

            try
            {
                string last = Lists.StudentsList.Where(c => c.Course_Id == Course_ID).Select(c => c.Student_Id).Last();

                last = last.Substring(COURSE_CODE.Length + 1, last.Length - (COURSE_CODE.Length + 1));

                int next = int.Parse(last) + 1;

                if (next < 10)
                {
                    retr = COURSE_CODE + "-" + "0" + next.ToString();
                }
                else
                {
                    retr = COURSE_CODE + "-" + next.ToString();
                }
            }
            catch (Exception)
            {
                retr = COURSE_CODE + "-01";
            }
            return retr;
        }
        #endregion

        #region CNIC Validator
        public bool IsCNICValid(string cnic)
        {
            long a;
            if (cnic == "nil" || cnic == "Nil" || cnic == "NIL")
            {
                return true;
            }
            else
            {
                if (cnic.Length == 13 && Int64.TryParse(cnic, out a))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion
    }
}