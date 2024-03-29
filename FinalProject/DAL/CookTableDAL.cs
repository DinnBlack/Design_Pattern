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
    internal class CookTableDAL: DatabaseSQLServer
    {
        public DataTable populateMenuData_CookTable_DAL(string type)
        {
            return populateMenuData_DA_DAL(type);
        }
        public DataTable getTotalQuantityOfDish_CookTable_DAL(string dishID, string userID)
        {
            return getTotalQuantityOfDish_DA_DAL(dishID, userID);
        }

    }
}
