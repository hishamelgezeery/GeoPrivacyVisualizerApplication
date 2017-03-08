using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace GeoPrivacyVisualizerApplication
{
    public partial class MainForm : Form
    {
        bool myPlacesVisible = false;
        bool myInterestsVisible = false;
        bool myFriendsVisible = false;
        public string username;
        public string pathToFiles;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userButton.Text = username;
        }

        private void myPlacesButton_Click(object sender, EventArgs e)
        {
            myPlacesVisible = !myPlacesVisible;
            allVisitedPlacesLine.Visible = myPlacesVisible ? true : false;
            allVisitedPlacesButton.Visible = myPlacesVisible ? true : false;
            FavouritePlacesLine.Visible = myPlacesVisible ? true : false;
            FavouritePlacesButton.Visible = myPlacesVisible ? true : false;
            RoutinePlacesLine.Visible = myPlacesVisible ? true : false;
            RoutinePlacesButton.Visible = myPlacesVisible ? true : false;
        }

        private void myFriendshipsButton_Click(object sender, EventArgs e)
        {
            myFriendsVisible = !myFriendsVisible;
            allFriendsLine.Visible = myFriendsVisible ? true : false;
            allFriendsButton.Visible = myFriendsVisible ? true : false;
            informationFriendsLine.Visible = myFriendsVisible ? true : false;
            informationFriendsButton.Visible = myFriendsVisible ? true : false;
            favouriteFriendsLine.Visible = myFriendsVisible ? true : false;
            favouriteFriendsButton.Visible = myFriendsVisible ? true : false;
            routineFriendsLine.Visible = myFriendsVisible ? true : false;
            routineFriendsButton.Visible = myFriendsVisible ? true : false;
        }

        private void myInterestsButton_Click(object sender, EventArgs e)
        {
            myInterestsVisible = !myInterestsVisible;
            allInterestsLine.Visible = myInterestsVisible ? true : false;
            allInterestsButton.Visible = myInterestsVisible ? true : false;
            favouriteInterestsLine.Visible = myInterestsVisible ? true : false;
            favouriteInterestsButton.Visible = myInterestsVisible ? true : false;
            routineInterestsLine.Visible = myInterestsVisible ? true : false;
            routineInterestsButton.Visible = myInterestsVisible ? true : false;
        }

        private void allVisitedPlacesButton_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "All visits to places";
            MyPlaces.AllVisitedPlacesUserControl control= new MyPlaces.AllVisitedPlacesUserControl(pathToFiles);
            form.Width = control.Width;
            form.Height = control.Height;
            control.Dock = DockStyle.Fill;
            form.Controls.Add(control);
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }

        private void FavouritePlacesButton_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Favourite visits to places";
            MyPlaces.FavouriteVisitedPlacesUserControl control = new MyPlaces.FavouriteVisitedPlacesUserControl(pathToFiles);
            form.Width = control.Width;
            form.Height = control.Height;
            control.Dock = DockStyle.Fill;
            form.Controls.Add(control);
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }

        private void RoutinePlacesButton_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            MyPlaces.RoutinePlacesUserControl control = new MyPlaces.RoutinePlacesUserControl(pathToFiles);
            form.Text = "Routine visits to places";
            form.Width = control.Width;
            form.Height = control.Height;
            control.Dock = DockStyle.Fill;
            form.Controls.Add(control);
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }
    }
}
