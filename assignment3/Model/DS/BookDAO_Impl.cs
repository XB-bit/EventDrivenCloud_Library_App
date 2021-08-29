using Model.DS;
using Model.DS.BookDataSetTableAdapters;
using Model.Model;
using System;
using System.Collections.Generic;

namespace Model
{
    class BookDAO_Impl : IBookDao
    {
        public List<Book> GetBooks()
        {

            ViewBookTableAdapter objViewBookTableAdapter = new ViewBookTableAdapter();
            BookDataSet.ViewBookDataTable objViewBookDataTable = objViewBookTableAdapter.GetData();

            int dataCount = objViewBookDataTable.Count;
            if (dataCount == 0)
            {
                return null;
            }
            else
            {
                List<Book> list = new List<Book>();

                foreach (var bookRow in objViewBookDataTable)
                {
                    Book book = new Book();
                    book.Isbn = bookRow["ISBN"].ToString();
                    book.Name = bookRow["BookName"].ToString();
                    book.Publisher = bookRow["Publisher"].ToString();
                    book.Author = bookRow["AuthorName"].ToString();
                    book.Language = bookRow["LanguageName"].ToString();
                    book.Year = Convert.ToInt32(bookRow["PublishYear"].ToString());
                    book.Pages = Convert.ToInt32(bookRow["Pages"].ToString());

                    list.Add(book);
                }

                return list;
            }
        }
        public List<Book> GetAvailableBooks()
        {

            ViewBookAvailableTableAdapter objViewBookTableAdapter = new ViewBookAvailableTableAdapter();
            BookDataSet.ViewBookAvailableDataTable objViewBookDataTable = objViewBookTableAdapter.GetData();

            int dataCount = objViewBookDataTable.Count;
            if (dataCount == 0)
            {
                return null;
            }
            else
            {
                List<Book> list = new List<Book>();

                foreach (var bookRow in objViewBookDataTable)
                {
                    Book book = new Book();
                    book.Isbn = bookRow["ISBN"].ToString();
                    book.Name = bookRow["BookName"].ToString();
                    book.Publisher = bookRow["Publisher"].ToString();
                    book.Author = bookRow["AuthorName"].ToString();
                    book.Language = bookRow["LanguageName"].ToString();
                    book.Year = Convert.ToInt32(bookRow["PublishYear"].ToString());
                    book.Pages = Convert.ToInt32(bookRow["Pages"].ToString());

                    list.Add(book);
                }

                return list;
            }
        }
        public List<Book> GetBooksWithPublishYear(int publishYear)
        {

            ViewBookTableAdapter objViewBookTableAdapter = new ViewBookTableAdapter();
            BookDataSet.ViewBookDataTable objViewBookDataTable = objViewBookTableAdapter.GetBooksWithPublishYear(publishYear);

            int dataCount = objViewBookDataTable.Count;
            if (dataCount == 0)
            {
                return null;
            }
            else
            {
                List<Book> list = new List<Book>();

                foreach (var bookRow in objViewBookDataTable)
                {
                    Book book = new Book();
                    book.Isbn = bookRow["ISBN"].ToString();
                    book.Name = bookRow["BookName"].ToString();
                    book.Publisher = bookRow["Publisher"].ToString();
                    book.Author = bookRow["AuthorName"].ToString();
                    book.Language = bookRow["LanguageName"].ToString();
                    book.Year = Convert.ToInt32(bookRow["PublishYear"].ToString());
                    book.Pages = Convert.ToInt32(bookRow["Pages"].ToString());

                    list.Add(book);

                }
                return list;
            }


        }
        public List<Book> GetBooksWithAuthor(string authorName)
        {

            ViewBookTableAdapter objViewBookTableAdapter = new ViewBookTableAdapter();
            BookDataSet.ViewBookDataTable objViewBookDataTable = objViewBookTableAdapter.GetBooksWithAuthor(authorName);

            int dataCount = objViewBookDataTable.Count;
            if (dataCount == 0)
            {
                return null;
            }
            else
            {
                List<Book> list = new List<Book>();

                foreach (var bookRow in objViewBookDataTable)
                {
                    Book book = new Book();
                    book.Isbn = bookRow["ISBN"].ToString();
                    book.Name = bookRow["BookName"].ToString();
                    book.Publisher = bookRow["Publisher"].ToString();
                    book.Author = bookRow["AuthorName"].ToString();
                    book.Language = bookRow["LanguageName"].ToString();
                    book.Year = Convert.ToInt32(bookRow["PublishYear"].ToString());
                    book.Pages = Convert.ToInt32(bookRow["Pages"].ToString());

                    list.Add(book);
                }

                return list;
            }
        }

