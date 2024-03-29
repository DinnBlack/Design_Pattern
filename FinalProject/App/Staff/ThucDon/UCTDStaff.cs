using FinalProject.App.Main.ThucDon;
using FinalProject.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace FinalProject.App.Staff.ThucDon
{
    public partial class UCTDStaff : UserControl
    {
        private string userIDLogin;

        public UCTDStaff()
        {
            InitializeComponent();
        }

        public UCTDStaff(string userIDLogin)
        {
            this.userIDLogin = userIDLogin;
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

        private FlowLayoutPanel populateMenuData_CookTable_UCTD(string type, FlowLayoutPanel flowLayoutPanel1)
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
                }
                return flowLayoutPanel1;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu MenuDataaa");
                return null;
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD("combo", flowLayoutPanel1);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD("food", flowLayoutPanel1);
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD("drink", flowLayoutPanel1);
        }

        private void UCTD_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD("combo", flowLayoutPanel1);
            populateMenuData_CookTable_UCTD("food", flowLayoutPanel1);
            populateMenuData_CookTable_UCTD("drink", flowLayoutPanel1);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populateMenuData_CookTable_UCTD("combo", flowLayoutPanel1);
            populateMenuData_CookTable_UCTD("food", flowLayoutPanel1);
            populateMenuData_CookTable_UCTD("drink", flowLayoutPanel1);
        }
    }
}
