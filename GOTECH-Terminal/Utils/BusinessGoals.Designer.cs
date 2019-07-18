namespace GOTECH.Utils
{
    partial class BusinessGoals
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
            this.labelGoalNo = new System.Windows.Forms.Label();
            this.labelGoalName = new System.Windows.Forms.Label();
            this.labelStartendDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGoalNo
            // 
            this.labelGoalNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.labelGoalNo.Location = new System.Drawing.Point(5, 5);
            this.labelGoalNo.Name = "labelGoalNo";
            this.labelGoalNo.Size = new System.Drawing.Size(69, 20);
            this.labelGoalNo.TabIndex = 0;
            this.labelGoalNo.Text = "Goal {#}:";
            this.labelGoalNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGoalName
            // 
            this.labelGoalName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.labelGoalName.Location = new System.Drawing.Point(71, 5);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(241, 20);
            this.labelGoalName.TabIndex = 0;
            this.labelGoalName.Text = "Goal Name";
            this.labelGoalName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStartendDate
            // 
            this.labelStartendDate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartendDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.labelStartendDate.Location = new System.Drawing.Point(71, 26);
            this.labelStartendDate.Name = "labelStartendDate";
            this.labelStartendDate.Size = new System.Drawing.Size(241, 20);
            this.labelStartendDate.TabIndex = 0;
            this.labelStartendDate.Text = "Start Date - End Date";
            this.labelStartendDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BusinessGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.labelStartendDate);
            this.Controls.Add(this.labelGoalName);
            this.Controls.Add(this.labelGoalNo);
            this.Name = "BusinessGoals";
            this.Size = new System.Drawing.Size(315, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGoalNo;
        private System.Windows.Forms.Label labelGoalName;
        private System.Windows.Forms.Label labelStartendDate;
    }
}
