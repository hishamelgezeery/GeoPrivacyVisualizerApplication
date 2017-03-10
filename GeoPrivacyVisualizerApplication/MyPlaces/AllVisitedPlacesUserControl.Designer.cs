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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllVisitedPlacesUserControl));
            this.label1 = new System.Windows.Forms.Label();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.allVisitedPlacesGrid = new Telerik.WinControls.UI.RadGridView();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label3 = new System.Windows.Forms.Label();
            this.zoomInPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zoomOutPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomInPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomOutPictureBox)).BeginInit();
            this.SuspendLayout();
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
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "VenueName";
            gridViewTextBoxColumn1.HeaderText = "Name";
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.Width = 158;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Latitude";
            gridViewTextBoxColumn2.HeaderText = "Coordinates(X)";
            gridViewTextBoxColumn2.Name = "Coordinates(X)";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 69;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Longitude";
            gridViewTextBoxColumn3.HeaderText = "Coordinates(Y)";
            gridViewTextBoxColumn3.Name = "Coordinates(Y)";
            gridViewTextBoxColumn3.Width = 69;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "DateOnly";
            gridViewTextBoxColumn4.HeaderText = "Date";
            gridViewTextBoxColumn4.Name = "Date";
            gridViewTextBoxColumn4.Width = 69;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "TimeOnly";
            gridViewTextBoxColumn5.HeaderText = "Time";
            gridViewTextBoxColumn5.Name = "Time";
            gridViewTextBoxColumn5.Width = 69;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "CategoryName";
            gridViewTextBoxColumn6.HeaderText = "Type";
            gridViewTextBoxColumn6.Name = "Type";
            gridViewTextBoxColumn6.Width = 69;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "CategoryURLType";
            gridViewTextBoxColumn7.HeaderText = "Main Type";
            gridViewTextBoxColumn7.Name = "Main Type";
            gridViewTextBoxColumn7.Width = 69;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "FormattedAddress";
            gridViewTextBoxColumn8.HeaderText = "Address";
            gridViewTextBoxColumn8.Name = "Address";
            gridViewTextBoxColumn8.Width = 69;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "City";
            gridViewTextBoxColumn9.HeaderText = "City";
            gridViewTextBoxColumn9.Name = "City";
            gridViewTextBoxColumn9.Width = 69;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Source";
            gridViewTextBoxColumn10.HeaderText = "Source";
            gridViewTextBoxColumn10.Name = "Source";
            gridViewTextBoxColumn10.Width = 67;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Visibility";
            gridViewTextBoxColumn11.HeaderText = "Visibility";
            gridViewTextBoxColumn11.Name = "Visibility";
            gridViewTextBoxColumn11.Width = 53;
            this.allVisitedPlacesGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.allVisitedPlacesGrid.MasterTemplate.EnableFiltering = true;
            this.allVisitedPlacesGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
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
            this.gMapControl1.Size = new System.Drawing.Size(426, 298);
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
            // zoomInPictureBox
            // 
            this.zoomInPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("zoomInPictureBox.Image")));
            this.zoomInPictureBox.Location = new System.Drawing.Point(1302, 152);
            this.zoomInPictureBox.Name = "zoomInPictureBox";
            this.zoomInPictureBox.Size = new System.Drawing.Size(47, 48);
            this.zoomInPictureBox.TabIndex = 46;
            this.zoomInPictureBox.TabStop = false;
            this.zoomInPictureBox.Click += new System.EventHandler(this.zoomInPictureBox_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.SteelBlue;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(31, 26);
            this.backButton.TabIndex = 45;
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GeoPrivacyVisualizerApplication.Properties.Resources.important_98442_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(22, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // zoomOutPictureBox
            // 
            this.zoomOutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutPictureBox.Image")));
            this.zoomOutPictureBox.Location = new System.Drawing.Point(1302, 206);
            this.zoomOutPictureBox.Name = "zoomOutPictureBox";
            this.zoomOutPictureBox.Size = new System.Drawing.Size(47, 48);
            this.zoomOutPictureBox.TabIndex = 47;
            this.zoomOutPictureBox.TabStop = false;
            this.zoomOutPictureBox.Click += new System.EventHandler(this.zoomOutPictureBox_Click);
            // 
            // AllVisitedPlacesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.zoomOutPictureBox);
            this.Controls.Add(this.zoomInPictureBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.radSeparator2);
            this.Controls.Add(this.allVisitedPlacesGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radSeparator1);
            this.MinimumSize = new System.Drawing.Size(1352, 637);
            this.Name = "AllVisitedPlacesUserControl";
            this.Size = new System.Drawing.Size(1352, 637);
            this.Load += new System.EventHandler(this.AllVisitedPlacesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allVisitedPlacesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomInPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomOutPictureBox)).EndInit();
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
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox zoomInPictureBox;
        private System.Windows.Forms.PictureBox zoomOutPictureBox;
    }
}
