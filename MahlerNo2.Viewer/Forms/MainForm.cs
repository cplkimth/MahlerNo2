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

            if (DesignMode || Program.OnRunTime == false)
                return;

            txtVersion.Text += Utility.GetProductVersion();
            txtIP.Text = Settings.Default.IP;
            txtPort.Text = Settings.Default.Port.ToString();
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var text = (string) dgvList[e.ColumnIndex, e.RowIndex].Value;
            var date = DateTime.ParseExact(text, Utility.DateFormat, null);
            
            Hide();
            Form form = new ShotForm(date);
            form.ShowDialog();
            Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bdsShotFolder.DataSource = ApiClient.Instance.GetDateList().ConvertAll(x => new ShotFolder(x));

            Settings.Default.IP = txtIP.Text;
            Settings.Default.Port = int.Parse(txtPort.Text);
            Settings.Default.Save();
        }
    }
}