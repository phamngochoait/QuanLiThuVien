using System; 
using System.Text; 
using System.Data; 
using System.Data.OleDb; 
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
using System.Collections.Generic;
{
    class AccessData
    {
         //Thuoc Tinh 
        protected string m_connectionString; 
        protected SqlConnection connection; 
        protected SqlDataAdapter da = null; 
        protected SqlCommand command; 
        //Phuong thuc 
        public AccessData() 
        { 
            m_connectionString = "Data Source=ZHANGLI\\SQLEXPRESS;Initial Catalog=D:\\C#\\BAITAP\\QLTV\\QLTV\\QUANLYTHUVIEN.MDF;Integrated Security=True"; 
        } 
        //Ket Noi 
        public void connect() 
        { 
            try 
            { 
                connection = new SqlConnection(ConnectionString); 
                connection.Open(); 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Không thể kết nối được với Server\n"+ ex.Message, "Lỗi chương trình"); 
                //Application.Exit(); 
            } 
        } 
        //Ngat Ket Noi 
        public void disconnect() 
        { 
            try 
            { 
                connection.Close(); 
            } 
            catch (Exception ex) 
            { 
 
                MessageBox.Show(ex.Message);             } 
        } 
        //Lay ra du lieu ra table 
        public DataTable TaoBang(String sqlString) 
        { 
            connect(); 
            DataTable ds = new DataTable(); 
            da = new SqlDataAdapter(sqlString, connection); 
            da.Fill(ds); 
            disconnect(); 
            return ds; 
        } 
        //Dung cho cac thao tac insert, delete, update 
        public void ExcuteNonQuery(string sqlString) 
        { 
            connect(); 
            command = new SqlCommand(sqlString, connection); 
            command.ExecuteNonQuery(); 
            disconnect(); 
        } 
        //Lay 1 gia tri du lieu ra 
        public object executeScalar(string sqlString) 
        { 
            connect(); 
            command = new SqlCommand(sqlString, connection); 
            object o = command.ExecuteScalar(); 
            disconnect(); 
            return o; 
        } 
 
        public string ConnectionString 
        { 
            get 
            { 
                return m_connectionString; 
            } 
            set 
            { 
                m_connectionString = value; 
            } 
        }
    }
}
