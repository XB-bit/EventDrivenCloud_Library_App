using Controller;
using Controller.Model_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace assignment1
{
    public partial class BorrowBook : Form
    {
        BookControllerImpl bookController = new BookControllerImpl();
        UserControllerImpl userController = new UserControllerImpl();
        public BorrowBook()
        {
            InitializeComponent();
            PopulateComboBoxData();
            LoadGridView();
        }

        void PopulateComboBoxData()
        {
            List<BookDTO> books = bookController.GetAvailableBooks();
            cbbBooks.DisplayMember = "Name";
            cbbBooks.ValueMember = "ISBN";
            cbbBooks.DataSource = books;

            List<UserDTO> users = userController.GetAllUsers();
            cbbUsers.DisplayMember = "Email";
            cbbUsers.ValueMember = "UID";
            cbbUsers.DataSource = users;
        }

        void LoadGridView()
        {
            dataGridView1.DataSource = bookController.GetBorrowedBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BookDTO selectedBook = (BookDTO)cbbBooks.SelectedItem;
            string isbn = selectedBook.ISBN;

            UserDTO selectedUser = (UserDTO)cbbUsers.SelectedItem;
            int uid = selectedUser.UID;

            string returnDate = dateTimePicker1.Value.ToString();

            bool isSuccessful = bookController.InsertBorrowBooks(uid, isbn, returnDate);

            if (isSuccessful)
            {
                MessageBox.Show("Data added");
            } else
            {
                MessageBox.Show("ERROR");
            }

            LoadGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
