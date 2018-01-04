using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class QuanLySach : Form
    {
	public QuanLySach()
        {
            InitializeComponent();
        }
        AccessData ac = new AccessData();
	private void QuanLySach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.DocGia' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.quanLyThuVienDataSet1.Sach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.quanLyThuVienDataSet1.Sach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter1.Fill(this.quanLyThuVienDataSet1.TacGia);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.NhaXuatBan' table. You can move, or remove it, as needed.
            this.nhaXuatBanTableAdapter1.Fill(this.quanLyThuVienDataSet1.NhaXuatBan);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter1.Fill(this.quanLyThuVienDataSet1.TheLoai);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.Sach' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.NhaXuatBan' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TheLoai' table. You can move, or remove it, as needed.
            //Thêm d? li?u vào cboTinhTrangSach
            this.cbxTinhTrangSach.Items.Add("T?t");
            this.cbxTinhTrangSach.Items.Add("X?u");
            this.cbxTinhTrangSach.Items.Add("Bình Th??ng");
            this.cbxTinhTrangSach.SelectedItem = "T?t";
            this.cbxNamXuatBan.SelectedItem = "2010";
            this.cbxKhoSach.SelectedItem = "20X30";
            this.cbxNgonNgu.SelectedItem = "Ti?ng vi?t";

            string sql1 = "Select *from Sach";
            dataGridViewSach.DataSource = ac.TaoBang(sql1);
            XoaSach();

            string sql2 = "Select *from TheLoai";
            dataGridViewTheLoai.DataSource = ac.TaoBang(sql2);
            XoaTheLoai();

            string sql3 = "Select *from NhaXuatBan";
            dataGridViewNXB.DataSource = ac.TaoBang(sql3);
            XoaNXB();

            //l?y tên tác gi?
            cbxTenTacGiaSach.DataSource = LayTenTacGia();
            cbxTenTacGiaSach.DisplayMember = "TenTacGia";
            //L?y tên th? lo?i
            cbxTenTheLoaiSach.DataSource = LayTenTheLoai();
            cbxTenTheLoaiSach.DisplayMember = "TenTheLoai";
            //L?y tên NXB
            cbxTenNXBSach.DataSource = LayTenNXB();
            cbxTenNXBSach.DisplayMember = "TenNhaXuatBan";

        }
        public static DataTable LayTenTacGia()
        {
            string sql;
            sql = "Select TenTacGia from TacGia ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayTenTheLoai()
        {
            string sql;
            sql = "Select TenTheLoai from TheLoai ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayTenNXB()
        {
            string sql;
            sql = "Select TenNhaXuatBan from NhaXuatBan ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        } 

        private void XoaTheLoai()
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
        }
        private void XoaNXB()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtDiaChiNXB.Clear();
        }
        private void XoaSach()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoBanSach.Clear();
            txtSoTrangSach.Clear();
            txtGiaSach.Clear();
            txtSoTap.Clear();
        }
        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            
            string sql = "Update NhaXuatBan set TenNhaXuatBan =N'" + txtTenNXB.Text + "',DiaChi =N'" + txtDiaChiNXB.Text + "',NgayThanhLap='" + dateTimePicker1.Value.ToString() + "' where MaNhaXuaBan='" + txtMaNXB.Text + "'";
            ac.ExcuteNonQuery(sql);
            string sql1 = "Select *from NhaXuatBan";
            dataGridViewNXB.DataSource = ac.TaoBang(sql1);
            XoaNXB();
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            string sql1 = "Delete from NhaXuatBan where MaNhaXuaBan ='" + txtMaNXB.Text + "'";
            string sql2 = "Delete from Sach where MaNhaXuatBan='" + txtMaNXB.Text + "'";
            DialogResult traloi = MessageBox.Show("B?n có ch?c ch?n xóa không ?", "Xóa Nhà Xu?t B?n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                ac.ExcuteNonQuery(sql1);
                ac.ExcuteNonQuery(sql2);
                string sql3 = "Select *from NhaXuatBan";
                dataGridViewNXB.DataSource = ac.TaoBang(sql3);
                XoaNXB();
            }
        }


            
     }
}