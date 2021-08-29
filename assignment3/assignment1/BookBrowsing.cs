using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controller;

namespace assignment1
{
    public partial class BookBrowsing : Form
    {
        public BookBrowsing()
        {
            InitializeComponent();
        }

        private void BookBrowsing_Load(object sender, EventArgs e)
        {
            //get the data from book view and list in the data grad view

            loadBookList();
        }

        void loadBookList()
        {
            //get the data from book view and list in the data grad view

            BookControllerImpl objBookControllerImpl = new BookControllerImpl();
            List<BookDTO> listBook = objBookControllerImpl.GetBooks();

            bookViewGrid.DataSource = listBook;
        }

        private void bookViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
