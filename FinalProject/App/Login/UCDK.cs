using FinalProject.DTO;
using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.MainUser;

namespace FinalProject.App.Login
{
    public partial class UCDK : UserControl
    {
        Login login2 = new Login();
        public UCDK()
        {
            InitializeComponent();
        }
        Func Func = new Func();
        private UCDK uCDK;
        private void btnDN_Click(object sender, EventArgs e)
        {
            panel_DN.Visible = true;
            panel_DN.Size = new System.Drawing.Size(525, 710);
            panel_DN.Location = new System.Drawing.Point(0, 0);
            Func.togglePanel(panel_DN, "DN");
            login2.Controls.Remove(uCDK);
        }
        private void FullNameText_Enter(object sender, EventArgs e)
        {
            if (FullNameText.Text == "Full name")
            {
                FullNameText.Text = "";
                FullNameText.StateActive.Content.Color1 = Color.Black;
            }
        }
        private void FullNameText_Leave(object sender, EventArgs e)
        {
            if (FullNameText.Text == "")
            {
                FullNameText.Text = "Full name";
                FullNameText.StateActive.Content.Color1 = Color.Silver;
            }
        }
        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (EmailText.Text == "Email")
            {
                EmailText.Text = "";
                EmailText.StateActive.Content.Color1 = Color.Black;
            }
        }
        private void EmailText_Leave(object sender, EventArgs e)
        {
            if (EmailText.Text == "")
            {
                EmailText.Text = "Email";
                EmailText.StateActive.Content.Color1 = Color.Silver;
            }
        }
        private void PhoneNumberText_Enter(object sender, EventArgs e)
        {
            if (PhoneNumberText.Text == "Phone number")
            {
                PhoneNumberText.Text = "";
                PhoneNumberText.StateActive.Content.Color1 = Color.Black;
            }
        }
        private void PhoneNumberText_Leave(object sender, EventArgs e)
        {
            if (PhoneNumberText.Text == "")
            {
                PhoneNumberText.Text = "Phone number";
                PhoneNumberText.StateActive.Content.Color1 = Color.Silver;
            }
        }
        private void UserNameText_Enter(object sender, EventArgs e)
        {
            if (UserNameText.Text == "Username")
            {
                UserNameText.Text = "";
                UserNameText.StateActive.Content.Color1 = Color.Black;
            }
        }
        private void UserNameText_Leave(object sender, EventArgs e)
        {
            if (UserNameText.Text == "")
            {
                UserNameText.Text = "Username";
                UserNameText.StateActive.Content.Color1 = Color.Silver;
            }
        }
        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.StateActive.Content.Color1 = Color.Black;
                PasswordText.UseSystemPasswordChar = true;
            }
        }
        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (PasswordText.Text == "")
            {
                PasswordText.Text = "Password";
                PasswordText.StateActive.Content.Color1 = Color.Silver;
            }
        }
        private void Eye2_Click(object sender, EventArgs e)
        {
            if (PasswordText.Text.Length > 0)
            {
                Blind2.BringToFront();
                PasswordText.UseSystemPasswordChar = false;
            }
        }
        private void Blind2_Click(object sender, EventArgs e)
        {
            Eye2.BringToFront();
            PasswordText.UseSystemPasswordChar = true;
        }
        private void UCDK_Load(object sender, EventArgs e)
        {
            LoginBLL newTKBLL = new LoginBLL();
            if (newTKBLL.populateProvince_Login_BLL() == null)
            {
                MessageBox.Show("Không có dữ liệu tỉnh thành");
            }
            else
            {
                foreach(DataRow row in newTKBLL.populateProvince_Login_BLL().Rows)
                {
                    ContactCB.Items.Add(row["provinceName"].ToString());
                }
            }
            lblSignUp.Select();
        }
        private void UCDK_Clicked(object sender, EventArgs e)
        {
            lblSignUp.Select();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User newTK = new User();
            newTK.fullName = FullNameText.Text;
            newTK.emailAddress = EmailText.Text;
            if(ContactCB.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tỉnh thành");
                return;
            }
            else
            {
                newTK.contactAddress = ContactCB.SelectedItem.ToString();

            }
            newTK.phoneNumber = PhoneNumberText.Text;
            newTK.userName = UserNameText.Text;
            newTK.userPassword = PasswordText.Text;

            LoginBLL newTKBLL = new LoginBLL();

            string temp = newTKBLL.signUp_Login_BLL(newTK);

            if (temp == "Vui lòng nhập họ tên đầy đủ")
            {
                MessageBox.Show("Vui lòng nhập họ tên đầy đủ");
                return;
            }
            else if (temp == "Vui lòng nhập email")
            {
                MessageBox.Show("Vui lòng nhập email");
                return;
            }
            else if (temp == "Vui lòng nhập email hợp lệ")
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ");
                return;
            }
            else if (temp == "Vui lòng nhập số điện thoại")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            else if (temp == "Vui lòng nhập tên tài khoản")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            else if (temp == "Vui lòng nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            else if (temp == "Tài khoản đã được đăng ký trước đây")
            {
                MessageBox.Show("Tài khoản đã được đăng ký trước đây");
                return;
            }
            else
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
                return;
            }
        }
        private void PhoneNumberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
