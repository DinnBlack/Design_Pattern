using FinalProject.App.Main;
using FinalProject.App.Main.ThucDon;
using FinalProject.BLL;
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

namespace FinalProject.App
{
    public partial class UCCH : UserControl
    {
        public UCCH()
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

        private void UCCH_Load(object sender, EventArgs e)
        {
            populateStoreAddressData_StoreAddressTable_UCCH();
        }
        private void populateStoreAddressData_StoreAddressTable_UCCH()
        {
            StoreAddressTableBLL storeAddressTableBLL = new StoreAddressTableBLL();

            if (storeAddressTableBLL.populateStoreAddressData_StoreAddressTable_BLL() != null)
            {
                foreach (DataRow row in storeAddressTableBLL.populateStoreAddressData_StoreAddressTable_BLL().Rows)
                {
                    FinalProject.DTO.StoreAddressItem newStoreAddressItem = new FinalProject.DTO.StoreAddressItem();

                    newStoreAddressItem.storeID = row["storeID"].ToString();
                    newStoreAddressItem.storePicture = row["storePicture"].ToString();
                    newStoreAddressItem.storeName = row["storeName"].ToString();
                    newStoreAddressItem.storeDescription = row["storeDescription"].ToString();
                    newStoreAddressItem.storeTime = row["storeTime"].ToString();
                    newStoreAddressItem.storePhone = row["storePhone"].ToString();

                    CardCH Item = new CardCH();

                    var request = WebRequest.Create(newStoreAddressItem.storePicture);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        Item.Picture = Bitmap.FromStream(stream);
                        Item.Picture = resizeImage(Item.Picture, 228, 187);
                    }

                    Item.Title = newStoreAddressItem.storeName;
                    Item.Description = newStoreAddressItem.storeDescription;
                    Item.Date = newStoreAddressItem.storeTime;
                    Item.Phone = newStoreAddressItem.storePhone;

                    this.flowLayoutPanel1.Controls.Add(Item);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu StoreAddressData");
            }
        }
    }
}
