using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Help
{
    public partial class Import : Form
    {
        private BackgroundWorker bw;

        private OpenFileDialog filedialog;

        private string databasepath = Application.StartupPath + @"/Database/";

        private string DatabaseName = "Database.data";

        private string backupName = "Backup.data";

        private string tempName = "temp.data";

        private bool HasFile = false;

        public Import()
        {
            InitializeComponent();
            HasFile = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            filedialog = new OpenFileDialog();
            filedialog.Filter = "DATA files (*.data)|*.data*";
            filedialog.Title = "Select your backup file..";

            DialogResult result = filedialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtDatabaseName.Text = filedialog.FileName;
                HasFile = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (HasFile)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to import database? \r\nYour current data will be overwrited or deleted!", "Import Confirmation - GO TECH Terminal", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    bw = new BackgroundWorker();
                    bw.DoWork += bw_DoWork;
                    bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                    if (!bw.IsBusy)
                    {
                        btnSave.Enabled = false;
                        progress1.Visible = true;
                        bw.RunWorkerAsync();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select your backup file!", "Import - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        bool done = false;
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (File.Exists(databasepath + tempName))
                {
                    File.Delete(databasepath + tempName);
                }

                File.Copy(filedialog.FileName, databasepath + tempName);

                File.Delete(databasepath + DatabaseName);

                File.Move(databasepath + tempName, databasepath + DatabaseName);
                done = true;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured while exporting!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSave.Enabled = true;
            progress1.Visible = false;

            if (done)
            {
                MessageBox.Show("Your database is successfully Imported! \r\nRestart may take effect \r\nYour app will be restarted!", "Export Successfull - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Application.Restart();
            }
        }
    }
}