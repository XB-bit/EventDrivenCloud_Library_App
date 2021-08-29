using System;
using System.Collections.Generic;
using Controller.Model_DTO;
using Controller.LibraryServiceReference;

namespace Controller
{
    public class BookControllerImpl : IBookContoller
    {
        LibraryWebServiceSoapClient objLibraryWebServiceSoapClient = new LibraryWebServiceSoapClient();

        public List<BookDTO> GetBooks()
        {
            Book[] bookList = objLibraryWebServiceSoapClient.GetBooks();


            if (bookList == null)
            {
                return null;
            }
            else
            {
                // Show book list
                List<BookDTO> list = new List<BookDTO>();

                foreach (var book in bookList)
                {
                    BookDTO bookDTO = new BookDTO();
                    bookDTO.ISBN = book.Isbn;
                    bookDTO.Name = book.Name;
                    bookDTO.Publisher = book.Publisher;
                    bookDTO.Author = book.Author;
                    bookDTO.Language = book.Language;
                    bookDTO.Year = book.Year;
                    bookDTO.Pages = book.Pages;

                    list.Add(bookDTO);
                }

                return list;
            }
        }
        public List<BookDTO> GetAvailableBooks()
        {
            Book[] bookList = objLibraryWebServiceSoapClient.GetAvailableBooks();


            if (bookList == null)
            {
                // Show empty
                return null;
            }
            else
            {
                // Show book list
                List<BookDTO> list = new List<BookDTO>();

                foreach (var book in bookList)
                {
                    BookDTO bookDTO = new BookDTO();
                    bookDTO.ISBN = book.Isbn;
                    bookDTO.Name = book.Name;
                    bookDTO.Publisher = book.Publisher;
                    bookDTO.Author = book.Author;
                    bookDTO.Language = book.Language;
                    bookDTO.Year = book.Year;
                    bookDTO.Pages = book.Pages;

                    list.Add(bookDTO);
                }

                return list;
            }

        }
        public List<BookDTO> GetBooksWithAuthor(string authorName)
        {
            Book[] bookList = objLibraryWebServiceSoapClient.GetBooksWithAuthor(authorName);


            if (bookList == null)
            {
                // Show empty
                return null;
            }
            else
            {
                // Show book list
                List<BookDTO> list = new List<BookDTO>();

                foreach (var book in bookList)
                {
                    BookDTO bookDTO = new BookDTO();
                    bookDTO.Name = book.Name;
                    bookDTO.Publisher = book.Publisher;
                    bookDTO.Author = book.Author;
                    bookDTO.Language = book.Language;
                    bookDTO.Year = book.Year;
                    bookDTO.Pages = book.Pages;

                    list.Add(bookDTO);
                }

                return list;
            }

        }

        public List<BookDTO> GetBooksWithName(string bookName)
        {
            Book[] bookList = objLibraryWebServiceSoapClient.GetBooksWithName(bookName);


            if (bookList == null)
            {
                // Show empty
                return null;
            }
            else
            {
                // Show book list
                List<BookDTO> list = new List<BookDTO>();

                foreach (var book in bookList)
                {
                    BookDTO bookDTO = new BookDTO();
                    bookDTO.Name = book.Name;
                    bookDTO.Publisher = book.Publisher;
                    bookDTO.Author = book.Author;
                    bookDTO.Language = book.Language;
                    bookDTO.Year = book.Year;
                    bookDTO.Pages = book.Pages;

                    list.Add(bookDTO);
                }

                return list;
            }

        }
        public List<BookDTO> GetBooksWithPublishYear(int publishYear)
        {

            Book[] bookList = objLibraryWebServiceSoapClient.GetBooksWithPublishYear(publishYear);


            if (bookList == null)
            {
                // Show empty
                return null;
            }
            else
            {
                // Show book list
                List<BookDTO> list = new List<BookDTO>();

                foreach (var book in bookList)
                {
                    BookDTO bookDTO = new BookDTO();
                    bookDTO.Name = book.Name;
                    bookDTO.Publisher = book.Publisher;
                    bookDTO.Author = book.Author;
                    bookDTO.Language = book.Language;
                    bookDTO.Year = book.Year;
                    bookDTO.Pages = book.Pages;

                    list.Add(bookDTO);
                }

                return list;
            }

        }

        public List<BookDTO> GetBorrowedBooks()
        {

            Book[] bookList = objLibraryWebServiceSoapClient.GetBorrowedBooks();


            List<BookDTO> list = new List<BookDTO>();

            foreach (var book in bookList)
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.ISBN = book.Isbn;
                bookDTO.Name = book.Name;
                bookDTO.Publisher = book.Publisher;
                bookDTO.Author = book.Author;
                bookDTO.Language = book.Language;
                bookDTO.Year = book.Year;
                bookDTO.Pages = book.Pages;

                list.Add(bookDTO);
            }

            return list;

        }

        public List<ComboBoxItem> GetAuthors()
        {

            BookAuthor[] list = objLibraryWebServiceSoapClient.GetAuthors();

            List<ComboBoxItem> cbbList = new List<ComboBoxItem>();

            foreach (BookAuthor author in list)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.ID = author.ID;
                item.Name = author.Name;

                cbbList.Add(item);
            }

            return cbbList;
        }

        public List<ComboBoxItem> GetCategories()
        {

            BookCategory[] list = objLibraryWebServiceSoapClient.GetCategories();

            List<ComboBoxItem> cbbList = new List<ComboBoxItem>();

            foreach (BookCategory cat in list)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.ID = cat.ID;
                item.Name = cat.Name;

                cbbList.Add(item);
            }

            return cbbList;
        }

        public List<ComboBoxItem> GetLanguages()
        {

            BookLanguage[] list = objLibraryWebServiceSoapClient.GetLanguages();

            List<ComboBoxItem> cbbList = new List<ComboBoxItem>();

            foreach (BookLanguage lang in list)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.ID = lang.ID;
                item.Name = lang.Name;

                cbbList.Add(item);
            }

            return cbbList;
        }

        public bool InsertBooks(string ISBN, string BookName, int Author, int Category, int Language,
            int PublishYear = 2020, int Pages = 0, string Publisher = "Unknown")
        {

            bool isSuccessful = objLibraryWebServiceSoapClient.InsertBooks(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);

            return isSuccessful;
        }


        public bool UpdateBook(string ISBN, string BookName, int Author, int Category, int Language,
            int PublishYear = 2020, int Pages = 0, string Publisher = "Unknown")
        {

            bool isSuccessful = objLibraryWebServiceSoapClient.UpdateBook(ISBN, BookName, Author, Category, Language, PublishYear, Pages, Publisher);

            return isSuccessful;
        }

        public bool DeleteBook(string ISBN)
        {

            bool isSuccessful = objLibraryWebServiceSoapClient.DeleteBook(ISBN);

            return isSuccessful;
        }

        public bool InsertBorrowBooks(int UID, string ISBN, string ReturnDate)
        {

            bool isSuccessful = objLibraryWebServiceSoapClient.InsertBorrowBooks(UID, ISBN, ReturnDate);

            return isSuccessful;
        }

        public bool InsertReserveBooks(int UID, string ISBN)
        {

            bool isSuccessful = objLibraryWebServiceSoapClient.InsertReserveBooks(UID, ISBN);

            return isSuccessful;
        }
    }

}
