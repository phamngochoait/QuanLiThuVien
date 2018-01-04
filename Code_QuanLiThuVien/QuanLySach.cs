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
            //Thêm dữ liệu vào cboTinhTrangSach
            this.cbxTinhTrangSach.Items.Add("Tốt");
            this.cbxTinhTrangSach.Items.Add("Xấu");
            this.cbxTinhTrangSach.Items.Add("Bình Thường");
            this.cbxTinhTrangSach.SelectedItem = "Tốt";
            this.cbxNamXuatBan.SelectedItem = "2010";
            this.cbxKhoSach.SelectedItem = "20X30";
            this.cbxNgonNgu.SelectedItem = "Tiếng việt";

            string sql1 = "Select *from Sach";
            dataGridViewSach.DataSource = ac.TaoBang(sql1);
            XoaSach();

            string sql2 = "Select *from TheLoai";
            dataGridViewTheLoai.DataSource = ac.TaoBang(sql2);
            XoaTheLoai();

            string sql3 = "Select *from NhaXuatBan";
            dataGridViewNXB.DataSource = ac.TaoBang(sql3);
            XoaNXB();

            //lấy tên tác giả
            cbxTenTacGiaSach.DataSource = LayTenTacGia();
            cbxTenTacGiaSach.DisplayMember = "TenTacGia";
            //Lấy tên thể loại
            cbxTenTheLoaiSach.DataSource = LayTenTheLoai();
            cbxTenTheLoaiSach.DisplayMember = "TenTheLoai";
            //Lấy tên NXB
            cbxTenNXBSach.DataSource = LayTenNXB();
            cbxTenNXBSach.DisplayMember = "TenNhaXuatBan";

            
     }
}
