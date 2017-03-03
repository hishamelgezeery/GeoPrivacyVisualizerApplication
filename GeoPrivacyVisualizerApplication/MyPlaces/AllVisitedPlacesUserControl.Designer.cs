namespace GeoPrivacyVisualizerApplication.MyPlaces
{
    partial class AllVisitedPlacesUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn34 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn35 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn36 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn37 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn38 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn39 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn40 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn41 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn42 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn43 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn44 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.allVisitedPlacesGrid = new Telerik.WinControls.UI.RadGridView();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GeoPrivacyVisualizerApplication.Properties.Resources.important_98442_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(95, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Privacy Warning";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(3, 90);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(865, 16);
            this.radSeparator1.TabIndex = 2;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // radSeparator2
            // 
            this.radSeparator2.Location = new System.Drawing.Point(859, 31);
            this.radSeparator2.Name = "radSeparator2";
            this.radSeparator2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radSeparator2.Size = new System.Drawing.Size(10, 606);
            this.radSeparator2.TabIndex = 3;
            this.radSeparator2.Text = "radSeparator2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.label2.Location = new System.Drawing.Point(95, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "People can know places you have been to and when ";
            // 
            // allVisitedPlacesGrid
            // 
            this.allVisitedPlacesGrid.AutoSizeRows = true;
            this.allVisitedPlacesGrid.BackColor = System.Drawing.Color.White;
            this.allVisitedPlacesGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.allVisitedPlacesGrid.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.allVisitedPlacesGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.allVisitedPlacesGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allVisitedPlacesGrid.Location = new System.Drawing.Point(12, 152);
            // 
            // 
            // 
            this.allVisitedPlacesGrid.MasterTemplate.AllowAddNewRow = false;
            this.allVisitedPlacesGrid.MasterTemplate.AllowColumnReorder = false;
            this.allVisitedPlacesGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn34.EnableExpressionEditor = false;
            gridViewTextBoxColumn34.FieldName = "VenueName";
            gridViewTextBoxColumn34.HeaderText = "Name";
            gridViewTextBoxColumn34.Name = "Name";
            gridViewTextBoxColumn34.Width = 158;
            gridViewTextBoxColumn35.EnableExpressionEditor = false;
            gridViewTextBoxColumn35.FieldName = "Latitude";
            gridViewTextBoxColumn35.HeaderText = "Coordinates(X)";
            gridViewTextBoxColumn35.Name = "Coordinates(X)";
            gridViewTextBoxColumn35.ReadOnly = true;
            gridViewTextBoxColumn35.Width = 69;
            gridViewTextBoxColumn36.EnableExpressionEditor = false;
            gridViewTextBoxColumn36.FieldName = "Longitude";
            gridViewTextBoxColumn36.HeaderText = "Coordinates(Y)";
            gridViewTextBoxColumn36.Name = "Coordinates(Y)";
            gridViewTextBoxColumn36.Width = 69;
            gridViewTextBoxColumn37.EnableExpressionEditor = false;
            gridViewTextBoxColumn37.FieldName = "DateOnly";
            gridViewTextBoxColumn37.HeaderText = "Date";
            gridViewTextBoxColumn37.Name = "Date";
            gridViewTextBoxColumn37.Width = 69;
            gridViewTextBoxColumn38.EnableExpressionEditor = false;
            gridViewTextBoxColumn38.FieldName = "TimeOnly";
            gridViewTextBoxColumn38.HeaderText = "Time";
            gridViewTextBoxColumn38.Name = "Time";
            gridViewTextBoxColumn38.Width = 69;
            gridViewTextBoxColumn39.EnableExpressionEditor = false;
            gridViewTextBoxColumn39.FieldName = "CategoryName";
            gridViewTextBoxColumn39.HeaderText = "Type";
            gridViewTextBoxColumn39.Name = "Type";
            gridViewTextBoxColumn39.Width = 69;
            gridViewTextBoxColumn40.EnableExpressionEditor = false;
            gridViewTextBoxColumn40.FieldName = "CategoryURLType";
            gridViewTextBoxColumn40.HeaderText = "Main Type";
            gridViewTextBoxColumn40.Name = "Main Type";
            gridViewTextBoxColumn40.Width = 69;
            gridViewTextBoxColumn41.EnableExpressionEditor = false;
            gridViewTextBoxColumn41.FieldName = "FormattedAddress";
            gridViewTextBoxColumn41.HeaderText = "Address";
            gridViewTextBoxColumn41.Name = "Address";
            gridViewTextBoxColumn41.Width = 69;
            gridViewTextBoxColumn42.EnableExpressionEditor = false;
            gridViewTextBoxColumn42.FieldName = "City";
            gridViewTextBoxColumn42.HeaderText = "City";
            gridViewTextBoxColumn42.Name = "City";
            gridViewTextBoxColumn42.Width = 69;
            gridViewTextBoxColumn43.EnableExpressionEditor = false;
            gridViewTextBoxColumn43.FieldName = "Source";
            gridViewTextBoxColumn43.HeaderText = "Source";
            gridViewTextBoxColumn43.Name = "Source";
            gridViewTextBoxColumn43.Width = 67;
            gridViewTextBoxColumn44.EnableExpressionEditor = false;
            gridViewTextBoxColumn44.FieldName = "Visibility";
            gridViewTextBoxColumn44.HeaderText = "Visibility";
            gridViewTextBoxColumn44.Name = "Visibility";
            gridViewTextBoxColumn44.Width = 53;
            this.allVisitedPlacesGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn34,
            gridViewTextBoxColumn35,
            gridViewTextBoxColumn36,
            gridViewTextBoxColumn37,
            gridViewTextBoxColumn38,
            gridViewTextBoxColumn39,
            gridViewTextBoxColumn40,
            gridViewTextBoxColumn41,
            gridViewTextBoxColumn42,
            gridViewTextBoxColumn43,
            gridViewTextBoxColumn44});
            this.allVisitedPlacesGrid.MasterTemplate.EnableFiltering = true;
            this.allVisitedPlacesGrid.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.allVisitedPlacesGrid.Name = "allVisitedPlacesGrid";
            this.allVisitedPlacesGrid.ReadOnly = true;
            this.allVisitedPlacesGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.allVisitedPlacesGrid.ShowGroupPanel = false;
            this.allVisitedPlacesGrid.Size = new System.Drawing.Size(841, 472);
            this.allVisitedPlacesGrid.TabIndex = 5;
            this.allVisitedPlacesGrid.Text = "radGridView1";
            this.allVisitedPlacesGrid.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.MasterTemplate_CurrentRowChanged);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(874, 73);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(403, 276);
            this.gMapControl1.TabIndex = 7;
            this.gMapControl1.Zoom = 13D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.label3.Location = new System.Drawing.Point(875, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Geo Location";
            // 
            // AllVisitedPlacesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.radSeparator2);
            this.Controls.Add(this.allVisitedPlacesGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radSeparator1);
            this.Name = "AllVisitedPlacesUserControl";
            this.Size = new System.Drawing.Size(1280, 637);
            this.Load += new System.EventHandler(this.AllVisitedPlacesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadSeparator radSeparator2;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView allVisitedPlacesGrid;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label3;
    }
}
