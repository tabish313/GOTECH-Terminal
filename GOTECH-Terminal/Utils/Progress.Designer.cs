namespace GOTECH.Utils
{
    partial class Progress
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
            this.servoLabel1 = new GOTECH.Utils.ServoLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // servoLabel1
            // 
            this.servoLabel1.AutoSize = true;
            this.servoLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.servoLabel1.ForeColor = System.Drawing.Color.White;
            this.servoLabel1.Location = new System.Drawing.Point(55, 7);
            this.servoLabel1.Name = "servoLabel1";
            this.servoLabel1.Size = new System.Drawing.Size(62, 17);
            this.servoLabel1.TabIndex = 1;
            this.servoLabel1.Text = "Loading";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GOTECH.Properties.Resources.loader_white;
            this.pictureBox1.Location = new System.Drawing.Point(24, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.servoLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Progress";
            this.Size = new System.Drawing.Size(140, 30);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ServoLabel servoLabel1;
    }
}
