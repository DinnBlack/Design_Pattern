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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FinalProject.DTO;

namespace FinalProject.App.Admin
{
    public partial class UCDTAdmin : UserControl
    {
        public UCDTAdmin()
        {
            InitializeComponent();
            AdminRevenueBLL ehe = new AdminRevenueBLL();
            dtgvDT.DataSource = ehe.getAllRevenue();
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
        public DataTable getRevenueBId()
        {
            AdminRevenueBLL ehe = new AdminRevenueBLL();
            String value = cbCNN.SelectedValue.ToString();
            return ehe.getAllRevenueById(value);
        }

        private void cbCNN_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminRevenueBLL ehe = new AdminRevenueBLL();
            dtgvDT.DataSource = getRevenueBId();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String start = timeStart.Value.ToString();
            string end = timeEnd.Value.ToString();
            AdminRevenueBLL ehe = new AdminRevenueBLL();
            dtgvDT.DataSource = ehe.getAllRevenueByTime(start, end, cbCNN.SelectedValue.ToString());
        }
    }
}
