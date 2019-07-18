using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace GOTECH.Utils
{
    [DefaultEvent("Click")]
    [ProvideProperty("ServoFramework", typeof(Control))]
    public class ServoFlatButton : UserControl
    {
        #region Variables
        private Image image_0;

        public Color colbackground = Color.SkyBlue;

        public Color colhover = Color.LightSkyBlue;

        public Color colselected = Color.SkyBlue;

		private bool bool_0;

		private int int_0;

		private bool bool_1 = true;

		private Color color_0 = Color.Gray;

		private Color color_1 = Color.Transparent;

		private int int_1;

		private int int_2;

		private double double_0 = 90;

		private double double_1;

		private Color color_2 = Color.White;

		private Color color_3 = Color.White;

		private bool bool_2;

		private Image image_1;

		private Image image_2;

		private IContainer icontainer_0;

		private ImageList imageList_0;

		public PictureBox limage;

		public PictureBox rimage;

		private ServoLabel txttext;

        private EventHandler eventHandler_0;
        private IContainer components;

        private EventHandler eventHandler_1;
        #endregion

        #region Properties
        public Color Activecolor
		{
			get
			{
				return this.colselected;
			}
			set
			{
				this.colselected = value;
			}
		}

		public int BorderRadius
		{
			get
			{
				return this.int_0;
			}
			set
			{
				int num = 0;
				int num1 = 0;
				int num2;
				if (value >= 50)
				{
					do
					{
						if (num != num1)
						{
							break;
						}
						num1 = 1;
						num2 = num;
						num = 1;
					}
					while (1 <= num2);
				}
				else
				{
					this.int_0 = value;
					Elipse.Apply(this, this.int_0);
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ButtonText
		{
			get
			{
				return this.txttext.Text;
			}
			set
			{
				this.txttext.Text = value;
			}
		}

		public new Color DisabledColor
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
			}
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public new bool Enabled
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
				if (value)
				{
					this.BackColor = this.Normalcolor;
					return;
				}
				this.BackColor = this.color_0;
			}
		}

		public Color Iconcolor
		{
			get
			{
				return this.limage.BackColor;
			}
			set
			{
				this.color_1 = value;
				this.limage.BackColor = value;
			}
		}

		public Image Iconimage
		{
			get
			{
				return this.limage.Image;
			}
			set
			{
				this.limage.Image = value;
				this.image_1 = value;
				this.OnResize(new EventArgs());
			}
		}

		public Image Iconimage_right
		{
			get
			{
				return this.rimage.Image;
			}
			set
			{
				this.rimage.Image = value;
				this.image_2 = value;
				this.OnResize(new EventArgs());
			}
		}

		public Image Iconimage_right_Selected
		{
			get
			{
				return (Image)this.rimage.Tag;
			}
			set
			{
				this.rimage.Tag = value;
				this.OnResize(new EventArgs());
			}
		}

		public Image Iconimage_Selected
		{
			get
			{
				return (Image)this.limage.Tag;
			}
			set
			{
				this.limage.Tag = value;
				this.OnResize(new EventArgs());
			}
		}

		public int IconMarginLeft
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
				this.ServoFlatButton_Resize(this, new EventArgs());
			}
		}

		public int IconMarginRight
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
				this.ServoFlatButton_Resize(this, new EventArgs());
			}
		}

		public bool IconRightVisible
		{
			get
			{
				return this.rimage.Visible;
			}
			set
			{
				this.rimage.Visible = value;
				this.method_0();
			}
		}

		public double IconRightZoom
		{
			get
			{
				return this.double_1;
			}
			set
			{
				this.double_1 = value;
				this.method_2();
			}
		}

		public bool IconVisible
		{
			get
			{
				return this.limage.Visible;
			}
			set
			{
				this.limage.Visible = value;
				this.method_0();
			}
		}

		public double IconZoom
		{
			get
			{
				return this.double_0;
			}
			set
			{
				this.double_0 = value;
				this.method_1();
			}
		}

		public bool IsTab
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public Color Normalcolor
		{
			get
			{
				return this.colbackground;
			}
			set
			{
				this.BackColor = value;
				this.colbackground = value;
			}
		}

		public Color OnHovercolor
		{
			get
			{
				return this.colhover;
			}
			set
			{
				this.colhover = value;
			}
		}

		public Color OnHoverTextColor
		{
			get
			{
				return this.color_2;
			}
			set
			{
				this.color_2 = value;
			}
		}

		public bool selected
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				int num = 0;
				int num1 = 0;
				int num2;
				this.bool_2 = value;
				if (!this.bool_2)
				{
					this.BackColor = this.colbackground;
					if (this.Iconimage_Selected != null)
					{
						this.limage.Image = this.image_1;
					}
					if (this.Iconimage_right_Selected == null)
					{
						do
						{
							if (num != num1)
							{
								break;
							}
							num1 = 1;
							num2 = num;
							num = 1;
						}
						while (1 <= num2);
						return;
					}
					this.rimage.Image = this.image_2;
					return;
				}
				else
				{
					this.BackColor = this.colselected;
					if (this.Iconimage_Selected != null)
					{
						this.limage.Image = this.Iconimage_Selected;
					}
					if (this.Iconimage_right_Selected != null)
					{
						this.rimage.Image = this.Iconimage_right_Selected;
						return;
					}
				}
				do
				{
					if (num != num1)
					{
						break;
					}
					num1 = 1;
					num2 = num;
					num = 1;
				}
				while (1 <= num2);
			}
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override string Text
		{
			get
			{
				return this.ButtonText;
			}
			set
			{
				this.ButtonText = value;
			}
		}

		public ContentAlignment TextAlign
		{
			get
			{
				return this.txttext.TextAlign;
			}
			set
			{
				this.txttext.TextAlign = value;
			}
		}

		public Color Textcolor
		{
			get
			{
				return this.txttext.ForeColor;
			}
			set
			{
				this.color_3 = value;
				this.txttext.ForeColor = value;
			}
		}

		public System.Drawing.Font TextFont
		{
			get
			{
				return this.txttext.Font;
			}
			set
			{
				this.txttext.Font = value;
				this.method_0();
			}
		}

        #endregion

        #region Constructor
        public ServoFlatButton()
		{
			int num = 0;
			int num1 = 0;
			int num2;
			this.InitializeComponent();
			if (!this.selected)
			{
				do
				{
					if (num != num1)
					{
						break;
					}
					num1 = 1;
					num2 = num;
					num = 1;
				}
				while (1 <= num2);
			}
			else
			{
				this.selected = true;
			}
		}

        #endregion

        #region Button Events
        private void ServoFlatButton_DoubleClick(object sender, EventArgs e)
		{
		}

		private void ServoFlatButton_Load(object sender, EventArgs e)
		{
			int num = 0;
			int num1 = 0;
			int num2;
			if (!this.bool_1)
			{
				this.BackColor = this.DisabledColor;
			}
			else
			{
				this.BackColor = this.Normalcolor;
			}
			if (!this.IsTab || !this.selected)
			{
				do
				{
					if (num != num1)
					{
						break;
					}
					num1 = 1;
					num2 = num;
					num = 1;
				}
				while (1 <= num2);
			}
			else
			{
				this.selected = true;
			}
		}

		private void ServoFlatButton_MouseClick(object sender, MouseEventArgs e)
		{
			if (!this.bool_1)
			{
				return;
			}
			this.bool_2 = true;
			this.BackColor = this.colselected;
			this.method_5();
		}

		private void ServoFlatButton_MouseEnter(object sender, EventArgs e)
		{
			if (!this.bool_1)
			{
				this.BackColor = this.DisabledColor;
				return;
			}
			this.txttext.ForeColor = this.color_2;
			this.limage.BackColor = Color.Transparent;
			this.BackColor = this.colhover;
		}

		private void ServoFlatButton_MouseLeave(object sender, EventArgs e)
		{
			if (!this.bool_1)
			{
				this.BackColor = this.DisabledColor;
				return;
			}
			if (!this.bool_0)
			{
				this.BackColor = this.colbackground;
			}
			else if (!this.bool_2)
			{
				this.BackColor = this.colbackground;
				if (this.Iconimage_Selected != null)
				{
					this.limage.Image = this.image_1;
				}
				if (this.Iconimage_right_Selected != null)
				{
					this.rimage.Image = this.image_2;
				}
			}
			else
			{
				this.BackColor = this.colselected;
				if (this.Iconimage_Selected != null)
				{
					this.limage.Image = this.Iconimage_Selected;
				}
				if (this.Iconimage_right_Selected != null)
				{
					this.rimage.Image = this.Iconimage_right_Selected;
				}
			}
			this.txttext.ForeColor = this.color_3;
			this.limage.BackColor = this.color_1;
		}

		private void ServoFlatButton_Resize(object sender, EventArgs e)
		{
			if (this.limage.Image != null)
			{
				this.limage.Width = this.limage.Height;
			}
			else
			{
				this.limage.Width = 0;
			}
			if (this.rimage.Image != null)
			{
				this.rimage.Width = this.rimage.Height;
			}
			else
			{
				this.rimage.Width = 0;
			}
			this.rimage.Top = base.Height / 2 - this.rimage.Height / 2;
			this.limage.Top = this.rimage.Top;
			if (this.IconMarginLeft <= 0)
			{
				this.limage.Left = this.limage.Top;
			}
			else
			{
				this.limage.Left = this.IconMarginLeft;
			}
			if (this.IconMarginRight <= 0)
			{
				this.rimage.Left = base.Width - this.rimage.Width - this.rimage.Top;
			}
			else
			{
				this.rimage.Left = this.IconMarginRight;
			}
			this.txttext.Top = base.Height / 2 - this.txttext.Height / 2;
			this.method_0();
			Elipse.Apply(this, this.int_0);
		}

