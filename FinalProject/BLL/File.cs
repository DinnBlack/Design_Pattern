using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    internal class File
    {
        public string readLanguage()
        {
            FileStream fs = new FileStream("../../Language.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String giatri = rd.ReadLine();
            rd.Close();
            return giatri;
        }
        public void changeLanguage(String lang)
        {
            using (StreamWriter sw = new StreamWriter("../../Language.txt"))
            {
                sw.WriteLine(lang);
            }
        }
    }
}
