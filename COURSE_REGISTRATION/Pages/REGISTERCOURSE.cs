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
    public partial class REGISTERCOURSE : UserControl
    {
        private STUDENT student;
        private string connectionString = "Data Source=WEIWEI;Initial Catalog=COURSEREGISTRATION;Integrated Security=True;Trust Server Certificate=True";
        public REGISTERCOURSE(STUDENT student)
        {
            InitializeComponent();
            this.student = student;
            InitialItemList();
        }

        void InitialItemList()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = $"select* from CLASS CL " +
                           $"JOIN COURSE C ON C.courseID = CL.courseID " +
                           $"where C.major = 'ALL' or C.major = '{student.majorid}' " +
                           $"order by C.courseID asc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem listitem = new ListViewItem();
                listitem.SubItems.Add(reader["courseID"].ToString());
                listitem.SubItems.Add(reader["courseName"].ToString());
                listitem.SubItems.Add(reader["classID"].ToString());
                listitem.SubItems.Add(reader["courseCredit"].ToString());
                listitem.SubItems.Add(reader["courseSize"].ToString());
                listitem.SubItems.Add(reader["Instructor"].ToString());
                listitem.SubItems.Add(DateTime.Parse(reader["startDay"].ToString()).ToString("dd/MM/yyyy"));
                listitem.SubItems.Add(reader["startClass"].ToString());
                listitem.SubItems.Add(Int32.Parse(reader["coursePrice"].ToString()).ToString("N0"));
                listcourseView.Items.Add(listitem);
            }
            reader.Close();

            string query2 = $"select* from CLASS CL " +
                            $"join COURSE C on C.courseID = CL.courseID " +
                            $"join REGISTRATION R on R.classID = CL.classID " +
                            $"join STUDENT S on S.studentID = R.studentID " +
                            $"where S.studentID = '{student.studentid.ToString()}'";

            cmd = new SqlCommand(query2, con);
            SqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                ListViewItem listitem = new ListViewItem();
                listitem.SubItems.Add(reader2["courseID"].ToString());
                listitem.SubItems.Add(reader2["courseName"].ToString());
                listitem.SubItems.Add(reader2["classID"].ToString());
                listitem.SubItems.Add(reader2["courseCredit"].ToString());
                listitem.SubItems.Add(DateTime.Parse(reader2["startDay"].ToString()).ToString("dd/MM/yyyy"));
                listitem.SubItems.Add(reader2["startClass"].ToString());
                listitem.SubItems.Add(reader2["Instructor"].ToString());
                listitem.SubItems.Add("Đã lưu vào CSDL");
                listcourseSelected.Items.Add(listitem);
            }
            reader2.Close();

            con.Close();
        }

        private void listcourseView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (e.Item.Checked)
            {
                foreach (ListViewItem item in listcourseSelected.Items)
                {
                    if (e.Item.SubItems[1].Text == item.SubItems[1].Text)
                    {
                        MessageBox.Show($"Trùng môn rồi");
                        e.Item.Checked = false;
                        return;
                    }

                    if ( e.Item.SubItems[7].Text == item.SubItems[5].Text
                        && e.Item.SubItems[8].Text == item.SubItems[6].Text)
                    {
                        MessageBox.Show($"Trùng ca rồi");
                        e.Item.Checked = false;
                        return;
                    }
                }
            }

            if (e.Item.Checked)
            {
                ListViewItem newitem = new ListViewItem();
                newitem.SubItems.Add(e.Item.SubItems[1]);
                newitem.SubItems.Add(e.Item.SubItems[2]);
                newitem.SubItems.Add(e.Item.SubItems[3]);
                newitem.SubItems.Add(e.Item.SubItems[4]);
                newitem.SubItems.Add(e.Item.SubItems[7]);
                newitem.SubItems.Add(e.Item.SubItems[8]);
                newitem.SubItems.Add(e.Item.SubItems[6]);
                newitem.SubItems.Add("Chưa lưu vào CSDL");
                listcourseSelected.Items.Add(newitem);
            }
            else
            {
                foreach (ListViewItem item in listcourseSelected.Items)
                {
                    if (e.Item.SubItems[1].Text == item.SubItems[1].Text && e.Item.SubItems[8].Text == item.SubItems[6].Text && item.SubItems[8].Text == "Chưa lưu vào CSDL")
                    {
                        listcourseSelected.Items.Remove(item);
                    }
                }
            }
        }



        private void registerSaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string getquery = $"select * from REGISTRATION " +
                              $"where studentID = '{student.studentid.ToString()}'";
            SqlCommand cmd = new SqlCommand(getquery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader["classID"].ToString());
            }
            reader.Close();

            foreach (ListViewItem item in listcourseSelected.CheckedItems)
            {
                if (!list.Contains(item.SubItems[3].Text))
                {
                    string setquery = $"insert into REGISTRATION (classID, studentID, coursepayment) " +
                                      $"values ('{item.SubItems[3].Text}', '{student.studentid.ToString()}', 'N')";
                    SqlCommand cmd2 = new SqlCommand(setquery, con);
                    cmd2.ExecuteNonQuery();
                    item.SubItems[8].Text = "Đã lưu vào CSDL";
                }
            }
            MessageBox.Show("Lưu thành công");

            con.Close();
            foreach (ListViewItem viewItem in listcourseView.Items)
            {
                viewItem.Checked = false;
            }
            foreach (ListViewItem selectedItem in listcourseSelected.Items)
            {
                selectedItem.Checked = false;
            }
        }


        private void registerCancelBtn_Click(object sender, EventArgs e)
        {
            if (listcourseSelected.CheckedItems.Count <= 0) return;
            List<string> list = new List<string>();
            foreach (ListViewItem selectedItem in listcourseSelected.CheckedItems)
            {
                listcourseSelected.Items.Remove(selectedItem);
                foreach (ListViewItem viewItem in listcourseView.Items)
                {
                    if (viewItem.SubItems[1] == selectedItem.SubItems[1])
                    {
                        viewItem.Checked = false;
                    }
                }
                list.Add(selectedItem.SubItems[3].Text);
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if (list.Count > 0)
            {
                foreach (string item in list)
                {
                    string removequery = $"delete from REGISTRATION " +
                                         $"where classID = '{item}' and studentID = '{student.studentid.ToString()}'";
                    SqlCommand cmd2 = new SqlCommand(removequery, con);
                    cmd2.ExecuteNonQuery();
                }
            }
            con.Close();
        }
    }
}
