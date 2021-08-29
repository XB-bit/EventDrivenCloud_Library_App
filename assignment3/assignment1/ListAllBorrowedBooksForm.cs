using Controller;
using System;
using System.Windows.Forms;

namespace assignment1
{
    public partial class ListAllBorrowedBooksForm : Form
    {
        public ListAllBorrowedBooksForm()
        {
            InitializeComponent();
        }

        private void ListAllBorrowedBooksForm_Load(object sender, EventArgs e)
        {

            BookControllerImpl controller = new BookControllerImpl();
            dataGridView1.DataSource = controller.GetBorrowedBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
