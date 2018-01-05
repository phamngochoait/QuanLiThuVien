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
    }
}