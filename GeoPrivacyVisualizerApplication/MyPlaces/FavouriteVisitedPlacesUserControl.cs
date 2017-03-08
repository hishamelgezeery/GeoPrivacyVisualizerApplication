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

namespace GeoPrivacyVisualizerApplication.MyPlaces
{
    public partial class FavouriteVisitedPlacesUserControl : UserControl
    {
        public string pathToFile;
        public DataTable data;
        GMap.NET.WindowsForms.GMapOverlay markers;
        public FavouriteVisitedPlacesUserControl(string pathToFiles)
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
                                   City = row.Field<string>("City"),
                                   Latitude = row.Field<string>("Latitude"),
                                   Longitude = row.Field<string>("Longitude")
                               } into grp
                               orderby grp.Count() descending
                               select new
                               {
                                   VenueName = grp.Key.VenueName,
                                   CategoryName = grp.Key.CategoryName,
                                   CategoryURLType = grp.Key.CategoryURLType,
                                   FormattedAddress = grp.Key.FormattedAddress,
                                   City = grp.Key.FormattedAddress,
                                   Latitude = grp.Key.Latitude,
                                   Longitude = grp.Key.Longitude,
                                   Count = grp.Count()
                               }).Take(20);

            allVisitedPlacesGrid.DataSource = queriedData;
            radChartView2.DataSource = queriedData.Take(5);
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            gMapControl1.Overlays.Add(markers);
            loadMarkersOntoMap();
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
    }
}
