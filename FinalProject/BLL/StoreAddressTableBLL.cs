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
    internal class StoreAddressTableBLL
    {
        StoreAddressTableDAL storeAddressTableDAL = new StoreAddressTableDAL();
        public DataTable populateStoreAddressData_StoreAddressTable_BLL()
        {
            if (storeAddressTableDAL.populateStoreAddressData_StoreAddressTable_DAL().Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return storeAddressTableDAL.populateStoreAddressData_StoreAddressTable_DAL();
            }
        }
    }
}
