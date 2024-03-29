using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class PromotionTableDAL: DatabaseSQLServer
    {
        public DataTable populatePromotionData_PromotionTable_DAL()
        {
            return populatePromotionData_DA_DAL();
        }
        public DataTable searchPromotion_DAL(String key)
        {
            return searchPromotion_DA_DAL(key);
        }
        public void addPromotion_DAL(PromotionItem item)
        {
            addPromotion_DA_DAL(item);
        }
        public void deletePromotion_DAL(String id)
        {
            deletePromotion_DA_DAL(id);
        }
    }
}
