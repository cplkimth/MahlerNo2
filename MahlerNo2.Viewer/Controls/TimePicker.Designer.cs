namespace MahlerNo2.Viewer.Controls
{
    partial class TimePicker
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
            this.components = new System.ComponentModel.Container();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnMinus600 = new System.Windows.Forms.Button();
            this.btnMinus60 = new System.Windows.Forms.Button();
            this.btnPlus60 = new System.Windows.Forms.Button();
            this.btnPlus600 = new System.Windows.Forms.Button();
            this.btnPrevNote = new System.Windows.Forms.Button();
            this.btnNextNote = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm:ss";
            this.dtpTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(3, 3);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(71, 21);
            this.dtpTime.TabIndex = 4;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // btnMinus600
            // 
            this.btnMinus600.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinus600.Location = new System.Drawing.Point(84, 3);
            this.btnMinus600.Name = "btnMinus600";
            this.btnMinus600.Size = new System.Drawing.Size(38, 21);
            this.btnMinus600.TabIndex = 5;
            this.btnMinus600.Text = "-600";
            this.btnMinus600.UseVisualStyleBackColor = true;
            this.btnMinus600.Click += new System.EventHandler(this.btnSeconds_Click);
            // 
            // btnMinus60
            // 
            this.btnMinus60.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinus60.Location = new System.Drawing.Point(122, 3);
            this.btnMinus60.Name = "btnMinus60";
            this.btnMinus60.Size = new System.Drawing.Size(38, 21);
            this.btnMinus60.TabIndex = 6;
            this.btnMinus60.Text = "-60";
            this.btnMinus60.UseVisualStyleBackColor = true;
            this.btnMinus60.Click += new System.EventHandler(this.btnSeconds_Click);
            // 
            // btnPlus60
            // 
            this.btnPlus60.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlus60.Location = new System.Drawing.Point(160, 3);
            this.btnPlus60.Name = "btnPlus60";
            this.btnPlus60.Size = new System.Drawing.Size(38, 21);
            this.btnPlus60.TabIndex = 8;
            this.btnPlus60.Text = "+60";
            this.btnPlus60.UseVisualStyleBackColor = true;
            this.btnPlus60.Click += new System.EventHandler(this.btnSeconds_Click);
            // 
            // btnPlus600
            // 
            this.btnPlus600.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlus600.Location = new System.Drawing.Point(198, 3);
            this.btnPlus600.Name = "btnPlus600";
            this.btnPlus600.Size = new System.Drawing.Size(38, 21);
            this.btnPlus600.TabIndex = 7;
            this.btnPlus600.Text = "+600";
            this.btnPlus600.UseVisualStyleBackColor = true;
            this.btnPlus600.Click += new System.EventHandler(this.btnSeconds_Click);
            // 
            // btnPrevNote
            // 
            this.btnPrevNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevNote.Location = new System.Drawing.Point(246, 3);
            this.btnPrevNote.Name = "btnPrevNote";
            this.btnPrevNote.Size = new System.Drawing.Size(50, 21);
            this.btnPrevNote.TabIndex = 9;
            this.btnPrevNote.Text = "-Note";
            this.btnPrevNote.UseVisualStyleBackColor = true;
            this.btnPrevNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnNextNote
            // 
            this.btnNextNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNextNote.Location = new System.Drawing.Point(296, 3);
            this.btnNextNote.Name = "btnNextNote";
            this.btnNextNote.Size = new System.Drawing.Size(50, 21);
            this.btnNextNote.TabIndex = 10;
            this.btnNextNote.Text = "+Note";
            this.btnNextNote.UseVisualStyleBackColor = true;
            this.btnNextNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::MahlerNo2.Viewer.Properties.Resources.Play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.Location = new System.Drawing.Point(356, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 21);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MahlerNo2.Viewer.Properties.Resources.Bar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(74, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 21);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MahlerNo2.Viewer.Properties.Resources.Bar;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(236, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 21);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::MahlerNo2.Viewer.Properties.Resources.Bar;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(346, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 21);
            this.panel3.TabIndex = 13;
            // 
            // TimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnNextNote);
            this.Controls.Add(this.btnPrevNote);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPlus600);
            this.Controls.Add(this.btnPlus60);
            this.Controls.Add(this.btnMinus60);
            this.Controls.Add(this.btnMinus600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpTime);
            this.Name = "TimePicker";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(567, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnMinus600;
        private System.Windows.Forms.Button btnMinus60;
        private System.Windows.Forms.Button btnPlus60;
        private System.Windows.Forms.Button btnPlus600;
        private System.Windows.Forms.Button btnPrevNote;
        private System.Windows.Forms.Button btnNextNote;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
