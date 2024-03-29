using FinalProject;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.DAL
{
    internal class UserCRUD_DAL: DatabaseSQLServer
    {
        public DataTable getAllUser_DAL()
        {
            return getAllUser_DA_DAL();
        }
        public DataTable searchUser_DAL(String key,String cn)
        {
            return searchUser_DA_BLL(key,cn);
        }
        public void deleteUser_DAL(String id)
        {
            deleteUser_DA_BLL(id);
        }
        public void updateUser_DAL(User user)
        {
            updateUser_DA_BLL(user);
        }
        public void addUser_DAL(User user, String cn)
        {
            addUser_DA_BLL(user,cn);
        }
        public String getIdByUsername_DAL(String name)
        {
            return getIdByUsername_DA_DAL(name);
        }
        public DataTable getUserByID(String id)
        {
            return getUserById_DA_DAL(id);
        }
        public DataTable getUserOfStore_DAL(String key)
        {
            return getAllUserOfStore_DA_DAL(key);
        }
    }
}
