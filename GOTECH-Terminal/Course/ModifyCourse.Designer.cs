namespace GOTECH.Course
{
    partial class ModifyCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyCourse));
            this.panelTop = new System.Windows.Forms.Panel();
            this.LabelText = new GOTECH.Utils.ServoLabel();
            this.CloseButton = new GOTECH.Utils.ServoImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progress1 = new GOTECH.Utils.Progress();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCourseCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dragControl1 = new GOTECH.Utils.DragControl();
            this.txtCourseName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourseStd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCourseRevenue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ComboCourseStatus = new GOTECH.Utils.CustomComboBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.AllowDrop = true;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelTop.Controls.Add(this.LabelText);
            this.panelTop.Controls.Add(this.CloseButton);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(2, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(419, 38);
            this.panelTop.TabIndex = 0;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.BackColor = System.Drawing.Color.Transparent;
            this.LabelText.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.LabelText.ForeColor = System.Drawing.Color.White;
            this.LabelText.Location = new System.Drawing.Point(12, 11);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(101, 17);
            this.LabelText.TabIndex = 5;
            this.LabelText.Text = "Course Name";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::GOTECH.Properties.Resources.Close_Window_white;
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(387, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(3);
            this.CloseButton.Size = new System.Drawing.Size(22, 20);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.progress1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 50);
            this.panel1.TabIndex = 6;
            // 
            // progress1
            // 
            this.progress1.LoaderImage = ((System.Drawing.Image)(resources.GetObject("progress1.LoaderImage")));
            this.progress1.LoaderText = "Saving";
            this.progress1.Location = new System.Drawing.Point(284, 10);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(111, 30);
            this.progress1.TabIndex = 6;
            this.progress1.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(1)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(141, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(421, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 346);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 2);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 344);
            this.panel4.TabIndex = 0;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.BackColor = System.Drawing.Color.Silver;
            this.txtCourseCode.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseCode.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseCode.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseCode.BorderThickness = 1;
            this.txtCourseCode.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseCode.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseCode.Enabled = false;
            this.txtCourseCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtCourseCode.isPassword = false;
            this.txtCourseCode.Location = new System.Drawing.Point(153, 58);
            this.txtCourseCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseCode.MaxLength = 32767;
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(232, 30);
            this.txtCourseCode.TabIndex = 0;
            this.txtCourseCode.Text = "05";
            this.txtCourseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(34, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Course Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(31, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Course Name:";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataSource = typeof(GOTECH.Data.Students);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelTop;
            // 
            // txtCourseName
            // 
            this.txtCourseName.BackColor = System.Drawing.Color.Silver;
            this.txtCourseName.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseName.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseName.BorderThickness = 1;
            this.txtCourseName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseName.Enabled = false;
            this.txtCourseName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseName.ForeColor = System.Drawing.Color.DimGray;
            this.txtCourseName.isPassword = false;
            this.txtCourseName.Location = new System.Drawing.Point(153, 103);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseName.MaxLength = 32767;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(232, 30);
            this.txtCourseName.TabIndex = 1;
            this.txtCourseName.Text = "05";
            this.txtCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(62, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Revenue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(65, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Students:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(83, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status:";
            // 
            // txtCourseStd
            // 
            this.txtCourseStd.BackColor = System.Drawing.Color.Silver;
            this.txtCourseStd.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseStd.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseStd.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseStd.BorderThickness = 1;
            this.txtCourseStd.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseStd.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseStd.Enabled = false;
            this.txtCourseStd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseStd.ForeColor = System.Drawing.Color.DimGray;
            this.txtCourseStd.isPassword = false;
            this.txtCourseStd.Location = new System.Drawing.Point(153, 144);
            this.txtCourseStd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseStd.MaxLength = 32767;
            this.txtCourseStd.Name = "txtCourseStd";
            this.txtCourseStd.Size = new System.Drawing.Size(232, 30);
            this.txtCourseStd.TabIndex = 2;
            this.txtCourseStd.Text = "05";
            this.txtCourseStd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCourseRevenue
            // 
            this.txtCourseRevenue.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseRevenue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseRevenue.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseRevenue.BorderThickness = 1;
            this.txtCourseRevenue.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseRevenue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseRevenue.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseRevenue.isPassword = false;
            this.txtCourseRevenue.Location = new System.Drawing.Point(153, 188);
            this.txtCourseRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseRevenue.MaxLength = 32767;
            this.txtCourseRevenue.Name = "txtCourseRevenue";
            this.txtCourseRevenue.Size = new System.Drawing.Size(232, 30);
            this.txtCourseRevenue.TabIndex = 3;
            this.txtCourseRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ComboCourseStatus
            // 
            this.ComboCourseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCourseStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ComboCourseStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboCourseStatus.FormattingEnabled = true;
            this.ComboCourseStatus.Items.AddRange(new object[] {
            "Pending",
            "Certified"});
            this.ComboCourseStatus.Location = new System.Drawing.Point(153, 236);
            this.ComboCourseStatus.Margin = new System.Windows.Forms.Padding(10);
            this.ComboCourseStatus.Name = "ComboCourseStatus";
            this.ComboCourseStatus.Size = new System.Drawing.Size(232, 25);
            this.ComboCourseStatus.TabIndex = 4;
            this.ComboCourseStatus.SelectedIndexChanged += new System.EventHandler(this.ComboCourseStatus_SelectedIndexChanged);
            // 
            // ModifyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(423, 346);
            this.Controls.Add(this.ComboCourseStatus);
            this.Controls.Add(this.txtCourseRevenue);
            this.Controls.Add(this.txtCourseStd);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyCourse";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.ModifyCourse_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Utils.ServoImageButton CloseButton;
        private Utils.DragControl dragControl1;
        private Utils.ServoLabel LabelText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseStd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseRevenue;
        private Utils.CustomComboBox ComboCourseStatus;
        private Utils.Progress progress1;
    }
}