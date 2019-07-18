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
    public partial class Export : Form
    {
        private string databasepath = Application.StartupPath + @"/Database/";

        private string DatabaseName = "Database.data";
       
        private FolderBrowserDialog folderBrowse;

        private BackgroundWorker bw;

        private string folderPath = "";

        private string tempName = "temp.data";

        public Export()
        {
            InitializeComponent();
        }

        private void Export_Load(object sender, EventArgs e)
        {
            long length = new System.IO.FileInfo(databasepath + DatabaseName).Length;

            if (Convert.ToInt32(ConvertBytesToKB(length)) > 1000)
            {
                txtDatabaseSize.Text = Math.Round(ConvertBytesToMB(length), 2).ToString() + " MB";
            }
            else
            {
                txtDatabaseSize.Text = Math.Round(ConvertBytesToKB(length), 2).ToString() + " KB";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            folderBrowse = new FolderBrowserDialog();

            DialogResult result = folderBrowse.ShowDialog();

            if(result==DialogResult.OK)
            {
                folderPath = folderBrowse.SelectedPath;
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

                File.Copy(databasepath + DatabaseName, databasepath + tempName);

                if (File.Exists(folderPath + @"\Backup.data"))
                {

                    DialogResult result = MessageBox.Show("Destination Directory already contain 'Backup.data' \r\nChoose if you want to overwrite the file or skip this transfer and keep existing file", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);


                    switch (result)
                    {
                        case DialogResult.Yes:
                            File.Delete(folderPath + @"\Backup.data");
                            File.Move(databasepath + tempName, folderPath + @"\Backup.data");
                            done = true;
                            break;

                        case DialogResult.No:
                            done = false;
                            return;

                        case DialogResult.Cancel:
                            done = false;
                            return;
                    }
                }
                else
                {
                    File.Move(databasepath + tempName, folderPath + @"\Backup.data");
                    done = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured while exporting!", "Error - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                done = false;
            }
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSave.Enabled = true;
            progress1.Visible = false;
            if (done)
            {
                MessageBox.Show("Your database is successfully exported to: " + folderPath + @"\Backup.data", "Export Successfull - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public double ConvertBytesToKB(long bytes)
        {
            return (bytes / 1024f);
        }

        public double ConvertBytesToMB(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

       
        
    }
}
