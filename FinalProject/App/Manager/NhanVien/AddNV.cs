using FinalProject.BLL;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Manager
{
    public partial class AddNV : Form
    {
        private String id;
        public AddNV(string id)
        {
            InitializeComponent();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            ProvinceBLL storeBLL = new ProvinceBLL();
            foreach (DataRow row in storeBLL.getAllProvince().Rows)
            {
                comboSource.Add(row["provinceID"].ToString(), row["provinceName"].ToString());
            }
            cbAddress.DataSource = new BindingSource(comboSource, null);
            cbAddress.DisplayMember = "Value";
            cbAddress.ValueMember = "Key";
            this.id = id;
        }
        bool IsValidEmail(string email)
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
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            User newUser = new User();
            if (txtFullname.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtPhonenumber.Text == "" || cbAddress.Text == "" || txtUsername.Text == "")
                MessageBox.Show("Nhập thiếu");
            else
            {
                if (IsValidEmail(txtEmail.Text) == false)
                    MessageBox.Show("Nhập sai email");
                else if (IsNumber(txtPhonenumber.Text) == false || txtPhonenumber.Text.Length != 10)
                    MessageBox.Show("Sai định dạng số điện thoại");
                else
                {
                    newUser.fullName = txtFullname.Text;
                    newUser.emailAddress = txtEmail.Text;
                    newUser.contactAddress = cbAddress.Text;
                    newUser.phoneNumber = txtPhonenumber.Text;
                    newUser.userPassword = txtPassword.Text;
                    newUser.userName = txtUsername.Text;
                    newUser.userRole = "staff";
                    ehe.addUser(newUser,this.id);
                }
            }
        }
    }
}
