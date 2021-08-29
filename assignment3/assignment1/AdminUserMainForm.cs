using System;
using System.Windows.Forms;

namespace assignment1
{
    public partial class AdminUserMainForm : Form
    {

        

        public AdminUserMainForm()
        {
            InitializeComponent();

            ActiveControl = button3;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            BookSearching objBookSearchingPage = new BookSearching();
            objBookSearchingPage.ShowDialog();
        }

        private void AdminUserMainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookBrowsing objBookBrowsingPage = new BookBrowsing();
            objBookBrowsingPage.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportsMainForm objReportsMainForm = new ReportsMainForm();
            objReportsMainForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MasterInformationMaintenanceForm objMasterInformationMaintenanceForm = new MasterInformationMaintenanceForm();
                objMasterInformationMaintenanceForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BorrowBook form = new BorrowBook();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReserveBook form = new ReserveBook();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserManagement form = new UserManagement();
            form.ShowDialog();
        }
    }
}
