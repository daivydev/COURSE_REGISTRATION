namespace COURSE_REGISTRATION
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.txtUsername = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.servicesNav = new System.Windows.Forms.Button();
            this.courseRegisterNav = new System.Windows.Forms.Button();
            this.tuitionfeecourseNav = new System.Windows.Forms.Button();
            this.accountinfoNav = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userAvatarBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(2, 21);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsername.Size = new System.Drawing.Size(168, 26);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "TenTaiKhoan";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(74, 49);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(92, 26);
            this.LogoutBtn.TabIndex = 11;
            this.LogoutBtn.Text = "Đăng xuất";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1122, 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.servicesNav, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.courseRegisterNav, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tuitionfeecourseNav, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.accountinfoNav, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(775, 94);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // servicesNav
            // 
            this.servicesNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesNav.AutoSize = true;
            this.servicesNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicesNav.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.servicesNav.Location = new System.Drawing.Point(583, 24);
            this.servicesNav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servicesNav.Name = "servicesNav";
            this.servicesNav.Size = new System.Drawing.Size(188, 46);
            this.servicesNav.TabIndex = 13;
            this.servicesNav.Text = "LH HỔ TRỢ";
            this.servicesNav.UseVisualStyleBackColor = true;
            this.servicesNav.Click += new System.EventHandler(this.servicesNav_Click);
            // 
            // courseRegisterNav
            // 
            this.courseRegisterNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.courseRegisterNav.AutoSize = true;
            this.courseRegisterNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseRegisterNav.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseRegisterNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.courseRegisterNav.Location = new System.Drawing.Point(4, 24);
            this.courseRegisterNav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseRegisterNav.Name = "courseRegisterNav";
            this.courseRegisterNav.Size = new System.Drawing.Size(185, 46);
            this.courseRegisterNav.TabIndex = 11;
            this.courseRegisterNav.Text = "ĐĂNG KÝ MÔN";
            this.courseRegisterNav.UseVisualStyleBackColor = true;
            this.courseRegisterNav.Click += new System.EventHandler(this.courseRegisterNav_Click);
            // 
            // tuitionfeecourseNav
            // 
            this.tuitionfeecourseNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tuitionfeecourseNav.AutoSize = true;
            this.tuitionfeecourseNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tuitionfeecourseNav.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuitionfeecourseNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.tuitionfeecourseNav.Location = new System.Drawing.Point(197, 24);
            this.tuitionfeecourseNav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tuitionfeecourseNav.Name = "tuitionfeecourseNav";
            this.tuitionfeecourseNav.Size = new System.Drawing.Size(185, 46);
            this.tuitionfeecourseNav.TabIndex = 12;
            this.tuitionfeecourseNav.Text = "XEM HỌC PHÍ";
            this.tuitionfeecourseNav.UseVisualStyleBackColor = true;
            this.tuitionfeecourseNav.Click += new System.EventHandler(this.tuitionfeecourseNav_Click);
            // 
            // accountinfoNav
            // 
            this.accountinfoNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.accountinfoNav.AutoSize = true;
            this.accountinfoNav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountinfoNav.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountinfoNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.accountinfoNav.Location = new System.Drawing.Point(390, 24);
            this.accountinfoNav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountinfoNav.Name = "accountinfoNav";
            this.accountinfoNav.Size = new System.Drawing.Size(185, 46);
            this.accountinfoNav.TabIndex = 9;
            this.accountinfoNav.Text = "TT CÁ NHÂN";
            this.accountinfoNav.UseVisualStyleBackColor = true;
            this.accountinfoNav.Click += new System.EventHandler(this.accountinfoNav_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.userAvatarBox, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(822, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(297, 94);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 88);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 668);
            this.panel2.TabIndex = 4;
            // 
            // userAvatarBox
            // 
            this.userAvatarBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userAvatarBox.BackColor = System.Drawing.Color.Transparent;
            this.userAvatarBox.Image = global::COURSE_REGISTRATION.Properties.Resources.userAvatar;
            this.userAvatarBox.Location = new System.Drawing.Point(205, 15);
            this.userAvatarBox.Margin = new System.Windows.Forms.Padding(0);
            this.userAvatarBox.Name = "userAvatarBox";
            this.userAvatarBox.Size = new System.Drawing.Size(64, 64);
            this.userAvatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAvatarBox.TabIndex = 1;
            this.userAvatarBox.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Home";
            this.Text = "TRANG CHỦ";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatarBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.PictureBox userAvatarBox;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button accountinfoNav;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button courseRegisterNav;
        private System.Windows.Forms.Button tuitionfeecourseNav;
        private System.Windows.Forms.Button servicesNav;
    }
}