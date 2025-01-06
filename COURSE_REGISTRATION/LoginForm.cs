using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COURSE_REGISTRATION
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = usernameTXT;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            handleLogin();
        }

        void handleLogin()
        {
            if (usernameTXT.Text != "" && passwordTXT.Text != "")
            {
                My_DB my_DB = new My_DB();
                ACCOUNT checkedAccount = my_DB.auth(usernameTXT.Text, passwordTXT.Text);
                if (checkedAccount != null)
                {
                    if (checkedAccount.auth)
                    {
                        Home homePage = new Home(checkedAccount);
                        this.Hide();
                        homePage.ShowDialog();
                        passwordTXT.Text = "";
                        this.Show();
                        this.ActiveControl = usernameTXT;
                    }
                }
                else
                {
                    this.ActiveControl = passwordTXT;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                passwordTXT.UseSystemPasswordChar = false;

            }
            else
            {
                passwordTXT.UseSystemPasswordChar = true;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void passwordTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                handleLogin();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
