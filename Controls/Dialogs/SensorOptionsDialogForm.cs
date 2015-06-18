using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempMonitor.Controls.Dialogs
{
    public partial class SensorOptionsDialogForm : DialogForm
    {

        public SensorOptions Options { get; private set; }

        public SensorOptionsDialogForm()
        {
            InitializeComponent();
        }

        public SensorOptionsDialogForm(SensorOptions options) : this()
        {
            Options = options;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Environment.SpecialFolder.MyDocuments.ToString();
        }
    }
}
