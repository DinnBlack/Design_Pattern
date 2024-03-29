using FinalProject.App.Admin.TaiKhoan;
using FinalProject.BLL;
using FinalProject.DTO;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Admin
{
    public partial class UCTK : UserControl
    {
        public UCTK()
        {
            InitializeComponent();
            AdminUserBLL ehe = new AdminUserBLL();
            dtgvTK.DataSource = ehe.getAllUser();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            StoreAddressTableBLL storeBLL = new StoreAddressTableBLL();
            foreach (DataRow row in storeBLL.populateStoreAddressData_StoreAddressTable_BLL().Rows)
            {
                comboSource.Add(row["storeID"].ToString(), row["storeName"].ToString());
            }
            cbCNN.DataSource = new BindingSource(comboSource, null);
            cbCNN.DisplayMember = "Value";
            cbCNN.ValueMember = "Key";
        }
        Form edit = new EditTK();
        private void picSearch_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            dtgvTK.DataSource = ehe.searchUser(tbSearch.Text,cbCNN.SelectedValue.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            int rowIndex = dtgvTK.SelectedCells[0].RowIndex;
            String value = dtgvTK.Rows[rowIndex].Cells[0].Value.ToString();
            ehe.deleteUser(value);
            dtgvTK.DataSource = ehe.getAllUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit.ShowDialog();
            
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            int rowIndex = dtgvTK.SelectedCells[0].RowIndex;
            if (IsValidEmail(dtgvTK.Rows[rowIndex].Cells[2].Value.ToString()) == false)
                MessageBox.Show("Invalid Email");
            else if (IsNumber(dtgvTK.Rows[rowIndex].Cells[4].Value.ToString()) == false || dtgvTK.Rows[rowIndex].Cells[4].Value.ToString().Length ==10 )
                MessageBox.Show("Invalid PhoneNumber");
            else
            {
                User newUser = new User();
                newUser.userID = dtgvTK.Rows[rowIndex].Cells[0].Value.ToString();
                newUser.fullName = dtgvTK.Rows[rowIndex].Cells[1].Value.ToString();
                newUser.emailAddress = dtgvTK.Rows[rowIndex].Cells[2].Value.ToString();
                newUser.contactAddress = dtgvTK.Rows[rowIndex].Cells[3].Value.ToString();
                newUser.phoneNumber = dtgvTK.Rows[rowIndex].Cells[4].Value.ToString();
                newUser.userName = dtgvTK.Rows[rowIndex].Cells[5].Value.ToString();
                newUser.userRole = dtgvTK.Rows[rowIndex].Cells[7].Value.ToString();
                if (newUser.userID == "" || newUser.fullName == "" || newUser.emailAddress == "" || newUser.contactAddress == "" || newUser.phoneNumber == "" || newUser.userName == "" || newUser.userRole == "")
                {
                    MessageBox.Show("Không được để trống");
                }
                else
                {
                    if (IsValidEmail(newUser.emailAddress) == false)
                        MessageBox.Show("Invalid email");
                    else
                    {
                        ehe.updateUser(newUser);
                        dtgvTK.DataSource = ehe.getAllUser();
                    }
                }
            }
        }

        private void btnList_click(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            dtgvTK.DataSource = ehe.searchUser("null","null");
        }
    }
}
