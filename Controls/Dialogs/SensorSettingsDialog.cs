using System;
using TempMonitor.Controls.Sensors;

namespace TempMonitor.Controls.Dialogs
{
    public partial class SensorSettingsDialog : DialogForm
    {

        public SensorSettings NewSettings;
        public SensorOptions Options { get; private set; }
        
        public SensorSettingsDialog()
        {
            InitializeComponent();
        }
        
        public SensorSettingsDialog(SensorSettings oldSettings
            ,SensorOptions options) : this()
        {
            NewSettings = oldSettings;
            Options = options;
            textBox1.Text = oldSettings.SensorName;
        }

        private void RenameDialogForm_Load(object sender, System.EventArgs e)
        {

            

            textBox1.SelectAll();
            textBox1.Select();

            try
            {
                metroTrackBar1.Maximum = Options.ChartMaxValue;
                metroTrackBar1.Minimum = Options.ChartMinValue;
                metroTrackBar1.Value = NewSettings.AlarmPoint;
                metroToggle1.Checked = NewSettings.SpeechEnabled;

            }
            catch (Exception)
            {
                //metroTrackBar1.Minimum = 0;
                //metroTrackBar1.Maximum = 100;
            }
        }

        protected override void buttonApply_Click(object sender, EventArgs e)
        {
            NewSettings.SensorName = textBox1.Text;
            NewSettings.AlarmPoint = metroTrackBar1.Value;
            NewSettings.SpeechEnabled = metroToggle1.Checked;

            base.buttonApply_Click(sender, e);
        }

        private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            metroLabel3.Text = metroTrackBar1.Value + " °C";
        }
    }
}
