using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace COURSE_REGISTRATION.Pages
{
    public partial class TUITITIONFEE : UserControl
    {
        private string connectionString = "Data Source=WEIWEI;Initial Catalog=COURSEREGISTRATION;Integrated Security=True;Trust Server Certificate=True";
        private STUDENT student;
        public TUITITIONFEE(STUDENT student)
        {
            InitializeComponent();
            this.student = student;
            InitialItemList();
        }

        public void InitialItemList()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"select* from CLASS CL " +
                            $"join COURSE C on C.courseID = CL.courseID " +
                            $"join REGISTRATION R on R.classID = CL.classID " +
                            $"join STUDENT S on S.studentID = R.studentID " +
                            $"where S.studentID = '{student.studentid.ToString()}'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            string TotalDiscountCourse = "";
            int courseCredit = 0;
            int totalPriceCourse = 0;
            int totalPayment = 0;
            int totalDebt = 0;

            while (reader.Read())
            {
                ListViewItem listitem = new ListViewItem();
                listitem.Text = (reader["courseID"].ToString());
                listitem.SubItems.Add(reader["courseName"].ToString());
                listitem.SubItems.Add(reader["classID"].ToString());
                listitem.SubItems.Add(reader["courseCredit"].ToString());
                listitem.SubItems.Add(Int32.Parse(reader["coursePrice"].ToString()).ToString("N0"));

                int discount = Int32.Parse(reader["discount"].ToString()) * Int32.Parse(reader["coursePrice"].ToString()) / 100;
                listitem.SubItems.Add(discount.ToString("N0"));

                TotalDiscountCourse = reader["discount"].ToString();

                int coursePrice = Int32.Parse(reader["coursePrice"].ToString()) - discount;
                totalPriceCourse += coursePrice;
                listitem.SubItems.Add(coursePrice.ToString("N0"));
                listcourseFee.Items.Add(listitem);

                courseCredit += Int32.Parse(reader["courseCredit"].ToString());

                if (reader["coursepayment"].ToString() == "Y")
                {
                    totalPayment += Int32.Parse(reader["coursePrice"].ToString()) - discount;
                }
                else
                {
                    totalDebt += Int32.Parse(reader["coursePrice"].ToString()) - discount;
                }
            }
            reader.Close();

            txtCourseCredit.Text = courseCredit.ToString();
            txtTotalPriceCourse.Text = totalPriceCourse.ToString("N0") + " " + "VND";
            txtTotalDiscountCourse.Text = TotalDiscountCourse + "%";
            txtTotalPayment.Text = totalPayment.ToString("N0") + " " + "VND";
            txtTotalDebt.Text = totalDebt.ToString("N0") + " " + "VND";
            con.Close();
        }

        private void refreshpageBtn_Click(object sender, EventArgs e)
        {
            refreshPage();
        }

        public void handlePayment()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"update REGISTRATION set coursepayment = 'Y' " +
                           $"where coursepayment = 'N' and studentID = '{student.studentid.ToString()}' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Đóng thành công");
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            handlePayment();
            refreshPage();
        }

        public void refreshPage()
        {
            this.Refresh();
            listcourseFee.Items.Clear();
            InitialItemList();
        }
    }
}
