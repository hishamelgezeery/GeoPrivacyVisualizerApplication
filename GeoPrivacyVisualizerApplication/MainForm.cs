﻿using System;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
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
    }
}