using FinalProject.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    internal class HistoryDataBLL
    {
        public DataTable getHistoryData(String id)
        {
            HistoryDataDAL data = new HistoryDataDAL();
            return data.getAllHistoryItem_DAL(id);
        }
    }
}
