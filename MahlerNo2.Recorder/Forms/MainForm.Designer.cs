namespace MahlerNo2.Recorder.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tmrShot = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOption = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiCamera = new System.Windows.Forms.ToolStripButton();
            this.tbcPage = new System.Windows.Forms.TabControl();
            this.tbpSpeech = new System.Windows.Forms.TabPage();
            this.uscEmoticonCounter = new MahlerNo2.Recorder.Controls.EmoticonCounterControl();
            this.tmrNotification = new System.Windows.Forms.Timer(this.components);
            this.tmrEmoticon = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.tbcPage.SuspendLayout();
            this.tbpSpeech.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrShot
            // 
            this.tmrShot.Interval = 1000;
            this.tmrShot.Tick += new System.EventHandler(this.tmrShot_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlay,
            this.toolStripSeparator1,
            this.tsbOption,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.tsiCamera});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::MahlerNo2.Recorder.Properties.Resources.Play;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(24, 24);
            this.tsbPlay.Text = "toolStripButton1";
            this.tsbPlay.ToolTipText = "Toggle Play/Pause";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbOption
            // 
            this.tsbOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOption.Image = global::MahlerNo2.Recorder.Properties.Resources.Option;
            this.tsbOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOption.Name = "tsbOption";
            this.tsbOption.Size = new System.Drawing.Size(24, 24);
            this.tsbOption.Text = "Option";
            this.tsbOption.ToolTipText = "Option";
            this.tsbOption.Click += new System.EventHandler(this.tsbOption_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(318, 24);
            this.toolStripLabel1.Text = "Initial Catalog=MahlerNo2;User ID=mahler;Password=no2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsiCamera
            // 
            this.tsiCamera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiCamera.Enabled = false;
            this.tsiCamera.Image = global::MahlerNo2.Recorder.Properties.Resources.Camera;
            this.tsiCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiCamera.Name = "tsiCamera";
            this.tsiCamera.Size = new System.Drawing.Size(24, 24);
            this.tsiCamera.Text = "toolStripButton1";
            // 
            // tbcPage
            // 
            this.tbcPage.Controls.Add(this.tbpSpeech);
            this.tbcPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPage.Location = new System.Drawing.Point(0, 27);
            this.tbcPage.Name = "tbcPage";
            this.tbcPage.SelectedIndex = 0;
            this.tbcPage.Size = new System.Drawing.Size(556, 228);
            this.tbcPage.TabIndex = 7;
            // 
            // tbpSpeech
            // 
            this.tbpSpeech.Controls.Add(this.uscEmoticonCounter);
            this.tbpSpeech.Location = new System.Drawing.Point(4, 22);
            this.tbpSpeech.Name = "tbpSpeech";
            this.tbpSpeech.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpSpeech.Size = new System.Drawing.Size(548, 202);
            this.tbpSpeech.TabIndex = 1;
            this.tbpSpeech.Text = "Speech";
            this.tbpSpeech.UseVisualStyleBackColor = true;
            // 
            // uscEmoticonCounter
            // 
            this.uscEmoticonCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscEmoticonCounter.Location = new System.Drawing.Point(3, 3);
            this.uscEmoticonCounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscEmoticonCounter.Name = "uscEmoticonCounter";
            this.uscEmoticonCounter.Size = new System.Drawing.Size(542, 196);
            this.uscEmoticonCounter.TabIndex = 0;
            // 
            // tmrNotification
            // 
            this.tmrNotification.Enabled = true;
            this.tmrNotification.Interval = 60000;
            this.tmrNotification.Tick += new System.EventHandler(this.tmrNotification_Tick);
            // 
            // tmrEmoticon
            // 
            this.tmrEmoticon.Interval = 3000;
            this.tmrEmoticon.Tick += new System.EventHandler(this.tmrEmoticon_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 255);
            this.Controls.Add(this.tbcPage);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mahler No. 2 Recorder";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcPage.ResumeLayout(false);
            this.tbpSpeech.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrShot;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOption;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tbcPage;
        private System.Windows.Forms.TabPage tbpSpeech;
        private System.Windows.Forms.Timer tmrNotification;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsiCamera;
        private Controls.EmoticonCounterControl uscEmoticonCounter;
        private System.Windows.Forms.Timer tmrEmoticon;
    }
}

