using Model;
using Model.Model;
using System.Collections.Generic;
using System.Web.Services;

namespace CloudApplication
{
    /// <summary>
    /// Summary description for LibraryWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LibraryWebService : System.Web.Services.WebService
    {
        //global variable, object of BookLogic_impl
        BookLogic_impl objBookLogic_impl = new BookLogic_impl();
        //global variable, object of UserlogicImpl
        UserlogicImpl objUserlogicImpl = new UserlogicImpl();
        //-----------------------------------------------------calling books method from webservice
        [WebMethod]
        public List<Book> GetBooks()
        {
            //calling getBooks mehod
            return objBookLogic_impl.GetBooks();
        }

        [WebMethod]
        public List<Book> GetAvailableBooks()
        {
            //calling getAvailableBooks method
            return objBookLogic_impl.GetAvailableBooks();
        }
        [WebMethod]
        public List<Book> GetBooksWithPublishYear(int publishYear)
        {
            //calling getBooksWithPublishYear method
            return objBookLogic_impl.GetBooksWithPublishYear(publishYear);
        }
        [WebMethod]
        public List<Book> GetBooksWithName(string bookName)
        {
            //calling getbooks with name method
            return objBookLogic_impl.GetBooksWithName(bookName);
        }
        [WebMethod]
        public List<Book> GetBooksWithAuthor(string authorName)
        {
            //calling get book with author
            return objBookLogic_impl.GetBooksWithAuthor(authorName);
        }
        [WebMethod]
        public List<Book> GetBorrowedBooks()
        {
            //calling GetborrowedBooks method
            return objBookLogic_impl.GetBorrowedBooks();
        }
        [WebMethod]
        public bool InsertBooks(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
        {
            //Calling Inserrt Books method
            return objBookLogic_impl.InsertBooks(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);

        }
        [WebMethod]
        public bool InsertBorrowBooks(int UID, string ISBN, string ReturnDate)
        {
            // Calling InsertBorrow Books
            return objBookLogic_impl.InsertBorrowBooks(UID, ISBN, ReturnDate);
        }
        [WebMethod]
        public bool InsertReserveBooks(int UID, string ISBN)
        {
            //calling InsertReserveBook method
            return objBookLogic_impl.InsertReserveBooks(UID, ISBN);

        }
        [WebMethod]
        public List<BookAuthor> GetAuthors()
        {
            // Calling Get Authors method
            return objBookLogic_impl.GetAuthors();
        }
        [WebMethod]
        public List<BookCategory> GetCategories()
        {
            // Calling get Categories method
            return objBookLogic_impl.GetCategories();
        }
        [WebMethod]
        public List<BookLanguage> GetLanguages()
        {
            // Calling get languages method
            return objBookLogic_impl.GetLanguages();
        }
        [WebMethod]
        public bool UpdateBook(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
        {
            // Calling update book method
            return objBookLogic_impl.UpdateBook(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);
        }
        [WebMethod]
        public bool DeleteBook(string ISBN)
        {
            // Calling delete book method
            return objBookLogic_impl.DeleteBook(ISBN);
        }
        //-----------------------------------------------------calling user methods from webservice
    
        [WebMethod]
        public User validateUserLogin(string userName, string password)
            {
            //calling validate user login method
            return objUserlogicImpl.validateUserLogin(userName,password);
            }
        [WebMethod]
        public List<User> GetUsers()
            {
            //calling get user method
            return objUserlogicImpl.GetUsers();
            }
        [WebMethod]
        public bool InsertUser(string username, string pwd, int level, string email)
            {
            // calling Insert user from business logic and use as web service method 
            return objUserlogicImpl.InsertUser(username, pwd,level,email);

        }
        [WebMethod]
        public bool UpdateUser(int uid, string username, string pwd, int level, string email)
        {
            // calling Update user from business logic and use as web service method 
            return objUserlogicImpl.UpdateUser(uid,username,pwd,level,email);

        }
        [WebMethod]
        public bool DeleteUser(int uid)
           {
            // calling Delete user from business logic and use as web service method 
            return objUserlogicImpl.DeleteUser(uid);

        }

    }
}


