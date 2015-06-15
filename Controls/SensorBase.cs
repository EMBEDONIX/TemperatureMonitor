using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using TempMonitor.Controls.Properties;

namespace TempMonitor.Controls
{
    public partial class SensorBase : MetroUserControl, IMetroControl
    {
        private readonly Func<double, double> _runningAverage = SimpleMovingAverage(65535);
        private int counter; //to count received samples
        private PictureBox pbEditLabel; //to edit label

        public SensorBase()
        {
            InitializeComponent();
            HighestSample = 0;
            LowestSample = 0;
            Average = _runningAverage(0);

            UpdateLabels();
        }

        public string SensorName { get; set; }
        public double HighestSample { get; private set; }
        public double LowestSample { get; private set; }
        public double Average { get; private set; }

        protected void UpdateLabels()
        {
            labelHighest.Text = string.Format("{0:F}", HighestSample) + " °C";
            LabelLowest.Text = string.Format("{0:F}", LowestSample) + " °C";
            labelAverage.Text = string.Format("{0:F}", Average) + " °C";
            graph.SetTotalAverage(Average);
        }

        private static Func<double, double> SimpleMovingAverage(int window)
        {
            var s = new Queue<double>(window);
            return x =>
            {
                if (s.Count >= window)
                    s.Dequeue();

                s.Enqueue(x);
                return s.Average();
            };
        }

        private void SensorControl_Load(object sender, EventArgs e)
        {
        }

        public void AddSample(GraphPoint sample)
        {
            var value = (double) sample.Value;

            if (counter == 0)
            {
                HighestSample = value;
                LowestSample = value;
                Average = value;
                Average = _runningAverage(value);
                counter++;
            }
            else
            {
                //Check for highest, lowest
                if (value > HighestSample)
                    HighestSample = value;

                if (value < LowestSample)
                    LowestSample = value;

                //Update running average
                Average = _runningAverage(value);
            }

            //update labels
            UpdateLabels();

            OnSampleReceived(sample);

            //Add the point to graph
            graph.AddValue(sample);
        }

        public virtual void OnSampleReceived(GraphPoint sample)
        {
        }

        public void SetName(string name)
        {
            labelName.Text = name;
        }

        private void panelLabels_MouseEnter(object sender, EventArgs e)
        {
            panelLabels.Focus();
            pbEditLabel = new PictureBox();
            pbEditLabel.Image = Resources.edit;
            pbEditLabel.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEditLabel.Size = new Size(labelName.Height - 4, labelName.Height - 4);
            pbEditLabel.Location = new Point(labelName.Location.X + labelName.Width + 5, labelName.Location.Y);
            pbEditLabel.Click += (o, args) => { MessageBox.Show("EDIT!"); };

            panelLabels.SuspendLayout();
            panelLabels.Controls.Add(pbEditLabel);
            panelLabels.ResumeLayout();
        }

        private void panelLabels_MouseLeave(object sender, EventArgs e)
        {
            if (pbEditLabel != null)
            {
                panelLabels.SuspendLayout();
                panelLabels.Controls.Remove(pbEditLabel);
                panelLabels.ResumeLayout();
                pbEditLabel = null;
            }
        }
    }
}