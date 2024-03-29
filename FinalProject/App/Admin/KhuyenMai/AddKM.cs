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

namespace FinalProject.App.Admin.KhuyenMai
{
    public partial class AddKM : Form
    {
        public AddKM()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PromotionTableBLL ehe = new PromotionTableBLL();
            PromotionItem item = new PromotionItem();
            item.promotionPicture = tbPoster.Text;
            item.promotionName = txtTD.Text;
            item.promotionDescription = txtND.Text;
            try
            {
                item.promotionPercent = int.Parse(tbPercent.Text);
            }
            catch { }
            ehe.addPromotion(item);
        }
    }
}
