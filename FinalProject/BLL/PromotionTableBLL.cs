using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.DTO;
using FinalProject.DAL;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace FinalProject.BLL
{
    internal class PromotionTableBLL
    {
        PromotionTableDAL promotionTableDAL = new PromotionTableDAL();
        public DataTable populatePromotionData_PromotionTable_BLL()
        {
            if (promotionTableDAL.populatePromotionData_PromotionTable_DAL().Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return promotionTableDAL.populatePromotionData_PromotionTable_DAL();
            }
        }
        public DataTable searchPromotion(String key)
        {
            return promotionTableDAL.searchPromotion_DAL(key);
        }
        public void addPromotion(PromotionItem item)
        {
            promotionTableDAL.addPromotion_DAL(item);
        }
        public void deletePromotion(String id)
        {
            promotionTableDAL.deletePromotion_DAL(id);
        }
    }
}
