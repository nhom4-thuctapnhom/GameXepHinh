using game_xep_hinh.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_xep_hinh.Database
{
    public class NguoiChoiData
    {
        Database db = new Database();

        public List<NguoiChoi> LayDsThongKe()
        {
            SqlCommand scmd = new SqlCommand();
            scmd.Connection = db.SqlConnection;
            scmd.CommandText = "SELECT * FROM NguoiChoi";
            SqlDataReader dr = null;
            List<NguoiChoi> list = new List<NguoiChoi>();
            try
            {
                db.OpenConnection();
                dr = scmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        NguoiChoi nc = new NguoiChoi();
                        nc.ID = (int)dr["id"];
                        nc.TenNguoiChoi = (string)dr["Ten"];
                        list.Add(nc);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }

        public void ThemNguoiChoi(NguoiChoi nc)
        {
            SqlCommand scmd = new SqlCommand();
            scmd.Connection = db.SqlConnection;
            scmd.CommandText = "INSERT INTO NguoiChoi(ID, Ten) values (@id, @ten)";
            scmd.Parameters.Add(new SqlParameter("id", nc.ID));
            scmd.Parameters.Add(new SqlParameter("ten", nc.TenNguoiChoi));
            try
            {
                db.OpenConnection();
                scmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
