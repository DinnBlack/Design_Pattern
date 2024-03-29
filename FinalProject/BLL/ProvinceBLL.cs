using FinalProject.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    internal class ProvinceBLL
    {
        public DataTable getAllProvince()
        {
            ProvinceDAL ehe = new ProvinceDAL();
            return ehe.getAllProvince_DAL();
        }
    }
}
