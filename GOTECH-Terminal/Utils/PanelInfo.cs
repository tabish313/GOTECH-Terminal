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
    public partial class PanelInfo : UserControl
    {
        private string _PanelLabel;

        private string _Count;

        private Image _PanelImage;

        public PanelInfo()
        {
            InitializeComponent();
        }

        public string PanelLabel
        {
            get
            {
                return _PanelLabel;
            }
            set
            {
                this.label1.Text = value;
                _PanelLabel = value;
            }
        }

        public string Count
        {
            get
            {
                return _Count;
            }
            set
            {
                this.label2.Text = value;
                _Count = value;
            }
        }

        public Image PanelImage
        {
            get
            {
                return _PanelImage;
            }
            set
            {
                this.pictureBox1.Image = value;
                _PanelImage = value;
            }
        }
    }
}
