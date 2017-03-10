using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Telerik.WinControls.UI;
using System.Collections;
using Telerik.Charting;
using DevExpress.XtraCharts;

namespace GeoPrivacyVisualizerApplication.MyPlaces
{
    public partial class RoutinePlacesUserControl : UserControl
    {
        public string pathToFile;
        public DataTable data;
        GMap.NET.WindowsForms.GMapOverlay markers;
        public RoutinePlacesUserControl(string pathToFiles)
        {
            this.pathToFile = pathToFiles + "checkins.csv";
            InitializeComponent();
        }

        private void AllVisitedPlacesUserControl_Load(object sender, EventArgs e)
        {

            data = Util.GetDataTableFromCsv(pathToFile, true);

            var queriedData = (from row in data.AsEnumerable()
                               group row by new
                               {
                                   VenueName = row.Field<string>("VenueName"),
                                   CategoryName = row.Field<string>("CategoryName"),
                                   CategoryURLType = row.Field<string>("CategoryURLType"),
                                   FormattedAddress = row.Field<string>("FormattedAddress"),
                                   Latitude = row.Field<string>("Latitude"),
                                   Longitude = row.Field<string>("Longitude"),
                                   City = row.Field<string>("City"),
                                   Day = row.Field<string>("Day"),
                                   Time = row.Field<string>("Hour").Trim() == "" ? "--" :
                                   int.Parse(row.Field<string>("Hour")) >= 5 && int.Parse(row.Field<string>("Hour")) < 12 ? "Morning" :
                                        int.Parse(row.Field<string>("Hour")) >= 12 && int.Parse(row.Field<string>("Hour")) < 17 ? "Afternoon" :
                                        int.Parse(row.Field<string>("Hour")) >= 17 && int.Parse(row.Field<string>("Hour")) < 20 ? "Evening" :
                                        int.Parse(row.Field<string>("Hour")) >= 20 || int.Parse(row.Field<string>("Hour")) < 5 ? "Night" : "-"
                               } into grp
                               orderby grp.Count() descending
                               where grp.Count() > 4
                               select new
                               {
                                   VenueName = grp.Key.VenueName,
                                   CategoryName = grp.Key.CategoryName,
                                   CategoryURLType = grp.Key.CategoryURLType,
                                   FormattedAddress = grp.Key.FormattedAddress,
                                   City = grp.Key.City,
                                   Latitude = grp.Key.Latitude,
                                   Longitude = grp.Key.Longitude,
                                   Day = grp.Key.Day,
                                   Time = grp.Key.Time,
                                   Count = grp.Count()
                               }).Take(20);
            var queriedData2 = (from row in data.AsEnumerable()
                                group row by new
                                {
                                    VenueName = row.Field<string>("VenueName"),
                                    CategoryName = row.Field<string>("CategoryName"),
                                    CategoryURLType = row.Field<string>("CategoryURLType"),
                                    FormattedAddress = row.Field<string>("FormattedAddress"),
                                    Latitude = row.Field<string>("Latitude"),
                                    Longitude = row.Field<string>("Longitude"),
                                    City = row.Field<string>("City"),
                                    Day = row.Field<string>("Day"),
                                    Time = "-"
                                } into grp
                                orderby grp.Count() descending
                                where grp.Count() > 4
                                select new
                                {
                                    VenueName = grp.Key.VenueName,
                                    CategoryName = grp.Key.CategoryName,
                                    CategoryURLType = grp.Key.CategoryURLType,
                                    FormattedAddress = grp.Key.FormattedAddress,
                                    City = grp.Key.City,
                                    Latitude = grp.Key.Latitude,
                                    Longitude = grp.Key.Longitude,
                                    Day = grp.Key.Day,
                                    Time = grp.Key.Time,
                                    Count = grp.Count()
                                }).Take(20);
            var queriedData3 = (from row in data.AsEnumerable()
                                group row by new
                                {
                                    VenueName = row.Field<string>("VenueName"),
                                    CategoryName = row.Field<string>("CategoryName"),
                                    CategoryURLType = row.Field<string>("CategoryURLType"),
                                    FormattedAddress = row.Field<string>("FormattedAddress"),
                                    Latitude = row.Field<string>("Latitude"),
                                    Longitude = row.Field<string>("Longitude"),
                                    City = row.Field<string>("City"),
                                    Day = "-",
                                    Time = row.Field<string>("Hour").Trim() == "" ? "--" :
                                   int.Parse(row.Field<string>("Hour")) >= 5 && int.Parse(row.Field<string>("Hour")) < 12 ? "Morning" :
                                        int.Parse(row.Field<string>("Hour")) >= 12 && int.Parse(row.Field<string>("Hour")) < 17 ? "Afternoon" :
                                        int.Parse(row.Field<string>("Hour")) >= 17 && int.Parse(row.Field<string>("Hour")) < 20 ? "Evening" :
                                        int.Parse(row.Field<string>("Hour")) >= 20 || int.Parse(row.Field<string>("Hour")) < 5 ? "Night" : "-"
                                } into grp
                                orderby grp.Count() descending
                                where grp.Count() > 4
                                select new
                                {
                                    VenueName = grp.Key.VenueName,
                                    CategoryName = grp.Key.CategoryName,
                                    CategoryURLType = grp.Key.CategoryURLType,
                                    FormattedAddress = grp.Key.FormattedAddress,
                                    City = grp.Key.City,
                                    Latitude = grp.Key.Latitude,
                                    Longitude = grp.Key.Longitude,
                                    Day = grp.Key.Day,
                                    Time = grp.Key.Time,
                                    Count = grp.Count()
                                }).Take(20);
            var output = queriedData.Union(queriedData2);
            output = (from row in output
                      group row by new { row.VenueName, row.Day })
                  .Select(group => group.First());
            var output1 = queriedData.Union(queriedData3);
            output1 = (from row in output1
                       group row by new { row.VenueName, row.Time })
                  .Select(group => group.First());
            output = output.Union(output1);
            output = output.OrderByDescending(x => x.Count)
           .ToList();
            /* */
            allVisitedPlacesGrid.DataSource = output;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            gMapControl1.Overlays.Add(markers);
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MarkersEnabled = true;
            loadMarkersOntoMap();
            setDayGraphData(output);
            setDayAndTimeGraphData(output);
        }

