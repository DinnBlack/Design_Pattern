using FinalProject.App.Main.ThucDon;
using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Manager.ThucDon
{
    public partial class UCTDManager : UserControl
    {
        public UCTDManager()
        {
            InitializeComponent();
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
        private void populateMenuData_CookTable_UCTD(string type)
        {
            CookTableBLL cookTableBLL = new CookTableBLL();

            if (cookTableBLL.populateMenuData_CookTable_BLL(type) != null)
            {
                foreach (DataRow row in cookTableBLL.populateMenuData_CookTable_BLL(type).Rows)
                {
                    FinalProject.DTO.MenuItem newMenuItem = new FinalProject.DTO.MenuItem();

                    newMenuItem.dishID = row["dishID"].ToString();
                    newMenuItem.dishPicture = row["dishPicture"].ToString();
                    newMenuItem.dishName = row["dishName"].ToString();
                    newMenuItem.dishDescription = row["dishDescription"].ToString();
                    newMenuItem.dishPrice = int.Parse(row["dishPrice"].ToString());
                    newMenuItem.dishType = row["dishType"].ToString();

                    CardTD Item = new CardTD();

                    var request = WebRequest.Create(newMenuItem.dishPicture);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Item.Picture = Bitmap.FromStream(stream);
                        Item.Picture = resizeImage(Item.Picture, 255, 143);
                    }

                    Item.Title = newMenuItem.dishName;
                    Item.Price = newMenuItem.dishPrice;

                    this.flowLayoutPanel1.Controls.Add(Item);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu MenuData");
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD(btnCombo.Text);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD(btnFood.Text);
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD(btnDrink.Text);
        }

        private void UCTD_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD(btnCombo.Text);
            populateMenuData_CookTable_UCTD(btnFood.Text);
            populateMenuData_CookTable_UCTD(btnDrink.Text);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD(btnCombo.Text);
            populateMenuData_CookTable_UCTD(btnFood.Text);
            populateMenuData_CookTable_UCTD(btnDrink.Text);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
