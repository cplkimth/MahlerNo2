using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Viewer.Components;
using MahlerNo2.Viewer.Properties;

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

            txtShotFolder.Text = Settings.Default.ShotFolder;

            LoadDirectories();

            Text += @" - " + Utility.GetProductVersion();
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var text = (string) dgvList[e.ColumnIndex, e.RowIndex].Value;
            var date = DateTime.ParseExact(text, Utility.DateFormat, null);
            Form form = new ViewerForm(date);
            form.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (fbdShotFolder.ShowDialog() != DialogResult.OK)
                return;

            txtShotFolder.Text = fbdShotFolder.SelectedPath;

            LoadDirectories();
        }

        private void LoadDirectories()
        {
            if (!Directory.Exists(txtShotFolder.Text))
                return;

            Settings.Default.ShotFolder = txtShotFolder.Text;

            var root = new DirectoryInfo(txtShotFolder.Text);
            var shotFolders = root.EnumerateDirectories()
                .Where(x => x.IsValidDate())
                .OrderByDescending(x => x.Name)
                .Select(x => new ShotFolder(x.Name))
                .ToList();

            bdsShotFolder.DataSource = shotFolders;
        }
    }
}