        public List<Book> GetBooksWithName(string bookName)
        {

            ViewBookTableAdapter objViewBookTableAdapter = new ViewBookTableAdapter();
            BookDataSet.ViewBookDataTable objViewBookDataTable = objViewBookTableAdapter.GetBooksWithName(bookName);

            int dataCount = objViewBookDataTable.Count;
            if (dataCount == 0)
            {
                return null;
            }
            else
            {
                List<Book> list = new List<Book>();

                foreach (var bookRow in objViewBookDataTable)
                {
                    Book book = new Book();
                    book.Isbn = bookRow["ISBN"].ToString();
                    book.Name = bookRow["BookName"].ToString();
                    book.Publisher = bookRow["Publisher"].ToString();
                    book.Author = bookRow["AuthorName"].ToString();
                    book.Language = bookRow["LanguageName"].ToString();
                    book.Year = Convert.ToInt32(bookRow["PublishYear"].ToString());
                    book.Pages = Convert.ToInt32(bookRow["Pages"].ToString());

                    list.Add(book);
                }

                return list;
            }
        }

        public bool InsertBooks(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
        {

            TabBookTableAdapter objTabBookTableAdapter = new TabBookTableAdapter();

            try
            {
                objTabBookTableAdapter.InsertQuery(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public List<BookAuthor> GetAuthors()
        {
            TabAuthorTableAdapter adapter = new TabAuthorTableAdapter();
            BookDataSet.TabAuthorDataTable dataTable = adapter.GetData();

            List<BookAuthor> list = new List<BookAuthor>();

            foreach (var row in dataTable)
            {
                BookAuthor author = new BookAuthor();
                author.ID = (int)row["AID"];
                author.Name = row["AuthorName"].ToString();

                list.Add(author);
            }

            return list;
        }

        public List<BookCategory> GetCategories()
        {
            TabCategoryTableAdapter adapter = new TabCategoryTableAdapter();
            BookDataSet.TabCategoryDataTable dataTable = adapter.GetData();

            List<BookCategory> list = new List<BookCategory>();

            foreach (var row in dataTable)
            {
                BookCategory cat = new BookCategory();
                cat.ID = (int)row["CID"];
                cat.Name = row["CategoryName"].ToString();

                list.Add(cat);
            }

            return list;
        }

        public List<BookLanguage> GetLanguages()
        {
            TabLanguageTableAdapter adapter = new TabLanguageTableAdapter();
            BookDataSet.TabLanguageDataTable dataTable = adapter.GetData();

            List<BookLanguage> list = new List<BookLanguage>();

            foreach (var row in dataTable)
            {
                BookLanguage lang = new BookLanguage();
                lang.ID = (int)row["LID"];
                lang.Name = row["LanguageName"].ToString();

                list.Add(lang);
            }

            return list;
        }

        public bool UpdateBook(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher)
        {
            TabBookTableAdapter objTabBookTableAdapter = new TabBookTableAdapter();

            try
            {
                objTabBookTableAdapter.UpdateQuery(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool DeleteBook(string ISBN)
        {
            TabBookTableAdapter objTabBookTableAdapter = new TabBookTableAdapter();

            try
            {
                objTabBookTableAdapter.DeleteQuery(ISBN);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool InsertBorrowBooks(int UID, string ISBN, string BorrowDate, string ReturnDate, decimal LateFee)
        {

            TabBorrowTableAdapter objTabBookTableAdapter = new TabBorrowTableAdapter();
            try
            {
                objTabBookTableAdapter.InsertQuery(UID, ISBN, BorrowDate, ReturnDate, LateFee);
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public bool InsertReserveBooks(int UID, string ISBN, string reserveDate)
        {

            TabReservedTableAdapter objTabBookTableAdapter = new TabReservedTableAdapter();
            try
            {
                objTabBookTableAdapter.InsertQuery(UID, ISBN, reserveDate);
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public List<Book> GetBorrowedBooks()
        {
            ViewBookBorrowedTableAdapter objViewBookTableAdapter = new ViewBookBorrowedTableAdapter();
            BookDataSet.ViewBookBorrowedDataTable objViewBookDataTable = objViewBookTableAdapter.GetData();

            int dataCount = objViewBookDataTable.Count;
            if (dataCount == 0)
            {
                return null;
            }
            else
            {
                List<Book> list = new List<Book>();

                foreach (var bookRow in objViewBookDataTable)
                {
                    Book book = new Book();
                    book.Isbn = bookRow["ISBN"].ToString();
                    book.Name = bookRow["BookName"].ToString();
                    book.Publisher = bookRow["Publisher"].ToString();
                    book.Author = bookRow["AuthorName"].ToString();
                    book.Language = bookRow["LanguageName"].ToString();
                    book.Year = Convert.ToInt32(bookRow["PublishYear"].ToString());
                    book.Pages = Convert.ToInt32(bookRow["Pages"].ToString());

                    list.Add(book);
                }

                return list;
            }
        }
    }
}
