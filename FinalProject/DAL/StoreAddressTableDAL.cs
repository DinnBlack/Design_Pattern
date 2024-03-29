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
    internal class StoreAddressTableDAL: DatabaseSQLServer
    {
        public DataTable populateStoreAddressData_StoreAddressTable_DAL()
        {
            return populateStoreAddressData_DA_DAL();
        }
    }
}
