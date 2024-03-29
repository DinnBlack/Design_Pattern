using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    public class DatabaseAdapter: IDatabaseSQLServer
    {
        private IDatabaseAccess _server;
        public DatabaseAdapter()
        {
            _server = new DatabaseAccess();
        }

        public void addNotification_DA_DAL(Notification item, string description, string focus)
        {
            _server.addNotification_DA_DAL(item, description, focus);
        }

        public void addPromotion_DA_DAL(PromotionItem item)
        {
            throw new NotImplementedException();
        }

        public void addUser_DA_BLL(User user, string cn)
        {
            throw new NotImplementedException();
        }

        public string checkLoginData_DA_DAL(User tk)
        {
            throw new NotImplementedException();
        }

        public void deleteCartItem_DA_DAL(string id, string userID)
        {
            throw new NotImplementedException();
        }

        public void deleteNotificationDataDetail(string id)
        {
            throw new NotImplementedException();
        }

        public void deleteNotification_DA_DAL(string id)
        {
            throw new NotImplementedException();
        }

        public void deletePromotion_DA_DAL(string id)
        {
            throw new NotImplementedException();
        }

        public void deleteUser_DA_BLL(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable getAllHistoryUserData_DA_DAL(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable getAllNotification_DA_DAL()
        {
            throw new NotImplementedException();
        }

        public DataTable getAllProvince_DA_DAL()
        {
            throw new NotImplementedException();
        }

        public DataTable getAllRevenueByIdManager_DA_DAL(string key)
        {
            throw new NotImplementedException();
        }

        public DataTable getAllRevenueById_DA_DAL(string key)
        {
            throw new NotImplementedException();
        }

        public DataTable getAllRevenueByTime_DA_DAL(string start, string end, string id)
        {
            throw new NotImplementedException();
        }

        public DataTable getAllRevenue_DA_DAL()
        {
            throw new NotImplementedException();
        }

        public DataTable getAllStoreAdress()
        {
            throw new NotImplementedException();
        }

        public DataTable getAllUserOfStore_DA_DAL(string key)
        {
            throw new NotImplementedException();
        }

        public DataTable getAllUser_DA_DAL()
        {
            throw new NotImplementedException();
        }

        public string getIdByUsername_DA_DAL(string name)
        {
            throw new NotImplementedException();
        }

        public DataTable getNotificationItem_DA_DAL()
        {
            throw new NotImplementedException();
        }

        public DataTable getTotalQuantityOfDish_DA_DAL(string dishID, string userID)
        {
            throw new NotImplementedException();
        }

        public DataTable getUserById_DA_DAL(string id)
        {
            throw new NotImplementedException();
        }

        public void insertIntoCartData_DA_DAL(string dishID, string dishPicture, string dishName, int dishPrice, int totalQuantity, string userID)
        {
            throw new NotImplementedException();
        }

        public void payMoney(string userID, int totalCash, string storeName)
        {
            throw new NotImplementedException();
        }

        public DataTable populateCartData_DA_DAL(string userID)
        {
            throw new NotImplementedException();
        }

        public DataTable populateHistoryDetail_DA_DAL(string orderUserID)
        {
            throw new NotImplementedException();
        }

        public DataTable populateInformationUser_DA_DAL(string userID)
        {
            throw new NotImplementedException();
        }

        public DataTable populateMenuData_DA_DAL(string type)
        {
            throw new NotImplementedException();
        }

        public DataTable populatePromotionData_DA_DAL()
        {
            throw new NotImplementedException();
        }

        public DataTable populateProvince_DA_DAL()
        {
            throw new NotImplementedException();
        }

        public DataTable populateStoreAddressData_DA_DAL()
        {
            throw new NotImplementedException();
        }

        public DataTable populateStoreAddress_DA_DAL()
        {
            throw new NotImplementedException();
        }

        public DataTable searchNotification_DA_DAL(string key)
        {
            throw new NotImplementedException();
        }

        public DataTable searchPromotion_DA_DAL(string key)
        {
            throw new NotImplementedException();
        }

        public DataTable searchUser_DA_BLL(string key, string cn)
        {
            throw new NotImplementedException();
        }

        public string signUp_DA_DAL(User newUser)
        {
            throw new NotImplementedException();
        }

        public void updateCartDataPromotion_DA_DAL(string promotionID, string promotionCash, string userID)
        {
            throw new NotImplementedException();
        }

        public void updateCartData_DA_DAL(string dishID, int totalQuantity, string userID)
        {
            throw new NotImplementedException();
        }

        public void updateUser_DA_BLL(User user)
        {
            throw new NotImplementedException();
        }
    }
}
