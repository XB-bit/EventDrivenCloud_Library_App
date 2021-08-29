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
    public partial class MasterInformationMaintenanceForm : Form
    {
        BookControllerImpl controller = new BookControllerImpl();

        public MasterInformationMaintenanceForm()
        {
            InitializeComponent();
        }

        private void MasterInformationMaintenanceForm_Load(object sender, EventArgs e)
        {
            PopulateComboBoxData();
            LoadGridViewData();
        }

        void LoadGridViewData()
        {
            gvData.DataSource = controller.GetBooks();
        }

        void PopulateComboBoxData()
        {
            List<ComboBoxItem> authors = controller.GetAuthors();
            cbbAuthor.DisplayMember = "Name";
            cbbAuthor.ValueMember = "ID";
            cbbAuthor.DataSource = authors;

            List<ComboBoxItem> categories = controller.GetCategories();
            cbbCat.DisplayMember = "Name";
            cbbCat.ValueMember = "ID";
            cbbCat.DataSource = categories;

            List<ComboBoxItem> languages = controller.GetLanguages();
            cbbLang.DisplayMember = "Name";
            cbbLang.ValueMember = "ID";
            cbbLang.DataSource = languages;
        }

        void ClearForm()
        {
            txtISBN.Clear();
            txtBookName.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //go back to previuos form
            Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtBookName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtISBN.Enabled == false)
            {
                SetEnableControls(true);
                ClearForm();
                return;
            }

            string isbn = txtISBN.Text;
            string name = txtBookName.Text;
            
            ComboBoxItem selectedAuthor = (ComboBoxItem)cbbAuthor.SelectedItem;
            int authorID = selectedAuthor.ID;

            ComboBoxItem selectedCat = (ComboBoxItem)cbbCat.SelectedItem;
            int catID = selectedCat.ID;

            ComboBoxItem selectedLang = (ComboBoxItem)cbbLang.SelectedItem;
            int langID = selectedLang.ID;

            bool isSuccesful = controller.InsertBooks(isbn, name, authorID, catID, langID);

            if (isSuccesful)
            {
                MessageBox.Show("Book added");
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            SetEnableControls(false);
            LoadGridViewData();
        }

        private void gvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            List<BookDTO> list = controller.GetBooks();

            BookDTO selectedBook = list[index];
            txtISBN.Text = selectedBook.ISBN;
            txtBookName.Text = selectedBook.Name;

            SetEnableControls(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            controller.DeleteBook(isbn);

            LoadGridViewData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtISBN.Enabled == false)
            {
                SetEnableControls(true);
                return;
            }

            string isbn = txtISBN.Text;
            string name = txtBookName.Text;

            ComboBoxItem selectedAuthor = (ComboBoxItem)cbbAuthor.SelectedItem;
            int authorID = selectedAuthor.ID;

            ComboBoxItem selectedCat = (ComboBoxItem)cbbCat.SelectedItem;
            int catID = selectedCat.ID;

            ComboBoxItem selectedLang = (ComboBoxItem)cbbLang.SelectedItem;
            int langID = selectedLang.ID;

            bool isSuccesful = controller.UpdateBook(isbn, name, authorID, catID, langID);

            if (isSuccesful)
            {
                MessageBox.Show("Book updated");
            }
            else
            {
                MessageBox.Show("ERROR");
            }


            SetEnableControls(false);
            LoadGridViewData();
        }

        void SetEnableControls(bool enabled)
        {
            txtISBN.Enabled = enabled;
            txtBookName.Enabled = enabled;
            cbbAuthor.Enabled = enabled;
            cbbCat.Enabled = enabled;
            cbbLang.Enabled = enabled;
        }
    }
}
