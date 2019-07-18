using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GOTECH.Utils
{
    public class ServoLabel : Label
    {
        public ServoLabel()
        {
            base.SetStyle(ControlStyles.UserPaint, true);
            base.ForeColor = Color.SteelBlue;
            base.Font = new Font("Century Gothic", 9, FontStyle.Regular);
            base.AutoSize = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (base.Enabled)
            {
                base.OnPaint(e);
                return;
            }
            SolidBrush solidBrush = new SolidBrush(this.ForeColor);
            e.Graphics.DrawString(this.Text, this.Font, solidBrush, 0f, 0f);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ServoLabel
            // 
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeLayout(false);

        }
    }
}
