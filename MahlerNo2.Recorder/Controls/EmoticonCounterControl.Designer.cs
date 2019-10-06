namespace MahlerNo2.Recorder.Controls
{
    partial class EmoticonCounterControl
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
            this.usc어려워요 = new MahlerNo2.Recorder.Controls.EmoticonCounterLineControl();
            this.usc재밌어요 = new MahlerNo2.Recorder.Controls.EmoticonCounterLineControl();
            this.usc쉬고싶어요 = new MahlerNo2.Recorder.Controls.EmoticonCounterLineControl();
            this.SuspendLayout();
            // 
            // usc어려워요
            // 
            this.usc어려워요.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usc어려워요.Location = new System.Drawing.Point(3, 3);
            this.usc어려워요.Name = "usc어려워요";
            this.usc어려워요.Padding = new System.Windows.Forms.Padding(5);
            this.usc어려워요.Size = new System.Drawing.Size(607, 79);
            this.usc어려워요.TabIndex = 0;
            // 
            // usc재밌어요
            // 
            this.usc재밌어요.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usc재밌어요.Emoticon = MahlerNo2.Core.Components.EmoticonType.재밌어요;
            this.usc재밌어요.Location = new System.Drawing.Point(3, 88);
            this.usc재밌어요.Name = "usc재밌어요";
            this.usc재밌어요.Padding = new System.Windows.Forms.Padding(5);
            this.usc재밌어요.Size = new System.Drawing.Size(607, 79);
            this.usc재밌어요.TabIndex = 1;
            // 
            // usc쉬고싶어요
            // 
            this.usc쉬고싶어요.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usc쉬고싶어요.Emoticon = MahlerNo2.Core.Components.EmoticonType.쉬고싶어요;
            this.usc쉬고싶어요.Location = new System.Drawing.Point(3, 173);
            this.usc쉬고싶어요.Name = "usc쉬고싶어요";
            this.usc쉬고싶어요.Padding = new System.Windows.Forms.Padding(5);
            this.usc쉬고싶어요.Size = new System.Drawing.Size(607, 79);
            this.usc쉬고싶어요.TabIndex = 2;
            // 
            // EmoticonCounterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usc쉬고싶어요);
            this.Controls.Add(this.usc재밌어요);
            this.Controls.Add(this.usc어려워요);
            this.Name = "EmoticonCounterControl";
            this.Size = new System.Drawing.Size(626, 303);
            this.ResumeLayout(false);

        }

        #endregion

        private EmoticonCounterLineControl usc어려워요;
        private EmoticonCounterLineControl usc재밌어요;
        private EmoticonCounterLineControl usc쉬고싶어요;
    }
}
