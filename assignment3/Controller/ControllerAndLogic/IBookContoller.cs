using Controller.Model_DTO;
using System.Collections.Generic;

namespace Controller
{
    public interface IBookContoller
    {

        List<BookDTO> GetBooksWithName(string bookName);
        List<BookDTO> GetBooksWithAuthor(string authorName);

        bool InsertBooks(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher);
        bool UpdateBook(string ISBN, string BookName, int Author, int Category, int Language, int PublishYear, int Pages, string Publisher);
        bool DeleteBook(string ISBN);


        List<BookDTO> GetBooks();
        List<ComboBoxItem> GetAuthors();
        List<ComboBoxItem> GetCategories();
        List<ComboBoxItem> GetLanguages();
    }
}
