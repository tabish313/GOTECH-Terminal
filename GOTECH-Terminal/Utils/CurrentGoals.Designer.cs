namespace GOTECH.Utils
{
    partial class CurrentGoals
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGoalName = new System.Windows.Forms.Label();
            this.Checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SuspendLayout();
            // 
            // labelGoalName
            // 
            this.labelGoalName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.labelGoalName.Location = new System.Drawing.Point(53, 5);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(215, 20);
            this.labelGoalName.TabIndex = 0;
            this.labelGoalName.Text = "Goal Name";
            this.labelGoalName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Checkbox
            // 
            this.Checkbox.AutoSize = true;
            this.Checkbox.BackColor = System.Drawing.Color.DimGray;
            this.Checkbox.ChechedOffColor = System.Drawing.Color.DimGray;
            this.Checkbox.Checked = false;
            this.Checkbox.CheckedOnColor = System.Drawing.Color.DimGray;
            this.Checkbox.Enabled = false;
            this.Checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.Checkbox.Location = new System.Drawing.Point(14, 5);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Size = new System.Drawing.Size(20, 20);
            this.Checkbox.TabIndex = 1;
            this.Checkbox.OnChange += new System.EventHandler(this.Checkbox_OnChange);
            // 
            // CurrentGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.Checkbox);
            this.Controls.Add(this.labelGoalName);
            this.Name = "CurrentGoals";
            this.Size = new System.Drawing.Size(315, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGoalName;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox;
    }
}