#endregion

        #region Dispose
        protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}
        #endregion

        #region InitializeComponent 
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.limage = new System.Windows.Forms.PictureBox();
            this.rimage = new System.Windows.Forms.PictureBox();
            this.txttext = new ServoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.limage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList_0
            // 
            this.imageList_0.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_0.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // limage
            // 
            this.limage.BackColor = System.Drawing.Color.Transparent;
            this.limage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.limage.Location = new System.Drawing.Point(0, 0);
            this.limage.Name = "limage";
            this.limage.Size = new System.Drawing.Size(50, 48);
            this.limage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.limage.TabIndex = 1;
            this.limage.TabStop = false;
            this.limage.Click += new System.EventHandler(this.txttext_Click);
            this.limage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ServoFlatButton_MouseClick);
            this.limage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.limage_MouseDoubleClick);
            this.limage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseDown);
            this.limage.MouseEnter += new System.EventHandler(this.ServoFlatButton_MouseEnter);
            this.limage.MouseLeave += new System.EventHandler(this.ServoFlatButton_MouseLeave);
            this.limage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseUp);
            // 
            // rimage
            // 
            this.rimage.BackColor = System.Drawing.Color.Transparent;
            this.rimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rimage.Location = new System.Drawing.Point(191, 0);
            this.rimage.Name = "rimage";
            this.rimage.Size = new System.Drawing.Size(50, 48);
            this.rimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rimage.TabIndex = 3;
            this.rimage.TabStop = false;
            this.rimage.Click += new System.EventHandler(this.txttext_Click);
            this.rimage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseDown);
            this.rimage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseUp);
            // 
            // txttext
            // 
            this.txttext.AutoEllipsis = true;
            this.txttext.AutoSize = true;
            this.txttext.BackColor = System.Drawing.Color.Transparent;
            this.txttext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttext.ForeColor = System.Drawing.Color.White;
            this.txttext.Location = new System.Drawing.Point(62, 16);
            this.txttext.Name = "txttext";
            this.txttext.Size = new System.Drawing.Size(116, 17);
            this.txttext.TabIndex = 4;
            this.txttext.Text = "Servo Flat Button";
            this.txttext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txttext.Click += new System.EventHandler(this.txttext_Click);
            this.txttext.DoubleClick += new System.EventHandler(this.txttext_DoubleClick);
            this.txttext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ServoFlatButton_MouseClick);
            this.txttext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseDown);
            this.txttext.MouseEnter += new System.EventHandler(this.ServoFlatButton_MouseEnter);
            this.txttext.MouseLeave += new System.EventHandler(this.ServoFlatButton_MouseLeave);
            this.txttext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseUp);
            // 
            // ServoFlatButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.limage);
            this.Controls.Add(this.rimage);
            this.Controls.Add(this.txttext);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "ServoFlatButton";
            this.Size = new System.Drawing.Size(241, 48);
            this.Load += new System.EventHandler(this.ServoFlatButton_Load);
            this.DoubleClick += new System.EventHandler(this.ServoFlatButton_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ServoFlatButton_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ServoFlatButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ServoFlatButton_MouseLeave);
            this.Resize += new System.EventHandler(this.ServoFlatButton_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.limage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

        #region limage_MouseDoubleClick
        private void limage_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}
        #endregion

        #region method_0
        private void method_0()
		{
			if (!this.limage.Visible)
			{
				this.txttext.Left = 0;
			}
			else
			{
				this.txttext.Left = this.limage.Right;
			}
			if (!this.rimage.Visible)
			{
				this.txttext.Width = base.Width - this.txttext.Left;
				return;
			}
			this.txttext.Width = this.rimage.Left - this.txttext.Left;
		}
        #endregion

        #region method_1
        private void method_1()
		{
			double height = (double)base.Height;
			double num = Math.Round(this.double_0 / 100 * height, 0);
			PictureBox pictureBox = this.limage;
			PictureBox pictureBox1 = this.rimage;
			int num1 = int.Parse(num.ToString());
			int num2 = num1;
			pictureBox1.Height = num1;
			pictureBox.Height = num2;
			this.OnResize(new EventArgs());
		}
        #endregion

        #region method_2
        private void method_2()
		{
			double height = (double)base.Height;
			double num = Math.Round(this.double_1 / 100 * height, 0);
			PictureBox pictureBox = this.rimage;
			PictureBox pictureBox1 = this.rimage;
			int num1 = int.Parse(num.ToString());
			int num2 = num1;
			pictureBox1.Height = num1;
			pictureBox.Height = num2;
			this.OnResize(new EventArgs());
		}
        #endregion

        #region method_3
        private void method_3(object sender, PaintEventArgs e)
		{
		}
        #endregion

        #region method_4
        private void method_4(object sender, EventArgs e)
		{
		}
 #endregion

        #region method_5
        private void method_5()
		{
			int num = 0;
			int num1 = 0;
			int num2;
			foreach (Control control in base.Parent.Controls)
			{
				if (!(control.GetType() == typeof(ServoFlatButton)) || !((ServoFlatButton)control).IsTab || !(((ServoFlatButton)control).Name != base.Name) || base.Parent != ((ServoFlatButton)control).Parent || !((ServoFlatButton)control).Enabled)
				{
					continue;
				}
				((ServoFlatButton)control).selected = false;
			}
			do
			{
				if (num != num1)
				{
					break;
				}
				num1 = 1;
				num2 = num;
				num = 1;
			}
			while (1 <= num2);
		}
        #endregion

        #region Missecalleoneuos
        public void reset()
		{
			this.bool_2 = false;
			this.BackColor = this.colbackground;
		}

		private void txttext_Click(object sender, EventArgs e)
		{
			if (!this.bool_1)
			{
				return;
			}
			base.OnClick(e);
		}

		private void txttext_DoubleClick(object sender, EventArgs e)
		{
			if (!this.bool_1)
			{
				return;
			}
			base.OnDoubleClick(e);
		}

		private void txttext_MouseDown(object sender, MouseEventArgs e)
		{
			int num = 0;
			int num1 = 0;
			int num2;
			if (!this.bool_1)
			{
				return;
			}
			if (this.eventHandler_0 == null)
			{
				do
				{
					if (num != num1)
					{
						break;
					}
					num1 = 1;
					num2 = num;
					num = 1;
				}
				while (1 <= num2);
			}
			else
			{
				this.eventHandler_0(this, e);
			}
		}

		private void txttext_MouseUp(object sender, MouseEventArgs e)
		{
			int num = 0;
			int num1 = 0;
			int num2;
			if (!this.bool_1)
			{
				return;
			}
			if (this.eventHandler_1 == null)
			{
				do
				{
					if (num != num1)
					{
						break;
					}
					num1 = 1;
					num2 = num;
					num = 1;
				}
				while (1 <= num2);
			}
			else
			{
				this.eventHandler_1(this, e);
			}
		}
        #endregion

        #region EventHandlers
        public event EventHandler MouseDown
		{
			add
			{
				EventHandler eventHandler;
				EventHandler eventHandler0 = this.eventHandler_0;
				do
				{
					eventHandler = eventHandler0;
					EventHandler eventHandler1 = (EventHandler)Delegate.Combine(eventHandler, value);
					eventHandler0 = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler1, eventHandler);
				}
				while ((object)eventHandler0 != (object)eventHandler);
			}
			remove
			{
				EventHandler eventHandler;
				EventHandler eventHandler0 = this.eventHandler_0;
				do
				{
					eventHandler = eventHandler0;
					EventHandler eventHandler1 = (EventHandler)Delegate.Remove(eventHandler, value);
					eventHandler0 = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, eventHandler1, eventHandler);
				}
				while ((object)eventHandler0 != (object)eventHandler);
			}
		}

		public event EventHandler MouseUp
		{
			add
			{
				EventHandler eventHandler;
				EventHandler eventHandler1 = this.eventHandler_1;
				do
				{
					eventHandler = eventHandler1;
					EventHandler eventHandler2 = (EventHandler)Delegate.Combine(eventHandler, value);
					eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, eventHandler2, eventHandler);
				}
				while ((object)eventHandler1 != (object)eventHandler);
			}
			remove
			{
				EventHandler eventHandler;
				EventHandler eventHandler1 = this.eventHandler_1;
				do
				{
					eventHandler = eventHandler1;
					EventHandler eventHandler2 = (EventHandler)Delegate.Remove(eventHandler, value);
					eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, eventHandler2, eventHandler);
				}
				while ((object)eventHandler1 != (object)eventHandler);
			}
        }

        #endregion
    }
}
