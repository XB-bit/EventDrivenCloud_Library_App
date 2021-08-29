using Model.DS;
using Model.DS.UserDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
namespace Model
{
   public class UserDAO_impl : IUserDAO
    {
        public User getUserByUserNameAndPassword(string userName, string password)
        {
          
            TabUserTableAdapter objTableUserTableAdapter = new TabUserTableAdapter();
            UserDataSet.TabUserDataTable objTabUserDataTable = objTableUserTableAdapter.GetUserByUserNameAndPassword(userName, password);

            int dataCount = objTabUserDataTable.Count;
            if (dataCount ==0)
            {
                return null;  
            }
            else
            {
                User objUser = new User();

                DataRow selectedUser = objTabUserDataTable.Rows[0];
                objUser.UID = Convert.ToInt32(selectedUser["UID"].ToString());
                objUser.Username = userName;
                objUser.Password = password;
                objUser.UserLevel = Convert.ToInt32(selectedUser["UserLevel"].ToString());
                objUser.Email = selectedUser["UserEmail"].ToString();

                return objUser;
            }

           
           

        }

        public List<User> GetUsers()
        {

            TabUserTableAdapter objTableUserTableAdapter = new TabUserTableAdapter();
            UserDataSet.TabUserDataTable objTabUserDataTable = objTableUserTableAdapter.GetData();

            List<User> list = new List<User>();

            foreach (var item in objTabUserDataTable)
            {
                User objUser = new User();

                objUser.UID = Convert.ToInt32(item["UID"].ToString());
                objUser.UserLevel = Convert.ToInt32(item["UserLevel"].ToString());
                objUser.Email = item["UserEmail"].ToString();
                objUser.Username = item["UserName"].ToString();
                objUser.Password = item["Password"].ToString();

                list.Add(objUser);
            }

            return list;
        }

        public bool InsertUser(string username, string pwd, int level, string email)
        {
            TabUserTableAdapter objTableUserTableAdapter = new TabUserTableAdapter();

            try
            {
                objTableUserTableAdapter.InsertQuery(username, pwd, level, email);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool UpdateUser(int uid, string username, string pwd, int level, string email)
        {
            TabUserTableAdapter objTableUserTableAdapter = new TabUserTableAdapter();

            try
            {
                objTableUserTableAdapter.UpdateQuery(username, pwd, level, email, uid);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool DeleteUser(int uid)
        {
            TabUserTableAdapter objTableUserTableAdapter = new TabUserTableAdapter();

            try
            {
                objTableUserTableAdapter.DeleteQuery(uid);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
