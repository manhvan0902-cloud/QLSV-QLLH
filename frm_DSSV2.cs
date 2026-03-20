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
    public partial class frm_DSSV2 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private string maLop;

        public frm_DSSV2(string malop)
        {
            InitializeComponent();
            this.maLop = malop;
        }

        private void frm_DSSV2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            label2.Text = "Lớp: " + maLop;

            int siso = db.tbl_sinhviens.Count(sv => sv.malop == maLop);
            label3.Text = "Sĩ số: " + siso;

            var dsSinhVien = from sv in db.tbl_sinhviens
                             where sv.malop == maLop
                             select new
                             {
                                 sv.id,
                                 sv.hoten,
                                 sv.gioitinh,
                                 sv.ngaysinh
                             };

            dataGridView1.DataSource = dsSinhVien.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_QLLH main = new frm_QLLH();
            main.Show();
            this.Close();
        }
    }
}