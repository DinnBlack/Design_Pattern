using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main
{
    public partial class CardCH : UserControl
    {
        public CardCH()
        {
            InitializeComponent();
        }
        #region Properties

        private string _title;
        private string _description;
        private Image _pic;
        private string _date;
        private string _phone;

        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; kryptonLabel36.Text = value; } }
        [Category("Custom Props")]
        public string Description { get { return _description; } set { _description = value; kryptonLabel35.Text = value; } }
        [Category("Custom Props")]
        public string Phone { get { return _phone; } set { _phone = value; kryptonLabel5.Text = value; } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pictureBox12.Image = value; } }
        [Category("Custom Props")]
        public string Date { get { return _date; } set { _date = value; kryptonLabel1.Text = value; } }
        #endregion
        private static readonly string[] VietnameseSigns = new string[]
        {

            "aAeEoOuUiIdDyY",

            "áàạảãâấầậẩẫăắằặẳẵ",

            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

            "éèẹẻẽêếềệểễ",

            "ÉÈẸẺẼÊẾỀỆỂỄ",

            "óòọỏõôốồộổỗơớờợởỡ",

            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

            "úùụủũưứừựửữ",

            "ÚÙỤỦŨƯỨỪỰỬỮ",

            "íìịỉĩ",

            "ÍÌỊỈĨ",

            "đ",

            "Đ",

            "ýỳỵỷỹ",

            "ÝỲỴỶỸ"
        };
        public static string RemoveSign4VietnameseString(string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }
        private void ButtonKM1_Click(object sender, EventArgs e)
        {
            StringBuilder address = new StringBuilder();
            address.Append("https://www.google.com/maps/place/");
            address.Append(kryptonLabel35.Text.Replace(' ', '+'));
            address.Append("/");
            System.Diagnostics.Process.Start(RemoveSign4VietnameseString(address.ToString()));
        }
    }
}
