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
    internal class CookTableBLL
    {
        CookTableDAL cookTableDAL = new CookTableDAL();
        public DataTable populateMenuData_CookTable_BLL(string type)
        {
            if (cookTableDAL.populateMenuData_CookTable_DAL(type).Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return cookTableDAL.populateMenuData_CookTable_DAL(type);
            }
        }
        public DataTable getTotalQuantityOfDish_CookTable_BLL(string dishID, string userID)
        {
            return cookTableDAL.getTotalQuantityOfDish_DA_DAL(dishID, userID);
        }
    }
}
