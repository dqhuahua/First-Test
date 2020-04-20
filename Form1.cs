using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace chartTest
{
    public partial class Form1 : Form
    {
        Series series1 = new Series();
        Series series2 = new Series();
        Series series3 = new Series();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            series1.Points.AddXY(1,10);
            series1.Points.AddXY(2, 25);
            series1.Points.AddXY(3, 20);
            series1.Points.AddXY(4, 50);
            series1.Points.AddXY(5, 30);
            series1.Points.AddXY(6, 30);
            series1.Points.AddXY(7, 30);
            series1.Points.AddXY(8, 30);
            series1.Points.AddXY(9, 30);
            series1.Points.AddXY(10, 30);
            series1.Points.AddXY(11, 30);

            series2.Points.AddXY(1, 10);
            series2.Points.AddXY(2, 15);
            series2.Points.AddXY(3, 25);
            series2.Points.AddXY(4, 20);
            series2.Points.AddXY(5, 30);
            series2.Points.AddXY(6, 30);
            series2.Points.AddXY(7, 30);
            series2.Points.AddXY(8, 30);
            series2.Points.AddXY(9, 30);
            series2.Points.AddXY(10, 30);
            series2.Points.AddXY(11, 30);

            series3.Points.AddXY(1, 5);
            series3.Points.AddXY(2, 12);
            series3.Points.AddXY(3, 25);
            series3.Points.AddXY(4, 40);
            series3.Points.AddXY(5, 35);
            series3.Points.AddXY(6, 35);
            series3.Points.AddXY(7, 35);
            series3.Points.AddXY(8, 35);
            series3.Points.AddXY(9, 35);
            series3.Points.AddXY(10, 35);
            series3.Points.AddXY(11, 35);

            //CustomLabel cuslbl = new CustomLabel();
            //cuslbl.Text = "1";
            //cuslbl.FromPosition = 0;
            //cuslbl.ToPosition = 1;
            //cuslbl.ForeColor = Color.Red;
            //chart1.ChartAreas["ChartArea2"].AxisY.CustomLabels.Add(cuslbl);
            //cuslbl.Text = "1";
            //cuslbl.FromPosition = 1;
            //cuslbl.ToPosition = 2;
            //cuslbl.ForeColor = Color.Red;
            //chart1.ChartAreas["ChartArea2"].AxisY.CustomLabels.Add(cuslbl);
            //cuslbl.Text = "1";
            //cuslbl.FromPosition = 2;
            //cuslbl.ToPosition = 3;
            //cuslbl.ForeColor = Color.Red;
            //chart1.ChartAreas["ChartArea2"].AxisY.CustomLabels.Add(cuslbl);
            //cuslbl.Text = "1";
            //cuslbl.FromPosition = 3;
            //cuslbl.ToPosition = 4;
            //cuslbl.ForeColor = Color.Red;
            //chart1.ChartAreas["ChartArea2"].AxisY.CustomLabels.Add(cuslbl);
            //chart1.ChartAreas["ChartArea3"].AxisY.CustomLabels.Add(cuslbl);

            //chart1.BackColor = Color.Transparent;
            //chart1.ChartAreas["ChartArea2"].AlignWithChartArea = "ChartArea1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            ChartArea ca2 = new ChartArea("ChartArea2");
            chart1.ChartAreas.Add(ca2);

            ChartArea ca3 = new ChartArea("ChartArea3");
            chart1.ChartAreas.Add(ca3);

            series1.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series1);
            series1.ChartArea = "ChartArea1";

            series2.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series2);
            series2.ChartArea = "ChartArea2";
            ca2.AxisY.MajorGrid.Enabled = false;
            ca2.AxisY.MajorTickMark.LineColor = Color.Transparent;
            ca2.AxisY.LabelStyle.ForeColor = Color.Transparent;

            series3.ChartType = SeriesChartType.Line;
            chart1.Series.Add(series3);
            series3.ChartArea = "ChartArea3";
            ca3.AxisY.MajorGrid.Enabled = false;
            ca3.AxisY.MajorTickMark.LineColor= Color.Transparent;
            ca3.AxisY.LabelStyle.ForeColor = Color.Transparent;

            chart1.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;            
            chart1.ChartAreas["ChartArea2"].CursorX.IsUserEnabled = true;
            chart1.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            chart1.ChartAreas["ChartArea2"].BackColor = Color.Transparent;
            chart1.ChartAreas["ChartArea3"].BackColor = Color.Transparent;


            chart1.ChartAreas["ChartArea1"].Position.X = 3;
            chart1.ChartAreas["ChartArea1"].Position.Y = 3;
            chart1.ChartAreas["ChartArea1"].Position.Width = 100;
            chart1.ChartAreas["ChartArea1"].Position.Height = 100;
            chart1.ChartAreas["ChartArea2"].Position.X = 3;
            chart1.ChartAreas["ChartArea2"].Position.Y = 3;
            chart1.ChartAreas["ChartArea2"].Position.Width = 100;
            chart1.ChartAreas["ChartArea2"].Position.Height = 100;
            chart1.ChartAreas["ChartArea3"].Position.X = 3;
            chart1.ChartAreas["ChartArea3"].Position.Y = 3;
            chart1.ChartAreas["ChartArea3"].Position.Width = 100;
            chart1.ChartAreas["ChartArea3"].Position.Height = 100;

        }

    }
}
