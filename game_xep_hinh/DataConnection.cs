using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_xep_hinh
{
    class DataConnection
    {
        //Hàm tạo chuỗi kết nối tới Database
        string conStr;
        public DataConnection()
        {
            conStr = @"Data Source = DESKTOP-MSES3F6\SQLEXPRESS; Initial Catalog = GameXepHinh; Integrated Security = true";
        }

        //Hàm lấy chuỗi kết nối và trả về SqlConnection
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
