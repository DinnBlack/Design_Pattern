using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.DTO;
using FinalProject.DAL;
using System.Windows.Forms;
using System.Data;

namespace FinalProject.BLL
{
    internal class LoginBLL
    {
        LoginDAL loginDAL = new LoginDAL();
        public bool isValidEmail(string email)
        {
            var trimmedEmail = email.Trim();
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        public string checkLoginData_Login_BLL(User tk)
        {
            if (tk.userName == "" || tk.userName == "Username")
            {
                return "Vui lòng nhập tên tài khoản";
            }
            else if (tk.userPassword == "" || tk.userPassword == "Password")
            {
                return "Vui lòng nhập mật khẩu";
            }
            return loginDAL.checkLoginData_Login_DAL(tk);
        }
        public string signUp_Login_BLL(User newUser)
        {
            if (newUser.fullName == "" || newUser.fullName == "Full name")
            {
                return "Vui lòng nhập họ tên đầy đủ";
            }
            else if (newUser.emailAddress == "" || newUser.emailAddress == "Email")
            {
                return "Vui lòng nhập email";
            }
            else if (isValidEmail(newUser.emailAddress) == false)
            {
                return "Vui lòng nhập email hợp lệ";
            }
            else if (newUser.contactAddress == "" || newUser.contactAddress == "Contact address")
            {
                return "Vui lòng nhập địa chỉ liên lạc";
            }
            else if (newUser.phoneNumber == "" || newUser.phoneNumber == "Phone number")
            {
                return "Vui lòng nhập số điện thoại";
            }
            else if (newUser.userName == "" || newUser.userName == "Username")
            {
                return "Vui lòng nhập tên tài khoản";
            }
            else if (newUser.userPassword == "" || newUser.userPassword == "Password")
            {
                return "Vui lòng nhập mật khẩu";
            }
            return loginDAL.signUp_Login_DAL(newUser);
        }
        public DataTable populateInformationUser_Login_BLL(string userID)
        {
            if (loginDAL.populateInformationUser_Login_DAL(userID) == null)
            {
                return null;
            }
            else
            {
                return loginDAL.populateInformationUser_Login_DAL(userID);
            }
        }
        public DataTable populateProvince_Login_BLL()
        {
            if(loginDAL.populateProvince_DA_DAL() == null)
            {
                return null;
            }
            else
            {
                return loginDAL.populateProvince_DA_DAL();
            }
        }
    }
}
