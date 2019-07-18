namespace GOTECH.Course
{
    partial class AddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.panelTop = new System.Windows.Forms.Panel();
            this.CloseButton = new GOTECH.Utils.ServoImageButton();
            this.labelText = new GOTECH.Utils.ServoLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCourseEntry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCourseName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCourseId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ComboCourseDuration = new GOTECH.Utils.CustomComboBox();
            this.btnOutlineUpload = new System.Windows.Forms.Button();
            this.txtCourseOutline = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCourseCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnTrainNew = new System.Windows.Forms.Button();
            this.btnTrainExisting = new System.Windows.Forms.Button();
            this.tabControlTrainer = new System.Windows.Forms.TabControl();
            this.tabTrainerNew = new System.Windows.Forms.TabPage();
            this.btnProfileUpload = new System.Windows.Forms.Button();
            this.btnCVUpload = new System.Windows.Forms.Button();
            this.txtNewTrainerProfile = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNewTrainerCV = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ComboNewTrainerRole = new GOTECH.Utils.CustomComboBox();
            this.ComboNewTrainerMode = new GOTECH.Utils.CustomComboBox();
            this.txtNewTrainerName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabTrainerExisting = new System.Windows.Forms.TabPage();
            this.ExistingTrainerImage = new GOTECH.Utils.OvalPictureBox();
            this.comboExistsingList = new GOTECH.Utils.CustomComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtNewTrainerModeValue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.labelDrop = new System.Windows.Forms.Label();
            this.dragControl1 = new GOTECH.Utils.DragControl();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControlTrainer.SuspendLayout();
            this.tabTrainerNew.SuspendLayout();
            this.tabTrainerExisting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExistingTrainerImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.AllowDrop = true;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelTop.Controls.Add(this.CloseButton);
            this.panelTop.Controls.Add(this.labelText);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(453, 38);
            this.panelTop.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::GOTECH.Properties.Resources.Close_Window_white;
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(422, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(3);
            this.CloseButton.Size = new System.Drawing.Size(22, 20);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 5;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(12, 11);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(87, 17);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Add Course";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(450, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 370);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 368);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 2);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 368);
            this.panel4.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Location = new System.Drawing.Point(5, 18);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(442, 286);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage1.Controls.Add(this.txtCourseEntry);
            this.tabPage1.Controls.Add(this.txtCourseName);
            this.tabPage1.Controls.Add(this.txtCourseId);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // txtCourseEntry
            // 
            this.txtCourseEntry.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseEntry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseEntry.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseEntry.BorderThickness = 1;
            this.txtCourseEntry.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseEntry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseEntry.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseEntry.isPassword = false;
            this.txtCourseEntry.Location = new System.Drawing.Point(163, 167);
            this.txtCourseEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseEntry.MaxLength = 32767;
            this.txtCourseEntry.Name = "txtCourseEntry";
            this.txtCourseEntry.Size = new System.Drawing.Size(232, 30);
            this.txtCourseEntry.TabIndex = 1;
            this.txtCourseEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCourseName
            // 
            this.txtCourseName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseName.BorderThickness = 1;
            this.txtCourseName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseName.isPassword = false;
            this.txtCourseName.Location = new System.Drawing.Point(163, 113);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseName.MaxLength = 32767;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(232, 30);
            this.txtCourseName.TabIndex = 0;
            this.txtCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCourseId
            // 
            this.txtCourseId.BackColor = System.Drawing.Color.Silver;
            this.txtCourseId.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseId.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseId.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseId.BorderThickness = 1;
            this.txtCourseId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseId.Enabled = false;
            this.txtCourseId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseId.ForeColor = System.Drawing.Color.DimGray;
            this.txtCourseId.isPassword = false;
            this.txtCourseId.Location = new System.Drawing.Point(163, 59);
            this.txtCourseId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseId.MaxLength = 32767;
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(232, 30);
            this.txtCourseId.TabIndex = 1;
            this.txtCourseId.Text = "05";
            this.txtCourseId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(61, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Entry Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(69, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Id:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPage2.Controls.Add(this.ComboCourseDuration);
            this.tabPage2.Controls.Add(this.btnOutlineUpload);
            this.tabPage2.Controls.Add(this.txtCourseOutline);
            this.tabPage2.Controls.Add(this.txtCourseCode);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // ComboCourseDuration
            // 
            this.ComboCourseDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCourseDuration.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ComboCourseDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboCourseDuration.FormattingEnabled = true;
            this.ComboCourseDuration.Location = new System.Drawing.Point(170, 114);
            this.ComboCourseDuration.Margin = new System.Windows.Forms.Padding(10);
            this.ComboCourseDuration.Name = "ComboCourseDuration";
            this.ComboCourseDuration.Size = new System.Drawing.Size(232, 25);
            this.ComboCourseDuration.TabIndex = 4;
            this.ComboCourseDuration.SelectedIndexChanged += new System.EventHandler(this.ComboCourseDuration_SelectedIndexChanged);
            // 
            // btnOutlineUpload
            // 
            this.btnOutlineUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutlineUpload.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutlineUpload.Location = new System.Drawing.Point(329, 166);
            this.btnOutlineUpload.Name = "btnOutlineUpload";
            this.btnOutlineUpload.Size = new System.Drawing.Size(73, 32);
            this.btnOutlineUpload.TabIndex = 6;
            this.btnOutlineUpload.Text = "Upload";
            this.btnOutlineUpload.UseVisualStyleBackColor = true;
            this.btnOutlineUpload.Click += new System.EventHandler(this.btnOutlineUpload_Click);
            // 
            // txtCourseOutline
            // 
            this.txtCourseOutline.BackColor = System.Drawing.Color.LightGray;
            this.txtCourseOutline.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCourseOutline.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCourseOutline.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCourseOutline.BorderThickness = 1;
            this.txtCourseOutline.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseOutline.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCourseOutline.Enabled = false;
            this.txtCourseOutline.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseOutline.ForeColor = System.Drawing.Color.Gray;
            this.txtCourseOutline.isPassword = false;
            this.txtCourseOutline.Location = new System.Drawing.Point(170, 167);
            this.txtCourseOutline.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseOutline.MaxLength = 32767;
            this.txtCourseOutline.Name = "txtCourseOutline";
            this.txtCourseOutline.Size = new System.Drawing.Size(151, 30);
            this.txtCourseOutline.TabIndex = 5;
            this.txtCourseOutline.Text = "Select Outline";
            this.txtCourseOutline.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseCode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseCode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseCode.BorderThickness = 1;
            this.txtCourseCode.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseCode.isPassword = false;
            this.txtCourseCode.Location = new System.Drawing.Point(170, 59);
            this.txtCourseCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseCode.MaxLength = 32767;
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(232, 30);
            this.txtCourseCode.TabIndex = 3;
            this.txtCourseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(42, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Course Outline:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(33, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Course Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(53, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Course Code:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Controls.Add(this.tabControlTrainer);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(434, 257);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnTrainNew);
            this.panel6.Controls.Add(this.btnTrainExisting);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(428, 36);
            this.panel6.TabIndex = 2;
            // 
            // btnTrainNew
            // 
            this.btnTrainNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnTrainNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrainNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnTrainNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTrainNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnTrainNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainNew.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainNew.Location = new System.Drawing.Point(3, 3);
            this.btnTrainNew.Name = "btnTrainNew";
            this.btnTrainNew.Size = new System.Drawing.Size(77, 29);
            this.btnTrainNew.TabIndex = 1;
            this.btnTrainNew.Text = "New";
            this.btnTrainNew.UseVisualStyleBackColor = false;
            this.btnTrainNew.Click += new System.EventHandler(this.btnTrainNew_Click);
            // 
            // btnTrainExisting
            // 
            this.btnTrainExisting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrainExisting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnTrainExisting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTrainExisting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnTrainExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainExisting.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainExisting.Location = new System.Drawing.Point(84, 3);
            this.btnTrainExisting.Name = "btnTrainExisting";
            this.btnTrainExisting.Size = new System.Drawing.Size(77, 29);
            this.btnTrainExisting.TabIndex = 10;
            this.btnTrainExisting.Text = "Existing";
            this.btnTrainExisting.UseVisualStyleBackColor = true;
            this.btnTrainExisting.Click += new System.EventHandler(this.btnTrainExisting_Click);
            // 
            // tabControlTrainer
            // 
            this.tabControlTrainer.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlTrainer.Controls.Add(this.tabTrainerNew);
            this.tabControlTrainer.Controls.Add(this.tabTrainerExisting);
            this.tabControlTrainer.Location = new System.Drawing.Point(6, 19);
            this.tabControlTrainer.Name = "tabControlTrainer";
            this.tabControlTrainer.SelectedIndex = 0;
            this.tabControlTrainer.Size = new System.Drawing.Size(422, 232);
            this.tabControlTrainer.TabIndex = 1;
            // 
            // tabTrainerNew
            // 
            this.tabTrainerNew.Controls.Add(this.btnProfileUpload);
            this.tabTrainerNew.Controls.Add(this.btnCVUpload);
            this.tabTrainerNew.Controls.Add(this.txtNewTrainerProfile);
            this.tabTrainerNew.Controls.Add(this.txtNewTrainerCV);
            this.tabTrainerNew.Controls.Add(this.ComboNewTrainerRole);
            this.tabTrainerNew.Controls.Add(this.ComboNewTrainerMode);
            this.tabTrainerNew.Controls.Add(this.txtNewTrainerName);
            this.tabTrainerNew.Controls.Add(this.label10);
            this.tabTrainerNew.Controls.Add(this.label7);
            this.tabTrainerNew.Controls.Add(this.label11);
            this.tabTrainerNew.Controls.Add(this.label8);
            this.tabTrainerNew.Controls.Add(this.label9);
            this.tabTrainerNew.Location = new System.Drawing.Point(4, 25);
            this.tabTrainerNew.Name = "tabTrainerNew";
            this.tabTrainerNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainerNew.Size = new System.Drawing.Size(414, 203);
            this.tabTrainerNew.TabIndex = 0;
            this.tabTrainerNew.Text = "tabPage4";
            this.tabTrainerNew.UseVisualStyleBackColor = true;
            // 
            // btnProfileUpload
            // 
            this.btnProfileUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileUpload.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileUpload.Location = new System.Drawing.Point(311, 45);
            this.btnProfileUpload.Name = "btnProfileUpload";
            this.btnProfileUpload.Size = new System.Drawing.Size(73, 32);
            this.btnProfileUpload.TabIndex = 1;
            this.btnProfileUpload.Text = "Upload";
            this.btnProfileUpload.UseVisualStyleBackColor = true;
            this.btnProfileUpload.Click += new System.EventHandler(this.btnProfileUpload_Click);
            // 
            // btnCVUpload
            // 
            this.btnCVUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCVUpload.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCVUpload.Location = new System.Drawing.Point(311, 89);
            this.btnCVUpload.Name = "btnCVUpload";
            this.btnCVUpload.Size = new System.Drawing.Size(73, 32);
            this.btnCVUpload.TabIndex = 2;
            this.btnCVUpload.Text = "Upload";
            this.btnCVUpload.UseVisualStyleBackColor = true;
            this.btnCVUpload.Click += new System.EventHandler(this.btnCVUpload_Click);
            // 
            // txtNewTrainerProfile
            // 
            this.txtNewTrainerProfile.BackColor = System.Drawing.Color.LightGray;
            this.txtNewTrainerProfile.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtNewTrainerProfile.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtNewTrainerProfile.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtNewTrainerProfile.BorderThickness = 1;
            this.txtNewTrainerProfile.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewTrainerProfile.Cursor = System.Windows.Forms.Cursors.No;
            this.txtNewTrainerProfile.Enabled = false;
            this.txtNewTrainerProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewTrainerProfile.ForeColor = System.Drawing.Color.Gray;
            this.txtNewTrainerProfile.isPassword = false;
            this.txtNewTrainerProfile.Location = new System.Drawing.Point(152, 46);
            this.txtNewTrainerProfile.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewTrainerProfile.MaxLength = 32767;
            this.txtNewTrainerProfile.Name = "txtNewTrainerProfile";
            this.txtNewTrainerProfile.Size = new System.Drawing.Size(151, 30);
            this.txtNewTrainerProfile.TabIndex = 34;
            this.txtNewTrainerProfile.Text = "Select Profile";
            this.txtNewTrainerProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNewTrainerCV
            // 
            this.txtNewTrainerCV.BackColor = System.Drawing.Color.LightGray;
            this.txtNewTrainerCV.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtNewTrainerCV.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtNewTrainerCV.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtNewTrainerCV.BorderThickness = 1;
            this.txtNewTrainerCV.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewTrainerCV.Cursor = System.Windows.Forms.Cursors.No;
            this.txtNewTrainerCV.Enabled = false;
            this.txtNewTrainerCV.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewTrainerCV.ForeColor = System.Drawing.Color.Gray;
            this.txtNewTrainerCV.isPassword = false;
            this.txtNewTrainerCV.Location = new System.Drawing.Point(152, 90);
            this.txtNewTrainerCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewTrainerCV.MaxLength = 32767;
            this.txtNewTrainerCV.Name = "txtNewTrainerCV";
            this.txtNewTrainerCV.Size = new System.Drawing.Size(151, 30);
            this.txtNewTrainerCV.TabIndex = 35;
            this.txtNewTrainerCV.Text = "Select CV";
            this.txtNewTrainerCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ComboNewTrainerRole
            // 
            this.ComboNewTrainerRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNewTrainerRole.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ComboNewTrainerRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboNewTrainerRole.FormattingEnabled = true;
            this.ComboNewTrainerRole.Items.AddRange(new object[] {
            "Member",
            "External"});
            this.ComboNewTrainerRole.Location = new System.Drawing.Point(152, 136);
            this.ComboNewTrainerRole.Margin = new System.Windows.Forms.Padding(10);
            this.ComboNewTrainerRole.Name = "ComboNewTrainerRole";
            this.ComboNewTrainerRole.Size = new System.Drawing.Size(232, 25);
            this.ComboNewTrainerRole.TabIndex = 3;
            this.ComboNewTrainerRole.SelectedIndexChanged += new System.EventHandler(this.ComboNewTrainerRole_SelectedIndexChanged);
            // 
            // ComboNewTrainerMode
            // 
            this.ComboNewTrainerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNewTrainerMode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ComboNewTrainerMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboNewTrainerMode.FormattingEnabled = true;
            this.ComboNewTrainerMode.Items.AddRange(new object[] {
            "Income",
            "Share"});
            this.ComboNewTrainerMode.Location = new System.Drawing.Point(152, 177);
            this.ComboNewTrainerMode.Margin = new System.Windows.Forms.Padding(10);
            this.ComboNewTrainerMode.Name = "ComboNewTrainerMode";
            this.ComboNewTrainerMode.Size = new System.Drawing.Size(232, 25);
            this.ComboNewTrainerMode.TabIndex = 4;
            this.ComboNewTrainerMode.SelectedIndexChanged += new System.EventHandler(this.customComboBox1_SelectedValueChanged);
            // 
            // txtNewTrainerName
            // 
            this.txtNewTrainerName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewTrainerName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewTrainerName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewTrainerName.BorderThickness = 1;
            this.txtNewTrainerName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewTrainerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewTrainerName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewTrainerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewTrainerName.isPassword = false;
            this.txtNewTrainerName.Location = new System.Drawing.Point(152, 1);
            this.txtNewTrainerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewTrainerName.MaxLength = 32767;
            this.txtNewTrainerName.Name = "txtNewTrainerName";
            this.txtNewTrainerName.Size = new System.Drawing.Size(232, 30);
            this.txtNewTrainerName.TabIndex = 0;
            this.txtNewTrainerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(31, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Income/Share:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(47, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Trainer Role:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(84, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Profile:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(57, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Trainer CV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(35, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Trainer Name:";
            // 
            // tabTrainerExisting
            // 
            this.tabTrainerExisting.Controls.Add(this.ExistingTrainerImage);
            this.tabTrainerExisting.Controls.Add(this.comboExistsingList);
            this.tabTrainerExisting.Controls.Add(this.label12);
            this.tabTrainerExisting.Location = new System.Drawing.Point(4, 25);
            this.tabTrainerExisting.Name = "tabTrainerExisting";
            this.tabTrainerExisting.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainerExisting.Size = new System.Drawing.Size(414, 203);
            this.tabTrainerExisting.TabIndex = 1;
            this.tabTrainerExisting.Text = "tabPage5";
            this.tabTrainerExisting.UseVisualStyleBackColor = true;
            // 
            // ExistingTrainerImage
            // 
            this.ExistingTrainerImage.BackColor = System.Drawing.Color.Transparent;
            this.ExistingTrainerImage.Image = global::GOTECH.Properties.Resources.profile_sample1;
            this.ExistingTrainerImage.Location = new System.Drawing.Point(157, 26);
            this.ExistingTrainerImage.Name = "ExistingTrainerImage";
            this.ExistingTrainerImage.Size = new System.Drawing.Size(100, 100);
            this.ExistingTrainerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExistingTrainerImage.TabIndex = 35;
            this.ExistingTrainerImage.TabStop = false;
            // 
            // comboExistsingList
            // 
            this.comboExistsingList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExistsingList.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboExistsingList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboExistsingList.FormattingEnabled = true;
            this.comboExistsingList.Location = new System.Drawing.Point(148, 149);
            this.comboExistsingList.Margin = new System.Windows.Forms.Padding(10);
            this.comboExistsingList.Name = "comboExistsingList";
            this.comboExistsingList.Size = new System.Drawing.Size(232, 25);
            this.comboExistsingList.TabIndex = 34;
            this.comboExistsingList.SelectedValueChanged += new System.EventHandler(this.comboExistsingList_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(34, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "Trainer Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 55);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(448, 1);
            this.panel5.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(1)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(156, 11);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 32);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtNewTrainerModeValue
            // 
            this.txtNewTrainerModeValue.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewTrainerModeValue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewTrainerModeValue.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewTrainerModeValue.BorderThickness = 1;
            this.txtNewTrainerModeValue.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewTrainerModeValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewTrainerModeValue.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewTrainerModeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewTrainerModeValue.isPassword = false;
            this.txtNewTrainerModeValue.Location = new System.Drawing.Point(171, 307);
            this.txtNewTrainerModeValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewTrainerModeValue.MaxLength = 32767;
            this.txtNewTrainerModeValue.Name = "txtNewTrainerModeValue";
            this.txtNewTrainerModeValue.Size = new System.Drawing.Size(232, 30);
            this.txtNewTrainerModeValue.TabIndex = 5;
            this.txtNewTrainerModeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewTrainerModeValue.Visible = false;
            // 
            // labelDrop
            // 
            this.labelDrop.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDrop.Location = new System.Drawing.Point(66, 313);
            this.labelDrop.Name = "labelDrop";
            this.labelDrop.Size = new System.Drawing.Size(91, 19);
            this.labelDrop.TabIndex = 10;
            this.labelDrop.Text = "Income:";
            this.labelDrop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDrop.Visible = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelTop;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(452, 370);
            this.Controls.Add(this.txtNewTrainerModeValue);
            this.Controls.Add(this.labelDrop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCourse";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCourse_FormClosing);
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabControlTrainer.ResumeLayout(false);
            this.tabTrainerNew.ResumeLayout(false);
            this.tabTrainerNew.PerformLayout();
            this.tabTrainerExisting.ResumeLayout(false);
            this.tabTrainerExisting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExistingTrainerImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Utils.ServoLabel labelText;
        private Utils.ServoImageButton CloseButton;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Utils.DragControl dragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseId;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseEntry;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseOutline;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCourseCode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnOutlineUpload;
        private System.Windows.Forms.TabControl tabControlTrainer;
        private System.Windows.Forms.TabPage tabTrainerNew;
        private System.Windows.Forms.TabPage tabTrainerExisting;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnTrainNew;
        private System.Windows.Forms.Button btnTrainExisting;
        private System.Windows.Forms.Button btnProfileUpload;
        private System.Windows.Forms.Button btnCVUpload;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNewTrainerProfile;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNewTrainerCV;
        private Utils.CustomComboBox ComboNewTrainerRole;
        private Utils.CustomComboBox ComboNewTrainerMode;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNewTrainerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNewTrainerModeValue;
        private System.Windows.Forms.Label labelDrop;
        private Utils.CustomComboBox comboExistsingList;
        private System.Windows.Forms.Label label12;
        private Utils.OvalPictureBox ExistingTrainerImage;
        private Utils.CustomComboBox ComboCourseDuration;
    }
}