namespace GOTECH.Help
{
    partial class UserSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSetting));
            this.panelTop = new System.Windows.Forms.Panel();
            this.LabelText = new GOTECH.Utils.ServoLabel();
            this.CloseButton = new GOTECH.Utils.ServoImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.txtNewUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtOldUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPassSave = new System.Windows.Forms.Button();
            this.txtConfirmPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNewPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOldPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dragControl1 = new GOTECH.Utils.DragControl();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.LabelText.Size = new System.Drawing.Size(53, 17);
            this.LabelText.TabIndex = 8;
            this.LabelText.Text = "Setting";
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 31);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "© Copyright 2019 | GO TECH Terminal | All Rights Reserved";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(421, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 503);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 501);
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
            this.panel4.Size = new System.Drawing.Size(2, 501);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUserSave);
            this.groupBox1.Controls.Add(this.txtNewUser);
            this.groupBox1.Controls.Add(this.txtOldUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(10, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Username";
            // 
            // btnUserSave
            // 
            this.btnUserSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUserSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnUserSave.BackgroundImage = global::GOTECH.Properties.Resources.Submit_01_Black_padding_10px;
            this.btnUserSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnUserSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnUserSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(1)))));
            this.btnUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSave.Location = new System.Drawing.Point(186, 134);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(30, 30);
            this.btnUserSave.TabIndex = 2;
            this.btnUserSave.UseVisualStyleBackColor = false;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // txtNewUser
            // 
            this.txtNewUser.BorderColorFocused = System.Drawing.SystemColors.Control;
            this.txtNewUser.BorderColorIdle = System.Drawing.SystemColors.Control;
            this.txtNewUser.BorderColorMouseHover = System.Drawing.SystemColors.Control;
            this.txtNewUser.BorderThickness = 1;
            this.txtNewUser.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewUser.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNewUser.isPassword = false;
            this.txtNewUser.Location = new System.Drawing.Point(134, 79);
            this.txtNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewUser.MaxLength = 32767;
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(232, 30);
            this.txtNewUser.TabIndex = 1;
            this.txtNewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOldUser
            // 
            this.txtOldUser.BorderColorFocused = System.Drawing.SystemColors.Control;
            this.txtOldUser.BorderColorIdle = System.Drawing.SystemColors.Control;
            this.txtOldUser.BorderColorMouseHover = System.Drawing.SystemColors.Control;
            this.txtOldUser.BorderThickness = 1;
            this.txtOldUser.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOldUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOldUser.ForeColor = System.Drawing.SystemColors.Control;
            this.txtOldUser.isPassword = false;
            this.txtOldUser.Location = new System.Drawing.Point(135, 29);
            this.txtOldUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldUser.MaxLength = 32767;
            this.txtOldUser.Name = "txtOldUser";
            this.txtOldUser.Size = new System.Drawing.Size(232, 30);
            this.txtOldUser.TabIndex = 0;
            this.txtOldUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "New Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Old Username:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPassSave);
            this.groupBox2.Controls.Add(this.txtConfirmPass);
            this.groupBox2.Controls.Add(this.txtNewPass);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtOldPass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(10, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 223);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // btnPassSave
            // 
            this.btnPassSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPassSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnPassSave.BackgroundImage = global::GOTECH.Properties.Resources.Submit_01_Black_padding_10px;
            this.btnPassSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPassSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnPassSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.btnPassSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(1)))));
            this.btnPassSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassSave.Location = new System.Drawing.Point(186, 185);
            this.btnPassSave.Name = "btnPassSave";
            this.btnPassSave.Size = new System.Drawing.Size(30, 30);
            this.btnPassSave.TabIndex = 6;
            this.btnPassSave.UseVisualStyleBackColor = false;
            this.btnPassSave.Click += new System.EventHandler(this.btnPassSave_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderColorFocused = System.Drawing.SystemColors.Control;
            this.txtConfirmPass.BorderColorIdle = System.Drawing.SystemColors.Control;
            this.txtConfirmPass.BorderColorMouseHover = System.Drawing.SystemColors.Control;
            this.txtConfirmPass.BorderThickness = 1;
            this.txtConfirmPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtConfirmPass.ForeColor = System.Drawing.SystemColors.Control;
            this.txtConfirmPass.isPassword = true;
            this.txtConfirmPass.Location = new System.Drawing.Point(153, 134);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.MaxLength = 32767;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(232, 30);
            this.txtConfirmPass.TabIndex = 5;
            this.txtConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderColorFocused = System.Drawing.SystemColors.Control;
            this.txtNewPass.BorderColorIdle = System.Drawing.SystemColors.Control;
            this.txtNewPass.BorderColorMouseHover = System.Drawing.SystemColors.Control;
            this.txtNewPass.BorderThickness = 1;
            this.txtNewPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewPass.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNewPass.isPassword = true;
            this.txtNewPass.Location = new System.Drawing.Point(152, 83);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(232, 30);
            this.txtNewPass.TabIndex = 4;
            this.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(11, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Confirm Password:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.BorderColorFocused = System.Drawing.SystemColors.Control;
            this.txtOldPass.BorderColorIdle = System.Drawing.SystemColors.Control;
            this.txtOldPass.BorderColorMouseHover = System.Drawing.SystemColors.Control;
            this.txtOldPass.BorderThickness = 1;
            this.txtOldPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOldPass.ForeColor = System.Drawing.SystemColors.Control;
            this.txtOldPass.isPassword = true;
            this.txtOldPass.Location = new System.Drawing.Point(153, 32);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldPass.MaxLength = 32767;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(232, 30);
            this.txtOldPass.TabIndex = 3;
            this.txtOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(33, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "New Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(33, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Old Password:";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataSource = typeof(GOTECH.Data.Students);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelTop;
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(423, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Activated += new System.EventHandler(this.UserSetting_Activated);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOldUser;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNewUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNewPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtOldPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtConfirmPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnPassSave;
    }
}