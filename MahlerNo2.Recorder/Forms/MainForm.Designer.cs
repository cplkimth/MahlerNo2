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
            this.grbNote = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOption = new System.Windows.Forms.ToolStripButton();
            this.btnDummy = new System.Windows.Forms.Button();
            this.grbNote.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrShot
            // 
            this.tmrShot.Interval = 1000;
            this.tmrShot.Tick += new System.EventHandler(this.tmrShot_Tick);
            // 
            // grbNote
            // 
            this.grbNote.Controls.Add(this.btnDummy);
            this.grbNote.Controls.Add(this.txtNote);
            this.grbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbNote.Location = new System.Drawing.Point(0, 25);
            this.grbNote.Name = "grbNote";
            this.grbNote.Padding = new System.Windows.Forms.Padding(5);
            this.grbNote.Size = new System.Drawing.Size(379, 168);
            this.grbNote.TabIndex = 7;
            this.grbNote.TabStop = false;
            this.grbNote.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(5, 19);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(369, 144);
            this.txtNote.TabIndex = 5;
            this.txtNote.Enter += new System.EventHandler(this.txtNote_Enter);
            this.txtNote.Leave += new System.EventHandler(this.txtNote_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlay,
            this.toolStripSeparator1,
            this.tsbOption});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::MahlerNo2.Recorder.Properties.Resources.Play;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(23, 22);
            this.tsbPlay.Text = "toolStripButton1";
            this.tsbPlay.ToolTipText = "Toggle Play/Pause";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOption
            // 
            this.tsbOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOption.Image = global::MahlerNo2.Recorder.Properties.Resources.Option;
            this.tsbOption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOption.Name = "tsbOption";
            this.tsbOption.Size = new System.Drawing.Size(23, 22);
            this.tsbOption.Text = "Option";
            this.tsbOption.ToolTipText = "Option";
            this.tsbOption.Click += new System.EventHandler(this.tsbOption_Click);
            // 
            // btnDummy
            // 
            this.btnDummy.Location = new System.Drawing.Point(134, 110);
            this.btnDummy.Name = "btnDummy";
            this.btnDummy.Size = new System.Drawing.Size(0, 0);
            this.btnDummy.TabIndex = 6;
            this.btnDummy.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 193);
            this.Controls.Add(this.grbNote);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mahler No. 2 Recorder";
            this.grbNote.ResumeLayout(false);
            this.grbNote.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbNote;
        private System.Windows.Forms.Button btnDummy;
    }
}

