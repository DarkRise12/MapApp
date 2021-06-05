
namespace MapApp
{
    partial class MapInitForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cityBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.next1 = new System.Windows.Forms.Button();
            this.back1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.next2 = new System.Windows.Forms.Button();
            this.back2 = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.next3 = new System.Windows.Forms.Button();
            this.back3 = new System.Windows.Forms.Button();
            this.radiusUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.amountUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.makemapButton = new System.Windows.Forms.Button();
            this.back4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 1);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 567);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cityBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.next1);
            this.tabPage1.Controls.Add(this.back1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(394, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(120, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ввод города";
            // 
            // cityBox1
            // 
            this.cityBox1.Location = new System.Drawing.Point(111, 121);
            this.cityBox1.Name = "cityBox1";
            this.cityBox1.Size = new System.Drawing.Size(241, 20);
            this.cityBox1.TabIndex = 3;
            this.cityBox1.TextChanged += new System.EventHandler(this.cityBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите город";
            // 
            // next1
            // 
            this.next1.Enabled = false;
            this.next1.Location = new System.Drawing.Point(193, 320);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(109, 44);
            this.next1.TabIndex = 1;
            this.next1.Text = "Далее";
            this.next1.UseVisualStyleBackColor = true;
            this.next1.Click += new System.EventHandler(this.next1_Click);
            // 
            // back1
            // 
            this.back1.Enabled = false;
            this.back1.Location = new System.Drawing.Point(78, 320);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(109, 44);
            this.back1.TabIndex = 0;
            this.back1.Text = "Назад";
            this.back1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.next2);
            this.tabPage2.Controls.Add(this.back2);
            this.tabPage2.Controls.Add(this.gMapControl1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(394, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(282, 343);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Долгота (lon):";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(88, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Широта (lat):";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 304);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ручной ввод";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Автоматический выбор";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // next2
            // 
            this.next2.Location = new System.Drawing.Point(188, 394);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(109, 44);
            this.next2.TabIndex = 3;
            this.next2.Text = "Далее";
            this.next2.UseVisualStyleBackColor = true;
            this.next2.Click += new System.EventHandler(this.next2_Click);
            // 
            // back2
            // 
            this.back2.Location = new System.Drawing.Point(73, 394);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(109, 44);
            this.back2.TabIndex = 2;
            this.back2.Text = "Назад";
            this.back2.UseVisualStyleBackColor = true;
            this.back2.Click += new System.EventHandler(this.back2_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(80, 96);
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
            this.gMapControl1.Size = new System.Drawing.Size(217, 192);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ввод контрольной точки";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.next3);
            this.tabPage3.Controls.Add(this.back3);
            this.tabPage3.Controls.Add(this.radiusUpDown2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.amountUpDown1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(394, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // next3
            // 
            this.next3.Location = new System.Drawing.Point(186, 297);
            this.next3.Name = "next3";
            this.next3.Size = new System.Drawing.Size(109, 44);
            this.next3.TabIndex = 12;
            this.next3.Text = "Далее";
            this.next3.UseVisualStyleBackColor = true;
            this.next3.Click += new System.EventHandler(this.next3_Click);
            // 
            // back3
            // 
            this.back3.Location = new System.Drawing.Point(71, 297);
            this.back3.Name = "back3";
            this.back3.Size = new System.Drawing.Size(109, 44);
            this.back3.TabIndex = 11;
            this.back3.Text = "Назад";
            this.back3.UseVisualStyleBackColor = true;
            this.back3.Click += new System.EventHandler(this.back3_Click);
            // 
            // radiusUpDown2
            // 
            this.radiusUpDown2.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.radiusUpDown2.Location = new System.Drawing.Point(186, 149);
            this.radiusUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.radiusUpDown2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radiusUpDown2.Name = "radiusUpDown2";
            this.radiusUpDown2.Size = new System.Drawing.Size(83, 20);
            this.radiusUpDown2.TabIndex = 5;
            this.radiusUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Выбор радиуса поиска точек";
            // 
            // amountUpDown1
            // 
            this.amountUpDown1.Location = new System.Drawing.Point(176, 114);
            this.amountUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.amountUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountUpDown1.Name = "amountUpDown1";
            this.amountUpDown1.Size = new System.Drawing.Size(57, 20);
            this.amountUpDown1.TabIndex = 3;
            this.amountUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Количество точек на карте";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Дополнительные параметры карты";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.makemapButton);
            this.tabPage4.Controls.Add(this.back4);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(394, 540);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // makemapButton
            // 
            this.makemapButton.Enabled = false;
            this.makemapButton.Location = new System.Drawing.Point(189, 278);
            this.makemapButton.Name = "makemapButton";
            this.makemapButton.Size = new System.Drawing.Size(109, 44);
            this.makemapButton.TabIndex = 14;
            this.makemapButton.Text = "Составить карту";
            this.makemapButton.UseVisualStyleBackColor = true;
            this.makemapButton.Click += new System.EventHandler(this.makemapButton_Click);
            // 
            // back4
            // 
            this.back4.Location = new System.Drawing.Point(74, 278);
            this.back4.Name = "back4";
            this.back4.Size = new System.Drawing.Size(109, 44);
            this.back4.TabIndex = 13;
            this.back4.Text = "Назад";
            this.back4.UseVisualStyleBackColor = true;
            this.back4.Click += new System.EventHandler(this.back4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Контактные данные";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Имя клиента";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(39, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Заполнение данных клиента";
            // 
            // MapInitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 591);
            this.Controls.Add(this.tabControl1);
            this.Name = "MapInitForm";
            this.Text = "Инициализация карты";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button next1;
        private System.Windows.Forms.Button back1;
        private System.Windows.Forms.TextBox cityBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.Button back2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button next3;
        private System.Windows.Forms.Button back3;
        private System.Windows.Forms.NumericUpDown radiusUpDown2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown amountUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button makemapButton;
        private System.Windows.Forms.Button back4;
        private System.Windows.Forms.TextBox textBox4;
    }
}