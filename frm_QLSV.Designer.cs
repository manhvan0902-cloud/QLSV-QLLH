namespace QLSV
{
    partial class frm_QLSV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dsSinhVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_class = new System.Windows.Forms.ComboBox();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.classs = new System.Windows.Forms.Label();
            this.genderr = new System.Windows.Forms.Label();
            this.birthdayyy = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.refreshhh = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.searchhh = new System.Windows.Forms.Button();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_qllh = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.page = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSinhVien
            // 
            this.dsSinhVien.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dsSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dsSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.hoten,
            this.gioitinh,
            this.ngaysinh,
            this.malop});
            this.dsSinhVien.Location = new System.Drawing.Point(388, 126);
            this.dsSinhVien.Name = "dsSinhVien";
            this.dsSinhVien.RowHeadersWidth = 51;
            this.dsSinhVien.Size = new System.Drawing.Size(600, 380);
            this.dsSinhVien.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.groupBox1.Controls.Add(this.txt_class);
            this.groupBox1.Controls.Add(this.dtp_birthday);
            this.groupBox1.Controls.Add(this.txt_gender);
            this.groupBox1.Controls.Add(this.txt_fullname);
            this.groupBox1.Controls.Add(this.txt_number);
            this.groupBox1.Controls.Add(this.classs);
            this.groupBox1.Controls.Add(this.genderr);
            this.groupBox1.Controls.Add(this.birthdayyy);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_class.Location = new System.Drawing.Point(98, 266);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(236, 31);
            this.txt_class.TabIndex = 0;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtp_birthday.Location = new System.Drawing.Point(98, 158);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(236, 30);
            this.dtp_birthday.TabIndex = 1;
            // 
            // txt_gender
            // 
            this.txt_gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_gender.Location = new System.Drawing.Point(98, 209);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(236, 30);
            this.txt_gender.TabIndex = 2;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_fullname.Location = new System.Drawing.Point(98, 104);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(236, 30);
            this.txt_fullname.TabIndex = 3;
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_number.Location = new System.Drawing.Point(98, 53);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(236, 30);
            this.txt_number.TabIndex = 4;
            // 
            // classs
            // 
            this.classs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.classs.Location = new System.Drawing.Point(5, 269);
            this.classs.Name = "classs";
            this.classs.Size = new System.Drawing.Size(100, 23);
            this.classs.TabIndex = 5;
            this.classs.Text = "Lớp học:";
            // 
            // genderr
            // 
            this.genderr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderr.Location = new System.Drawing.Point(5, 212);
            this.genderr.Name = "genderr";
            this.genderr.Size = new System.Drawing.Size(100, 23);
            this.genderr.TabIndex = 6;
            this.genderr.Text = "Giới tính:";
            // 
            // birthdayyy
            // 
            this.birthdayyy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.birthdayyy.Location = new System.Drawing.Point(5, 161);
            this.birthdayyy.Name = "birthdayyy";
            this.birthdayyy.Size = new System.Drawing.Size(100, 23);
            this.birthdayyy.TabIndex = 7;
            this.birthdayyy.Text = "Ngày sinh:";
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fname.Location = new System.Drawing.Point(5, 107);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 23);
            this.fname.TabIndex = 8;
            this.fname.Text = "Họ và tên:";
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.number.Location = new System.Drawing.Point(5, 56);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(73, 23);
            this.number.TabIndex = 9;
            this.number.Text = "Mã SV:";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Location = new System.Drawing.Point(76, 435);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(110, 40);
            this.Add.TabIndex = 2;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Location = new System.Drawing.Point(196, 435);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(110, 40);
            this.Update.TabIndex = 3;
            this.Update.Text = "Sửa";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(76, 485);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 40);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // refreshhh
            // 
            this.refreshhh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.refreshhh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshhh.ForeColor = System.Drawing.Color.Black;
            this.refreshhh.Location = new System.Drawing.Point(196, 485);
            this.refreshhh.Name = "refreshhh";
            this.refreshhh.Size = new System.Drawing.Size(110, 40);
            this.refreshhh.TabIndex = 5;
            this.refreshhh.Text = "Làm mới";
            this.refreshhh.UseVisualStyleBackColor = false;
            this.refreshhh.Click += new System.EventHandler(this.refreshhh_Click_1);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(478, 92);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(377, 29);
            this.txt_search.TabIndex = 7;
            // 
            // searchhh
            // 
            this.searchhh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchhh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchhh.Location = new System.Drawing.Point(861, 92);
            this.searchhh.Name = "searchhh";
            this.searchhh.Size = new System.Drawing.Size(127, 29);
            this.searchhh.TabIndex = 8;
            this.searchhh.Text = "Tìm nhanh";
            this.searchhh.UseVisualStyleBackColor = false;
            this.searchhh.Click += new System.EventHandler(this.searchhh_Click_1);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignOut.ForeColor = System.Drawing.Color.Red;
            this.btn_SignOut.Location = new System.Drawing.Point(877, 538);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(111, 35);
            this.btn_SignOut.TabIndex = 11;
            this.btn_SignOut.Text = "Đăng xuất";
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm:";
            // 
            // btn_qllh
            // 
            this.btn_qllh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_qllh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qllh.ForeColor = System.Drawing.Color.Black;
            this.btn_qllh.Location = new System.Drawing.Point(76, 531);
            this.btn_qllh.Name = "btn_qllh";
            this.btn_qllh.Size = new System.Drawing.Size(230, 40);
            this.btn_qllh.TabIndex = 12;
            this.btn_qllh.Text = "Quản lý lớp học";
            this.btn_qllh.UseVisualStyleBackColor = false;
            this.btn_qllh.Click += new System.EventHandler(this.btn_qllh_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_previous.Location = new System.Drawing.Point(387, 510);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(35, 28);
            this.btn_previous.TabIndex = 26;
            this.btn_previous.Text = "<<";
            this.btn_previous.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_next.Location = new System.Drawing.Point(513, 510);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(38, 28);
            this.btn_next.TabIndex = 25;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // page
            // 
            this.page.AutoSize = true;
            this.page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page.Location = new System.Drawing.Point(428, 520);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(79, 18);
            this.page.TabIndex = 24;
            this.page.Text = "Trang 1/1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(350, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "MSSV";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 125;
            // 
            // frm_QLSV
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.page);
            this.Controls.Add(this.btn_qllh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.refreshhh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.searchhh);
            this.Controls.Add(this.dsSinhVien);
            this.Controls.Add(this.btn_SignOut);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_QLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Sinh viên";
            this.Load += new System.EventHandler(this.frm_QLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsSinhVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txt_class;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label classs;
        private System.Windows.Forms.Label genderr;
        private System.Windows.Forms.Label birthdayyy;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button refreshhh;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button searchhh;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_qllh;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
    }
}