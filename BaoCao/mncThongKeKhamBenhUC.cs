using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace BaoCao
{
    public partial class mncThongKeKhamBenhUC : DevExpress.XtraEditors.XtraUserControl
    {
        public mncThongKeKhamBenhUC()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            //lay ty le bang cach lay kich thuoc man hinh chia cho kich thuoc thiet ke
            //1386 là chi?u r?ng, 788 là chi?u cao Form khi thi?t k?, xem trong Properties c?a Form
            float WidthPerscpective = (float)Width / 1024;
            float HeightPerscpective = (float)Height / 768;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            lbTiepNhan.Text = "800";
            lbDaKhamBenh.Text = "350";
            lbChoKham.Text = "450";
            lbChoThucHien.Text = "80";
            lbThucHien.Text = "120";
        }
        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                //g?i d? quy n?u nhu 1 control nào có ch?a các control khác n?a

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                //canh l?i to? d? x, y, chi?u r?ng, cao cho các control trên form

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }

        private DataTable CreateChartData()
        {
            DataTable table = new DataTable("TiepNhan");

            // Add two columns to the table.
            table.Columns.Add("Ngay", typeof(Int32));
            table.Columns.Add("Value", typeof(Int32));

            // Add data rows to the table.
            Random rnd = new Random();
            DataRow row = null;

                row = table.NewRow();
                row["Ngay"] = 1;
                row["Value"] = 700;
                table.Rows.Add(row);

            return table;
        }

        private DataTable CreateChartData1()
        {
            DataTable table = new DataTable("TiepNhan");

            // Add two columns to the table.
            table.Columns.Add("Ngay", typeof(Int32));
            table.Columns.Add("Value", typeof(Int32));

            // Add data rows to the table.
            Random rnd = new Random();
            DataRow row = null;

            row = table.NewRow();
            row["Ngay"] = 2;
            row["Value"] = 800;
            table.Rows.Add(row);

            return table;
        }

        private void mncThongKeKhamBenhUC_Load(object sender, EventArgs e)
        {
            // Create a chart.
            //ChartControl chart = new ChartControl();

            // Create an empty Bar series and add it to the chart.
            Series series = new Series("Yesterday", ViewType.Bar);
            chart.Series.Add(series);

            // Generate a data table and bind the series to it.
            series.DataSource = CreateChartData();

            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.Numerical;
            series.ArgumentDataMember = "Ngay";
            
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });


            Series series1 = new Series("Today", ViewType.Bar);
            chart.Series.Add(series1);

            // Generate a data table and bind the series to it.
            series1.DataSource = CreateChartData1();

            // Specify data members to bind the series.
            series1.ArgumentScaleType = ScaleType.Numerical;
            series1.ArgumentDataMember = "Ngay";

            series1.ValueScaleType = ScaleType.Numerical;
            series1.ValueDataMembers.AddRange(new string[] { "Value" });
            ((XYDiagram)chart.Diagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False;

            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;


            //// Set some properties to get a nice-looking chart.
            //((SideBySideBarSeriesView)series.View).ColorEach = true;
            //((XYDiagram)chart.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
            //chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            //// Dock the chart into its parent and add it to the current form.
            ////chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);
            TaoChart();
        
    }

        private DataTable PhongKham()
        {
            DataTable table = new DataTable("PhongKham");

            // Add two columns to the table.
            table.Columns.Add("PhongKham", typeof(string));
            table.Columns.Add("Value", typeof(Int32));

            // Add data rows to the table.
            Random rnd = new Random();
            DataRow row = null;

            row = table.NewRow();
            row["PhongKham"] = "PK1";
            row["Value"] = 25;
            table.Rows.Add(row);


            row = table.NewRow();
            row["PhongKham"] = "PK2";
            row["Value"] = 10;
            table.Rows.Add(row);

            row = table.NewRow();
            row["PhongKham"] = "PK3";
            row["Value"] = 20;
            table.Rows.Add(row);

            row = table.NewRow();
            row["PhongKham"] = "PK4";
            row["Value"] = 15;
            table.Rows.Add(row);

            row = table.NewRow();
            row["PhongKham"] = "PK5";
            row["Value"] = 5;
            table.Rows.Add(row);


            return table;
        }

        private DataTable PhongKham1()
        {
            DataTable table = new DataTable("PhongKham1");

            // Add two columns to the table.
            table.Columns.Add("PhongKham1", typeof(string));
            table.Columns.Add("Value", typeof(Int32));

            // Add data rows to the table.
            Random rnd = new Random();
            DataRow row = null;

            row = table.NewRow();
            row["PhongKham1"] = "PK1";
            row["Value"] = 20;
            table.Rows.Add(row);


            row = table.NewRow();
            row["PhongKham1"] = "PK2";
            row["Value"] = 15;
            table.Rows.Add(row);

            row = table.NewRow();
            row["PhongKham1"] = "PK3";
            row["Value"] = 25;
            table.Rows.Add(row);

            row = table.NewRow();
            row["PhongKham1"] = "PK4";
            row["Value"] = 16;
            table.Rows.Add(row);

            row = table.NewRow();
            row["PhongKham1"] = "PK5";
            row["Value"] = 9;
            table.Rows.Add(row);


            return table;
        }

        private void TaoChart()
        {
            // Create a chart.
            //ChartControl chart = new ChartControl();

            // Create an empty Bar series and add it to the chart.
            Series series = new Series("Yesterday", ViewType.Bar);
            ChartPhongKham.Series.Add(series);

            // Generate a data table and bind the series to it.
            series.DataSource = PhongKham1();

            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "PhongKham1";

            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });


            Series series1 = new Series("Today", ViewType.Bar);
            ChartPhongKham.Series.Add(series1);

            // Generate a data table and bind the series to it.
            series1.DataSource = PhongKham();

            // Specify data members to bind the series.
            series1.ArgumentScaleType = ScaleType.Auto;
            series1.ArgumentDataMember = "PhongKham";

            series1.ValueScaleType = ScaleType.Numerical;
            series1.ValueDataMembers.AddRange(new string[] { "Value" });
            //((XYDiagram)ChartPhongKham.Diagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False;

            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;


            //// Set some properties to get a nice-looking chart.
            //((SideBySideBarSeriesView)series.View).ColorEach = true;
            //((XYDiagram)chart.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
            //chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            //// Dock the chart into its parent and add it to the current form.
            ////chart.Dock = DockStyle.Fill;
            this.Controls.Add(ChartPhongKham);
        }

    }
}
