namespace QLSV
{
    partial class frm_QLLH
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txt_MonHoc = new System.Windows.Forms.TextBox();
            this.txt_SiSo = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.txt_GiangVien = new System.Windows.Forms.TextBox();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.btn_dssv = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.page = new System.Windows.Forms.Label();
            this.btn_qlsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(306, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(351, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(37, 94);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 23);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(136, 89);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(220, 32);
            this.txt_Search.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(383, 89);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(108, 32);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malop,
            this.monhoc,
            this.giangvien,
            this.siso});
            this.dgvLopHoc.Location = new System.Drawing.Point(38, 127);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHoc.Size = new System.Drawing.Size(830, 266);
            this.dgvLopHoc.TabIndex = 4;
            this.dgvLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellContentClick);
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            // 
            // monhoc
            // 
            this.monhoc.DataPropertyName = "monhoc";
            this.monhoc.HeaderText = "Môn học";
            this.monhoc.MinimumWidth = 6;
            this.monhoc.Name = "monhoc";
            // 
            // giangvien
            // 
            this.giangvien.DataPropertyName = "giangvien";
            this.giangvien.HeaderText = "Giảng viên";
            this.giangvien.MinimumWidth = 6;
            this.giangvien.Name = "giangvien";
            // 
            // siso
            // 
            this.siso.DataPropertyName = "siso";
            this.siso.HeaderText = "Sĩ số";
            this.siso.MinimumWidth = 6;
            this.siso.Name = "siso";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(127, 458);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(67, 23);
            this.lblMaLop.TabIndex = 5;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(127, 498);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(82, 23);
            this.lblTenLop.TabIndex = 6;
            this.lblTenLop.Text = "Môn học:";
            // 
            // lblGVCN
            // 
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Location = new System.Drawing.Point(527, 458);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(37, 23);
            this.lblGVCN.TabIndex = 7;
            this.lblGVCN.Text = "GV:";
            // 
            // lblSiSo
            // 
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Location = new System.Drawing.Point(527, 498);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(49, 23);
            this.lblSiSo.TabIndex = 8;
            this.lblSiSo.Text = "Sĩ số:";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(217, 453);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(200, 30);
            this.txt_MaLop.TabIndex = 9;
            // 
            // txt_MonHoc
            // 
            this.txt_MonHoc.Location = new System.Drawing.Point(217, 493);
            this.txt_MonHoc.Name = "txt_MonHoc";
            this.txt_MonHoc.Size = new System.Drawing.Size(200, 30);
            this.txt_MonHoc.TabIndex = 10;
            // 
            // txt_SiSo
            // 
            this.txt_SiSo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SiSo.Location = new System.Drawing.Point(587, 493);
            this.txt_SiSo.Name = "txt_SiSo";
            this.txt_SiSo.ReadOnly = true;
            this.txt_SiSo.Size = new System.Drawing.Size(200, 30);
            this.txt_SiSo.TabIndex = 11;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Them.Location = new System.Drawing.Point(264, 546);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 35);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(371, 546);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 35);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(477, 546);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 35);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(587, 546);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(100, 35);
            this.btn_LamMoi.TabIndex = 16;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // txt_GiangVien
            // 
            this.txt_GiangVien.Location = new System.Drawing.Point(587, 453);
            this.txt_GiangVien.Name = "txt_GiangVien";
            this.txt_GiangVien.Size = new System.Drawing.Size(200, 30);
            this.txt_GiangVien.TabIndex = 11;
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignOut.ForeColor = System.Drawing.Color.Red;
            this.btn_SignOut.Location = new System.Drawing.Point(760, 84);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(108, 33);
            this.btn_SignOut.TabIndex = 17;
            this.btn_SignOut.Text = "Đăng Xuất";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // btn_dssv
            // 
            this.btn_dssv.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_dssv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_dssv.Location = new System.Drawing.Point(477, 587);
            this.btn_dssv.Name = "btn_dssv";
            this.btn_dssv.Size = new System.Drawing.Size(207, 35);
            this.btn_dssv.TabIndex = 20;
            this.btn_dssv.Text = "Danh sách sinh viên";
            this.btn_dssv.UseVisualStyleBackColor = false;
            this.btn_dssv.Click += new System.EventHandler(this.btn_dssv_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_previous.Location = new System.Drawing.Point(36, 397);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(35, 28);
            this.btn_previous.TabIndex = 23;
            this.btn_previous.Text = "<<";
            this.btn_previous.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_next.Location = new System.Drawing.Point(162, 397);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(38, 28);
            this.btn_next.TabIndex = 22;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // page
            // 
            this.page.AutoSize = true;
            this.page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page.Location = new System.Drawing.Point(77, 407);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(79, 18);
            this.page.TabIndex = 21;
            this.page.Text = "Trang 1/1";
            // 
            // btn_qlsv
            // 
            this.btn_qlsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_qlsv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_qlsv.Location = new System.Drawing.Point(264, 587);
            this.btn_qlsv.Name = "btn_qlsv";
            this.btn_qlsv.Size = new System.Drawing.Size(207, 35);
            this.btn_qlsv.TabIndex = 24;
            this.btn_qlsv.Text = "Quản lý sinh viên";
            this.btn_qlsv.UseVisualStyleBackColor = false;
            this.btn_qlsv.Click += new System.EventHandler(this.btn_qlsv_Click);
            // 
            // frm_QLLH
            // 
            this.AcceptButton = this.btn_Search;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(905, 652);
            this.Controls.Add(this.btn_qlsv);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.page);
            this.Controls.Add(this.btn_dssv);
            this.Controls.Add(this.btn_SignOut);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.lblGVCN);
            this.Controls.Add(this.lblSiSo);
            this.Controls.Add(this.txt_MaLop);
            this.Controls.Add(this.txt_MonHoc);
            this.Controls.Add(this.txt_GiangVien);
            this.Controls.Add(this.txt_SiSo);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_LamMoi);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frm_QLLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.frm_QLLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;

        private System.Windows.Forms.DataGridView dgvLopHoc;

        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.Label lblSiSo;

        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.TextBox txt_MonHoc;
        private System.Windows.Forms.TextBox txt_SiSo;

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.TextBox txt_GiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn giangvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Button btn_dssv;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label page;
        private System.Windows.Forms.Button btn_qlsv;
    }
}