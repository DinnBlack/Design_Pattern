using FinalProject.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    internal class AdminRevenueBLL
    {
        public DataTable getAllRevenue()
        {
            RevenueCRUD_DAL ehe = new RevenueCRUD_DAL();
            return ehe.getAllRevenue_DAL();
        }
        public DataTable getAllRevenueById(String key)
        {
            RevenueCRUD_DAL ehe = new RevenueCRUD_DAL();
            return ehe.getAllRevenueById_DAL(key);
        }
        public DataTable getAllRevenueByTime(String start, String end, String id)
        {
            RevenueCRUD_DAL ehe = new RevenueCRUD_DAL();
            return ehe.getAllRevenueByTime_DAL(start, end,id);
        }
        public DataTable getAllRevenueByIdManagerBLL(String id)
        {
            RevenueCRUD_DAL ehe = new RevenueCRUD_DAL();
            return ehe.getAllRevenueByIDManager_DAL(id);
        }
    }
}
