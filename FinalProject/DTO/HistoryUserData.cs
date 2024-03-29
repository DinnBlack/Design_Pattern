using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    internal class HistoryUserData
    {
        public String orderUserID { get; set; }
        public String userID { get; set; }
        public String orderPicture { get; set; }
        public int totalDish { get; set; }
        public int totalCash { get; set; }
        public String orderDate { get; set; }
        public String condition { get; set; }
    }
}
