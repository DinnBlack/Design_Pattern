using FinalProject.App.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static FinalProject.MainUser;
using FinalProject.DTO;
using FinalProject.BLL;
using FinalProject.App.Admin;
using FinalProject.App.Staff;
using FinalProject.App.Manager;

namespace FinalProject.App
{
    public partial class UCDN : UserControl
    {
        Login.Login login2 = new Login.Login();
        public UCDN()
        {
            InitializeComponent();
        }
        private UCDN uCDN;
        Func Func = new Func();
        
        private void linkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_DK.Visible = true;
            panel_DK.Size = new System.Drawing.Size(525,710);
            panel_DK.Location = new System.Drawing.Point(0, 0);
            Func.togglePanel(panel_DK,"DK");
            login2.Controls.Remove(uCDN);
        }
        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (UsernameText.Text == "Username")
            {
                UsernameText.Text = "";
                UsernameText.StateActive.Content.Color1 = Color.Black;
            }
        }
        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (UsernameText.Text == "")
            {
                UsernameText.Text = "Username";
                UsernameText.StateActive.Content.Color1 = Color.Silver;
            }
        }
        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.StateActive.Content.Color1 = Color.Black;
                PasswordText.UseSystemPasswordChar= true;
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
        private void Eye_Click(object sender, EventArgs e)
        {
            if (PasswordText.Text.Length > 0)
            {
                Blind.BringToFront();
                PasswordText.UseSystemPasswordChar = false;
            }
        }
        private void Blind_Click(object sender, EventArgs e)
        {
            Eye.BringToFront();
            PasswordText.UseSystemPasswordChar = true;
        }
        private void UCDN_Load(object sender, EventArgs e)
        {
            lblSignIn.Select();
            
        }
        private void UCDN_Clicked(object sender, EventArgs e)
        {
            lblSignIn.Select();
        }
        public event EventHandler ButtonClicked;
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User tk = new User();
            AdminUserBLL ehe = new AdminUserBLL();
            tk.userName = UsernameText.Text;
            tk.userPassword = PasswordText.Text;

            LoginBLL tkBLL = new LoginBLL();

            if(tkBLL.checkLoginData_Login_BLL(tk) == "Vui lòng nhập tên tài khoản")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            else if (tkBLL.checkLoginData_Login_BLL(tk) == "Vui lòng nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            else if (tkBLL.checkLoginData_Login_BLL(tk) == "Thông tin đăng nhập không chính xác!")
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
                return;
            }
            else
            {
                if (ehe.getIdByUsername(tk.userName).ToString().Contains('A'))
                {
                    MainAdmin newMain = new MainAdmin(ehe.getIdByUsername(tk.userName).ToString());
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                }
                else if (ehe.getIdByUsername(tk.userName).ToString().Contains('U'))
                {
                    MainUser newMain = new MainUser(ehe.getIdByUsername(tk.userName).ToString());
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                }
                else if (ehe.getIdByUsername(tk.userName).ToString().Contains('S'))
                {
                    MainStaff newMain = new MainStaff(ehe.getIdByUsername(tk.userName).ToString());
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                }
                else if (ehe.getIdByUsername(tk.userName).ToString().Contains('M'))
                {
                    MainManager newMain = new MainManager(ehe.getIdByUsername(tk.userName).ToString());
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                }
                return;
            }
        }
    }
}
