#region using

using System;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Data;
using MahlerNo2.Data.Components;
using MahlerNo2.Viewer.Components;
using MahlerNo2.Viewer.Properties;

#endregion

namespace MahlerNo2.Viewer.Forms
{
    public partial class MainForm : ViewerBaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode || Program.IsRunTime == false)
                return;

            lblVersion.Text += Utility.GetProductVersion();
            txtAddress.Text = Settings.Default.Address;
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var text = (string) dgvList[e.ColumnIndex, e.RowIndex].Value;

            if (text == null)
                return;

            var date = DateTime.ParseExact(text, Utility.DateFormat, null);
            
            Hide();
            Form form = new ShotForm(date);
            form.ShowDialog();
            Show();
        }

        private void btnConnectOnline_Click(object sender, EventArgs e)
        {
            Settings.Default.Address = txtAddress.Text;
            Settings.Default.Save();

            DbContextFactory.ChangeIpAddress(Settings.Default.Address);

            bdsShotFolder.DataSource = DataRepository.Shot.GetDateList().ConvertAll(x => new StringItem(x));
        }

        private void btnConnectOffline_Click(object sender, EventArgs e)
        {
            Program.OfflineMode = true;

            bdsShotFolder.DataSource = OfflineShotManager.Instance.GetDateList().ConvertAll(x => new StringItem(x));
        }
    }
}