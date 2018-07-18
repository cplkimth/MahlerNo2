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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRatio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnFarFarPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnFarPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.txtTime = new System.Windows.Forms.ToolStripTextBox();
            this.prbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.txtIndex = new System.Windows.Forms.ToolStripTextBox();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnFarNext = new System.Windows.Forms.ToolStripButton();
            this.btnFarFarNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreviousNote = new System.Windows.Forms.ToolStripButton();
            this.btnNextNote = new System.Windows.Forms.ToolStripButton();
            this.txtNote = new System.Windows.Forms.ToolStripTextBox();
            this.btnNote = new System.Windows.Forms.ToolStripButton();
            this.btnBrowse = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bgwShotLoader = new System.ComponentModel.BackgroundWorker();
            this.ptbShot = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShot)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.toolStripSeparator3,
            this.btnRatio,
            this.toolStripSeparator2,
            this.btnFirst,
            this.btnFarFarPrevious,
            this.btnFarPrevious,
            this.btnPrevious,
            this.txtTime,
            this.prbProgress,
            this.txtIndex,
            this.btnNext,
            this.btnFarNext,
            this.btnFarFarNext,
            this.btnLast,
            this.toolStripSeparator1,
            this.btnPreviousNote,
            this.btnNextNote,
            this.txtNote,
            this.btnNote,
            this.btnBrowse,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::MahlerNo2.Viewer.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ToolTipText = "Ctrl+R";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRatio
            // 
            this.btnRatio.CheckOnClick = true;
            this.btnRatio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRatio.Image = global::MahlerNo2.Viewer.Properties.Resources.Ratio;
            this.btnRatio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRatio.Name = "btnRatio";
            this.btnRatio.Size = new System.Drawing.Size(23, 22);
            this.btnRatio.Text = "비율 유지";
            this.btnRatio.ToolTipText = "Ctrl+T";
            this.btnRatio.Click += new System.EventHandler(this.btnRatio_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Image = global::MahlerNo2.Viewer.Properties.Resources.First;
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(23, 22);
            this.btnFirst.Tag = "-1000000";
            this.btnFirst.Text = "First";
            this.btnFirst.ToolTipText = "HOME";
            this.btnFirst.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnFarFarPrevious
            // 
            this.btnFarFarPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFarFarPrevious.Image = global::MahlerNo2.Viewer.Properties.Resources.PPP;
            this.btnFarFarPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFarFarPrevious.Name = "btnFarFarPrevious";
            this.btnFarFarPrevious.Size = new System.Drawing.Size(23, 22);
            this.btnFarFarPrevious.Text = "toolStripButton1";
            this.btnFarFarPrevious.ToolTipText = "Ctrl+Shift+Left";
            this.btnFarFarPrevious.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnFarPrevious
            // 
            this.btnFarPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFarPrevious.Image = global::MahlerNo2.Viewer.Properties.Resources.PP;
            this.btnFarPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFarPrevious.Name = "btnFarPrevious";
            this.btnFarPrevious.Size = new System.Drawing.Size(23, 22);
            this.btnFarPrevious.Text = "Far Previous";
            this.btnFarPrevious.ToolTipText = "Ctrl+Left";
            this.btnFarPrevious.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = global::MahlerNo2.Viewer.Properties.Resources.P;
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 22);
            this.btnPrevious.Tag = "-1";
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.ToolTipText = "Left";
            this.btnPrevious.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtTime
            // 
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(60, 25);
            this.txtTime.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prbProgress
            // 
            this.prbProgress.MarqueeAnimationSpeed = 30;
            this.prbProgress.Name = "prbProgress";
            this.prbProgress.Size = new System.Drawing.Size(60, 22);
            // 
            // txtIndex
            // 
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.ReadOnly = true;
            this.txtIndex.Size = new System.Drawing.Size(80, 25);
            this.txtIndex.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = global::MahlerNo2.Viewer.Properties.Resources.N;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 22);
            this.btnNext.Tag = "1";
            this.btnNext.Text = "Next";
            this.btnNext.ToolTipText = "Right";
            this.btnNext.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnFarNext
            // 
            this.btnFarNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFarNext.Image = global::MahlerNo2.Viewer.Properties.Resources.NN;
            this.btnFarNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFarNext.Name = "btnFarNext";
            this.btnFarNext.Size = new System.Drawing.Size(23, 22);
            this.btnFarNext.Text = "Far Next";
            this.btnFarNext.ToolTipText = "Ctrl+Right";
            this.btnFarNext.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnFarFarNext
            // 
            this.btnFarFarNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFarFarNext.Image = global::MahlerNo2.Viewer.Properties.Resources.NNN;
            this.btnFarFarNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFarFarNext.Name = "btnFarFarNext";
            this.btnFarFarNext.Size = new System.Drawing.Size(23, 22);
            this.btnFarFarNext.Text = "toolStripButton2";
            this.btnFarFarNext.ToolTipText = "Ctrl+Shift+Right";
            this.btnFarFarNext.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Image = global::MahlerNo2.Viewer.Properties.Resources.Last;
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(23, 22);
            this.btnLast.Tag = "1000000";
            this.btnLast.Text = "Last";
            this.btnLast.ToolTipText = "End";
            this.btnLast.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPreviousNote
            // 
            this.btnPreviousNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousNote.Image = global::MahlerNo2.Viewer.Properties.Resources.PreviousNote;
            this.btnPreviousNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousNote.Name = "btnPreviousNote";
            this.btnPreviousNote.Size = new System.Drawing.Size(23, 22);
            this.btnPreviousNote.Text = "Previous Note";
            this.btnPreviousNote.ToolTipText = "Alt+Left";
            this.btnPreviousNote.Click += new System.EventHandler(this.btnMoveNote_Click);
            // 
            // btnNextNote
            // 
            this.btnNextNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextNote.Image = global::MahlerNo2.Viewer.Properties.Resources.NextNote;
            this.btnNextNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextNote.Name = "btnNextNote";
            this.btnNextNote.Size = new System.Drawing.Size(23, 22);
            this.btnNextNote.Text = "Next Note";
            this.btnNextNote.ToolTipText = "Alt+Right";
            this.btnNextNote.Click += new System.EventHandler(this.btnMoveNote_Click);
            // 
            // txtNote
            // 
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(500, 25);
            // 
            // btnNote
            // 
            this.btnNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNote.Image = global::MahlerNo2.Viewer.Properties.Resources.Note;
            this.btnNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(23, 22);
            this.btnNote.Text = "Note";
            this.btnNote.ToolTipText = "Ctrl+N";
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrowse.Image = global::MahlerNo2.Viewer.Properties.Resources.Browser;
            this.btnBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(23, 22);
            this.btnBrowse.Text = "브라우저에서 열기";
            this.btnBrowse.ToolTipText = "Ctrl+B";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::MahlerNo2.Viewer.Properties.Resources.Escape;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Text = "toolStripButton1";
            this.btnExit.ToolTipText = "Esc";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bgwShotLoader
            // 
            this.bgwShotLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwShotLoader_DoWork);
            this.bgwShotLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwShotLoader_RunWorkerCompleted);
            // 
            // ptbShot
            // 
            this.ptbShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbShot.Location = new System.Drawing.Point(0, 25);
            this.ptbShot.Name = "ptbShot";
            this.ptbShot.Size = new System.Drawing.Size(1184, 425);
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
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewerForm";
            this.Text = "ViewerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox ptbShot;
        private System.Windows.Forms.ToolStripButton btnRatio;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnFarPrevious;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripTextBox txtTime;
        private System.Windows.Forms.ToolStripProgressBar prbProgress;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnFarNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtNote;
        private System.Windows.Forms.ToolStripButton btnBrowse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripTextBox txtIndex;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnPreviousNote;
        private System.Windows.Forms.ToolStripButton btnNextNote;
        private System.ComponentModel.BackgroundWorker bgwShotLoader;
        private System.Windows.Forms.ToolStripButton btnNote;
        private System.Windows.Forms.ToolStripButton btnFarFarPrevious;
        private System.Windows.Forms.ToolStripButton btnFarFarNext;
    }
}

