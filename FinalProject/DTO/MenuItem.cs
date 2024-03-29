using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    internal class MenuItem
    {
        public string dishID { get; set; }
        public string dishPicture { get; set; }
        public string dishName { get; set; }
        public string dishDescription { get; set; }
        public int dishPrice { get; set; }
        public string dishType { get; set; }
    }
}
