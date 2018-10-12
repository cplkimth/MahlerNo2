namespace MahlerNo2.Viewer.Forms
{
    partial class ViewerForm
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
            this.bgwShotLoader = new System.ComponentModel.BackgroundWorker();
            this.ptbShot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShot)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwShotLoader
            // 
            this.bgwShotLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwShotLoader_DoWork);
            this.bgwShotLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwShotLoader_RunWorkerCompleted);
            // 
            // ptbShot
            // 
            this.ptbShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbShot.Location = new System.Drawing.Point(0, 0);
            this.ptbShot.Name = "ptbShot";
            this.ptbShot.Size = new System.Drawing.Size(1184, 450);
            this.ptbShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbShot.TabIndex = 2;
            this.ptbShot.TabStop = false;
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.ptbShot);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewerForm";
            this.Text = "ViewerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptbShot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbShot;
        private System.ComponentModel.BackgroundWorker bgwShotLoader;
    }
}

