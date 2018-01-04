using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        AccessData ac = new AccessData();    
        
        private void ThongKe_Load(object sender, EventArgs e)
        {
            
            this.tacGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TacGia);
            string sql1 = "Select COUNT(*) from Sach";
            string sql2 = "Select COUNT(*) from DocGia";
            string sql3 = "Select COUNT(*) from TacGia";
            string sql4 = "Select COUNT(*) from TheLoai";
            string sql5 = "Select COUNT(*) from NhaXuatBan";
            string sql6 = "Select COUNT(*) from PhieuYeuCau";


   	  
 
        }

    }
}
