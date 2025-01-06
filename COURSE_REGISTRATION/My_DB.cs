using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COURSE_REGISTRATION
{

    public class ACCOUNT
    {
        private string Username;
        private string Password;
        private string StudentId;
        private string Role;

        private Boolean Auth;

        public ACCOUNT()
        {
            this.Username = "";
            this.Password = "";
            this.StudentId = "";
            this.Role = "";
        }

        public String username
        {
            get => this.Username;
            set => this.Username = value;
        }

        public String password
        {
            get => this.Password;
            set => this.Password = value;
        }
        public String studentid
        {
            get => this.StudentId;
            set => this.StudentId = value;
        }

        public String role
        {
            get => this.Role;
            set => this.Role = value;
        }

        public Boolean auth
        {
            get => this.Auth;
            set => this.Auth = value;
        }
    }

    public class STUDENT
    {
        private String StudentId;
        private String StudentName;
        private String Email;
        private String Phone;
        private String Major;
        private String Avatar;
        private String MajorId;
        private String Discount;

        public String studentid
        {
            get => this.StudentId;
            set => this.StudentId = value;
        }

        public String studentname
        {
            get => this.StudentName;
            set => this.StudentName = value;
        }

        public String email
        {
            get => this.Email;
            set => this.Email = value;
        }

        public String phone
        {
            get => this.Phone;
            set => this.Phone = value;
        }

        public String major
        {
            get => this.Major;
            set => this.Major = value;
        }
        public String avatar
        {
            get => this.Avatar;
            set => this.Avatar = value;
        }

        public String majorid
        {
            get => this.MajorId;
            set => this.MajorId = value;
        }

        public String discount
        {
            get => this.Discount;
            set => this.Discount = value;
        }

    }



    public class COURSE
    {
        private String CourseId;
        private String CourseName;
        private String Price;
        private String Credit;
        private String Size;
        private String Instructor;
        private String Major;
        private String Class;

        public String courseid
        {
            get => this.CourseId;
            set => this.CourseId = value;
        }

        public String coursename
        {
            get => this.CourseName;
            set => this.CourseName = value;
        }

        public String price
        {
            get => this.Price;
            set => this.Price = value;
        }

        public String credit
        {
            get => this.Credit;
            set => this.Credit = value;
        }

        public String size
        {
            get => this.Size;
            set => this.Size = value;
        }

        public String instructor
        {
            get => this.Instructor;
            set => this.Instructor = value;
        }

        public String courseclass
        {
            get => this.Class;
            set => this.Class = value;

        }

        public String coursemajor
        {
            get => this.Major;
            set => this.Major = value;
        }

    }

    internal class My_DB
    {
        public SqlConnection con = new SqlConnection("Data Source=WEIWEI;Initial Catalog=COURSEREGISTRATION;Integrated Security=True;Trust Server Certificate=True");

        public My_DB()
        {
        }

        public ACCOUNT GetAccount(String username, String password, String studentid, String role, Boolean check)
        {
            ACCOUNT account = new ACCOUNT();
            account.username = username;
            account.password = password;
            account.studentid = studentid;
            account.role = role;
            account.auth = check;
            return account;
        }

        public ACCOUNT auth(String uname, String pass)
        {
            con.Open();
            string query = "select * from ACCOUNT";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            ACCOUNT checkedAccount = new ACCOUNT();
            Boolean check = false;
            while (reader.Read())
            {
                string username = reader["username"].ToString();
                string password = reader["password"].ToString();
                string studentid = reader["studentID"].ToString();
                string role = reader["role"].ToString();
                if (uname == username && pass == password)
                {
                    check = true;
                    checkedAccount = GetAccount(username, password, studentid, role, check);
                }
            }
            reader.Close();
            con.Close();

            if (check)
            {

                MessageBox.Show("Login Sucessfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return checkedAccount;
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public STUDENT getSTUDENT(ACCOUNT account)
        {
            con.Open();
            string query = $"select * from STUDENT " +
                           $"where STUDENT.studentID = {account.studentid}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            STUDENT newstudent = new STUDENT();
            while (reader.Read())
            {
                newstudent.studentid = reader["studentID"].ToString();
                newstudent.studentname = reader["studentName"].ToString();
                newstudent.email = reader["studentEmail"].ToString();
                newstudent.phone = reader["studentPhone"].ToString();
                newstudent.major = reader["major"].ToString();
                newstudent.avatar = reader["avatar"].ToString();
                newstudent.majorid = reader["majorID"].ToString();
                newstudent.discount = reader["discount"].ToString();

            }
            reader.Close();
            con.Close();
            return newstudent;
        }

    }
}
