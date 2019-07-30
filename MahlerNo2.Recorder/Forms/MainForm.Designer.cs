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
            this.btnDummy = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOption = new System.Windows.Forms.ToolStripButton();
            this.tbcPage = new System.Windows.Forms.TabControl();
            this.tbpSpeech = new System.Windows.Forms.TabPage();
            this.uscSpeech = new MahlerNo2.Recorder.Controls.SpeechListControl();
            this.tbpNote = new System.Windows.Forms.TabPage();
            this.tmrBreakTime = new System.Windows.Forms.Timer(this.components);
            this.tmrNotification = new System.Windows.Forms.Timer(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.tbcPage.SuspendLayout();
            this.tbpSpeech.SuspendLayout();
            this.tbpNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrShot
            // 
            this.tmrShot.Interval = 1000;
            this.tmrShot.Tick += new System.EventHandler(this.tmrShot_Tick);
            // 
            // btnDummy
            // 
            this.btnDummy.Location = new System.Drawing.Point(153, 138);
            this.btnDummy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDummy.Name = "btnDummy";
            this.btnDummy.Size = new System.Drawing.Size(0, 0);
            this.btnDummy.TabIndex = 6;
            this.btnDummy.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(3, 4);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(722, 349);
            this.txtNote.TabIndex = 5;
            this.txtNote.Enter += new System.EventHandler(this.txtNote_Enter);
            this.txtNote.Leave += new System.EventHandler(this.txtNote_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlay,
            this.toolStripSeparator1,
            this.tsbOption,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::MahlerNo2.Recorder.Properties.Resources.Play;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(29, 24);
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
            this.tsbOption.Size = new System.Drawing.Size(29, 24);
            this.tsbOption.Text = "Option";
            this.tsbOption.ToolTipText = "Option";
            this.tsbOption.Click += new System.EventHandler(this.tsbOption_Click);
            // 
            // tbcPage
            // 
            this.tbcPage.Controls.Add(this.tbpSpeech);
            this.tbcPage.Controls.Add(this.tbpNote);
            this.tbcPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPage.Location = new System.Drawing.Point(0, 27);
            this.tbcPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcPage.Name = "tbcPage";
            this.tbcPage.SelectedIndex = 0;
            this.tbcPage.Size = new System.Drawing.Size(736, 391);
            this.tbcPage.TabIndex = 7;
            // 
            // tbpSpeech
            // 
            this.tbpSpeech.Controls.Add(this.uscSpeech);
            this.tbpSpeech.Location = new System.Drawing.Point(4, 25);
            this.tbpSpeech.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpSpeech.Name = "tbpSpeech";
            this.tbpSpeech.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpSpeech.Size = new System.Drawing.Size(728, 362);
            this.tbpSpeech.TabIndex = 1;
            this.tbpSpeech.Text = "Speech";
            this.tbpSpeech.UseVisualStyleBackColor = true;
            // 
            // uscSpeech
            // 
            this.uscSpeech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscSpeech.Location = new System.Drawing.Point(3, 4);
            this.uscSpeech.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uscSpeech.Name = "uscSpeech";
            this.uscSpeech.Size = new System.Drawing.Size(722, 354);
            this.uscSpeech.TabIndex = 0;
            // 
            // tbpNote
            // 
            this.tbpNote.Controls.Add(this.btnDummy);
            this.tbpNote.Controls.Add(this.txtNote);
            this.tbpNote.Location = new System.Drawing.Point(4, 25);
            this.tbpNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpNote.Name = "tbpNote";
            this.tbpNote.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpNote.Size = new System.Drawing.Size(728, 357);
            this.tbpNote.TabIndex = 0;
            this.tbpNote.Text = "Note";
            this.tbpNote.UseVisualStyleBackColor = true;
            // 
            // tmrBreakTime
            // 
            this.tmrBreakTime.Interval = 60000;
            this.tmrBreakTime.Tick += new System.EventHandler(this.tmrBreakTime_Tick);
            // 
            // tmrNotification
            // 
            this.tmrNotification.Enabled = true;
            this.tmrNotification.Interval = 60000;
            this.tmrNotification.Tick += new System.EventHandler(this.TmrNotification_Tick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(406, 24);
            this.toolStripLabel1.Text = "Initial Catalog=MahlerNo2;User ID=mahler;Password=no2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 418);
            this.Controls.Add(this.tbcPage);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mahler No. 2 Recorder";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcPage.ResumeLayout(false);
            this.tbpSpeech.ResumeLayout(false);
            this.tbpNote.ResumeLayout(false);
            this.tbpNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrShot;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOption;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnDummy;
        private System.Windows.Forms.TabControl tbcPage;
        private System.Windows.Forms.TabPage tbpNote;
        private System.Windows.Forms.TabPage tbpSpeech;
        private Controls.SpeechListControl uscSpeech;
        private System.Windows.Forms.Timer tmrBreakTime;
        private System.Windows.Forms.Timer tmrNotification;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

