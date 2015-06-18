using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SensorChart
{
    [TypeConverter(typeof (ExpandableObjectConverter))]
    public class RunningGraphStyle
    {
        private bool antiAliasing = true;
        private Color backgroundColorBottom = Color.DarkGreen;
        private Color backgroundColorTop = Color.DarkGreen;
        private bool showAverageLine = true;
        private bool showHorizontalGridLines = true;
        private bool showVerticalGridLines = true;

        public RunningGraphStyle()
        {
            VerticalGridPen = new ChartPen();
            HorizontalGridPen = new ChartPen();
            AvgLinePen = new ChartPen();
            ChartLinePen = new ChartPen();
        }

        public bool ShowVerticalGridLines
        {
            get { return showVerticalGridLines; }
            set { showVerticalGridLines = value; }
        }

        public bool ShowHorizontalGridLines
        {
            get { return showHorizontalGridLines; }
            set { showHorizontalGridLines = value; }
        }

        public bool ShowAverageLine
        {
            get { return showAverageLine; }
            set { showAverageLine = value; }
        }

        public ChartPen VerticalGridPen { get; set; }
        public ChartPen HorizontalGridPen { get; set; }
        public ChartPen AvgLinePen { get; set; }
        public ChartPen ChartLinePen { get; set; }

        public bool AntiAliasing
        {
            get { return antiAliasing; }
            set { antiAliasing = value; }
        }

        public Color BackgroundColorTop
        {
            get { return backgroundColorTop; }
            set { backgroundColorTop = value; }
        }

        public Color BackgroundColorBottom
        {
            get { return backgroundColorBottom; }
            set { backgroundColorBottom = value; }
        }
    }

    [TypeConverter(typeof (ExpandableObjectConverter))]
    public class ChartPen
    {
        public ChartPen()
        {
            Pen = new Pen(Color.Black);
        }

        public Color Color
        {
            get { return Pen.Color; }
            set { Pen.Color = value; }
        }

        public DashStyle DashStyle
        {
            get { return Pen.DashStyle; }
            set { Pen.DashStyle = value; }
        }

        public float Width
        {
            get { return Pen.Width; }
            set { Pen.Width = value; }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Pen Pen { get; private set; }
    }
}