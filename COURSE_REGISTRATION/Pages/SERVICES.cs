using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COURSE_REGISTRATION.Pages
{
    public partial class SERVICES : UserControl
    {
        public SERVICES()
        {
            InitializeComponent();
            InitializePage();
        }

        void InitializePage()
        {
            HeaderTitle.Text = "Thông tin liên hệ";
            SubTitle1.Text = "* Liên hệ Đào tạo";
            SubTitle2.Text = "* Liên hệ Tư vấn Tuyển sinh";
            SubTitle3.Text = "* Kênh tiếp nhận ý kiến đóng góp, phản hồi: ";
            content1_1.Text = "Trường Đại học Kinh tế - Tài chính thành phố Hồ Chí Minh (UEF)";
            content1_2.Text = "Địa chỉ: 141 - 145 Điện Biên Phủ, Phường 2, Q. Bình Thạnh, TP.HCM";
            content1_3.Text = "Điện thoại: (028) 5422 6666  * Email: info@uef.edu.vn";
            content1_4.Text = "Giờ làm việc: Thứ Hai - Thứ Sáu, từ 7:30 đến 17:00";
            content2_1.Text = "Hotline: 094 998 1717; 091 648 1080";
            content2_2.Text = "Email: ";
            content2_3.Text = "Facebook: ";
            FacebookLink.Text = "www.facebook.com/uef.edu.vn";
            linkEmail.Text = "www.uef.edu.vn/tuyen-sinh";
            ReportLink.Text = "tại đây";
        }

        private void FacebookLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/uef.edu.vn");
        }

        private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.uef.edu.vn/tuyen-sinh");
        }

        private void ReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.gle/aKiW5aghyXajzGHB8");
        }
    }
}
