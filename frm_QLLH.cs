using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_QLLH : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public frm_QLLH()
        {
            InitializeComponent();
        }
        private void frm_QLLH_Load(object sender, EventArgs e)
        {
            dgvLopHoc.AutoGenerateColumns = false;
            LoadData();

            btn_Them.Click += btn_Them_Click;
            btn_Sua.Click += btn_Sua_Click;
            btn_Xoa.Click += btn_Xoa_Click;
            btn_Search.Click += btn_Search_Click;
            btn_LamMoi.Click += btn_LamMoi_Click;
            dgvLopHoc.CellClick += dgvLopHoc_CellClick;
        }

        //Load dữ liệu lên DataGridView
        void LoadData()
        {
            var ds = from lh in db.tbl_lophocs
                     select new
                     {
                         lh.malop,
                         lh.monhoc,
                         lh.giangvien,
                         lh.siso
                     };
            dgvLopHoc.DataSource = ds.ToList();
        }

        //Clear form
        void ClearForm()
        {
            txt_MaLop.Clear();
            txt_GiangVien.Clear();
            txt_MonHoc.Clear();
            txt_SiSo.Clear();
            txt_MaLop.Focus();
        }

        //Click DataGridView
        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];

                txt_MaLop.Text = row.Cells["malop"].Value?.ToString();
                txt_MonHoc.Text = row.Cells["monhoc"].Value?.ToString();
                txt_GiangVien.Text = row.Cells["giangvien"].Value?.ToString();
                txt_SiSo.Text = row.Cells["siso"].Value?.ToString();
                txt_MaLop.Focus();

            }
        }

        //Thêm 
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_lophoc lh = new tbl_lophoc();

                lh.malop = txt_MaLop.Text;
                lh.monhoc = txt_MonHoc.Text;
                lh.giangvien = txt_GiangVien.Text;
                lh.siso = int.Parse(txt_SiSo.Text);


                db.tbl_lophocs.InsertOnSubmit(lh);
                db.SubmitChanges();

                LoadData();
                ClearForm();

                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sửa
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                var lh = db.tbl_lophocs.FirstOrDefault(x => x.malop == txt_MaLop.Text);

                if (lh != null)
                {
                    lh.malop = txt_MaLop.Text;
                    lh.monhoc = txt_MonHoc.Text;
                    lh.giangvien = txt_GiangVien.Text;
                    lh.siso = int.Parse(txt_SiSo.Text);

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

        //Xóa 
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                var lh = db.tbl_lophocs.FirstOrDefault(x => x.malop == txt_MaLop.Text);

                if (lh != null)
                {
                    db.tbl_lophocs.DeleteOnSubmit(lh);
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
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string key = txt_Search.Text.Trim();

            var ds = db.tbl_lophocs.Where(lh =>

                lh.malop.Contains(key) ||
                lh.monhoc.Contains(key) ||
                lh.giangvien.Contains(key))
                  .Select(lh => new
                  {
                      lh.malop,
                      lh.monhoc,
                      lh.giangvien,
                      lh.siso
                  });

            dgvLopHoc.DataSource = ds.ToList();
        }

        //Refresh
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

    }
}

