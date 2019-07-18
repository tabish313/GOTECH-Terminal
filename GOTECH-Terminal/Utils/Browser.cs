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
    public partial class Browser : UserControl
    {
        public static string txt;
        public Browser()
        {
            InitializeComponent();
        }

        public string TextHTML
        {
            get
            {
                return txt;
            }
            set
            {
                this.webBrowser1.DocumentText = value;
                txt = value;
            }
        }
    }
}
