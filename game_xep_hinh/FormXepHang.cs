using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_xep_hinh
{
    public partial class FormXepHang : Form
    {
        DataConnection dc = new DataConnection();
        SqlDataAdapter da; //Khởi tạo 1 đối tg SqlDataAdapter
        public FormXepHang()
        {
            InitializeComponent();
            dgvDe.DataSource = getDataTable("select top 10 tk.ID, Ten, SoLanThaoTac, ThoiGian  from THONGKE tk, NGUOICHOI nc where nc.ID = tk.ID and tk.IDMucDo = 1 order by SoLanThaoTac");
        }

        public DataTable getDataTable(string str)
        {
            try
            {
                SqlConnection con = dc.getConnect(); //Tạo 1 kết nối đến Sql từ hàm getConnect() trong DataConnection
                da = new SqlDataAdapter(str, con); //Khởi tạo đối tượng của lớp SqlDataAdapter với chuỗi lệnh SQL là str và chuỗi connect là con

                con.Open(); // Mở kết nối để truyền và lấy dữ liệu từ SQL sever 
                DataTable dt = new DataTable(); // Tạ 1 đối tượng kiểu DataTable để đổ dữ liệu từ SQL vào\
                da.Fill(dt); // Đổ dữ liệu vào
                con.Close(); //Đóng kết nối
                return dt;  //Trả về dt sau khi select đc dữ liệu từ SQL
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
                return null;
            }
        }
    }
}
