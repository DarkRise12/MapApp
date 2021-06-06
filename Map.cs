using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using MapApp.MapFolder;
using System.Diagnostics;
using MapApp.DBFolder;
using System.IO;
using MySql.Data.MySqlClient;
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.IO.Font;
using System.Drawing.Imaging;
using iText.IO.Image;

namespace MapApp
{
    public partial class Map : Form
    {
        List<PointLatLng> points = new List<PointLatLng>();
        List<string> ord = new List<string>();
        GMapOverlay mapOverlay = new GMapOverlay("markers");
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            gMapControl1.MaxZoom = 50;
            gMapControl1.MinZoom = 0;
            gMapControl1.Zoom = 17;
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.Position = MapInfo.CityPoint;

            string inf = ApiGet.GetPlaceApi(MapInfo.Radius.ToString(), MapInfo.CityPoint.Lng.ToString().Replace(",","."), MapInfo.CityPoint.Lat.ToString().Replace(",", ".")).ToString();
            string[] rtb = inf.Split('\n');
            
            if (rtb.Length < MapInfo.Amount)
                MapInfo.Amount = rtb.Length-1;
            for(int i = 0; i < MapInfo.Amount;i++)
            {
                ord = new List<string>(rtb[i].Split('|'));
                //if(string.IsNullOrEmpty(ord[0]))
                    ord.Insert(0, Convert.ToString(i));
                dataGridView1.Rows.Add(ord.ToArray());
            }

            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                PointLatLng pll = new PointLatLng(Convert.ToDouble(i.Cells[2].Value), Convert.ToDouble(i.Cells[3].Value));
                points.Add(pll);
                GMarkerGoogle marker = new GMarkerGoogle(pll, GMarkerGoogleType.green);
                mapOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(mapOverlay);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PointAdd add = new PointAdd();
            add.ShowDialog();
            if(add.DialogResult == DialogResult.OK)
            {
                int last_row = Convert.ToInt32(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value);
                int id = last_row + 1;
                dataGridView1.Rows.Add(id, add.Name, add.Lat, add.Lng, add.Rate, add.Type);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mapOverlay.Clear();
            for(int i = 0;i < dataGridView1.Rows.Count - 1;i++)
            {
                double lat = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString().Replace(".",","));
                double lon = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString().Replace(".",","));
                Debug.WriteLine(lat.ToString() + " " + lon.ToString());
                PointLatLng pll = new PointLatLng(lat, lon);
                points.Add(pll);
                GMarkerGoogle marker = new GMarkerGoogle(pll, GMarkerGoogleType.green);
                mapOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(mapOverlay);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\MapPoints\");
            string filename = @"C:\Users\" + Environment.UserName + @"\Documents\MapPoints\" + MapInfo.Name + " " + MapInfo.City + " " + DateTime.Now.ToString("dd-MM-yyyy H-mm") + ".txt";
            string text = "Сотрудник: \n" + UserData.UserName + "\nКлиент: \n" + MapInfo.Name + "\nКонтактные данные:\n" + MapInfo.Contact + "\nГород:\n" + MapInfo.City +  "\nКоличество точек:\n" + MapInfo.Amount + "\nТочки:\n";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                text += dataGridView1.Rows[i].Cells[0].Value.ToString() + " | " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " | " + dataGridView1.Rows[i].Cells[2].Value.ToString() + 
                    " | " + dataGridView1.Rows[i].Cells[3].Value.ToString() + " | " + dataGridView1.Rows[i].Cells[4].Value.ToString() + " | " + dataGridView1.Rows[i].Cells[5].Value.ToString();
                text += "\n";
            }

            try
            {
                if (File.Exists(filename))
                    File.Delete(filename);

                using (StreamWriter sw = File.CreateText(filename))
                {
                    sw.WriteLine(text);
                }
                MessageBox.Show("Запись прошла успешно");
            }
            catch
            {
                MessageBox.Show("Ошибка записи в файл");

            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `clients`(`client_name`, `client_contact`, `city`, `date`, `file_name`, `empl_name`, `empl_type`) VALUES " +
                "(@cl_name, @cl_contact, @cl_city, @cl_date, @cl_file, @emp_name, @emp_type)", db.getCon());

            command.Parameters.Add("@cl_name", MySqlDbType.VarChar).Value = MapInfo.Name;
            command.Parameters.Add("@cl_contact", MySqlDbType.VarChar).Value = MapInfo.Contact;
            command.Parameters.Add("@cl_city", MySqlDbType.VarChar).Value = MapInfo.City;
            command.Parameters.Add("@cl_date", MySqlDbType.VarChar).Value = DateTime.Now.ToString("dd-MM-yyyy");
            command.Parameters.Add("@cl_file", MySqlDbType.VarChar).Value = MapInfo.Name + " " + MapInfo.City + " " + DateTime.Now.ToString("dd-MM-yyyy H-mm") + ".txt";
            command.Parameters.Add("@emp_name", MySqlDbType.VarChar).Value = UserData.UserName;
            command.Parameters.Add("@emp_type", MySqlDbType.VarChar).Value = UserData.UserType;

            db.openCon();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Произошла запись в бд");
            }

            db.closeCon();
        }

        [Obsolete]
        private void button5_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = MapInfo.Name + " " + MapInfo.City + " " + DateTime.Now.ToString("dd-MM-yyyy H-mm") + ".pdf";
                bool fileError = false;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(sfd.FileName))
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Произошла ошибка: " + ex.Message);
                        }

                    if(!fileError)
                        try
                        {
                            string ttf = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
                            PdfFont font = PdfFontFactory.CreateFont(ttf, PdfEncodings.IDENTITY_H, true);
                            Table table = new Table(dataGridView1.Columns.Count);
                            table.SetPadding(3);
                            table.SetWidth(100);
                            table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);

                            foreach(DataGridViewColumn column in dataGridView1.Columns)
                            {
                                Cell cell = new Cell().Add(new Paragraph(column.HeaderText).SetFont(font));
                                table.AddCell(cell);
                            }

                            foreach(DataGridViewRow row in dataGridView1.Rows)
                                foreach(DataGridViewCell viewCell in row.Cells)
                                {
                                    //if(viewCell.ColumnIndex != 5)
                                        table.AddCell(System.Convert.ToString(viewCell.Value)).SetFont(font);
                                }

                            Bitmap bmp = new Bitmap(gMapControl1.Width, gMapControl1.Height);

                            using (Graphics g = Graphics.FromImage(bmp))
                            {
                                using (Bitmap b = new Bitmap(this.Width, this.Height))
                                {
                                    //captures the Form screenschot, and saves it into Bitmap b
                                    this.DrawToBitmap(b, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));

                                    //this draws the image from Bitmap b starting at the specified location to Bitmap bmp 
                                    g.DrawImageUnscaled(b, -15, -50);
                                }
                            }
                            string save_path = @"C:\Users\" + Environment.UserName + @"\Documents\MapPoints\" + MapInfo.Name + " " + MapInfo.City + " " + DateTime.Now.ToString("dd-MM-yyyy H-mm") + ".bmp";
                            bmp.Save(save_path, ImageFormat.Bmp);
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                PdfDocument pdfDoc = new PdfDocument(new PdfWriter(stream));
                                Document doc = new Document(pdfDoc);
                                doc.Add(table);
                                iText.Layout.Element.Image im = new iText.Layout.Element.Image(ImageDataFactory.Create(save_path));
                                doc.Add(im);
                                doc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Документ успешно создан");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при записи данных: " + ex.Message);
                        }
                }
            }
        }
    }
}
