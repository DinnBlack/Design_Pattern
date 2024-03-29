using FinalProject.App.Main.CaiDat;
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
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.MainUser;

namespace FinalProject.App.Main.CaiDat
{
    public partial class UCCD : UserControl
    {
        private String id;
        public UCCD(string id)
        {
            File ehe = new File();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ehe.readLanguage());
            InitializeComponent();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            ProvinceBLL storeBLL = new ProvinceBLL();
            foreach (DataRow row in storeBLL.getAllProvince().Rows)
            {
                comboSource.Add(row["provinceID"].ToString(), row["provinceName"].ToString());
            }
            CBQQ.DataSource = new BindingSource(comboSource, null);
            CBQQ.DisplayMember = "Value";
            CBQQ.ValueMember = "Key";
            this.id = id;
        }
        Func Func= new Func();
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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (tabControl1.SelectedIndex == 1)
            {
                HistoryDataBLL data = new HistoryDataBLL();
                if (data.getHistoryData(id) != null)
                {
                    foreach (DataRow row in data.getHistoryData(id).Rows)
                    {
                        FinalProject.DTO.HistoryUserData newMenuItem = new FinalProject.DTO.HistoryUserData();

                        newMenuItem.orderUserID = row["orderUserID"].ToString();
                        newMenuItem.userID = row["userID"].ToString();
                        newMenuItem.orderPicture = row["orderPicture"].ToString();
                        newMenuItem.totalDish = int.Parse(row["totalDish"].ToString());
                        newMenuItem.totalCash = int.Parse(row["totalCash"].ToString());
                        newMenuItem.orderDate = row["orderDate"].ToString();
                        newMenuItem.condition = row["condition"].ToString();

                        CardDH Item = new CardDH();
                        Item.OrderUserID = newMenuItem.orderUserID;
                        var request = WebRequest.Create(newMenuItem.orderPicture);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            Item.Picture = Bitmap.FromStream(stream);
                            Item.Picture = resizeImage(Item.Picture, 255, 143);
                        }
                        Item.Soluong = newMenuItem.totalDish.ToString();
                        Item.Date = newMenuItem.orderDate;
                        Item.Price = newMenuItem.totalCash;
                        Item.Status = newMenuItem.condition;

                        flowLayoutPanel1.Controls.Add(Item);
                    }
                }
            }
        }
        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            File ehe = new File();
            switch (kryptonComboBox1.SelectedIndex)
            {
                case 0:
                    ehe.changeLanguage("vi");
                    MessageBox.Show("Khởi động lại ứng đụng để cập nhập cài đặt");
                    InitializeComponent();
                    break;
                case 1:
                    ehe.changeLanguage("en");
                    MessageBox.Show("Khởi động lại ứng đụng để cập nhập cài đặt");
                    InitializeComponent();
                    break;
            }
        }
        public String convertBirthDate(String key)
        {
            string date = key.Split(' ')[0].Replace("-", "/");
            string[] tmp = date.Split('/');
            string result ="";
            for (int i=0;i<tmp.Length;i++)
            {
                if (tmp[i].Length == 1)
                    tmp[i] = tmp[i].Replace(tmp[i], "0" + tmp[i]);
                if(i==0)
                    result = tmp[i];
                else
                    result = result +"/"+ tmp[i];
            }
            return result;
        }
        private void UCCD_Load(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            User user = new User();
            user = ehe.getUserByID(this.id);
            txtHoten.Text = user.fullName;
            txtEmail.Text = user.emailAddress;
            timeDate.Value = DateTime.ParseExact(convertBirthDate(user.userDateOfBirth), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            txtSDT.Text = user.phoneNumber;
            CBQQ.SelectedIndex = CBQQ.FindStringExact(user.contactAddress);
        }
        private void btnSighOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CBQQ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.userID=this.id;
            newUser.fullName=txtHoten.Text;
            newUser.userDateOfBirth = timeDate.Value.ToString();
            newUser.phoneNumber = txtSDT.Text;
            newUser.emailAddress = txtEmail.Text;
            newUser.contactAddress = CBQQ.SelectedItem.ToString().Replace(", ", ",").Split(',')[1].Replace("]", "");
            AdminUserBLL userBLL = new AdminUserBLL();
            userBLL.updateUser(newUser);
            this.tabTTCN.Refresh();
        }

        private void btnSDT_Click(object sender, EventArgs e)
        {
            txtSDT.Enabled = true;
            btnSave.Enabled = true;
        }


        private void btnEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled= true;
            btnSave.Enabled = true;
        }


        private void btnHoTen_Click(object sender, EventArgs e)
        {
            txtHoten.Enabled = true;
            btnSave.Enabled = true;
        }

        private void radbtnMoney_CheckedChanged(object sender, EventArgs e)
        {

        }
      
        private void radbtnMomo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
