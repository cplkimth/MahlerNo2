namespace MahlerNo2.Recorder.Controls
{
    partial class ScreenSelectionControl
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
            this.ptbScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbScreen
            // 
            this.ptbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbScreen.Location = new System.Drawing.Point(0, 0);
            this.ptbScreen.Name = "ptbScreen";
            this.ptbScreen.Size = new System.Drawing.Size(150, 150);
            this.ptbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbScreen.TabIndex = 0;
            this.ptbScreen.TabStop = false;
            this.ptbScreen.DoubleClick += new System.EventHandler(this.ptbScreen_DoubleClick);
            // 
            // ScreenSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbScreen);
            this.Name = "ScreenSelectionControl";
            ((System.ComponentModel.ISupportInitialize)(this.ptbScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbScreen;
    }
}
