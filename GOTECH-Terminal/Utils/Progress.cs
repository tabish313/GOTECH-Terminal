using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Utils
{
    public partial class Progress : UserControl
    {

        private string _LoaderText = null;
        private Image _LoaderImage = null;

        public string LoaderText
        {
            get
            {
                return _LoaderText;
            }
            set
            {
                this._LoaderText = value;
                this.servoLabel1.Text = value;
            }
        }

        public Image LoaderImage
        {
            get
            {
                return _LoaderImage;
            }
            set
            {
                this._LoaderImage = value;
                this.pictureBox1.Image = value;   
            }
        }

        public Progress()
        {
            InitializeComponent();
            LoaderText = "Loading";
            LoaderImage = Properties.Resources.loader_white;
        }
    }
}
