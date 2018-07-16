using MahlerNo2.Recorder.Controls;

namespace MahlerNo2.Recorder.Forms
{
    partial class ScreenSelectionForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uscLeftScreen = new ScreenSelectionControl();
            this.uscRightScreen = new ScreenSelectionControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.uscRightScreen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uscLeftScreen, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uscLeftScreen
            // 
            this.uscLeftScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscLeftScreen.Location = new System.Drawing.Point(3, 3);
            this.uscLeftScreen.Name = "uscLeftScreen";
            this.uscLeftScreen.Size = new System.Drawing.Size(394, 444);
            this.uscLeftScreen.TabIndex = 0;
            this.uscLeftScreen.ScreenSelected += new System.EventHandler<ScreenSelectionControl.ScreenSelectedEventArgs>(this.uscScreenSelector_ScreenSelected);
            // 
            // uscRightScreen
            // 
            this.uscRightScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscRightScreen.Location = new System.Drawing.Point(403, 3);
            this.uscRightScreen.Name = "uscRightScreen";
            this.uscRightScreen.Size = new System.Drawing.Size(394, 444);
            this.uscRightScreen.TabIndex = 1;
            this.uscRightScreen.ScreenSelected += new System.EventHandler<ScreenSelectionControl.ScreenSelectedEventArgs>(this.uscScreenSelector_ScreenSelected);
            // 
            // ScreenSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ScreenSelectionForm";
            this.Text = "ScreenSelectionForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ScreenSelectionControl uscLeftScreen;
        private ScreenSelectionControl uscRightScreen;
    }
}