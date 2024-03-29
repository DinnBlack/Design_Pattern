using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class HistoryDataDAL: DatabaseSQLServer
    {
        public DataTable getAllHistoryItem_DAL(String id)
        {
            return getAllHistoryUserData_DA_DAL(id);
        }
    }
}
