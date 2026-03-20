using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_QLSV : Form
    {

        DataClasses1DataContext db = new DataClasses1DataContext();

        public frm_QLSV()
        {
            InitializeComponent();
        }

        //Load form
        private void frm_QLSV_Load(object sender, EventArgs e)
        {
            dsSinhVien.AutoGenerateColumns = false;
            LoadData();
            LoadComboBoxClass();

            Add.Click += Add_Click_1;
            Update.Click += Update_Click_1;
            Delete.Click += Delete_Click_1;
            searchhh.Click += searchhh_Click;
            refreshhh.Click += refreshhh_Click;
            dsSinhVien.CellClick += dsSinhVien_CellClick;
        }

        //Load dữ liệu lên DataGridView
        void LoadData()
        {
            var ds = from sv in db.tbl_sinhviens
                     select new
                     {
                         sv.id,
                         sv.hoten,
                         sv.gioitinh,
                         sv.ngaysinh,
                         sv.malop
                     };
            dsSinhVien.DataSource = ds.ToList();
        }

        //Clear form
        void ClearForm()
        {
            txt_fullname.Clear();
            txt_number.Clear();
            txt_class.SelectedIndex = -1;
            txt_gender.Clear();
            dtp_birthday.Value = DateTime.Now;
        }

        //Click DataGridView
        private void dsSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dsSinhVien.Rows[e.RowIndex];

                txt_number.Text = row.Cells["id"].Value?.ToString();
                txt_fullname.Text = row.Cells["hoten"].Value?.ToString();
                txt_gender.Text = row.Cells["gioitinh"].Value?.ToString();
                txt_class.Text = row.Cells["malop"].Value?.ToString();
                dtp_birthday.Text = row.Cells["ngaysinh"].Value?.ToString();
            }
        }

        //Thêm sinh viên
        private void Add_Click_1(object sender, EventArgs e)
        {
            try
            {
                tbl_sinhvien sv = new tbl_sinhvien();

                sv.id = txt_number.Text;
                sv.hoten = txt_fullname.Text;
                sv.gioitinh = txt_gender.Text;
                sv.malop = txt_class.SelectedValue?.ToString();
                sv.ngaysinh = DateTime.Parse(dtp_birthday.Text);

                db.tbl_sinhviens.InsertOnSubmit(sv);
                db.SubmitChanges();

                LoadData();
                ClearForm();

                MessageBox.Show("Thêm sinh viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sửa sinh viên
        private void Update_Click_1(object sender, EventArgs e)
        {
            try
            {
                var sv = db.tbl_sinhviens.FirstOrDefault(x => x.id == txt_number.Text);

                if (sv != null)
                {
                    sv.hoten = txt_fullname.Text;
                    sv.gioitinh = txt_gender.Text;
                    sv.malop = txt_class.SelectedValue?.ToString();
                    sv.ngaysinh = DateTime.Parse(dtp_birthday.Text);

                    db.SubmitChanges();

                    LoadData();
                    ClearForm();

                    MessageBox.Show("Cập nhật thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Xóa sinh viên
        private void Delete_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                var sv = db.tbl_sinhviens.FirstOrDefault(x => x.id == txt_number.Text);

                if (sv != null)
                {
                    db.tbl_sinhviens.DeleteOnSubmit(sv);
                    db.SubmitChanges();

                    LoadData();
                    ClearForm();

                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tìm kiếm
        private void searchhh_Click(object sender, EventArgs e)
        {
            string key = txt_search.Text;

            var ds = db.tbl_sinhviens.Where(sv =>

                sv.id.Contains(key) ||
                sv.hoten.Contains(key) ||
                sv.malop.Contains(key))
                  .Select(sv => new
                  {
                      sv.id,
                      sv.hoten,
                      sv.gioitinh,
                      sv.ngaysinh,
                      sv.malop
                  });

            dsSinhVien.DataSource = ds.ToList();
        }

        //Refresh
        private void refreshhh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        private void link_qllh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_QLLH main = new frm_QLLH();
            main.Show();
            this.Close();
        }

        //Đăng xuất 
        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
        }

        // Load danh sách lớp học lên ComboBox
        void LoadComboBoxClass()
        {
            var classList = from lh in db.tbl_lophocs
                            select new
                            {
                                lh.malop,
                                DisplayText = lh.malop
                            };

            txt_class.DataSource = classList.ToList();
            txt_class.DisplayMember = "DisplayText"; 
            txt_class.ValueMember = "malop"; 
            txt_class.SelectedIndex = -1; 
            txt_class.Refresh();
        }

    }
}