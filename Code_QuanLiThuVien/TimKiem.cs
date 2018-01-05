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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        AccessData ac = new AccessData();
        private void TimKiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.NhaXuatBan' table. You can move, or remove it, as needed.
            this.nhaXuatBanTableAdapter.Fill(this.quanLyThuVienDataSet1.NhaXuatBan);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.TheLoai' table. You can move, or remove it, as needed.
            this.theLoaiTableAdapter.Fill(this.quanLyThuVienDataSet1.TheLoai);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet1.TacGia);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.quanLyThuVienDataSet1.Sach);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.Sach' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.NhaXuatBan' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TheLoai' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            
            cbxTenSachTK.DisplayMember = "";
            //hiển thị tên sách
            cbxTenSachTK.DataSource = LayTenSach();
            cbxTenSachTK.DisplayMember = "TenSach";
            //Hiển thị tên tác giả
            cbxTenTacGiaTK.DataSource = LayTenTacGia();
            cbxTenTacGiaTK.DisplayMember = "TenTacGia";
            //Hiển thị tên Thể Loại
            cbxTenTLTK.DataSource = LayTenTheLoai();
            cbxTenTLTK.DisplayMember = "TenTheLoai";
            //Hiển thị tên nhà xuất bản
            cbxTenNXBTK.DataSource = LayTenNXB();
            cbxTenNXBTK.DisplayMember = "TenNhaXuatBan";



        }

        public static DataTable LayTenSach()
        {
            string sql;
            sql = "Select TenSach from Sach ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
       

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from Sach where TenSach like N'%" + cbxTenSachTK.Text.ToString() + "%'";
            dataGridViewTimKiem.DataSource = ac.TaoBang(sql1);
        }
    }
}
