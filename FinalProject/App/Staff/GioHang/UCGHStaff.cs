using FinalProject.BLL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Staff.GioHang
{
    public partial class UCGHStaff : UserControl
    {
        private String userIDLogin;
        public UCGHStaff()
        {
            InitializeComponent();
        }
        public UCGHStaff(String userIDLogin)
        {
            this.userIDLogin= userIDLogin;
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
        private void ChildControl_ButtonClicked(object sender, EventArgs e)
        {
            label1.Focus();
            populateCartData_CartTable_UCTD();
        }
        private void populateCartData_CartTable_UCTD()
        {
            flowLayoutPanel1.Controls.Clear();

            CartTableBLL cartTableBLL = new CartTableBLL();
            int totalCash = 0;
            int promotionCash = 0;
            if (cartTableBLL.populateCartData_CartTable_BLL(userIDLogin) != null)
            {
                foreach (DataRow row in cartTableBLL.populateCartData_CartTable_BLL(userIDLogin).Rows)
                {
                    FinalProject.DTO.CartDataItem newCartDataItem = new FinalProject.DTO.CartDataItem();

                    newCartDataItem.dishID = row["dishID"].ToString();
                    newCartDataItem.dishPicture = row["dishPicture"].ToString();
                    newCartDataItem.dishName = row["dishName"].ToString();
                    newCartDataItem.dishPrice = int.Parse(row["dishPrice"].ToString());
                    newCartDataItem.totalQuantity = int.Parse(row["totalQuantity"].ToString());

                    totalCash += newCartDataItem.dishPrice * newCartDataItem.totalQuantity;

                    CardGH Item = new CardGH(flowLayoutPanel1);

                    var request = WebRequest.Create(newCartDataItem.dishPicture);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Item.Picture = Bitmap.FromStream(stream);
                        Item.Picture = resizeImage(Item.Picture, 255, 143);
                    }
                    Item.ID = newCartDataItem.dishID;
                    Item.Title = newCartDataItem.dishName;
                    Item.Price = newCartDataItem.dishPrice;
                    Item.Quantity = newCartDataItem.totalQuantity;
                    Item.ButtonClicked += ChildControl_ButtonClicked;
                    Item.UserID = userIDLogin;
                    Item.PromotionID = row["promotionID"].ToString();
                    Item.Percent = int.Parse(row["promotionCash"].ToString());
                    promotionCash = (totalCash * Item.Percent) / 100;
                    this.flowLayoutPanel1.Controls.Add(Item);
                }
            }
            label4.Text = promotionCash.ToString();
            totalCash = totalCash - promotionCash;
            tbCash.Text = totalCash.ToString();
        }

        private void UCGHStaff_Load(object sender, EventArgs e)
        {
            LoginBLL newLoginBLL = new LoginBLL();
            populateCartData_CartTable_UCTD();
        }
    }
}
