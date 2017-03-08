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
    public partial class AllVisitedPlacesUserControl : UserControl
    {
        public string pathToFile;
        public DataTable data;
        GMap.NET.WindowsForms.GMapOverlay markers;
        public AllVisitedPlacesUserControl(string pathToFiles)
        {
            this.pathToFile = pathToFiles + "checkins.csv";
            InitializeComponent();
        }

        private void AllVisitedPlacesUserControl_Load(object sender, EventArgs e)
        {
            data = Util.GetDataTableFromCsv(pathToFile, true);
            allVisitedPlacesGrid.DataSource = data;
            
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
                gMapControl1.Position = new GMap.NET.PointLatLng(double.Parse(allVisitedPlacesGrid.CurrentRow.Cells["Coordinates(X)"].Value.ToString()),
                    double.Parse(allVisitedPlacesGrid.CurrentRow.Cells["Coordinates(Y)"].Value.ToString()));
                gMapControl1.Zoom = 15;
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
        private void loadMarkersOntoMap()
        {
            foreach (GridViewRowInfo rowInfo in allVisitedPlacesGrid.Rows)
            {try
                {
                    GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                            new GMap.NET.PointLatLng(double.Parse(rowInfo.Cells["Coordinates(X)"].Value.ToString()),
                            double.Parse(rowInfo.Cells["Coordinates(Y)"].Value.ToString())),
                            GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_pushpin);

                    marker.ToolTipText = "Place : " + rowInfo.Cells["Name"].Value + "\n" +
                                     "Type : " + rowInfo.Cells["Type"].Value;
                    markers.Markers.Add(marker);
                }
                catch { }
            }
        }
    }
}
