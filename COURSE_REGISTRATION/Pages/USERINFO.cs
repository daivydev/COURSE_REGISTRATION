using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace COURSE_REGISTRATION.Pages
{
    public partial class USERINFO : UserControl
    {
        private string connectionString = "Data Source=WEIWEI;Initial Catalog=COURSEREGISTRATION;Integrated Security=True;Trust Server Certificate=True";
        private ACCOUNT account;
        private STUDENT student;

        public USERINFO(ACCOUNT account)
        {
            InitializeComponent();
            this.account = account;
            setUp();
        }


        public void setUp()
        {
            My_DB my_DB = new My_DB();
            STUDENT student = my_DB.getSTUDENT(account);
            this.student = student;
            setAvatar();
            setName();
            setId();
            setMail();
            setPhone();
            setMajor();
            setDiscount();
        }

        public void setAvatar()
        {
            if (student.avatar.ToString() != "")
            {
                String base64String = student.avatar;
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    avatarBox.Image = System.Drawing.Image.FromStream(ms);
                    avatarBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        public void setName()
        {
            nameLabel.Text = student.studentname.ToString();
        }
        public void setId()
        {
            studentidLabel.Text = student.studentid.ToString();
        }

        public void setMail()
        {
            emailLabel.Text = student.email.ToString();
        }

        public void setPhone()
        {
            phoneLabel.Text = student.phone.ToString();
        }

        public void setMajor()
        {
            majorLabel.Text = student.major.ToString();
        }

        public void setDiscount()
        {
            discountLabel.Text = student.discount.ToString() + "%";
        }

        bool IsValidEmail(string email)
        {
            string regexEmail = @"^[a-zA-Z0-9._%+-]+@(gmail\.com|uef\.edu\.vn)$";
            return Regex.IsMatch(email, regexEmail);
        }

        bool IsValidPhone(string phone)
        {
            string regexPhoneNumber = @"^(84|0)(3[2-9]|5[6|8|9]|7[0|6-9]|8[1-5]|9[0-9])[0-9]{7}$";
            return Regex.IsMatch(phone, regexPhoneNumber);
        }

        private void updateInfoBtn_Click(object sender, EventArgs e)
        {
            HandleUpdateInfo();
            refreshPage();
        }

        private void editEmailInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HandleUpdateInfo();
                refreshPage();
            }
        }

        private void editPhoneInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HandleUpdateInfo();
                refreshPage();
            }
        }

        void refreshPage()
        {
            this.Refresh();
            setUp();
        }

        void HandleUpdateInfo()
        {
            bool checkedMail = false;
            if (editEmailInput.Text != "")
            {
                checkedMail = IsValidEmail(editEmailInput.Text);
                if (checkedMail)
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    string query = $"update STUDENT set studentEmail = '{editEmailInput.Text}' " +
                                   $"where studentID = '{student.studentid.ToString()}' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Email không hợp lệ");
                }
            }

            bool checkedPhone = false;
            if (editPhoneInput.Text != "")
            {
                checkedPhone = IsValidPhone(editPhoneInput.Text);
                if (checkedPhone)
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    string query = $"update STUDENT set studentPhone = '{editPhoneInput.Text}' " +
                                   $"where studentID = '{student.studentid.ToString()}' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("SĐT không hợp lệ");
                }
            }

            if (checkedMail || checkedPhone)
            {
                MessageBox.Show("Cập nhật thành công");
            }

            editEmailInput.Text = "";
            editPhoneInput.Text = "";
        }


    }
}
