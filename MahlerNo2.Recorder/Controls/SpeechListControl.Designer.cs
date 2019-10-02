namespace MahlerNo2.Recorder.Controls
{
    partial class SpeechListControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSpeech = new System.Windows.Forms.DataGridView();
            this.bgwSpeech = new System.ComponentModel.BackgroundWorker();
            this.chbToSpeacker = new System.Windows.Forms.CheckBox();
            this.At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeech)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpeech
            // 
            this.dgvSpeech.AllowUserToAddRows = false;
            this.dgvSpeech.AllowUserToDeleteRows = false;
            this.dgvSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSpeech.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpeech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeech.ColumnHeadersVisible = false;
            this.dgvSpeech.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.At,
            this.Text});
            this.dgvSpeech.Location = new System.Drawing.Point(3, 25);
            this.dgvSpeech.Name = "dgvSpeech";
            this.dgvSpeech.ReadOnly = true;
            this.dgvSpeech.RowTemplate.Height = 23;
            this.dgvSpeech.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpeech.Size = new System.Drawing.Size(528, 319);
            this.dgvSpeech.TabIndex = 0;
            // 
            // bgwSpeech
            // 
            this.bgwSpeech.WorkerReportsProgress = true;
            this.bgwSpeech.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSpeech_DoWork);
            this.bgwSpeech.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSpeech_ProgressChanged);
            // 
            // chbToSpeacker
            // 
            this.chbToSpeacker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbToSpeacker.AutoSize = true;
            this.chbToSpeacker.Checked = true;
            this.chbToSpeacker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbToSpeacker.Location = new System.Drawing.Point(3, 3);
            this.chbToSpeacker.Name = "chbToSpeacker";
            this.chbToSpeacker.Size = new System.Drawing.Size(88, 16);
            this.chbToSpeacker.TabIndex = 1;
            this.chbToSpeacker.Text = "스피커 출력";
            this.chbToSpeacker.UseVisualStyleBackColor = true;
            // 
            // At
            // 
            this.At.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.At.HeaderText = "Column1";
            this.At.Name = "At";
            this.At.ReadOnly = true;
            this.At.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Text
            // 
            this.Text.HeaderText = "Column1";
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            // 
            // SpeechListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbToSpeacker);
            this.Controls.Add(this.dgvSpeech);
            this.Name = "SpeechListControl";
            this.Size = new System.Drawing.Size(534, 347);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeech)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpeech;
        private System.ComponentModel.BackgroundWorker bgwSpeech;
        private System.Windows.Forms.CheckBox chbToSpeacker;
        private System.Windows.Forms.DataGridViewTextBoxColumn At;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
    }
}
