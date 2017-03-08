namespace GeoPrivacyVisualizerApplication.MyPlaces
{
    partial class FavouriteVisitedPlacesUserControl
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.PieSeries pieSeries1 = new Telerik.WinControls.UI.PieSeries();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.allVisitedPlacesGrid = new Telerik.WinControls.UI.RadGridView();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radChartView2 = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).BeginInit();
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
            this.radSeparator1.Size = new System.Drawing.Size(742, 16);
            this.radSeparator1.TabIndex = 2;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // radSeparator2
            // 
            this.radSeparator2.Location = new System.Drawing.Point(743, 31);
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
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your";
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
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "VenueName";
            gridViewTextBoxColumn1.HeaderText = "Place Name ";
            gridViewTextBoxColumn1.Name = "VenueName";
            gridViewTextBoxColumn1.Width = 222;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "CategoryName";
            gridViewTextBoxColumn2.HeaderText = "Type";
            gridViewTextBoxColumn2.Name = "CategoryName";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 98;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "CategoryURLType";
            gridViewTextBoxColumn3.HeaderText = "Main Type";
            gridViewTextBoxColumn3.Name = "CategoryURLType";
            gridViewTextBoxColumn3.Width = 98;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "FormattedAddress";
            gridViewTextBoxColumn4.HeaderText = "Address";
            gridViewTextBoxColumn4.Name = "FormattedAddress";
            gridViewTextBoxColumn4.Width = 98;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "City";
            gridViewTextBoxColumn5.HeaderText = "City";
            gridViewTextBoxColumn5.Name = "City";
            gridViewTextBoxColumn5.Width = 115;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Count";
            gridViewTextBoxColumn6.HeaderText = "No. of visits";
            gridViewTextBoxColumn6.Name = "Count";
            gridViewTextBoxColumn6.Width = 78;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Latitude";
            gridViewTextBoxColumn7.HeaderText = "Latitude";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Latitude";
            gridViewTextBoxColumn7.Width = 43;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Longitude";
            gridViewTextBoxColumn8.HeaderText = "Longitude";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Longitude";
            this.allVisitedPlacesGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.allVisitedPlacesGrid.MasterTemplate.EnableFiltering = true;
            this.allVisitedPlacesGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.allVisitedPlacesGrid.Name = "allVisitedPlacesGrid";
            this.allVisitedPlacesGrid.ReadOnly = true;
            this.allVisitedPlacesGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.allVisitedPlacesGrid.ShowGroupPanel = false;
            this.allVisitedPlacesGrid.Size = new System.Drawing.Size(725, 472);
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
            this.gMapControl1.Location = new System.Drawing.Point(763, 73);
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
            this.gMapControl1.Size = new System.Drawing.Size(532, 288);
            this.gMapControl1.TabIndex = 7;
            this.gMapControl1.Zoom = 13D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.label3.Location = new System.Drawing.Point(759, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Geo Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.label4.Location = new System.Drawing.Point(212, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "places are exposed to others";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Favourite";
            // 
            // radChartView2
            // 
            this.radChartView2.AreaType = Telerik.WinControls.UI.ChartAreaType.Pie;
            this.radChartView2.LegendTitle = "Place name";
            this.radChartView2.Location = new System.Drawing.Point(763, 367);
            this.radChartView2.Name = "radChartView2";
            pieSeries1.DrawLinesToLabels = true;
            pieSeries1.LegendTitleMember = "VenueName";
            pieSeries1.PointSize = new System.Drawing.SizeF(10F, 10F);
            pieSeries1.ShowLabels = true;
            pieSeries1.ValueMember = "Count";
            this.radChartView2.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            pieSeries1});
            this.radChartView2.ShowGrid = false;
            this.radChartView2.ShowLegend = true;
            this.radChartView2.ShowPanZoom = true;
            this.radChartView2.ShowToolTip = true;
            this.radChartView2.ShowTrackBall = true;
            this.radChartView2.Size = new System.Drawing.Size(540, 279);
            this.radChartView2.TabIndex = 0;
            this.radChartView2.Text = "radChartView2";
            this.radChartView2.Click += new System.EventHandler(this.radChartView2_Click);
            ((Telerik.WinControls.UI.RadChartElement)(this.radChartView2.GetChildAt(0))).NumberOfColors = 10;
            ((Telerik.WinControls.UI.RadChartElement)(this.radChartView2.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            ((Telerik.WinControls.UI.ChartLegendElement)(this.radChartView2.GetChildAt(0).GetChildAt(0).GetChildAt(2))).DrawBorder = true;
            ((Telerik.WinControls.UI.ChartLegendElement)(this.radChartView2.GetChildAt(0).GetChildAt(0).GetChildAt(2))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            ((Telerik.WinControls.UI.ChartLegendElement)(this.radChartView2.GetChildAt(0).GetChildAt(0).GetChildAt(2))).TextWrap = true;
            ((Telerik.WinControls.UI.ChartLegendElement)(this.radChartView2.GetChildAt(0).GetChildAt(0).GetChildAt(2))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radChartView2.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0).GetChildAt(0))).TextWrap = true;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radChartView2.GetChildAt(0).GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0).GetChildAt(0))).AutoSize = true;
            // 
            // FavouriteVisitedPlacesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radChartView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.radSeparator2);
            this.Controls.Add(this.allVisitedPlacesGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radSeparator1);
            this.Name = "FavouriteVisitedPlacesUserControl";
            this.Size = new System.Drawing.Size(1306, 637);
            this.Load += new System.EventHandler(this.AllVisitedPlacesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView2)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadChartView radChartView2;
    }
}
