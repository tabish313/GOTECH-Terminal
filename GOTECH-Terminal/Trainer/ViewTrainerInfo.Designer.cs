namespace GOTECH.Trainer
{
    partial class ViewTrainerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTrainerInfo));
            this.panelTop = new System.Windows.Forms.Panel();
            this.LabelText = new GOTECH.Utils.ServoLabel();
            this.CloseButton = new GOTECH.Utils.ServoImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progress1 = new GOTECH.Utils.Progress();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTrainerName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrainerCV = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrainerRole = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.labelMode = new System.Windows.Forms.Label();
            this.txtTrainerModeValue = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnCVSave = new System.Windows.Forms.Button();
            this.trainerPic = new GOTECH.Utils.OvalPictureBox();
            this.dragControl1 = new GOTECH.Utils.DragControl();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainerPic)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(401, 38);
            this.panelTop.TabIndex = 0;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.BackColor = System.Drawing.Color.Transparent;
            this.LabelText.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.LabelText.ForeColor = System.Drawing.Color.White;
            this.LabelText.Location = new System.Drawing.Point(10, 10);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(98, 17);
            this.LabelText.TabIndex = 5;
            this.LabelText.Text = "Trainer Name";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::GOTECH.Properties.Resources.Close_Window_white;
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(369, 9);
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
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 50);
            this.panel1.TabIndex = 2;
            // 
            // progress1
            // 
            this.progress1.LoaderImage = ((System.Drawing.Image)(resources.GetObject("progress1.LoaderImage")));
            this.progress1.LoaderText = "Saving";
            this.progress1.Location = new System.Drawing.Point(275, 9);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(120, 30);
            this.progress1.TabIndex = 18;
            this.progress1.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(1)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(132, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 32);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(403, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 453);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 2);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 451);
            this.panel4.TabIndex = 0;
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.BackColor = System.Drawing.Color.Silver;
            this.txtTrainerName.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTrainerName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTrainerName.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTrainerName.BorderThickness = 1;
            this.txtTrainerName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTrainerName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTrainerName.Enabled = false;
            this.txtTrainerName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTrainerName.ForeColor = System.Drawing.Color.Black;
            this.txtTrainerName.isPassword = false;
            this.txtTrainerName.Location = new System.Drawing.Point(139, 194);
            this.txtTrainerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrainerName.MaxLength = 32767;
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(232, 30);
            this.txtTrainerName.TabIndex = 15;
            this.txtTrainerName.Text = "05";
            this.txtTrainerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Trainer Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(45, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Trainer CV:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTrainerCV
            // 
            this.txtTrainerCV.BackColor = System.Drawing.Color.Silver;
            this.txtTrainerCV.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTrainerCV.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTrainerCV.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTrainerCV.BorderThickness = 1;
            this.txtTrainerCV.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTrainerCV.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTrainerCV.Enabled = false;
            this.txtTrainerCV.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTrainerCV.ForeColor = System.Drawing.Color.Black;
            this.txtTrainerCV.isPassword = false;
            this.txtTrainerCV.Location = new System.Drawing.Point(139, 242);
            this.txtTrainerCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrainerCV.MaxLength = 32767;
            this.txtTrainerCV.Name = "txtTrainerCV";
            this.txtTrainerCV.Size = new System.Drawing.Size(165, 30);
            this.txtTrainerCV.TabIndex = 15;
            this.txtTrainerCV.Text = "05";
            this.txtTrainerCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(29, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Trainer Role:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTrainerRole
            // 
            this.txtTrainerRole.BackColor = System.Drawing.Color.Silver;
            this.txtTrainerRole.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTrainerRole.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTrainerRole.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTrainerRole.BorderThickness = 1;
            this.txtTrainerRole.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTrainerRole.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTrainerRole.Enabled = false;
            this.txtTrainerRole.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTrainerRole.ForeColor = System.Drawing.Color.Black;
            this.txtTrainerRole.isPassword = false;
            this.txtTrainerRole.Location = new System.Drawing.Point(139, 291);
            this.txtTrainerRole.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrainerRole.MaxLength = 32767;
            this.txtTrainerRole.Name = "txtTrainerRole";
            this.txtTrainerRole.Size = new System.Drawing.Size(232, 30);
            this.txtTrainerRole.TabIndex = 15;
            this.txtTrainerRole.Text = "05";
            this.txtTrainerRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelMode
            // 
            this.labelMode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMode.Location = new System.Drawing.Point(45, 345);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(84, 19);
            this.labelMode.TabIndex = 16;
            this.labelMode.Text = "Income:";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTrainerModeValue
            // 
            this.txtTrainerModeValue.BackColor = System.Drawing.Color.Silver;
            this.txtTrainerModeValue.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTrainerModeValue.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTrainerModeValue.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTrainerModeValue.BorderThickness = 1;
            this.txtTrainerModeValue.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTrainerModeValue.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTrainerModeValue.Enabled = false;
            this.txtTrainerModeValue.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTrainerModeValue.ForeColor = System.Drawing.Color.Black;
            this.txtTrainerModeValue.isPassword = false;
            this.txtTrainerModeValue.Location = new System.Drawing.Point(139, 341);
            this.txtTrainerModeValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrainerModeValue.MaxLength = 32767;
            this.txtTrainerModeValue.Name = "txtTrainerModeValue";
            this.txtTrainerModeValue.Size = new System.Drawing.Size(232, 30);
            this.txtTrainerModeValue.TabIndex = 15;
            this.txtTrainerModeValue.Text = "05";
            this.txtTrainerModeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCVSave
            // 
            this.btnCVSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCVSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCVSave.Location = new System.Drawing.Point(311, 242);
            this.btnCVSave.Name = "btnCVSave";
            this.btnCVSave.Size = new System.Drawing.Size(60, 32);
            this.btnCVSave.TabIndex = 17;
            this.btnCVSave.Text = "Save";
            this.btnCVSave.UseVisualStyleBackColor = true;
            this.btnCVSave.Click += new System.EventHandler(this.btnCVSave_Click);
            // 
            // trainerPic
            // 
            this.trainerPic.BackColor = System.Drawing.Color.Transparent;
            this.trainerPic.Image = global::GOTECH.Properties.Resources.profile_sample1;
            this.trainerPic.Location = new System.Drawing.Point(142, 57);
            this.trainerPic.Name = "trainerPic";
            this.trainerPic.Size = new System.Drawing.Size(120, 110);
            this.trainerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trainerPic.TabIndex = 3;
            this.trainerPic.TabStop = false;
            this.trainerPic.Click += new System.EventHandler(this.trainerPic_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelTop;
            // 
            // ViewTrainerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(405, 453);
            this.Controls.Add(this.btnCVSave);
            this.Controls.Add(this.txtTrainerModeValue);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.txtTrainerRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTrainerCV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTrainerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainerPic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTrainerInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.ViewTrainerInfo_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainerPic)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnClose;
        private Utils.OvalPictureBox trainerPic;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTrainerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTrainerCV;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTrainerRole;
        private System.Windows.Forms.Label labelMode;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTrainerModeValue;
        private System.Windows.Forms.Button btnCVSave;
        private Utils.Progress progress1;
    }
}