        private void setDayAndTimeGraphData(IEnumerable<dynamic> output)
        {

            IList routineDaysAndTimes = output.Where(x => x.Time != "-" && x.Day != "-").OrderByDescending(x => x.Count).Take(10).ToList();
            for (int i = 0; i < routineDaysAndTimes.Count; i++)
            {
                dynamic s = routineDaysAndTimes[i];
                ScatterSeries series = new ScatterSeries("Time", "Day");
                series.LegendTitle = s.VenueName;
                series.PointSize = new SizeF(15, 15);
                series.DataPoints.Add(new ScatterDataPoint(getTimeAsInteger(s.Time), getDayAsInteger(s.Day)));
                for (int j = i + 1; j < routineDaysAndTimes.Count; j++)
                {
                    dynamic d = routineDaysAndTimes[j];
                    if (d.VenueName == s.VenueName)
                    {
                        series.DataPoints.Add(new ScatterDataPoint(getTimeAsInteger(d.Time), getDayAsInteger(d.Day)));
                        routineDaysAndTimes.RemoveAt(j);
                        j--;
                    }
                }
                this.routineDayAndTimeChartView.Series.Add(series);
            }
            this.routineDayAndTimeChartView.ShowLegend = true;
            LinearAxis horizontalAxis = routineDayAndTimeChartView.Axes.Get<LinearAxis>(0);
            horizontalAxis.Minimum = 0;
            horizontalAxis.Maximum = 5;
            horizontalAxis.LabelFormatProvider = new TimeFormatProvider();
            LinearAxis verticalAxis = routineDayAndTimeChartView.Axes.Get<LinearAxis>(1);
            verticalAxis.LabelFormatProvider = new DayFormatProvider();
            verticalAxis.Minimum = 0;
            verticalAxis.Maximum = 8;
            this.routineDayAndTimeChartView.ShowLegend = true;
            this.routineDayAndTimeChartView.ChartElement.LegendPosition = LegendPosition.Top;
            this.routineDayAndTimeChartView.ShowGrid = true;

            routineDaysAndTimes = output.Where(x => x.Time != "-" && x.Day != "-").OrderByDescending(x => x.Count).Take(10).ToList();

            for (int i = 0; i < routineDaysAndTimes.Count; i++)
            {
                dynamic s = routineDaysAndTimes[i];

                Series series = new Series("Series 1", ViewType.Point);
                series.LegendText = s.VenueName;
                ((PointSeriesView)series.View).PointMarkerOptions.Size = 15;
                //series. = new SizeF(15, 15);
                series.Points.Add(new SeriesPoint(getTimeAsInteger(s.Time), getDayAsInteger(s.Day)));
                for (int j = i + 1; j < routineDaysAndTimes.Count; j++)
                {
                    dynamic d = routineDaysAndTimes[j];
                    if (d.VenueName == s.VenueName)
                    {
                        series.Points.Add(new SeriesPoint(getTimeAsInteger(d.Time), getDayAsInteger(d.Day)));
                        routineDaysAndTimes.RemoveAt(j);
                        j--;
                    }
                }
                this.chartControl1.Series.Add(series);
            }
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartControl1.Legend.MaxHorizontalPercentage = 100;
            chartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.TopOutside;
            chartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.Auto = false;
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.MinValue = 1;
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.MaxValue = 4;
            ((XYDiagram)chartControl1.Diagram).AxisX.CustomLabels.Add(new CustomAxisLabel("", 0));
            ((XYDiagram)chartControl1.Diagram).AxisX.CustomLabels.Add(new CustomAxisLabel("Morning", 1));
            ((XYDiagram)chartControl1.Diagram).AxisX.CustomLabels.Add(new CustomAxisLabel("Afternoon", 2));
            ((XYDiagram)chartControl1.Diagram).AxisX.CustomLabels.Add(new CustomAxisLabel("Evening", 3));
            ((XYDiagram)chartControl1.Diagram).AxisX.CustomLabels.Add(new CustomAxisLabel("Night", 4));

            ((XYDiagram)chartControl1.Diagram).AxisY.WholeRange.Auto = false;
            ((XYDiagram)chartControl1.Diagram).AxisY.WholeRange.MinValue = 1;
            ((XYDiagram)chartControl1.Diagram).AxisY.WholeRange.MaxValue = 7;
            ((XYDiagram)chartControl1.Diagram).AxisY.CustomLabels.Add(new CustomAxisLabel("", 0));
            ((XYDiagram)chartControl1.Diagram).AxisY.CustomLabels.Add(new CustomAxisLabel("Monday", 1));
            ((XYDiagram)chartControl1.Diagram).AxisY.CustomLabels.Add(new CustomAxisLabel("Tuesday", 2));
            ((XYDiagram)chartControl1.Diagram).AxisY.CustomLabels.Add(new CustomAxisLabel("Wednesday", 3));
            ((XYDiagram)chartControl1.Diagram).AxisY.CustomLabels.Add(new CustomAxisLabel("Thursday", 4));
            ((XYDiagram)chartControl1.Diagram).AxisY.CustomLabels.Add(new CustomAxisLabel("Friday", 5));
            ((XYDiagram)chartControl1.Diagram).AxisY.CustomLabels.Add(new CustomAxisLabel("Saturday", 6));
            ((XYDiagram)chartControl1.Diagram).AxisY.CustomLabels.Add(new CustomAxisLabel("Sunday", 7));
            chartControl1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.False;
        }
        private int getDayAsInteger(string day)
        {
            switch (day)
            {
                case "Monday":return 1;
                case "Tuesday": return 2;
                case "Wednesday": return 3;
                case "Thursday": return 4;
                case "Friday": return 5;
                case "Saturday": return 6;
                case "Sunday": return 7;
                default: return -1;
            }
        }

