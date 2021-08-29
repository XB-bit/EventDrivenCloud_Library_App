namespace Controller
{
    public class BookDTO
    {
        int iStatusCode;
        string message;

        string isbn;
        string name;
        string publisher;
        string author;
        string language;
        int year;
        int pages;

        public string ISBN { get => isbn; set => isbn = value; }
        public string Name { get => name; set => name = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Author { get => author; set => author = value; }
        public int Year { get => year; set => year = value; }
        public int Pages { get => pages; set => pages = value; }
        public string Language { get => language; set => language = value; }
        public int IStatusCode { get => iStatusCode; set => iStatusCode = value; }
        public string Message { get => message; set => message = value; }
    }
}
