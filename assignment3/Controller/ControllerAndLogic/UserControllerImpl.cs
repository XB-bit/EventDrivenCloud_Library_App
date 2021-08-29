using Controller.LibraryServiceReference;
using Controller.Model_DTO;
using System;
using System.Collections.Generic;



namespace Controller
{
    public class UserControllerImpl : IUserController
    {
        LibraryWebServiceSoapClient objLibraryWebServiceSoapClient = new LibraryWebServiceSoapClient();
        public UserLoginDTO validateUserLogin(string userName, string password)
        {
            User objUser = objLibraryWebServiceSoapClient.validateUserLogin(userName, password);

            UserLoginDTO objUserLoginDTO = null;

            if (objUser == null)
            {
                //redirect to the SignIn page
                return null;

            }
            else
            {
                //redirect to the MainPage
                objUserLoginDTO = new UserLoginDTO();
                objUserLoginDTO.UserLevel = objUser.UserLevel;
                return objUserLoginDTO;




            }
        }



        public List<UserDTO> GetAllUsers()
        {
            User[] userList = objLibraryWebServiceSoapClient.GetUsers();

            List<UserDTO> list = new List<UserDTO>();

            foreach (var u in userList)
            {
                UserDTO dto = new UserDTO();
                dto.UID = u.UID;
                dto.Email = u.Email;
                dto.Username = u.Username;
                dto.UserLevel = u.UserLevel;
                dto.Password = u.Password;

                list.Add(dto);
            }

            return list;
        }

        public bool AddUser(string username, string pwd, int level, string email)
        {
            bool isSuccessful = objLibraryWebServiceSoapClient.InsertUser(username, pwd, level, email);
            return isSuccessful;
        }

        public bool UpdateUser(int uid, string username, string pwd, int level, string email)
        {
            bool isSuccessful = objLibraryWebServiceSoapClient.UpdateUser(uid, username, pwd, level, email);
            return isSuccessful;
        }

        public bool DeleteUser(int uid)
        {
            bool isSuccessful = objLibraryWebServiceSoapClient.DeleteUser(uid);
            return isSuccessful;
        }
    }
}
/*
using Controller.LibraryServiceReference;
using System;
using System.Collections.Generic;



namespace Controller
{
    public class UserControllerImpl : IUserController
    {
        public UserLoginDTO validateUserLogin(string userName, string password)
        {
            /*
            UserlogicImpl objUserLogicImpl = new UserlogicImpl();
            User objUser  = objUserLogicImpl.validateUserLogin(userName, password);

            UserLoginDTO objUserLoginDTO = null;

            if (objUser == null)
            {
                //redirect to the SignIn page
                return null;
                
            }
            else
            {
                //redirect to the MainPage
                objUserLoginDTO = new UserLoginDTO();
                objUserLoginDTO.UserLevel = objUser.UserLevel;
                return objUserLoginDTO;



                
            }
         

            User objUser = null;

            //connect to web services
            LibraryServiceReference.LibraryWebServiceSoapClient objLibraryWebServiceSoapClient = new LibraryServiceReference.LibraryWebServiceSoapClient();
            objUser = objLibraryWebServiceSoapClient.validateUserLogin(userName, password);
            return null;
        }
     
        public List<UserDTO> GetAllUsers()
        {
            UserlogicImpl objUserLogicImpl = new UserlogicImpl();
            List<User> userList = objUserLogicImpl.GetUsers();

            List<UserDTO> list = new List<UserDTO>();

            foreach (var u in userList)
            {
                UserDTO dto = new UserDTO();
                dto.UID = u.UID;
                dto.Email = u.Email;
                dto.Username = u.Username;
                dto.UserLevel = u.UserLevel;
                dto.Password = u.Password;

                list.Add(dto);
            }

            return list;
        }

        public bool AddUser(string username, string pwd, int level, string email)
        {
            UserlogicImpl objUserLogicImpl = new UserlogicImpl();
            bool isSuccessful = objUserLogicImpl.InsertUser(username, pwd, level, email);
            return isSuccessful;
        }

        public bool UpdateUser(int uid, string username, string pwd, int level, string email)
        {
            UserlogicImpl objUserLogicImpl = new UserlogicImpl();
            bool isSuccessful = objUserLogicImpl.UpdateUser(uid, username, pwd, level, email);
            return isSuccessful;
        }

        public bool DeleteUser(int uid)
        {
            UserlogicImpl objUserLogicImpl = new UserlogicImpl();
            bool isSuccessful = objUserLogicImpl.DeleteUser(uid);
            return isSuccessful;
        }
    }

    }
}
*/