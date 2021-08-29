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
    public partial class ReportsMainForm : Form
    {
        public ReportsMainForm()
        {
            InitializeComponent();
        }

        private void ReportsMainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListAllBorrowedBooksForm objListAllBorrowedBooksForm = new ListAllBorrowedBooksForm();
            objListAllBorrowedBooksForm.ShowDialog();
        }
    }
}
