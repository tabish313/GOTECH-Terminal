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
using GOTECH.Home;
using GOTECH.Utils;
using GOTECH.Students;
using GOTECH.Crypto;
using GOTECH.Trainer;

namespace GOTECH.Startup
{
    public partial class FormLogin : Form
    {
        #region Variables
        public DbEntities db = null;
        public List<Users> UsersList = null;
        private BackgroundWorker bw;
        private BackgroundWorker Loginbw;
        private bool IsLogin = false;
        private string UserID = "";
        private string Password = "";
        #endregion

        #region COnstructor
        public FormLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Params/Shadows
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
        #endregion

        #region CLoseButtonClick
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        #endregion

        #region Textbox PlaceHolders
        private void txtboxUser_Enter(object sender, EventArgs e)
        {

            if (txtboxUser.Text == "User Id")
            {
                txtboxUser.Text = "";
            }


        }
        
        private void txtboxUser_Leave(object sender, EventArgs e)
        {
            if (txtboxUser.Text == "")
            {
                txtboxUser.Text = "User Id";
            }
        }

        private void txtboxPass_Enter(object sender, EventArgs e)
        {

            if (txtboxPass.Text == "Password")
            {
                txtboxPass.Text = "";
                txtboxPass.isPassword = true;
            }
        }

        private void txtboxPass_Leave(object sender, EventArgs e)
        {
            if (txtboxPass.Text == "")
            {
                txtboxPass.isPassword = false;
                txtboxPass.Text = "Password";
            }
        }
        #endregion

        #region Form Activated
        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.Focus();
        }
        #endregion

        #region Form Shown Event
        private void FormLogin_Shown(object sender, EventArgs e)
        {
            bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;

            if (!bw.IsBusy)
            {
                progress1.Visible = true;
                btnLogin.Cursor = Cursors.No;
                
                btnLogin.Enabled = false;
                bw.RunWorkerAsync();
            }
        }
        #endregion

        #region BackgroundWorker BW 
        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progress1.Visible = false;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Enabled = true;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            db = new DbEntities();
            UsersList = db.Users.ToList();
            Lists.UsersList = db.Users.ToList();
            Lists.TrainersList = db.Trainers.ToList();
            Lists.CoursesList = db.Courses.ToList();
            Lists.StudentsList = db.Students.ToList();
            Lists.BusinessPlansList = db.BusinessPlans.ToList();
            Lists.GoalsInfoList = db.GoalsInfo.ToList();
            Lists.GoalsList = db.Goals.ToList();
        }
        #endregion

        #region Button LoginClick
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Enabled)
            {
                DoLogin();
            }
        }
        #endregion

        #region Function DoLogin()
        private void DoLogin()
        {
            UserID = Gulipso.DataEncrypt(txtboxUser.Text);
            Password = Gulipso.DataEncrypt(txtboxPass.Text);
            Loginbw = new BackgroundWorker();
            Loginbw.DoWork += Loginbw_DoWork;
            Loginbw.RunWorkerCompleted += Loginbw_RunWorkerCompleted;

            if (!Loginbw.IsBusy)
            {
                progress1.LoaderText = "Please Wait";
                progress1.Visible = true;
                btnLogin.Cursor = Cursors.No;
                btnLogin.Enabled = false;
                Loginbw.RunWorkerAsync();
            }
        }
        #endregion

        #region BackgroundWorker Loginbw
        void Loginbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (IsLogin)
            {
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Invalid Credentials!", "GO Tech Softibication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            progress1.Visible = false;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Enabled = true;
        }

        void Loginbw_DoWork(object sender, DoWorkEventArgs e)
        {
            
            var user = db.Users.Where(c => c.UserId == UserID && c.Password ==Password ).FirstOrDefault();

            if (user != null)
            {
                IsLogin = true;
            }
            else
            {
                IsLogin = false;
            }
        }
        #endregion

        #region Form KeyPress
        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!bw.IsBusy)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    DoLogin();

                    e.Handled = true;
                }
            }
        }
        #endregion

        private void servoImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void servoImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_EnabledChanged(object sender, EventArgs e)
        {
            if(btnLogin.Enabled)
            {
                btnLogin.BackColor = Color.FromArgb(192, 192, 1);
                btnLogin.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 1);
                
                btnLogin.Cursor = Cursors.Hand;
            }
            else
            {
                btnLogin.BackColor = SystemColors.ActiveBorder;
                btnLogin.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
                btnLogin.Cursor = Cursors.No;
            }
        }
    }
}