        private int getTimeAsInteger(string time)
        {
            switch (time)
            {
                case "Morning": return 1;
                case "Afternoon": return 2;
                case "Evening": return 3;
                case "Night": return 4;
                default: return -1;
            }
        }
        private void setDayGraphData(IEnumerable<dynamic> output)
        {
            IList routineDaysOnly = output.Where(x => x.Time == "-").Take(5).ToList();
            for (int i = 0; i < routineDaysOnly.Count; i++)
            {
                dynamic s = routineDaysOnly[i];
                BarSeries barSeries = new BarSeries("Count", "Day");
                barSeries.LegendTitle = s.VenueName;
                barSeries.DataPoints.Add(new CategoricalDataPoint(0, "Monday"));
                barSeries.DataPoints.Add(new CategoricalDataPoint(0, "Tuesday"));
                barSeries.DataPoints.Add(new CategoricalDataPoint(0, "Wednesday"));
                barSeries.DataPoints.Add(new CategoricalDataPoint(0, "Thursday"));
                barSeries.DataPoints.Add(new CategoricalDataPoint(0, "Friday"));
                barSeries.DataPoints.Add(new CategoricalDataPoint(0, "Saturday"));
                barSeries.DataPoints.Add(new CategoricalDataPoint(0, "Sunday"));
                barSeries.DataPoints.Add(new CategoricalDataPoint(s.Count, s.Day));
                for (int j = i + 1; j < routineDaysOnly.Count; j++)
                {
                    dynamic d = routineDaysOnly[j];
                    if (d.VenueName == s.VenueName)
                    {
                        barSeries.DataPoints.Add(new CategoricalDataPoint(d.Count, d.Day));
                        routineDaysOnly.RemoveAt(j);
                        j--;
                    }
                }
                this.routineDayChartView.Series.Add(barSeries);

            }
            this.routineDayChartView.ChartElement.LegendPosition = LegendPosition.Float;
            this.routineDayChartView.ChartElement.LegendOffset = new Point(200, 0);
        }
        
