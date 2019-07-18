using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace GOTECH.Utils
{
    [DefaultEvent("Click")]
    public class ServoImageButton : PictureBox
    {
        private int int_0 = 10;

		private System.Drawing.Image image_0;

		private System.Drawing.Image image_1;

		private IContainer icontainer_0;

		public System.Drawing.Image ImageActive
		{
			get
			{
				return this.image_0;
			}
			set
			{
				this.image_0 = value;
			}
		}

		public int Zoom
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public ServoImageButton()
		{
			this.method_0();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.BackColor = Color.SeaGreen;
			base.Size = new System.Drawing.Size(71, 71);
            base.BackColor = Color.SkyBlue;
			base.SizeMode = PictureBoxSizeMode.Zoom;
            base.Padding = new Padding(3, 3, 3, 3);
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		protected override void OnClick(EventArgs e)
		{
			if (this.image_0 != null)
			{
				base.Image = this.image_1;
			}
			Styles.ZoomOut(this);
			base.OnClick(e);
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			if (this.image_0 != null)
			{
				this.image_1 = base.Image;
				base.Image = this.image_0;
			}
			Styles.ZoomIn(this, this.int_0);
			base.OnMouseEnter(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			if (this.image_0 != null)
			{
				base.Image = this.image_1;
			}
			Styles.ZoomOut(this);
			base.OnMouseLeave(e);
		}
    }
}
