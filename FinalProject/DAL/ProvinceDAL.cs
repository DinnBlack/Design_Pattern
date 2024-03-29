using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class ProvinceDAL: DatabaseSQLServer
    {
        public DataTable getAllProvince_DAL()
        {
            return getAllProvince_DA_DAL();
        }
    }
}
