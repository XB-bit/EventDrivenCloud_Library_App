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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControllerImpl objUserControlImpl = new UserControllerImpl();
            UserLoginDTO objUserLoginDTO = objUserControlImpl.validateUserLogin(textBox1.Text, textBox2.Text);
            
            
            if (objUserLoginDTO == null)
            {
                MessageBox.Show("Invalid Username or Password");
            }
            else
            {
                //hide login form if goes to new form
                this.Hide();

                if(objUserLoginDTO.UserLevel == 3)
                {
                    AdminUserMainForm objAdminUserMainForm = new AdminUserMainForm();
                    objAdminUserMainForm.ShowDialog();
                }
                else if (objUserLoginDTO.UserLevel == 1)
                {
                    NormalUserMainForm objNormalUserMainForm = new NormalUserMainForm();
                    objNormalUserMainForm.ShowDialog();
                }
                else if (objUserLoginDTO.UserLevel == 2)
                {
                    //send to a suitable page
                    SupUserMainForm objSupMainPage = new SupUserMainForm();
                    objSupMainPage.ShowDialog();
                }

               
            }
   

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click()
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;

            textBox1.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
