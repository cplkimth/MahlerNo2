namespace MahlerNo2.Recorder.Forms
{
    partial class OptionForm
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
            this.nupShotInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.trbOpacity = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.nupMaxPreviousShot = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nupEmoticonInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nupLatestEmoticonMinute = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupShotInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxPreviousShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEmoticonInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLatestEmoticonMinute)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nupShotInterval
            // 
            this.nupShotInterval.Location = new System.Drawing.Point(112, 25);
            this.nupShotInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupShotInterval.Name = "nupShotInterval";
            this.nupShotInterval.Size = new System.Drawing.Size(53, 25);
            this.nupShotInterval.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "주기(초) :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(285, 305);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(192, 305);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 29);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // trbOpacity
            // 
            this.trbOpacity.LargeChange = 20;
            this.trbOpacity.Location = new System.Drawing.Point(97, 249);
            this.trbOpacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trbOpacity.Maximum = 100;
            this.trbOpacity.Minimum = 20;
            this.trbOpacity.Name = "trbOpacity";
            this.trbOpacity.Size = new System.Drawing.Size(275, 56);
            this.trbOpacity.SmallChange = 5;
            this.trbOpacity.TabIndex = 3;
            this.trbOpacity.TickFrequency = 5;
            this.trbOpacity.Value = 100;
            this.trbOpacity.Scroll += new System.EventHandler(this.trbTranparent_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "투명도 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nupMaxPreviousShot
            // 
            this.nupMaxPreviousShot.Location = new System.Drawing.Point(294, 25);
            this.nupMaxPreviousShot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupMaxPreviousShot.Name = "nupMaxPreviousShot";
            this.nupMaxPreviousShot.Size = new System.Drawing.Size(53, 25);
            this.nupMaxPreviousShot.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "최근(갯수): ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(112, 25);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(235, 25);
            this.txtAddress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "IP : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nupEmoticonInterval
            // 
            this.nupEmoticonInterval.Location = new System.Drawing.Point(112, 25);
            this.nupEmoticonInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupEmoticonInterval.Name = "nupEmoticonInterval";
            this.nupEmoticonInterval.Size = new System.Drawing.Size(53, 25);
            this.nupEmoticonInterval.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "주기(초) :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nupLatestEmoticonMinute
            // 
            this.nupLatestEmoticonMinute.Location = new System.Drawing.Point(294, 25);
            this.nupLatestEmoticonMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupLatestEmoticonMinute.Name = "nupLatestEmoticonMinute";
            this.nupLatestEmoticonMinute.Size = new System.Drawing.Size(53, 25);
            this.nupLatestEmoticonMinute.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "피드백(분) :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nupShotInterval);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nupMaxPreviousShot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 59);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "샷";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nupEmoticonInterval);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nupLatestEmoticonMinute);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "피드백";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 59);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IP";
            // 
            // OptionForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 349);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trbOpacity);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OptionForm";
            this.Text = "Option";
            ((System.ComponentModel.ISupportInitialize)(this.nupShotInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxPreviousShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEmoticonInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLatestEmoticonMinute)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nupShotInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TrackBar trbOpacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupMaxPreviousShot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupEmoticonInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupLatestEmoticonMinute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}