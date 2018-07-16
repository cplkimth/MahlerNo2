using System.Configuration;
using System.Drawing;
using MahlerNo2.Core.Forms;
using MahlerNo2.Viewer.Properties;

namespace MahlerNo2.Viewer.Forms
{
    public partial class ViewerBaseForm : BaseForm
    {
        public ViewerBaseForm()
        {
            InitializeComponent();
        }

        protected override Icon FormIcon => Resources.Mahler;

        protected override ApplicationSettingsBase Setting => Settings.Default;
    }
}