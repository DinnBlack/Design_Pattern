using FinalProject.App.Main;
using FinalProject.BLL;
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

namespace FinalProject.App.Staff.KhuyenMai
{
    public partial class UCKMStaff : UserControl
    {
        private string userIDLogin;
        public UCKMStaff()
        {
            InitializeComponent();
        }
        public UCKMStaff(string userIDLogin)
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
        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Search";
                tbSearch.ForeColor = Color.Silver;
            }
        }
        private void UCKM_Load(object sender, EventArgs e)
        {
            populatePromotionData_PromotionTable_UCKM(false);
        }
        PromotionTableBLL promotionTableBLL = new PromotionTableBLL();
        private void populatePromotionData_PromotionTable_UCKM(Boolean flag)
        {
            this.flowLayoutPanel1.Controls.Clear();
            DataTable list;
            if (flag)
            {
                list = promotionTableBLL.searchPromotion(tbSearch.Text);
            }
            else
            {
                list = promotionTableBLL.populatePromotionData_PromotionTable_BLL();
            }
            if (list != null)
            {
                foreach (DataRow row in list.Rows)
                {
                    FinalProject.DTO.PromotionItem newPromotionItem = new FinalProject.DTO.PromotionItem();

                    newPromotionItem.promotionID = row["promotionID"].ToString();
                    newPromotionItem.promotionPicture = row["promotionPicture"].ToString();
                    newPromotionItem.promotionName = row["promotionName"].ToString();
                    newPromotionItem.promotionDescription = row["promotionDescription"].ToString();
                    newPromotionItem.promotionDate = row["promotionDate"].ToString();
                    newPromotionItem.promotionPercent = int.Parse(row["promotionPercent"].ToString());

                    CardKM Item = new CardKM();

                    var request = WebRequest.Create(newPromotionItem.promotionPicture);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Item.Picture = Bitmap.FromStream(stream);
                        Item.Picture = resizeImage(Item.Picture, 228, 187);
                    }
                    Item.Title = newPromotionItem.promotionName;
                    Item.Description = newPromotionItem.promotionDescription;
                    Item.Percent = newPromotionItem.promotionPercent;
                    Item.UserID = userIDLogin;
                    Item.ButtonClicked += ChildControl_ButtonClicked;
                    Item.PromotionID = newPromotionItem.promotionID;
                    this.flowLayoutPanel1.Controls.Add(Item);
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
        private void ChildControl_ButtonClicked(object sender, EventArgs e)
        {
            //populatePromotionData_PromotionTable_UCKM(false);
        }
    }
}
