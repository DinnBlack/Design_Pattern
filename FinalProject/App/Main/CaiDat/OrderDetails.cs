using FinalProject.App.Main.ThucDon;
using FinalProject.BLL;
using FinalProject.DAL;
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

namespace FinalProject.App.Main.CaiDat
{
    public partial class OrderDetails : Form
    {
        private string orderUserID;
        public OrderDetails()
        {
            InitializeComponent();
        }
        public OrderDetails(string orderUserID)
        {
            InitializeComponent();
            this.orderUserID = orderUserID;
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
        public void populateHistoryDetail(string orderUserID)
        {
            DatabaseAccess newDTB = new DatabaseAccess();
            if(newDTB.populateHistoryDetail_DA_DAL(orderUserID).Rows.Count > 0 )
            {
                foreach(DataRow row in newDTB.populateHistoryDetail_DA_DAL(orderUserID).Rows)
                {
                    CardOrderDetails Item = new CardOrderDetails();

                    var request = WebRequest.Create(row["dishPicture"].ToString());

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Item.Picture = Bitmap.FromStream(stream);
                        Item.Picture = resizeImage(Item.Picture, 335, 193);
                    }
                    Item.OrderUserID = orderUserID;
                    Item.DishID = row["dishID"].ToString();
                    Item.Name = row["dishName"].ToString();
                    Item.Price = int.Parse(row["dishPrice"].ToString());
                    Item.DishTotal = int.Parse(row["dishTotal"].ToString()); 
                    Item.PromotionCash = int.Parse(row["promotionCash"].ToString()); 
                    flowLayoutPanel1.Controls.Add(Item);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu HistoryUserDataDetail");
            }
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            populateHistoryDetail(orderUserID);
        }
    }
}
