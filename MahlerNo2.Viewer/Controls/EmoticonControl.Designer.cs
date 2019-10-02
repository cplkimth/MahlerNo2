namespace MahlerNo2.Viewer.Controls
{
    partial class EmoticonControl
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
            this.components = new System.ComponentModel.Container();
            this.prbCoolTime = new System.Windows.Forms.ProgressBar();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // prbCoolTime
            // 
            this.prbCoolTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prbCoolTime.Location = new System.Drawing.Point(0, 140);
            this.prbCoolTime.Name = "prbCoolTime";
            this.prbCoolTime.Size = new System.Drawing.Size(150, 10);
            this.prbCoolTime.TabIndex = 1;
            // 
            // ptbImage
            // 
            this.ptbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbImage.Image = global::MahlerNo2.Viewer.Properties.Resources.재밌어요;
            this.ptbImage.Location = new System.Drawing.Point(0, 0);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(150, 140);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            this.ptbImage.Click += new System.EventHandler(this.ptbImage_Click);
            // 
            // EmoticonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.prbCoolTime);
            this.Name = "EmoticonControl";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.ProgressBar prbCoolTime;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
