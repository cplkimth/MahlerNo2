using System.Configuration;
using System.Drawing;
using MahlerNo2.Core.Forms;
using MahlerNo2.Recorder.Properties;

namespace MahlerNo2.Recorder.Forms
{
    public partial class RecorderBaseForm : BaseForm
    {
        public RecorderBaseForm()
        {
            InitializeComponent();
        }

        protected override Icon FormIcon => Resources.Mahler;
    }
}