using FinalProject.App.Main.ThucDon;
using FinalProject.BLL;
using FinalProject.DAL;
using FinalProject.DTO;
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
using System.Drawing.Drawing2D;

namespace FinalProject.App.Main.GioHang
{
    public partial class UCGH : UserControl
    {
        private string userIDLogin;
        public UCGH()
        {
            File ehe = new File();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ehe.readLanguage());
            InitializeComponent();
        }
        public UCGH(string userIDLogin)
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
                    promotionCash = (totalCash*Item.Percent)/100;
                    this.flowLayoutPanel1.Controls.Add(Item);
                }
            }
            label14.Text = promotionCash.ToString();
            label12.Text = totalCash.ToString();
            totalCash = totalCash - promotionCash;
            label3.Text = totalCash.ToString();
        }
        private void ChildControl_ButtonClicked(object sender, EventArgs e)
        {
            label1.Focus();
            populateCartData_CartTable_UCTD();
        }
        private void UCGH_Load(object sender, EventArgs e)
        {
            CartTableBLL newCartTableBLL = new CartTableBLL();
            if (newCartTableBLL.populateStoreAddress_CartTable_BLL() == null)
            {
                MessageBox.Show("Không có dữ liệu cửa hàng");
            }
            else
            {
                foreach (DataRow row in newCartTableBLL.populateStoreAddress_CartTable_BLL().Rows)
                {
                    cbStoreAddress.Items.Add(row["storeName"].ToString());
                }
            }
            RadbtnMoney.Checked = true;
            LoginBLL newLoginBLL = new LoginBLL();
            if (newLoginBLL.populateInformationUser_Login_BLL(userIDLogin) != null)
            {
                foreach (DataRow row in newLoginBLL.populateInformationUser_Login_BLL(userIDLogin).Rows)
                {
                    txtFullName.Text = row["fullName"].ToString();
                    txtSDT.Text = row["phoneNumber"].ToString();
                    kryptonTextBox1.Text = row["contactAddress"].ToString();
                    break;
                }
            }
            populateCartData_CartTable_UCTD();
        }
        private void btnSelectVoucher_Click(object sender, EventArgs e)
        {
            ADKM frm = new ADKM(userIDLogin);
            frm.ShowDialog();
            ChildControl_ButtonClicked(sender, e);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên");
                return;
            }

            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            else if (kryptonTextBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ liên hệ");
                return;
            }
            else if (label3.Text == "")
            {
                MessageBox.Show("Giỏ hàng không có món để thanh toán");
                return;
            }
            else if (cbStoreAddress.SelectedItem == null)
            {
                MessageBox.Show("Bạn muốn chi nhánh nào sẽ giao hàng?");
                return;
            }
            else if (RadbtnMoney.Checked == true && txtFullName.Text != "" && txtSDT.Text != "" && kryptonTextBox1.Text != "" && label3.Text != "0" && cbStoreAddress.SelectedItem != null)
            {
                CartTableBLL newCartTableBLL = new CartTableBLL();
                newCartTableBLL.payMoney(userIDLogin, int.Parse(label3.Text), cbStoreAddress.SelectedItem.ToString());
                MessageBox.Show("Vui lòng thanh toán khi nhận được đồ ăn. Chúc bạn ngon miệng");
                populateCartData_CartTable_UCTD();
                return;
            }
            else if (RadbtnMomo.Checked == true && txtFullName.Text != "" && txtSDT.Text != "" && kryptonTextBox1.Text != "" && label3.Text != "0" && cbStoreAddress.SelectedItem != null)
            {
                QRcode newQRCode = new QRcode(label3.Text);
                newQRCode.ShowDialog();
                CartTableBLL newCartTableBLL = new CartTableBLL();
                newCartTableBLL.payMoney(userIDLogin, int.Parse(label3.Text), cbStoreAddress.SelectedItem.ToString());
                MessageBox.Show("Vui lòng chờ nhận hàng");
                populateCartData_CartTable_UCTD();
                return;
            }

        }
    }
}
