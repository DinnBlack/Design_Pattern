using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.DAL
{
    internal class CartTableDAL: DatabaseSQLServer
    {
        public DataTable populateCartData_CartTable_DAL(string userID)
        {
            return populateCartData_DA_DAL(userID);
        }
        public void deleteCartItem_CartTable_DAL(string id, string userID)
        {
            deleteCartItem_DA_DAL(id, userID);
        }
        public void insertIntoCartData_CartTable_DAL(string dishID, string dishPicture, string dishName, int dishPrice, int totalQuantity, string userID)
        {
            insertIntoCartData_DA_DAL(dishID, dishPicture, dishName, dishPrice, totalQuantity, userID);
        }
        public void updateCartData_CartTable_DAL(string dishID, int totalQuantity, string userID)
        {
            updateCartData_DA_DAL(dishID, totalQuantity, userID);
        }
        public void updateCartDataPromotion_CartTable_DAL(string promotionID, string promotionCash, string userID)
        {
            updateCartDataPromotion_DA_DAL(promotionID, promotionCash, userID);
        }
        public DataTable populateStoreAddress_CartTable_DAL()
        {
            if (populateStoreAddress_DA_DAL() == null)
            {
                return null;
            }
            else
            {
                return populateStoreAddress_DA_DAL();
            }
        }
        public void payMoney_BLL(string userID, int totalCash, string storeName)
        {
            payMoney(userID, totalCash, storeName);
        }
    }
}
