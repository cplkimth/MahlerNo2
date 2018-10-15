#region
using System;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Viewer.Components;
#endregion

namespace MahlerNo2.Viewer.Forms
{
    public partial class BackupForm : Form
    {
        private BackupForm()
        {
            InitializeComponent();
        }

        public BackupForm(DateTime date) : this()
        {
            _date = date;
        }

        private readonly DateTime _date;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.IsRunTime == false)
                return;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            bdsBackup.DataSource = ApiClient.Instance.GetFileNamesInDate(_date.ToDateString()).ConvertAll(x => new BackupItem(x));
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var text = (string) dgvList[e.ColumnIndex, e.RowIndex].Value;

            if (text == null)
                return;

            var bytes = ApiClient.Instance.GetShotForBackup(_date.ToDateString(), text);
            MessageBox.Show(bytes.Length.ToString());
        }
    }

    public class BackupItem
    {
        public BackupItem(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; set; }

        public bool Downloaded { get; set; }
    }
}