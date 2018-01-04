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
    public partial class QuanLyThe : Form
    {
         public QuanLyThe()
        {
            InitializeComponent();
        }
        private void QuanLyThe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.The' table. You can move, or remove it, as needed.
            this.theTableAdapter.Fill(this.quanLyThuVienDataSet1.The);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.quanLyThuVienDataSet1.DocGia);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet1.DocGia' table. You can move, or remove it, as needed.
            this.docGiaTableAdapter.Fill(this.quanLyThuVienDataSet1.DocGia);
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.DocGia' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.The' table. You can move, or remove it, as needed.
            string sql1 = "Select *from The";
            dataGridViewThe.DataSource = ac.TaoBang(sql1);
            Xoa();
            //Hiển thị mã độc giả
            cbxMaDocGiaThe.DataSource = LayMaDocGia();
            cbxMaDocGiaThe.DisplayMember = "MaDocGia";
            
        }
        AccessData ac = new AccessData();
        public static DataTable LayMaDocGia()
        {
            string sql;
            sql = "Select MaDocGia from DocGia ";
            AccessData db = new AccessData();
            DataTable dt;
            dt = db.TaoBang(sql);
            return dt;
        }
        private void Xoa()
        {
            this.txtMaThe.Clear();

        }
    }
}
