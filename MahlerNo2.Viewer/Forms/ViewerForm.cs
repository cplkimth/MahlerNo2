using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MahlerNo2.Core.Components;
using MahlerNo2.Viewer.Properties;

namespace MahlerNo2.Viewer.Forms
{
    public partial class ViewerForm : ViewerBaseForm
    {
        private ViewerForm()
        {
            InitializeComponent();

//            btnFarPrevious.Tag = (Settings.Default.NSecond * -1).ToString();
//            btnFarNext.Tag = (Settings.Default.FarMoveStep * 1).ToString();
//            btnFarFarPrevious.Tag = (Settings.Default.FarFarMoveStep * -1).ToString();
//            btnFarFarNext.Tag = (Settings.Default.FarFarMoveStep * 1).ToString();

            btnRatio.Checked = Settings.Default.KeepRatio;
        }

        public ViewerForm(DateTime date) : this()
        {
            _date = date;
        }

        private readonly DateTime _date;

        private List<Shot> _shots;

        private int _shotIndex = -1;

        private Shot CurrentShot => _shots[_shotIndex];

        #region MoveButtons

        private List<ToolStripButton> MoveButtons => new List<ToolStripButton>
        {
            btnFirst,
            btnFarFarPrevious,
            btnFarPrevious,
            btnPrevious,
            btnNext,
            btnFarNext,
            btnFarFarNext,
            btnLast
        };

        private List<ToolStripButton> LeftMoveButtons => new List<ToolStripButton>
        {
            btnFirst,
            btnFarPrevious,
            btnFarFarPrevious,
            btnPrevious
        };

        private List<ToolStripButton> RightMoveButtons => new List<ToolStripButton>
        {
            btnNext,
            btnFarNext,
            btnFarFarNext,
            btnLast
        };

        #endregion

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode || Program.OnRunTime == false)
                return;

            btnRefresh.PerformClick();
        }

        private void LoadCurrentShot()
        {
            if (_shotIndex == -1)
            {
                MoveButtons.ForEach(x => x.Enabled = false);
                txtTime.Text = string.Empty;
                txtIndex.Text = string.Empty;
                prbProgress.Value = 0;

                txtNote.Text = string.Empty;
                btnBrowse.Enabled = false;
            }

            txtTime.Text = CurrentShot.Time.ToString("HH:mm:ss");
            txtIndex.Text = $@"{_shotIndex + 1:N0}/{_shots.Count:N0}";
            prbProgress.Value = _shotIndex + 1;

            txtNote.Text = CurrentShot.Note;
            btnBrowse.Enabled = txtNote.Text.ToLower().StartsWith("http");

            LeftMoveButtons.ForEach(x => x.Enabled = _shotIndex > 0);
            RightMoveButtons.ForEach(x => x.Enabled = _shotIndex < _shots.Count - 1);

            var imagePath = Path.Combine(Settings.Default.ShotFolder, _date.ToString(Utility.DateFormat));
            imagePath = Path.Combine(imagePath,
                CurrentShot.Time.ToString(Utility.DateTimeFormat) + Utility.ImageFileExtension);
            ptbShot.Image = Image.FromFile(imagePath);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            var tag = ((ToolStripButton) sender).Tag.ToString();
            var step = int.Parse(tag);

            _shotIndex += step;

            if (_shotIndex < 0)
                _shotIndex = 0;
            else if (_shotIndex > _shots.Count - 1)
                _shotIndex = _shots.Count - 1;

            LoadCurrentShot();
        }

        private void btnMoveNote_Click(object sender, EventArgs e)
        {
            var step = sender == btnPreviousNote ? -1 : 1;

            var index = _shotIndex + step;

            while (index >= 0 && index < _shots.Count)
            {
                if (_shots[index].Note != string.Empty)
                {
                    _shotIndex = index;
                    LoadCurrentShot();
                    return;
                }

                index += step;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Process.Start(txtNote.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRatio_Click(object sender, EventArgs e)
        {
            Settings.Default.KeepRatio = btnRatio.Checked;

            ptbShot.SizeMode = Settings.Default.KeepRatio ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.StretchImage;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            prbProgress.Style = ProgressBarStyle.Marquee;
            Enabled = false;

            bgwShotLoader.RunWorkerAsync();
        }

        private void bgwShotLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            var directory =
                new DirectoryInfo(Path.Combine(Settings.Default.ShotFolder, _date.ToString(Utility.DateFormat)));

            var pngs = directory.EnumerateFiles("*" + Utility.ImageFileExtension);
            _shots = pngs
                .Select(x => new Shot(x.ToDateTime()))
                .OrderBy(x => x.Time)
                .ToList();

            var noteFiles = directory.EnumerateFiles("*" + Utility.NoteFileExtension);
            foreach (var noteFile in noteFiles)
            {
                var shot = _shots.Find(x => noteFile.ToDateTime() == x.Time);

                if (shot == null)
                    continue;

                shot.Note = File.ReadAllText(noteFile.FullName);
            }
        }

        private void bgwShotLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            prbProgress.Style = ProgressBarStyle.Blocks;
            Enabled = true;

            prbProgress.Maximum = _shots.Count;
            prbProgress.Value = 0;

            _shotIndex = _shots.Count == 0 ? -1 : 0;

            LoadCurrentShot();
        }
    }
}