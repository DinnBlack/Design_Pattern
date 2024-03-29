using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FinalProject.App.Main.ThucDon;
using System.Drawing;
using System.Net;
using System.Data.OleDb;

namespace FinalProject.DAL
{
    public class DatabaseAccess: IDatabaseAccess
    {
        String strConn = ConfigurationManager.ConnectionStrings["MyConnAccess"].ConnectionString;
        public DataTable populateHistoryDetail_DA_DAL(string orderUserID)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM HistoryUserDataDetail WHERE orderUserID = ?";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("?", orderUserID);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable populateStoreAddress_DA_DAL()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM StoreAddress";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void payMoney(string userID, int totalCash, string storeName)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "INSERT INTO Payment (UserID, TotalCash, StoreName) VALUES (@userID, @totalCash, @storeName)";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@totalCash", totalCash);
            cmd.Parameters.AddWithValue("@storeName", storeName);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable populateProvince_DA_DAL()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM Province";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public string getIdByUsername_DA_DAL(string name)
        {
            string userID = "";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM LoginData WHERE userName = ?";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@name", name);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                userID = row["userID"].ToString();
            }
            return userID;
        }
        public string checkLoginData_DA_DAL(User tk)
        {
            string userName = null;
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM LoginData WHERE userName = @userName AND userPassword = @userPassword";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@userName", tk.userName);
            cmd.Parameters.AddWithValue("@userPassword", tk.userPassword);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userName = reader.GetString(5);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                reader.Close();
                conn.Close();
                return "Thông tin đăng nhập không chính xác!";
            }
            return userName;
        }
        public string signUp_DA_DAL(User newUser)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM LoginData WHERE userName = @userName";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@userName", newUser.userName);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                string anotherStringSQL = "INSERT INTO LoginData (fullName, emailAddress, contactAddress, phoneNumber, userName, userPassword) VALUES (@fullName, @emailAddress, @contactAddress, @phoneNumber, @userName, @userPassword)";
                OleDbCommand anotherCmd = new OleDbCommand(anotherStringSQL, conn);
                anotherCmd.Parameters.AddWithValue("@fullName", newUser.fullName);
                anotherCmd.Parameters.AddWithValue("@emailAddress", newUser.emailAddress);
                anotherCmd.Parameters.AddWithValue("@contactAddress", newUser.contactAddress);
                anotherCmd.Parameters.AddWithValue("@phoneNumber", newUser.phoneNumber);
                anotherCmd.Parameters.AddWithValue("@userName", newUser.userName);
                anotherCmd.Parameters.AddWithValue("@userPassword", newUser.userPassword);
                anotherCmd.ExecuteNonQuery();
                conn.Close();
                return "Đăng ký tài khoản thành công";
            }
            else
            {
                conn.Close();
                return "Tài khoản đã được đăng ký trước đây";
            }
        }
        public DataTable populateMenuData_DA_DAL(string type)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM MenuData WHERE dishType = @type";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@type", type);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable populateInformationUser_DA_DAL(string userID)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM LoginData WHERE userID = @userID";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@userID", userID);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void updateCartDataPromotion_DA_DAL(string promotionID, string promotionCash, string userID)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string sSQL = "UPDATE CartData SET promotionID = @promotionID, promotionCash = @promotionCash WHERE userID = @userID";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@promotionID", promotionID);
                cmd.Parameters.AddWithValue("@promotionCash", promotionCash);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Áp dụng khuyến mãi không thành công");
            }
        }
        public DataTable getTotalQuantityOfDish_DA_DAL(string dishID, string userID)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT CartData.totalQuantity FROM (MenuData INNER JOIN CartData ON MenuData.dishID = CartData.dishID) INNER JOIN LoginData ON CartData.userID = LoginData.userID WHERE CartData.dishID = @dishID AND CartData.userID = @userID";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@dishID", dishID);
            cmd.Parameters.AddWithValue("@userID", userID);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable populateCartData_DA_DAL(string userID)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM CartData WHERE userID = @userID";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@userID", userID);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void insertIntoCartData_DA_DAL(string dishID, string dishPicture, string dishName, int dishPrice, int totalQuantity, string userID)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string sSQL = "INSERT INTO CartData (dishID, dishPicture, dishName, dishPrice, totalQuantity, userID) VALUES (@dishID, @dishPicture, @dishName, @dishPrice, @totalQuantity, @userID)";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@dishID", dishID);
                cmd.Parameters.AddWithValue("@dishPicture", dishPicture);
                cmd.Parameters.AddWithValue("@dishName", dishName);
                cmd.Parameters.AddWithValue("@dishPrice", dishPrice);
                cmd.Parameters.AddWithValue("@totalQuantity", totalQuantity);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đã thêm vào giỏ hàng");
            }
            catch
            {
                MessageBox.Show("Mặt hàng đã có trong giỏ hàng của bạn");
            }
        }
        public void updateCartData_DA_DAL(string dishID, int totalQuantity, string userID)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string sSQL = "UPDATE CartData SET totalQuantity = @totalQuantity WHERE dishID = @dishID AND userID = @userID";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@dishID", dishID);
                cmd.Parameters.AddWithValue("@totalQuantity", totalQuantity);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Cập nhật số lượng không thành công");
            }
        }
        public void deleteCartItem_DA_DAL(string id, string userID)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "DELETE FROM CartData WHERE dishID = @id AND userID = @userID";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable populatePromotionData_DA_DAL()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM PromotionData";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable populateStoreAddressData_DA_DAL()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM StoreAddress";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //Data admin page user
        public DataTable getAllUser_DA_DAL()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM LoginData";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable searchUser_DA_BLL(string key, string cn)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(cn) || string.IsNullOrEmpty(key))
            {
                string sSQL = "SELECT * FROM LoginData";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            else
            {
                string sSQL = "SELECT DISTINCT LoginData.*, UserAddress.storeID FROM LoginData INNER JOIN UserAddress ON LoginData.userID = UserAddress.userID WHERE (fullName LIKE '%" + key + "%' OR fullName LIKE '" + key + "%') AND UserAddress.storeID = '" + cn + "'";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            conn.Close();
            return dt;
        }
        public void deleteUser_DA_BLL(string id)
        {
            MessageBox.Show("Delete id: " + id);
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "DELETE FROM LoginData WHERE userID = @id";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully");
        }
        public void updateUser_DA_BLL(User user)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string sSQL = "UPDATE LoginData SET fullName=@name, emailAddress=@email, contactAddress=@contact, phoneNumber=@phone WHERE userID=@id";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@name", user.fullName);
                cmd.Parameters.AddWithValue("@email", user.emailAddress);
                cmd.Parameters.AddWithValue("@contact", user.contactAddress);
                cmd.Parameters.AddWithValue("@phone", user.phoneNumber);
                cmd.Parameters.AddWithValue("@id", user.userID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Sai tỉnh thành");
            }
        }

        public void addUser_DA_BLL(User user, string cn)
        {
            MessageBox.Show("add user :" + user.fullName);
            OleDbConnection conn = new OleDbConnection(strConn);
            string sSQL = "INSERT INTO LoginData (fullName, emailAddress, contactAddress, phoneNumber, userName, userPassword) VALUES (@name, @email, @contact, @phone, @username, @userpassword)";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@name", user.fullName);
            cmd.Parameters.AddWithValue("@email", user.emailAddress);
            cmd.Parameters.AddWithValue("@contact", user.contactAddress);
            cmd.Parameters.AddWithValue("@phone", user.phoneNumber);
            cmd.Parameters.AddWithValue("@username", user.userName);
            cmd.Parameters.AddWithValue("@userpassword", user.userPassword);
            conn.Open();
            if (cn[0] == 'M')
            {
                OleDbTransaction transaction = null;
                try
                {
                    transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();

                    string sSQL2 = "INSERT INTO UserAddress (userID, storeID) VALUES ((SELECT userID FROM LoginData WHERE userName = @userName), (SELECT storeID FROM UserAddress WHERE userID = @managerID))";
                    OleDbCommand cmd2 = new OleDbCommand(sSQL2, conn);
                    cmd2.Parameters.AddWithValue("@userName", user.userName);
                    cmd2.Parameters.AddWithValue("@managerID", cn);
                    cmd2.Transaction = transaction;
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Thêm thành công");
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public DataTable getUserById_DA_DAL(string id)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM LoginData WHERE userID = @id";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getAllUserOfStore_DA_DAL(string key)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT LoginData.* FROM LoginData, UserAddress WHERE UserAddress.userID=LoginData.userID AND UserAddress.storeId = (SELECT storeID FROM UserAddress WHERE UserAddress.userID=@key)";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@key", key);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //StoreAddress
        public DataTable getAllStoreAdress()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM StoreAddress";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        // REVENUE
        public DataTable getAllRevenue_DA_DAL()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM Revenue";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getAllRevenueById_DA_DAL(string key)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM Revenue WHERE storeID=@id";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", key);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getAllRevenueByIdManager_DA_DAL(string key)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT Revenue.* FROM Revenue INNER JOIN UserAddress ON Revenue.storeID = UserAddress.storeID WHERE UserAddress.userID=@id";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", key);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getAllRevenueByTime_DA_DAL(string start, string end, string id)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM Revenue WHERE dateCreate >= @start AND dateCreate <= @end AND storeID=@id";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            cmd.Parameters.AddWithValue("@id", id);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        // NOTIFICATION
        public DataTable getAllNotification_DA_DAL()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM NotificationData";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getNotificationItem_DA_DAL()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM NotificationDataDetail";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void addNotification_DA_DAL(Notification item, string description, string focus)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "INSERT INTO NotificationData (notificationPicture, notificationName, notificationDate, notificationDescription, notificationFocus) VALUES (?, ?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@pic", item.notificationPicture);
            cmd.Parameters.AddWithValue("@name", item.notificationName);
            cmd.Parameters.AddWithValue("@date", item.notificationDate);
            cmd.Parameters.AddWithValue("@des", description);
            cmd.Parameters.AddWithValue("@focus", focus);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm thành công");
        }
        public DataTable searchNotification_DA_DAL(string key)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(key))
            {
                string sSQL = "SELECT DISTINCT * FROM NotificationData";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            else
            {
                string sSQL = "SELECT DISTINCT * FROM NotificationData WHERE notificationName LIKE '%' + @key + '%' OR notificationName LIKE @key + '%'";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                cmd.Parameters.AddWithValue("@key", key);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            conn.Close();
            return dt;
        }
        public void deleteNotificationDataDetail(string id)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "DELETE FROM NotificationDataDetail WHERE notificationID = @id";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteNotification_DA_DAL(string id)
        {
            deleteNotificationDataDetail(id);
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "DELETE FROM NotificationData WHERE notificationID = @id";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Xóa thành công");
        }
        //Province
        public DataTable getAllProvince_DA_DAL()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM Province";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //Promotion
        public DataTable searchPromotion_DA_DAL(string key)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(key) || key.Equals("Search"))
            {
                string sSQL = "SELECT * FROM PromotionData";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            else
            {
                string sSQL = "SELECT DISTINCT * FROM PromotionData WHERE promotionName LIKE '%" + key + "%' OR promotionName LIKE '" + key + "%'";
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            conn.Close();
            return dt;
        }
        public void addPromotion_DA_DAL(PromotionItem item)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "INSERT INTO PromotionData (poster, promotionName, description, percent) VALUES (@poster, @name, @description, @percent)";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@poster", item.promotionPicture);
            cmd.Parameters.AddWithValue("@name", item.promotionName);
            cmd.Parameters.AddWithValue("@description", item.promotionDescription);
            cmd.Parameters.AddWithValue("@percent", item.promotionPercent);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm thành công");
        }
        public void deletePromotion_DA_DAL(string id)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "DELETE FROM PromotionData WHERE promotionID = @id";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Xóa thành công");
        }
        //HistoryUserData
        public DataTable getAllHistoryUserData_DA_DAL(string id)
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string sSQL = "SELECT * FROM HistoryUserData WHERE userID=@id";
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@id", id);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
