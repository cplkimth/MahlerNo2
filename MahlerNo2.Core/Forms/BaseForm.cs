using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace MahlerNo2.Core.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            if (FormIcon != null)
                Icon = FormIcon;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Setting?.Save();

            base.OnClosing(e);
        }

        protected virtual Icon FormIcon => null;

        protected virtual ApplicationSettingsBase Setting => null;
    }
}