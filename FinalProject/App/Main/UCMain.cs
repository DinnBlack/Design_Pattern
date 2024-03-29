using FinalProject.App.Main.ThucDon;
using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App
{
    public partial class UCMain : UserControl
    {
        private string userIDLogin;
        public UCMain()
        {
            InitializeComponent();
        }
        public UCMain(string userIDLogin)
        {
            InitializeComponent();
            this.userIDLogin = userIDLogin;
        }
        public Image resizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        private void NextSlider_Click(object sender, EventArgs e)
        {
            if (Radbutton.Checked)
            {
                Radbutton.Checked = false;
                ImageSlider.Visible = false;
                Radbutton2.Checked = true;
                ImageSlider2.Visible = true;
            }
            else if (Radbutton2.Checked)
            {
                Radbutton2.Checked = false;
                ImageSlider2.Visible = false;
                Radbutton3.Checked = true;
                ImageSlider3.Visible = true;
            }
            else if (Radbutton3.Checked)
            {
                Radbutton3.Checked = false;
                ImageSlider3.Visible = false;
                Radbutton4.Checked = true;
                ImageSlider4.Visible = true;
            }
            else if (Radbutton4.Checked)
            {
                Radbutton4.Checked = false;
                ImageSlider4.Visible = false;
                Radbutton5.Checked = true;
                ImageSlider5.Visible = true;

            }
            else if (Radbutton5.Checked)
            {
                Radbutton5.Checked = false;
                ImageSlider5.Visible = false;
                Radbutton.Checked = true;
                ImageSlider.Visible = true;
            }
        }
        private void LastSlider_Click(object sender, EventArgs e)
        {
            if (Radbutton.Checked)
            {
                Radbutton.Checked = false;
                ImageSlider.Visible = false;
                Radbutton5.Checked = true;
                ImageSlider5.Visible = true;
            }
            else if (Radbutton5.Checked)
            {
                Radbutton5.Checked = false;
                ImageSlider5.Visible = false;
                Radbutton4.Checked = true;
                ImageSlider4.Visible = true;
            }
            else if (Radbutton4.Checked)
            {
                Radbutton4.Checked = false;
                ImageSlider4.Visible = false;
                Radbutton3.Checked = true;
                ImageSlider3.Visible = true;
            }
            else if (Radbutton3.Checked)
            {
                Radbutton3.Checked = false;
                ImageSlider3.Visible = false;
                Radbutton2.Checked = true;
                ImageSlider2.Visible = true;

            }
            else if (Radbutton2.Checked)
            {
                Radbutton2.Checked = false;
                ImageSlider2.Visible = false;
                Radbutton.Checked = true;
                ImageSlider.Visible = true;
            }
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1 = populateMenuData_CookTable_UCTD(flowLayoutPanel1);
        }
        private FlowLayoutPanel populateMenuData_CookTable_UCTD(FlowLayoutPanel flowLayoutPanel1)
        {
            CookTableBLL cookTableBLL = new CookTableBLL();

            if (cookTableBLL.populateMenuData_CookTable_BLL("combo") != null)
            {
                int i = 0;
                foreach (DataRow row in cookTableBLL.populateMenuData_CookTable_BLL("combo").Rows)
                {
                    if (i < 4)
                    {
                        FinalProject.DTO.MenuItem newMenuItem = new FinalProject.DTO.MenuItem();

                        newMenuItem.dishID = row["dishID"].ToString();
                        newMenuItem.dishPicture = row["dishPicture"].ToString();
                        newMenuItem.dishName = row["dishName"].ToString();
                        newMenuItem.dishDescription = row["dishDescription"].ToString();
                        newMenuItem.dishPrice = int.Parse(row["dishPrice"].ToString());
                        newMenuItem.dishType = row["dishType"].ToString();
                        string tenp = newMenuItem.dishPicture;
                        CardTD Item = new CardTD();

                        Item.ImageLink = tenp;
                        var request = WebRequest.Create(newMenuItem.dishPicture);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            Item.Picture = Bitmap.FromStream(stream);
                            Item.Picture = resizeImage(Item.Picture, 255, 143);
                        }
                        Item.ID = newMenuItem.dishID;
                        Item.Title = newMenuItem.dishName;
                        Item.Price = newMenuItem.dishPrice;
                        foreach (DataRow r in cookTableBLL.getTotalQuantityOfDish_CookTable_BLL(newMenuItem.dishID, userIDLogin).Rows)
                        {
                            Item.TotalQuantity = int.Parse(r["totalQuantity"].ToString());
                            break;
                        }
                        Item.UserID = userIDLogin;

                        flowLayoutPanel1.Controls.Add(Item);

                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                return flowLayoutPanel1;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu MenuData");
                return null;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(615, 0);
            Point endPoint = new Point(615, 380);

            LinearGradientBrush lgb =
                new LinearGradientBrush(startPoint, endPoint, Color.FromArgb(255, 255, 170, 122), Color.FromArgb(255, 255, 255, 255));
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 0, 0, 1230, 380);
        }
    }
}
