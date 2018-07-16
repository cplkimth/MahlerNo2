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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblNote = new System.Windows.Forms.Label();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbNote = new System.Windows.Forms.ToolStripButton();
            this.tsbOption = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbUrl = new System.Windows.Forms.RadioButton();
            this.rdbText = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grbNote = new System.Windows.Forms.GroupBox();
            this.btnCancelNote = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrShot
            // 
            this.tmrShot.Interval = 1000;
            this.tmrShot.Tick += new System.EventHandler(this.tmrShot_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlay,
            this.toolStripSeparator1,
            this.tsbNote,
            this.toolStripSeparator2,
            this.tsbOption});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblNote
            // 
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.Location = new System.Drawing.Point(0, 25);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new System.Windows.Forms.Padding(5);
            this.lblNote.Size = new System.Drawing.Size(379, 168);
            this.lblNote.TabIndex = 5;
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::MahlerNo2.Recorder.Properties.Resources.Pause;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(23, 22);
            this.tsbPlay.Text = "toolStripButton1";
            this.tsbPlay.ToolTipText = "Toggle Play/Pause (CTRL ALT F12)";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbNote
            // 
            this.tsbNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNote.Image = global::MahlerNo2.Recorder.Properties.Resources.Note;
            this.tsbNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNote.Name = "tsbNote";
            this.tsbNote.Size = new System.Drawing.Size(23, 22);
            this.tsbNote.Text = "Note";
            this.tsbNote.ToolTipText = "Toggle Play/Pause (CTRL ALT F11)";
            this.tsbNote.Click += new System.EventHandler(this.tsbNote_Click);
            // 
            // tsbOption
            // 
            this.tsbOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOption.Image = global::MahlerNo2.Recorder.Properties.Resources.Option;
            this.tsbOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOption.Name = "tsbOption";
            this.tsbOption.Size = new System.Drawing.Size(23, 22);
            this.tsbOption.Text = "Option";
            this.tsbOption.ToolTipText = "Option (CTRL ALT F11)";
            this.tsbOption.Click += new System.EventHandler(this.tsbOption_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbUrl);
            this.panel2.Controls.Add(this.rdbText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 30);
            this.panel2.TabIndex = 3;
            // 
            // rdbUrl
            // 
            this.rdbUrl.AutoSize = true;
            this.rdbUrl.Location = new System.Drawing.Point(57, 6);
            this.rdbUrl.Name = "rdbUrl";
            this.rdbUrl.Size = new System.Drawing.Size(46, 16);
            this.rdbUrl.TabIndex = 1;
            this.rdbUrl.Text = "URL";
            this.rdbUrl.UseVisualStyleBackColor = true;
            // 
            // rdbText
            // 
            this.rdbText.AutoSize = true;
            this.rdbText.Checked = true;
            this.rdbText.Location = new System.Drawing.Point(3, 6);
            this.rdbText.Name = "rdbText";
            this.rdbText.Size = new System.Drawing.Size(48, 16);
            this.rdbText.TabIndex = 0;
            this.rdbText.TabStop = true;
            this.rdbText.Text = "Text";
            this.rdbText.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancelNote);
            this.panel3.Controls.Add(this.btnAddNote);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 33);
            this.panel3.TabIndex = 4;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNote.Location = new System.Drawing.Point(206, 3);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.Text = "&Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(5, 49);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(369, 81);
            this.txtNote.TabIndex = 5;
            // 
            // grbNote
            // 
            this.grbNote.Controls.Add(this.txtNote);
            this.grbNote.Controls.Add(this.panel3);
            this.grbNote.Controls.Add(this.panel2);
            this.grbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbNote.Enabled = false;
            this.grbNote.Location = new System.Drawing.Point(0, 25);
            this.grbNote.Name = "grbNote";
            this.grbNote.Padding = new System.Windows.Forms.Padding(5);
            this.grbNote.Size = new System.Drawing.Size(379, 168);
            this.grbNote.TabIndex = 7;
            this.grbNote.TabStop = false;
            this.grbNote.Text = "Note";
            // 
            // btnCancelNote
            // 
            this.btnCancelNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelNote.Location = new System.Drawing.Point(287, 3);
            this.btnCancelNote.Name = "btnCancelNote";
            this.btnCancelNote.Size = new System.Drawing.Size(75, 23);
            this.btnCancelNote.TabIndex = 1;
            this.btnCancelNote.Text = "&Cancel";
            this.btnCancelNote.UseVisualStyleBackColor = true;
            this.btnCancelNote.Click += new System.EventHandler(this.btnCancelNote_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 193);
            this.Controls.Add(this.grbNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resurrection";
            this.TopMost = true;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grbNote.ResumeLayout(false);
            this.grbNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrShot;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOption;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbUrl;
        private System.Windows.Forms.RadioButton rdbText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox grbNote;
        private System.Windows.Forms.Button btnCancelNote;
    }
}

