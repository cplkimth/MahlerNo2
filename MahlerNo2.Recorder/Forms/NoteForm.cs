using System;
using System.Windows.Forms;
using MahlerNo2.Core.Components;

namespace MahlerNo2.Recorder.Forms
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
        }

        public Note Note => new Note(rdbText.Checked ? NoteType.Text : NoteType.Url, txtNote.Text);

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.OnRunTime == false)
                return;

            if (Clipboard.GetData(DataFormats.Text) is string clipboardText)
                txtNote.Text = clipboardText;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}