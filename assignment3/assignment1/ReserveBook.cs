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
    public partial class ReserveBook : Form
    {
        BookControllerImpl bookController = new BookControllerImpl();
        UserControllerImpl userController = new UserControllerImpl();
        public ReserveBook()
        {
            InitializeComponent();
            PopulateComboBoxData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            BookDTO selectedBook = (BookDTO)cbbBooks.SelectedItem;
            string isbn = selectedBook.ISBN;

            UserDTO selectedUser = (UserDTO)cbbUsers.SelectedItem;
            int uid = selectedUser.UID;

            bool isSuccessful = bookController.InsertReserveBooks(uid, isbn);

            if (isSuccessful)
            {
                MessageBox.Show("Data added");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
