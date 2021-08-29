using Controller;
using Controller.Model_DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace assignment1
{
    public partial class UserManagement : Form
    {
        UserControllerImpl userController = new UserControllerImpl();
        List<UserDTO> allUserList = new List<UserDTO>();
        public UserManagement()
        {
            InitializeComponent();
            LoadGridViewData();
        }

        void LoadGridViewData()
        {
            allUserList = userController.GetAllUsers();
            dataGridView1.DataSource = allUserList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtUsername.Enabled)
            {
                txtUID.Text = "";
                SetEnableControls(true);
                return;
            }

            string username = txtUsername.Text;
            string pwd = txtPassword.Text;
            string email = txtEmail.Text;
            int level = 0;

            try
            {
                level = int.Parse(txtLevel.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid level");
                return;
            }

            bool isSuccesful = userController.AddUser(username, pwd, level, email);

            if (isSuccesful)
            {
                MessageBox.Show("User updated");
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            SetEnableControls(false);
            LoadGridViewData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txtUsername.Enabled)
            {
                SetEnableControls(true);
                return;
            }

            string username = txtUsername.Text;
            string pwd = txtPassword.Text;
            string email = txtEmail.Text;

            int uid;
            int level;

            try
            {
                level = int.Parse(txtLevel.Text);
                uid = int.Parse(txtUID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid value entered");
                return;
            }

            bool isSuccesful = userController.UpdateUser(uid, username, pwd, level, email);

            if (isSuccesful)
            {
                MessageBox.Show("User updated");
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            SetEnableControls(false);
            LoadGridViewData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int uid;

            try
            {
                uid = int.Parse(txtUID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid value entered");
                return;
            }

            bool isSuccesful = userController.DeleteUser(uid);

            if (isSuccesful)
            {
                MessageBox.Show("User deleted");
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            LoadGridViewData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            UserDTO selectedUser = allUserList[index];
            txtUID.Text = selectedUser.UID.ToString();
            txtUsername.Text = selectedUser.Username;
            txtPassword.Text = selectedUser.Password;
            txtEmail.Text = selectedUser.Email;
            txtLevel.Text = selectedUser.UserLevel.ToString();

            SetEnableControls(false);
        }

        void SetEnableControls(bool enabled)
        {
            txtUsername.Enabled = enabled;
            txtPassword.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtLevel.Enabled = enabled;
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
