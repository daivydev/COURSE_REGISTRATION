using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COURSE_REGISTRATION
{

    public partial class Home : Form
    {
        NavigationControl navigationControl;
        private STUDENT student;
        private ACCOUNT account;

        public Home(ACCOUNT account)
        {
            InitializeComponent();
            this.account = account;
            getStudent();
            InitializeNavigationControl();
            setUserAvatar();
            txtUsername.Text = student.studentname;
        }

        void getStudent ()
        {
            My_DB my_DB = new My_DB();
            STUDENT student = my_DB.getSTUDENT(account);
            this.student = student;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, userAvatarBox.Width, userAvatarBox.Height);
            Region rg = new Region(path);
            userAvatarBox.Region = rg;
        }

        void setUserAvatar()
        {
            if (student.avatar.ToString() != "")
            {
                String base64String = student.avatar;
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    userAvatarBox.Image = System.Drawing.Image.FromStream(ms);
                    userAvatarBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> users = new List<UserControl>() { new Pages.USERINFO(account), new Pages.REGISTERCOURSE(student), new Pages.TUITITIONFEE(student), new Pages.SERVICES()};

            navigationControl = new NavigationControl(users, panel2);
            navigationControl.Display(0);
        }


        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void accountinfoNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
        }

        private void courseRegisterNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
        }



        private void tuitionfeecourseNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
        }

        private void servicesNav_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
        }
    }
}
