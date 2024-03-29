using FinalProject.App.Admin;
using FinalProject.App.Main;
using FinalProject.App.Main.KhuyenMai;
using FinalProject.App.Main.ThucDon;
using FinalProject.BLL;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = System.Drawing.Rectangle;

namespace FinalProject.App
{
    public partial class UCKM : UserControl
    {
        PromotionTableBLL listBLL = new PromotionTableBLL();
        System.Data.DataTable list;
        public UCKM()
        {
            File ehe = new File();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ehe.readLanguage());
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
        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Search";
                tbSearch.StateActive.Content.Color1 = Color.Silver;
            }
        }
        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search")
            {
                tbSearch.Text = "";
                tbSearch.StateActive.Content.Color1 = Color.Black;
            }
        }
        private void UCKM_Load(object sender, EventArgs e)
        {
            populatePromotionData_PromotionTable_UCKM(false);
        }
        private void populatePromotionData_PromotionTable_UCKM(Boolean flag)
        {
            this.flowLayoutPanel1.Controls.Clear();
            if (flag)
                this.list = listBLL.searchPromotion(tbSearch.Text);
            else
                this.list = listBLL.populatePromotionData_PromotionTable_BLL();
            if (this.list != null)
            {
                foreach (DataRow row in this.list.Rows)
                {
                    FinalProject.DTO.PromotionItem newPromotionItem = new FinalProject.DTO.PromotionItem();
                    newPromotionItem.promotionID = row["promotionID"].ToString();
                    newPromotionItem.promotionPicture = row["promotionPicture"].ToString();
                    newPromotionItem.promotionName = row["promotionName"].ToString();
                    newPromotionItem.promotionDescription = row["promotionDescription"].ToString();
                    newPromotionItem.promotionDate = row["promotionDate"].ToString();
                    newPromotionItem.promotionPercent = int.Parse(row["promotionPercent"].ToString());

                    try
                    {
                        CardKMForDisplay Item = new CardKMForDisplay();

                        var request = WebRequest.Create(newPromotionItem.promotionPicture);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            Item.Picture = Bitmap.FromStream(stream);
                            Item.Picture = resizeImage(Item.Picture, 228, 187);
                        }
                        Item.Title = newPromotionItem.promotionName;
                        Item.Description = newPromotionItem.promotionDescription;
                        this.flowLayoutPanel1.Controls.Add(Item);
                    }
                    catch
                    {
                        MessageBox.Show("Không tìm được poster của khuyến mãi id: " + newPromotionItem.promotionID + "| name:" + newPromotionItem.promotionName);
                        listBLL.deletePromotion(newPromotionItem.promotionID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu PromotionData");
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            populatePromotionData_PromotionTable_UCKM(true);
        }
    }
}
