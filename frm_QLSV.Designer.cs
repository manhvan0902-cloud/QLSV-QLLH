namespace QLSV
{
    partial class frm_QLSV
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
            this.dsSinhVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.searchhh = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.birthdayyy = new System.Windows.Forms.Label();
            this.classs = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.genderr = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshhh = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSinhVien
            // 
            this.dsSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.hoten,
            this.gioitinh,
            this.ngaysinh,
            this.lop});
            this.dsSinhVien.Location = new System.Drawing.Point(3, 87);
            this.dsSinhVien.Name = "dsSinhVien";
            this.dsSinhVien.RowHeadersWidth = 51;
            this.dsSinhVien.RowTemplate.Height = 24;
            this.dsSinhVien.Size = new System.Drawing.Size(656, 402);
            this.dsSinhVien.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm( Tên/MSSV/Lớp) ";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(6, 31);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(305, 33);
            this.txt_search.TabIndex = 2;
            // 
            // searchhh
            // 
            this.searchhh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchhh.Location = new System.Drawing.Point(342, 31);
            this.searchhh.Name = "searchhh";
            this.searchhh.Size = new System.Drawing.Size(108, 33);
            this.searchhh.TabIndex = 3;
            this.searchhh.Text = "Tìm kiếm";
            this.searchhh.UseVisualStyleBackColor = false;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(44, 88);
            this.fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(39, 16);
            this.fname.TabIndex = 0;
            this.fname.Text = "mssv";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(44, 135);
            this.number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(40, 16);
            this.number.TabIndex = 0;
            this.number.Text = "hoten";
            // 
            // birthdayyy
            // 
            this.birthdayyy.AutoSize = true;
            this.birthdayyy.Location = new System.Drawing.Point(44, 240);
            this.birthdayyy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdayyy.Name = "birthdayyy";
            this.birthdayyy.Size = new System.Drawing.Size(61, 16);
            this.birthdayyy.TabIndex = 0;
            this.birthdayyy.Text = "ngaysinh";
            // 
            // classs
            // 
            this.classs.AutoSize = true;
            this.classs.Location = new System.Drawing.Point(44, 186);
            this.classs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classs.Name = "classs";
            this.classs.Size = new System.Drawing.Size(49, 16);
            this.classs.TabIndex = 0;
            this.classs.Text = "gioitinh";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(116, 88);
            this.txt_fullname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(225, 22);
            this.txt_fullname.TabIndex = 0;
            // 
            // genderr
            // 
            this.genderr.AutoSize = true;
            this.genderr.Location = new System.Drawing.Point(44, 293);
            this.genderr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderr.Name = "genderr";
            this.genderr.Size = new System.Drawing.Size(45, 16);
            this.genderr.TabIndex = 0;
            this.genderr.Text = "malop";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(116, 135);
            this.txt_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(225, 22);
            this.txt_number.TabIndex = 2;
            // 
            // txt_birthday
            // 
            this.txt_birthday.Location = new System.Drawing.Point(116, 240);
            this.txt_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(225, 22);
            this.txt_birthday.TabIndex = 5;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(116, 186);
            this.txt_class.Margin = new System.Windows.Forms.Padding(4);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(225, 22);
            this.txt_class.TabIndex = 4;
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(116, 293);
            this.txt_gender.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(225, 22);
            this.txt_gender.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(41, 374);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(146, 39);
            this.Add.TabIndex = 7;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.OrangeRed;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(41, 421);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(146, 39);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.LimeGreen;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(209, 374);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(146, 39);
            this.Update.TabIndex = 8;
            this.Update.Text = "Sửa";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // refreshhh
            // 
            this.refreshhh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.refreshhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshhh.ForeColor = System.Drawing.Color.Black;
            this.refreshhh.Location = new System.Drawing.Point(209, 420);
            this.refreshhh.Name = "refreshhh";
            this.refreshhh.Size = new System.Drawing.Size(146, 39);
            this.refreshhh.TabIndex = 11;
            this.refreshhh.Text = "Làm mới";
            this.refreshhh.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.refreshhh);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Update);
            this.splitContainer1.Panel1.Controls.Add(this.Delete);
            this.splitContainer1.Panel1.Controls.Add(this.Add);
            this.splitContainer1.Panel1.Controls.Add(this.txt_gender);
            this.splitContainer1.Panel1.Controls.Add(this.txt_class);
            this.splitContainer1.Panel1.Controls.Add(this.txt_birthday);
            this.splitContainer1.Panel1.Controls.Add(this.txt_number);
            this.splitContainer1.Panel1.Controls.Add(this.genderr);
            this.splitContainer1.Panel1.Controls.Add(this.txt_fullname);
            this.splitContainer1.Panel1.Controls.Add(this.classs);
            this.splitContainer1.Panel1.Controls.Add(this.birthdayyy);
            this.splitContainer1.Panel1.Controls.Add(this.number);
            this.splitContainer1.Panel1.Controls.Add(this.fname);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.searchhh);
            this.splitContainer1.Panel2.Controls.Add(this.txt_search);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.dsSinhVien);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // mssv
            // 
            this.mssv.HeaderText = "MSSV";
            this.mssv.MinimumWidth = 6;
            this.mssv.Name = "mssv";
            this.mssv.Width = 75;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Hoten";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Gioitinh";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngaysinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // lop
            // 
            this.lop.HeaderText = "Malop";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // frm_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main";
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVien)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button searchhh;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label birthdayyy;
        private System.Windows.Forms.Label classs;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label genderr;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshhh;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
    }
}