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
            
     }
}
