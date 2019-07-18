namespace GOTECH.Utils
{
    partial class PlanBox
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
            this.panel24 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelGoals = new System.Windows.Forms.FlowLayoutPanel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGoals = new System.Windows.Forms.Label();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel24
            // 
            this.panel24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(105)))));
            this.panel24.Controls.Add(this.flowLayoutPanelGoals);
            this.panel24.Controls.Add(this.panel25);
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(315, 250);
            this.panel24.TabIndex = 43;
            // 
            // flowLayoutPanelGoals
            // 
            this.flowLayoutPanelGoals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelGoals.AutoScroll = true;
            this.flowLayoutPanelGoals.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanelGoals.Name = "flowLayoutPanelGoals";
            this.flowLayoutPanelGoals.Size = new System.Drawing.Size(315, 220);
            this.flowLayoutPanelGoals.TabIndex = 1;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.panel25.Controls.Add(this.label1);
            this.panel25.Controls.Add(this.labelGoals);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(0, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(315, 30);
            this.panel25.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(100, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Duration: 12/04/2019 to 12/05/2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGoals
            // 
            this.labelGoals.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGoals.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.labelGoals.Location = new System.Drawing.Point(16, 1);
            this.labelGoals.Name = "labelGoals";
            this.labelGoals.Size = new System.Drawing.Size(82, 28);
            this.labelGoals.TabIndex = 16;
            this.labelGoals.Text = "Goal {0}";
            this.labelGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlanBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel24);
            this.Name = "PlanBox";
            this.Size = new System.Drawing.Size(315, 250);
            this.panel24.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGoals;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label labelGoals;
        private System.Windows.Forms.Label label1;

    }
}
