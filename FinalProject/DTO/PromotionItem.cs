using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public class PromotionItem
    {
        public string promotionID { get; set; }
        public string promotionPicture { get; set; }
        public string promotionName { get; set; }
        public string promotionDescription { get; set; }
        public string promotionDate { get; set; }
        public int promotionPercent { get; set; }
    }
}
