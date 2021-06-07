
namespace MapApp
{
    partial class MapOpen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.names,
            this.Lat,
            this.Lng,
            this.Rate,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(368, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(481, 523);
            this.dataGridView1.TabIndex = 0;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(5, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(357, 523);
            this.gMapControl1.TabIndex = 3;
            this.gMapControl1.Zoom = 0D;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // names
            // 
            this.names.HeaderText = "Название";
            this.names.Name = "names";
            this.names.ReadOnly = true;
            // 
            // Lat
            // 
            this.Lat.HeaderText = "Широта";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            // 
            // Lng
            // 
            this.Lng.HeaderText = "Долгота";
            this.Lng.Name = "Lng";
            this.Lng.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Рейтинг";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип объекта";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // MapOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 547);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "MapOpen";
            this.Text = "Открытое из файла  ";
            this.Load += new System.EventHandler(this.MapOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}