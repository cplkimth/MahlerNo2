namespace MahlerNo2.Viewer.Forms
{
    partial class ShotForm
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
            this.ptbShot = new System.Windows.Forms.PictureBox();
            this.uscRemocon = new MahlerNo2.Viewer.Controls.RemoconControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShot)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbShot
            // 
            this.ptbShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbShot.Location = new System.Drawing.Point(0, 0);
            this.ptbShot.Name = "ptbShot";
            this.ptbShot.Size = new System.Drawing.Size(911, 812);
            this.ptbShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbShot.TabIndex = 0;
            this.ptbShot.TabStop = false;
            // 
            // uscRemocon
            // 
            this.uscRemocon.Dock = System.Windows.Forms.DockStyle.Right;
            this.uscRemocon.Location = new System.Drawing.Point(783, 0);
            this.uscRemocon.Name = "uscRemocon";
            this.uscRemocon.Size = new System.Drawing.Size(128, 812);
            this.uscRemocon.TabIndex = 4;
            this.uscRemocon.BackupClicked += new System.EventHandler<MahlerNo2.Viewer.Controls.RemoconControl.BackupClickedEventArgs>(this.uscRemocon_BackupClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbShot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 812);
            this.panel1.TabIndex = 5;
            // 
            // ShotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 812);
            this.Controls.Add(this.uscRemocon);
            this.Controls.Add(this.panel1);
            this.Name = "ShotForm";
            this.Text = "MahlerNo2.Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptbShot)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbShot;
        private Controls.RemoconControl uscRemocon;
        private System.Windows.Forms.Panel panel1;
    }
}