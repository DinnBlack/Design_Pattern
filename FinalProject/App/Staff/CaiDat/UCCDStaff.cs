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

namespace FinalProject.App.Staff.CaiDat
{
    public partial class UCCDStaff : UserControl
    {
        private string id;
        public UCCDStaff(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void UCCDStaff_Load(object sender, EventArgs e)
        {
            AdminUserBLL ehe = new AdminUserBLL();
            User user = new User();
            user = ehe.getUserByID(this.id);
            txtHoten.Text = user.fullName;
            txtEmail.Text = user.emailAddress;
            txtNS.Text = user.userDateOfBirth;
            txtSDT.Text = user.phoneNumber;
            txtQQ.Text = user.contactAddress;
        }
    }
}
