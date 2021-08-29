using Model.Model;
using System.Collections.Generic;

namespace Model
{
    interface IBookDao

    {

        List<Book> GetBooks();
        List<Book> GetBooksWithName(string bookName);
        List<Book> GetBooksWithAuthor(string authorName);
        List<Book> GetBooksWithPublishYear(int publisherYear);


        List<Book> GetBorrowedBooks();


        List<BookAuthor> GetAuthors();
        List<BookCategory> GetCategories();
        List<BookLanguage> GetLanguages();

        bool InsertBooks(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher);
        bool UpdateBook(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher);
        bool DeleteBook(string ISBN);

    }
}
