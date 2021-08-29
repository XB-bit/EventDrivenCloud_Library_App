using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace assignment1
{
    public partial class BookSearching : Form
    {
        public BookSearching()
        {
            InitializeComponent();
        }

        private void BookSearching_Load(object sender, EventArgs e)
        {
        }
        void loadBookList()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookName = textBox1.Text;

            BookControllerImpl objBookControllerImpl = new BookControllerImpl();
            List<BookDTO> listBook = objBookControllerImpl.GetBooksWithName(bookName);

            if (listBook == null || listBook.Count == 0)
            {
                loadBookList();
                MessageBox.Show("No books found");
            }
            else
            {
                bookViewGrid.DataSource = listBook;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string authorName = textBox2.Text;

            BookControllerImpl objBookControllerImpl = new BookControllerImpl();
            List<BookDTO> listBook = objBookControllerImpl.GetBooksWithAuthor(authorName);

            if (listBook == null || listBook.Count == 0)
            {
                loadBookList();
                MessageBox.Show("No books found");
            }
            else
            {
                bookViewGrid.DataSource = listBook;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int publishYear = Convert.ToInt32(textBox3.Text);
            textBox3.Text = publishYear.ToString();


            BookControllerImpl objBookControllerImpl = new BookControllerImpl();
            List<BookDTO> listBook = objBookControllerImpl.GetBooksWithPublishYear(publishYear);

            if (listBook == null || listBook.Count == 0)
            {
                loadBookList();
                MessageBox.Show("No books found");
            }
            else
            {
                bookViewGrid.DataSource = listBook;
            }


        }

        private void bookViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

