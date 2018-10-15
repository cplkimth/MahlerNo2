#region using

using System;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
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
            txtIP.Text = Settings.Default.IP;
            txtPort.Text = Settings.Default.Port.ToString();
            txtBrowse.Text = Settings.Default.ShotRoot;
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
            Settings.Default.IP = txtIP.Text;
            Settings.Default.Port = int.Parse(txtPort.Text);
            Settings.Default.Save();

            this.Run(
                () => bdsShotFolder.DataSource = ApiClient.Instance.GetDateList().ConvertAll(x => new StringItem(x))
                );
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (fbdBrowse.ShowDialog() != DialogResult.OK)
                return;

            txtBrowse.Text = fbdBrowse.SelectedPath;
        }

        private void btnConnectOffline_Click(object sender, EventArgs e)
        {
            Program.OfflineMode = true;
            Settings.Default.ShotRoot = txtBrowse.Text;

            bdsShotFolder.DataSource = Utility.GetShotFolderList(Settings.Default.ShotRoot).ConvertAll(x => new StringItem(x));
        }
    }
}