using Model.DS.BookDataSetTableAdapters;
using System;
using Model.Model;
using System.Collections.Generic;

namespace Model
{
    public class BookLogic_impl : IBookLogic
    {
        public List<Book> GetBooks()
        {
            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
            List<Book> list = objBookDAO_Impl.GetBooks();

            if (list == null)
            {
                return null;
            }
            else
            {
                return list;
            }
        }
        public List<Book> GetAvailableBooks()
        {
            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
            List<Book> list = objBookDAO_Impl.GetAvailableBooks();

            if (list == null)
            {
                return null;
            }
            else
            {
                return list;
            }
        }

        public List<Book> GetBooksWithAuthor(string authorName)
        {

            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
            List<Book> list = objBookDAO_Impl.GetBooksWithAuthor(authorName);

            if (list == null)
            {
                return null;
            }
            else
            {
                return list;
            }
        }
        public List<Book> GetBooksWithPublishYear(int publishYear)
        {
            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
            List<Book> list = objBookDAO_Impl.GetBooksWithPublishYear(publishYear);

            if (list == null)
            {
                return null;
            }
            else
            {
                return list;
            }
        }
        public List<Book> GetBooksWithName(string bookName)
        {
            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
            List<Book> list = objBookDAO_Impl.GetBooksWithName(bookName);

            if (list == null)
            {
                return null;
            }
            else
            {
                return list;
            }
        }

        public List<Book> GetBorrowedBooks()
        {
            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
            List<Book> list = objBookDAO_Impl.GetBorrowedBooks();

            if (list == null)
            {
                return null;
            }
            else
            {
                return list;
            }
        }

        public bool InsertBooks(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
        {

            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
            bool isSuccessful = objBookDAO_Impl.InsertBooks(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);

            return isSuccessful;

        }

        public bool InsertBorrowBooks(int UID, string ISBN, string ReturnDate)
        {
            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();

            string BorrowDate = DateTime.Now.ToString();
            decimal LateFee = 10;

            bool isSuccessful = objBookDAO_Impl.InsertBorrowBooks(UID, ISBN, BorrowDate, ReturnDate, LateFee);

            return isSuccessful;

        }

        public bool InsertReserveBooks(int UID, string ISBN)
        {
            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();

            string reserveDate = DateTime.Now.ToString();
            bool isSuccessful = objBookDAO_Impl.InsertReserveBooks(UID, ISBN, reserveDate);

            return isSuccessful;

        }

        public List<BookAuthor> GetAuthors()
        {
            BookDAO_Impl dao = new BookDAO_Impl();
            List<BookAuthor> list = dao.GetAuthors();
            return list;
        }

        public List<BookCategory> GetCategories()
        {
            BookDAO_Impl dao = new BookDAO_Impl();
            List<BookCategory> list = dao.GetCategories();
            return list;
        }

        public List<BookLanguage> GetLanguages()
        {
            BookDAO_Impl dao = new BookDAO_Impl();
            List<BookLanguage> list = dao.GetLanguages();
            return list;
        }

        public bool UpdateBook(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
        {
            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
            bool isSuccessful = objBookDAO_Impl.UpdateBook(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);

            return isSuccessful;
        }

        public bool DeleteBook(string ISBN)
        {
            BookDAO_Impl objBookDAO_Impl = new BookDAO_Impl();
            bool isSuccessful = objBookDAO_Impl.DeleteBook(ISBN);

            return isSuccessful;
        }
    }
}