        private void MasterTemplate_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (allVisitedPlacesGrid.CurrentRow.Index != -1)
            {
                gMapControl1.Position = new GMap.NET.PointLatLng(double.Parse(allVisitedPlacesGrid.CurrentRow.Cells["Latitude"].Value.ToString()), double.Parse(allVisitedPlacesGrid.CurrentRow.Cells["Longitude"].Value.ToString()));
                gMapControl1.Zoom = 15;
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
        private void loadMarkersOntoMap()
        {
            foreach (GridViewRowInfo rowInfo in allVisitedPlacesGrid.Rows)
            {
                try
                {
                    GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                            new GMap.NET.PointLatLng(double.Parse(rowInfo.Cells["Latitude"].Value.ToString()),
                            double.Parse(rowInfo.Cells["Longitude"].Value.ToString())),
                            GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_pushpin);

                    marker.ToolTipText = "Place : " + rowInfo.Cells["VenueName"].Value + "\n" +
                                     "Type : " + rowInfo.Cells["CategoryURLType"].Value;
                    markers.Markers.Add(marker);
                }
                catch { }
            }
        }

        private void radChartView2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            (this.Parent as Form).Close();
        }

        private void zoomInPictureBox_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom++;
        }

        private void zoomOutPictureBox_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom--;
        }

        private void allVisitedPlacesGrid_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridHeaderCellElement)
            {
                e.CellElement.Font = new Font(SystemFonts.DialogFont, FontStyle.Bold);
            }
        }

        private void radChartView1_Click(object sender, EventArgs e)
        {

        }
    }
    public class TimeFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            return this;
        }
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            string s = arg.ToString();
            switch (s)
            {
                case "0":
                    return "";
                case "1":
                    return "Morning";
                case "2":
                    return "Afternoon";
                case "3":
                    return "Evening";
                case "4":
                    return "Night";
                case "5":
                    return "";
            }
            return null;
        }
    }
    public class DayFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            return this;
        }
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            string s = arg.ToString();
            switch (s)
            {
                case "0":
                    return "";
                case "1":
                    return "Monday";
                case "2":
                    return "Tuesday";
                case "3":
                    return "Wednesday";
                case "4":
                    return "Thursday";
                case "5":
                    return "Friday";
                case "6":
                    return "Saturday";
                case "7":
                    return "Sunday";
                case "8":
                    return "";

            }
            return null;
        }
    }
}
