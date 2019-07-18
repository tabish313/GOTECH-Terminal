namespace GOTECH.Home
{
    partial class SearchBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBox));
            this.panelTop = new System.Windows.Forms.Panel();
            this.LabelText = new GOTECH.Utils.ServoLabel();
            this.CloseButton = new GOTECH.Utils.ServoImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpageStudents = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStdContact = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStdEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStdFName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStdName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStdId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCourses = new System.Windows.Forms.TabPage();
            this.btnCVSave = new System.Windows.Forms.Button();
            this.txtCourseStatus = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCourseDuration = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCourseDate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCourseTrainerName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCourseName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCourseOutline = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCourseCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dragControl1 = new GOTECH.Utils.DragControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progress1 = new GOTECH.Utils.Progress();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabpageStudents.SuspendLayout();
            this.tabPageCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.AllowDrop = true;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelTop.Controls.Add(this.LabelText);
            this.panelTop.Controls.Add(this.CloseButton);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(423, 38);
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
            this.LabelText.Size = new System.Drawing.Size(54, 17);
            this.LabelText.TabIndex = 5;
            this.LabelText.Text = "Search";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::GOTECH.Properties.Resources.Close_Window_white;
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(391, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(3);
            this.CloseButton.Size = new System.Drawing.Size(22, 20);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(421, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 437);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 2);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 437);
            this.panel4.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabpageStudents);
            this.tabControl1.Controls.Add(this.tabPageCourses);
            this.tabControl1.Location = new System.Drawing.Point(-9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 424);
            this.tabControl1.TabIndex = 7;
            // 
            // tabpageStudents
            // 
            this.tabpageStudents.Controls.Add(this.label5);
            this.tabpageStudents.Controls.Add(this.txtStdContact);
            this.tabpageStudents.Controls.Add(this.txtStdEmail);
            this.tabpageStudents.Controls.Add(this.txtStdFName);
            this.tabpageStudents.Controls.Add(this.txtStdName);
            this.tabpageStudents.Controls.Add(this.txtStdId);
            this.tabpageStudents.Controls.Add(this.label4);
            this.tabpageStudents.Controls.Add(this.label3);
            this.tabpageStudents.Controls.Add(this.label2);
            this.tabpageStudents.Controls.Add(this.label1);
            this.tabpageStudents.Location = new System.Drawing.Point(4, 25);
            this.tabpageStudents.Name = "tabpageStudents";
            this.tabpageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageStudents.Size = new System.Drawing.Size(431, 395);
            this.tabpageStudents.TabIndex = 0;
            this.tabpageStudents.Text = "tabpageStudents";
            this.tabpageStudents.UseVisualStyleBackColor = true;
            this.tabpageStudents.Click += new System.EventHandler(this.tabpageStudents_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(74, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Contact:";
            // 
            // txtStdContact
            // 
            this.txtStdContact.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStdContact.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtStdContact.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtStdContact.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtStdContact.BorderThickness = 1;
            this.txtStdContact.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStdContact.Cursor = System.Windows.Forms.Cursors.No;
            this.txtStdContact.Enabled = false;
            this.txtStdContact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStdContact.ForeColor = System.Drawing.Color.DimGray;
            this.txtStdContact.isPassword = false;
            this.txtStdContact.Location = new System.Drawing.Point(161, 232);
            this.txtStdContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtStdContact.MaxLength = 32767;
            this.txtStdContact.Name = "txtStdContact";
            this.txtStdContact.Size = new System.Drawing.Size(232, 30);
            this.txtStdContact.TabIndex = 3;
            this.txtStdContact.Text = "05";
            this.txtStdContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStdEmail
            // 
            this.txtStdEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStdEmail.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtStdEmail.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtStdEmail.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtStdEmail.BorderThickness = 1;
            this.txtStdEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStdEmail.Cursor = System.Windows.Forms.Cursors.No;
            this.txtStdEmail.Enabled = false;
            this.txtStdEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStdEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtStdEmail.isPassword = false;
            this.txtStdEmail.Location = new System.Drawing.Point(161, 180);
            this.txtStdEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtStdEmail.MaxLength = 32767;
            this.txtStdEmail.Name = "txtStdEmail";
            this.txtStdEmail.Size = new System.Drawing.Size(232, 30);
            this.txtStdEmail.TabIndex = 2;
            this.txtStdEmail.Text = "05";
            this.txtStdEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStdFName
            // 
            this.txtStdFName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStdFName.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtStdFName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtStdFName.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtStdFName.BorderThickness = 1;
            this.txtStdFName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStdFName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtStdFName.Enabled = false;
            this.txtStdFName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStdFName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStdFName.isPassword = false;
            this.txtStdFName.Location = new System.Drawing.Point(161, 128);
            this.txtStdFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStdFName.MaxLength = 32767;
            this.txtStdFName.Name = "txtStdFName";
            this.txtStdFName.Size = new System.Drawing.Size(232, 30);
            this.txtStdFName.TabIndex = 1;
            this.txtStdFName.Text = "05";
            this.txtStdFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStdName
            // 
            this.txtStdName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStdName.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtStdName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtStdName.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtStdName.BorderThickness = 1;
            this.txtStdName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStdName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtStdName.Enabled = false;
            this.txtStdName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStdName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStdName.isPassword = false;
            this.txtStdName.Location = new System.Drawing.Point(161, 76);
            this.txtStdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStdName.MaxLength = 32767;
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.Size = new System.Drawing.Size(232, 30);
            this.txtStdName.TabIndex = 0;
            this.txtStdName.Text = "05";
            this.txtStdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStdId
            // 
            this.txtStdId.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStdId.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtStdId.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtStdId.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtStdId.BorderThickness = 1;
            this.txtStdId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStdId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtStdId.Enabled = false;
            this.txtStdId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStdId.ForeColor = System.Drawing.Color.DimGray;
            this.txtStdId.isPassword = false;
            this.txtStdId.Location = new System.Drawing.Point(161, 24);
            this.txtStdId.Margin = new System.Windows.Forms.Padding(4);
            this.txtStdId.MaxLength = 32767;
            this.txtStdId.Name = "txtStdId";
            this.txtStdId.Size = new System.Drawing.Size(232, 30);
            this.txtStdId.TabIndex = 30;
            this.txtStdId.Text = "05";
            this.txtStdId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(95, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(38, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Father\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Student Id:";
            // 
            // tabPageCourses
            // 
            this.tabPageCourses.Controls.Add(this.btnCVSave);
            this.tabPageCourses.Controls.Add(this.txtCourseStatus);
            this.tabPageCourses.Controls.Add(this.txtCourseDuration);
            this.tabPageCourses.Controls.Add(this.label12);
            this.tabPageCourses.Controls.Add(this.txtCourseDate);
            this.tabPageCourses.Controls.Add(this.label11);
            this.tabPageCourses.Controls.Add(this.label6);
            this.tabPageCourses.Controls.Add(this.txtCourseTrainerName);
            this.tabPageCourses.Controls.Add(this.txtCourseName);
            this.tabPageCourses.Controls.Add(this.label10);
            this.tabPageCourses.Controls.Add(this.label7);
            this.tabPageCourses.Controls.Add(this.txtCourseOutline);
            this.tabPageCourses.Controls.Add(this.label9);
            this.tabPageCourses.Controls.Add(this.txtCourseCode);
            this.tabPageCourses.Controls.Add(this.label8);
            this.tabPageCourses.Location = new System.Drawing.Point(4, 25);
            this.tabPageCourses.Name = "tabPageCourses";
            this.tabPageCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourses.Size = new System.Drawing.Size(431, 395);
            this.tabPageCourses.TabIndex = 2;
            this.tabPageCourses.Text = "tabPageCourses";
            this.tabPageCourses.UseVisualStyleBackColor = true;
            // 
            // btnCVSave
            // 
            this.btnCVSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCVSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCVSave.Location = new System.Drawing.Point(332, 172);
            this.btnCVSave.Name = "btnCVSave";
            this.btnCVSave.Size = new System.Drawing.Size(60, 32);
            this.btnCVSave.TabIndex = 24;
            this.btnCVSave.Text = "Save";
            this.btnCVSave.UseVisualStyleBackColor = true;
            this.btnCVSave.Click += new System.EventHandler(this.btnCVSave_Click);
            // 
            // txtCourseStatus
            // 
            this.txtCourseStatus.BackColor = System.Drawing.Color.Silver;
            this.txtCourseStatus.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseStatus.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseStatus.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseStatus.BorderThickness = 1;
            this.txtCourseStatus.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseStatus.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseStatus.Enabled = false;
            this.txtCourseStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseStatus.ForeColor = System.Drawing.Color.Black;
            this.txtCourseStatus.isPassword = false;
            this.txtCourseStatus.Location = new System.Drawing.Point(160, 320);
            this.txtCourseStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseStatus.MaxLength = 32767;
            this.txtCourseStatus.Name = "txtCourseStatus";
            this.txtCourseStatus.Size = new System.Drawing.Size(232, 30);
            this.txtCourseStatus.TabIndex = 18;
            this.txtCourseStatus.Text = "05";
            this.txtCourseStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCourseDuration
            // 
            this.txtCourseDuration.BackColor = System.Drawing.Color.Silver;
            this.txtCourseDuration.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseDuration.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseDuration.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseDuration.BorderThickness = 1;
            this.txtCourseDuration.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseDuration.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseDuration.Enabled = false;
            this.txtCourseDuration.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseDuration.ForeColor = System.Drawing.Color.Black;
            this.txtCourseDuration.isPassword = false;
            this.txtCourseDuration.Location = new System.Drawing.Point(160, 265);
            this.txtCourseDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseDuration.MaxLength = 32767;
            this.txtCourseDuration.Name = "txtCourseDuration";
            this.txtCourseDuration.Size = new System.Drawing.Size(232, 30);
            this.txtCourseDuration.TabIndex = 18;
            this.txtCourseDuration.Text = "05";
            this.txtCourseDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(42, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Course Status:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCourseDate
            // 
            this.txtCourseDate.BackColor = System.Drawing.Color.Silver;
            this.txtCourseDate.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseDate.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseDate.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseDate.BorderThickness = 1;
            this.txtCourseDate.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseDate.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseDate.Enabled = false;
            this.txtCourseDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseDate.ForeColor = System.Drawing.Color.Black;
            this.txtCourseDate.isPassword = false;
            this.txtCourseDate.Location = new System.Drawing.Point(160, 127);
            this.txtCourseDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseDate.MaxLength = 32767;
            this.txtCourseDate.Name = "txtCourseDate";
            this.txtCourseDate.Size = new System.Drawing.Size(232, 30);
            this.txtCourseDate.TabIndex = 18;
            this.txtCourseDate.Text = "05";
            this.txtCourseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(20, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Course Duration:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(50, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Entry Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCourseTrainerName
            // 
            this.txtCourseTrainerName.BackColor = System.Drawing.Color.Silver;
            this.txtCourseTrainerName.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseTrainerName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseTrainerName.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseTrainerName.BorderThickness = 1;
            this.txtCourseTrainerName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseTrainerName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseTrainerName.Enabled = false;
            this.txtCourseTrainerName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseTrainerName.ForeColor = System.Drawing.Color.Black;
            this.txtCourseTrainerName.isPassword = false;
            this.txtCourseTrainerName.Location = new System.Drawing.Point(160, 219);
            this.txtCourseTrainerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseTrainerName.MaxLength = 32767;
            this.txtCourseTrainerName.Name = "txtCourseTrainerName";
            this.txtCourseTrainerName.Size = new System.Drawing.Size(232, 30);
            this.txtCourseTrainerName.TabIndex = 19;
            this.txtCourseTrainerName.Text = "05";
            this.txtCourseTrainerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtCourseName.ForeColor = System.Drawing.Color.Black;
            this.txtCourseName.isPassword = false;
            this.txtCourseName.Location = new System.Drawing.Point(160, 81);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseName.MaxLength = 32767;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(232, 30);
            this.txtCourseName.TabIndex = 19;
            this.txtCourseName.Text = "05";
            this.txtCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(42, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Trainer Name:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(42, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Course Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCourseOutline
            // 
            this.txtCourseOutline.BackColor = System.Drawing.Color.Silver;
            this.txtCourseOutline.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseOutline.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseOutline.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseOutline.BorderThickness = 1;
            this.txtCourseOutline.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseOutline.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseOutline.Enabled = false;
            this.txtCourseOutline.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseOutline.ForeColor = System.Drawing.Color.Black;
            this.txtCourseOutline.isPassword = false;
            this.txtCourseOutline.Location = new System.Drawing.Point(160, 173);
            this.txtCourseOutline.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseOutline.MaxLength = 32767;
            this.txtCourseOutline.Name = "txtCourseOutline";
            this.txtCourseOutline.Size = new System.Drawing.Size(165, 30);
            this.txtCourseOutline.TabIndex = 20;
            this.txtCourseOutline.Text = "05";
            this.txtCourseOutline.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(38, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Course Outline";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtCourseCode.ForeColor = System.Drawing.Color.Black;
            this.txtCourseCode.isPassword = false;
            this.txtCourseCode.Location = new System.Drawing.Point(160, 35);
            this.txtCourseCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseCode.MaxLength = 32767;
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(232, 30);
            this.txtCourseCode.TabIndex = 20;
            this.txtCourseCode.Text = "05";
            this.txtCourseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(38, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Course Code:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataSource = typeof(GOTECH.Data.Students);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelTop;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.progress1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 50);
            this.panel1.TabIndex = 37;
            // 
            // progress1
            // 
            this.progress1.LoaderImage = ((System.Drawing.Image)(resources.GetObject("progress1.LoaderImage")));
            this.progress1.LoaderText = "Saving";
            this.progress1.Location = new System.Drawing.Point(255, 10);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(140, 30);
            this.progress1.TabIndex = 38;
            this.progress1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(419, 2);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnDelete.BackgroundImage = global::GOTECH.Properties.Resources.Garbage_Closed_Black_padding_10px;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(1)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(170, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnClose.BackgroundImage = global::GOTECH.Properties.Resources.Close_Black_padding_10px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(1)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(214, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(423, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.SearchBox_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabpageStudents.ResumeLayout(false);
            this.tabpageStudents.PerformLayout();
            this.tabPageCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Utils.ServoImageButton CloseButton;
        private Utils.DragControl dragControl1;
        private Utils.ServoLabel LabelText;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpageStudents;
        private System.Windows.Forms.TabPage tabPageCourses;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStdContact;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStdEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStdFName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStdName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStdId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCVSave;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseDate;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseName;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseCode;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseDuration;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseTrainerName;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseOutline;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseStatus;
        private System.Windows.Forms.Label label12;
        private Utils.Progress progress1;
    }
}