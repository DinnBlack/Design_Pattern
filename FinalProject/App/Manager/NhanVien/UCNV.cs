using System;
using System.Collections.Generic;
using FinalProject.BLL;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Manager
{
    public partial class UCNV : UserControl
    {
        public string id;
        public UCNV(string id)
        {
            InitializeComponent();
            this.id = id;
            AdminUserBLL ehe = new AdminUserBLL();
            dtgvNV.DataSource = ehe.getAllUserOfStore(id);
        }
        private void UCNV_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Form frm = new AddNV(id);
            frm.ShowDialog();

        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mua vjp để cập nhập tính năng này");
        }
    }
}
