using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.DTO;
using FinalProject.DAL;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject.BLL
{
    internal class CartTableBLL
    {
        CartTableDAL cartTableDAL = new CartTableDAL();
        public DataTable populateCartData_CartTable_BLL(string userID)
        {
            if (cartTableDAL.populateCartData_CartTable_DAL(userID).Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return cartTableDAL.populateCartData_CartTable_DAL(userID);
            }
        }
        public void deleteCartItem_CartTable_BLL(string id, string userID)
        {
            cartTableDAL.deleteCartItem_CartTable_DAL(id, userID);
        }
        public void insertIntoCartData_CartTable_BLL(string dishID, string dishPicture, string dishName, int dishPrice, int totalQuantity, string userID)
        {
            cartTableDAL.insertIntoCartData_CartTable_DAL(dishID, dishPicture, dishName, dishPrice, totalQuantity, userID);
        }
        public void updateIntoCartData_CartTable_BLL(string dishID, int totalQuantity, string userID)
        {
            cartTableDAL.updateCartData_CartTable_DAL(dishID, totalQuantity, userID);
        }
        public void updateCartDataPromotion_CartTable_BLL(string promotionID, string promotionCash, string userID)
        {
            cartTableDAL.updateCartDataPromotion_CartTable_DAL(promotionID, promotionCash, userID);
        }
        public DataTable populateStoreAddress_CartTable_BLL()
        {
            if (cartTableDAL.populateStoreAddress_DA_DAL() == null)
            {
                return null;
            }
            else
            {
                return cartTableDAL.populateStoreAddress_DA_DAL();
            }
        }
        public void payMoney(string userID, int totalCash, string storeName)
        {
            cartTableDAL.payMoney_BLL(userID, totalCash, storeName);
        }
    }
}
