using System.Collections.Generic;

namespace Model
{
    public class UserlogicImpl : IUserLogic
    {
        public User validateUserLogin(string userName, string password)
        {
            UserDAO_impl objUserDAO_Impl = new UserDAO_impl();
            User objUser = objUserDAO_Impl.getUserByUserNameAndPassword(userName, password);

            if (objUser == null)
            {
                return null;
            }
            else
            {
                return objUser;
            }
        }

        public List<User> GetUsers()
        {
            UserDAO_impl objUserDAO_Impl = new UserDAO_impl();
            List<User> list = objUserDAO_Impl.GetUsers();

            return list;
        }

        public bool InsertUser(string username, string pwd, int level, string email)
        {
            UserDAO_impl objUserDAO_Impl = new UserDAO_impl();
            bool isSuccess = objUserDAO_Impl.InsertUser(username, pwd, level, email);

            return isSuccess;
        }

        public bool UpdateUser(int uid, string username, string pwd, int level, string email)
        {
            UserDAO_impl objUserDAO_Impl = new UserDAO_impl();
            bool isSuccess = objUserDAO_Impl.UpdateUser(uid, username, pwd, level, email);

            return isSuccess;
        }

        public bool DeleteUser(int uid)
        {
            UserDAO_impl objUserDAO_Impl = new UserDAO_impl();
            bool isSuccess = objUserDAO_Impl.DeleteUser(uid);

            return isSuccess;
        }

    }
}
