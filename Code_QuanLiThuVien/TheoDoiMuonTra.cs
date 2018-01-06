﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TheoDoiMuonTra : Form
    {
        public TheoDoiMuonTra()
        {
            InitializeComponent();
        }
        AccessData ac = new AccessData();
        private void Xoa()
        {
            this.txtSoPhieu.Clear();
        }
        private void HienThi()
        {
            string sql = "Select *from PhieuYeuCau";
            dataGridViewMuon.DataSource = ac.TaoBang(sql);

        }
        public static DataTable LaySoPhieu()
        {
            string sql;
            sql = "Select DISTINCT SoPhieu from PhieuYeuCau ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);

            return dt;
        }
        public static DataTable LayMaTheDocGia()
        {
            string sql;
            sql = "Select MaThe from The ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayMaTheMuon()
        {
            string sql;
            sql = "Select DISTINCT MaThe from PhieuYeuCau ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayMaDocGia()
        {
            string sql;
            sql = "Select MaDocGia from The ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        public static DataTable LayMaSach()
        {
            string sql;
            sql = "Select MaSach from Sach ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
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
        public static DataTable LayNgayHenTra()
        {
            string sql;
            sql = "Select NgayTra from PhieuYeuCau ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        private void TheoDoiMuonTra_Load(object sender, EventArgs e)
        {
        
            this.sachTableAdapter.Fill(this.quanLyThuVienDataSet1.Sach);
      
            this.phieuYeuCauTableAdapter.Fill(this.quanLyThuVienDataSet1.PhieuYeuCau);
        
            this.theTableAdapter.Fill(this.quanLyThuVienDataSet1.The);
              

            //Lấy Mã Thẻ Độc giả đưa vào mượn
            cbxMaTheMuon.DataSource = LayMaTheDocGia();
            cbxMaTheMuon.DisplayMember = "MaThe";
            //Lấy Mã Thẻ đã mượn để theo dõi trả
            cbxMaTheTra.DataSource = LayMaTheMuon();
            cbxMaTheTra.DisplayMember = "MaThe";
           
            //Lấy số phiếu
            cbxSoPhieu.DataSource = LaySoPhieu();
            cbxSoPhieu.DisplayMember = "SoPhieu";

            //Lấy mã sách đưa vào mượn
            cbxMaSachMuon.DataSource = LayMaSach();
            cbxMaSachMuon.DisplayMember = "MaSach";
            //Lấy tên Sách đưa vòa mượn
            cbxTenSachMuon.DataSource = LayTenSach();
            cbxTenSachMuon.DisplayMember = "TenSach";
            //Lấy ngày hẹn trả đưa vào trả
            cbxNgayHenTraMuon.DataSource = LayNgayHenTra();
            cbxNgayHenTraMuon.DisplayMember = "NgayHenTra";
            cbxTinhTrangTra.SelectedItem = "Tốt";
            HienThi();
            Xoa();
        }
        int dong;
        private void dataGridViewMuon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtSoPhieu.Text = dataGridViewMuon.Rows[dong].Cells[1].Value.ToString();
            cbxMaSachMuon.Text = dataGridViewMuon.Rows[dong].Cells[3].Value.ToString();
            
        }
        private void btnMuon_Click(object sender, EventArgs e)
        {
            //Lấy mã độc giả
            string docgia = "Select MaDocGia from The where MaThe='" + cbxMaTheMuon.Text.ToString() + "'";
            string MaDG = Convert.ToString(ac.executeScalar(docgia));
            //Lấy tên độc giả từ bảng độc giả
            string docgia1 = "Select TenDocGia from DocGia where MaDocGia='" + MaDG + "'";
            string TenDG = Convert.ToString(ac.executeScalar(docgia1));
	}  
                 

    }
}