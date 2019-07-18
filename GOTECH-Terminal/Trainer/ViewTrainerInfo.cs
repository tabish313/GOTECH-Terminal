using GOTECH.Data;
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

namespace GOTECH.Trainer
{
    public partial class ViewTrainerInfo : Form
    {
        private List<Trainers> trainerList = Lists.TrainersList;

        private string TRAINER_NAME = "";

        private BackgroundWorker bw;

        private FolderBrowserDialog folderBrowser;

        public ViewTrainerInfo(string trainerName)
        {
            InitializeComponent();
            this.LabelText.Text = trainerName;
            this.TRAINER_NAME = trainerName;
        }

        private void ViewTrainerInfo_Load(object sender, EventArgs e)
        {
            var trainer = trainerList.Where(c => c.Name == TRAINER_NAME).FirstOrDefault();

            txtTrainerName.Text = TRAINER_NAME;
            txtTrainerCV.Text = trainer.Name + " CV" + trainer.cv_file_type;
            txtTrainerRole.Text = trainer.Role;

            if(trainer.Mode=="Income")
            {
                labelMode.Text = "Income:";
                txtTrainerModeValue.Text = trainer.ModeValue;
            }
            else
            {
                labelMode.Text = "Share:";
                txtTrainerModeValue.Text = trainer.ModeValue;
            }

            MemoryStream strem=new MemoryStream(trainer.Profile);
            trainerPic.Image = Image.FromStream(strem);

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
                if(!bw.IsBusy)
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
                var trainer = trainerList.Where(c => c.Name == TRAINER_NAME).FirstOrDefault();

                SaveCV(folderBrowser.SelectedPath, trainer.Name.ToString() + " CV", trainer.cv_file_type, trainer.CV);
            }
            catch(Exception)
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trainerPic_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}