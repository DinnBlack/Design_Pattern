using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class LoginDAL: DatabaseSQLServer
    {
        public string checkLoginData_Login_DAL(User tk)
        {
            return checkLoginData_DA_DAL(tk);
        }
        public string signUp_Login_DAL(User newUser)
        {
            return signUp_DA_DAL(newUser);
        }
        public DataTable populateInformationUser_Login_DAL(string userID)
        {
            if (populateInformationUser_DA_DAL(userID) == null)
            {
                return null;
            }
            else
            {
                return populateInformationUser_DA_DAL(userID);
            }
        }
        public DataTable populateProvince_Login_DAL()
        {
            if(populateProvince_DA_DAL() == null)
            {
                return null;
            }
            else
            {
                return populateProvince_DA_DAL();
            }
        }
    }
}
