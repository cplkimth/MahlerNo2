namespace MahlerNo2.Recorder.Controls
{
    partial class EmoticonCounterLineControl
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
            this.uscRater = new ShaperRater.Rater();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uscRater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // uscRater
            // 
            this.uscRater.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscRater.CurrentRating = 0;
            this.uscRater.Enabled = false;
            this.uscRater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscRater.ForeColor = System.Drawing.Color.Crimson;
            this.uscRater.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uscRater.LabelShow = false;
            this.uscRater.LabelText = "RateLabel";
            this.uscRater.LabelTextItems = new string[0];
            this.uscRater.Location = new System.Drawing.Point(83, 0);
            this.uscRater.Margin = new System.Windows.Forms.Padding(0);
            this.uscRater.MaxRating = 10;
            this.uscRater.Name = "uscRater";
            this.uscRater.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.uscRater.RadiusInner = 3F;
            this.uscRater.RadiusOuter = 15F;
            this.uscRater.ShapeBorderEmptyColor = System.Drawing.Color.SteelBlue;
            this.uscRater.ShapeColorHover = System.Drawing.Color.Blue;
            this.uscRater.Size = new System.Drawing.Size(609, 80);
            this.uscRater.TabIndex = 1;
            // 
            // ptbImage
            // 
            this.ptbImage.Image = global::MahlerNo2.Recorder.Properties.Resources.쉬고싶어요;
            this.ptbImage.Location = new System.Drawing.Point(0, 0);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(80, 80);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImage.TabIndex = 2;
            this.ptbImage.TabStop = false;
            // 
            // EmoticonCounterLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uscRater);
            this.Controls.Add(this.ptbImage);
            this.Name = "EmoticonCounterLineControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(692, 80);
            ((System.ComponentModel.ISupportInitialize)(this.uscRater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbImage;
        private ShaperRater.Rater uscRater;
    }
}
