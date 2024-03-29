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

namespace FinalProject.App.Admin.TaiKhoan
{
    public partial class EditTK : Form
    {
        public EditTK()
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
            Dictionary<string, string> data = new Dictionary<string, string>();
            StoreAddressTableBLL dataBLL = new StoreAddressTableBLL();
            foreach (DataRow row in dataBLL.populateStoreAddressData_StoreAddressTable_BLL().Rows)
            {
                data.Add(row["storeID"].ToString(), row["storeName"].ToString());
            }
            CBCN.DataSource = new BindingSource(data, null);
            CBCN.DisplayMember = "Value";
            CBCN.ValueMember = "Key";
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
            if (txtFullname.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtPhonenumber.Text == "" || cbAddress.Text == "" || txtUsername.Text == "" || cbRole.Text == "")
                MessageBox.Show("Nhập thiếu");
            else
            {
                if (IsValidEmail(txtEmail.Text) == false)
                    MessageBox.Show("Nhập sai email");
                else if (IsNumber(txtPhonenumber.Text) == false || txtPhonenumber.Text.Length !=10)
                    MessageBox.Show("Sai định dạng số điện thoại");
                else
                {
                    newUser.fullName = txtFullname.Text;
                    newUser.emailAddress = txtEmail.Text;
                    newUser.contactAddress = cbAddress.Text;
                    newUser.phoneNumber = txtPhonenumber.Text;
                    newUser.userPassword = txtPassword.Text;
                    newUser.userName = txtUsername.Text;
                    newUser.userRole = cbRole.Text;
                    ehe.addUser(newUser, CBCN.SelectedValue.ToString());
                }
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedIndex == 0)
            {
                label9.Visible = false;
                CBCN.Visible = false;
            }
            else if (cbRole.SelectedIndex == 1)
            {
                
                label9.Visible = true;
                CBCN.Visible = true;
            }
            else if (cbRole.SelectedIndex == 2)
            {
                label9.Visible = false;
                CBCN.Visible = false;
            }
            else if((cbRole.SelectedIndex == 3))
            {
                label9.Visible = true;
                CBCN.Visible = true;
            }
        }
    }
}
