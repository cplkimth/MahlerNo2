using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MahlerNo2.Core.Forms;

namespace MahlerNo2.Viewer.Forms
{
    public partial class NoteForm : ViewerBaseForm
    {
        public NoteForm(string note)
        {
            InitializeComponent();

            txtNote.Text = note;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
