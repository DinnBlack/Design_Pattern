using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.DAL
{
    public interface IDatabaseAccess
    {
        DataTable populateHistoryDetail_DA_DAL(string orderUserID);
        DataTable populateStoreAddress_DA_DAL();
        void payMoney(string userID, int totalCash, string storeName);
        DataTable populateProvince_DA_DAL();
        String getIdByUsername_DA_DAL(String name);
        string checkLoginData_DA_DAL(User tk);
        string signUp_DA_DAL(User newUser);
        DataTable populateMenuData_DA_DAL(string type);
        DataTable populateInformationUser_DA_DAL(string userID);
        void updateCartDataPromotion_DA_DAL(string promotionID, string promotionCash, string userID);
        DataTable getTotalQuantityOfDish_DA_DAL(string dishID, string userID);
        DataTable populateCartData_DA_DAL(string userID);
        void insertIntoCartData_DA_DAL(string dishID, string dishPicture, string dishName, int dishPrice, int totalQuantity, string userID);
        void updateCartData_DA_DAL(string dishID, int totalQuantity, string userID);
        void deleteCartItem_DA_DAL(string id, string userID);
        DataTable populatePromotionData_DA_DAL();
        DataTable populateStoreAddressData_DA_DAL();
        //Data admin page user
        DataTable getAllUser_DA_DAL();
        DataTable searchUser_DA_BLL(String key, String cn);
        void deleteUser_DA_BLL(String id);
        void updateUser_DA_BLL(User user);
        void addUser_DA_BLL(User user, String cn);
        DataTable getUserById_DA_DAL(String id);
        DataTable getAllUserOfStore_DA_DAL(String key);
        //StoreAddress
        DataTable getAllStoreAdress();
        // REVENUE
        DataTable getAllRevenue_DA_DAL();
        DataTable getAllRevenueById_DA_DAL(String key);
        DataTable getAllRevenueByIdManager_DA_DAL(String key);
        DataTable getAllRevenueByTime_DA_DAL(String start, String end, String id);
        // NOTIFICATION
        DataTable getAllNotification_DA_DAL();
        DataTable getNotificationItem_DA_DAL();
        void addNotification_DA_DAL(Notification item, String description, String focus);
        DataTable searchNotification_DA_DAL(String key);
        void deleteNotificationDataDetail(String id);
        void deleteNotification_DA_DAL(String id);
        //Province
        DataTable getAllProvince_DA_DAL();
        //Promotion
        DataTable searchPromotion_DA_DAL(String key);
        void addPromotion_DA_DAL(PromotionItem item);
        void deletePromotion_DA_DAL(String id);
        //HistoryUserData
        DataTable getAllHistoryUserData_DA_DAL(String id);
    }
}
