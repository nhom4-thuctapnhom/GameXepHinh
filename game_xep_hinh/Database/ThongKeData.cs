using game_xep_hinh.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_xep_hinh.Database
{
    public class ThongKeData
    {
        Database db = new Database();

        public List<ThongKe> LayDsThongKe()
        {
            SqlCommand scmd = new SqlCommand();
            scmd.Connection = db.SqlConnection;
            scmd.CommandText = "SELECT tk.id, tk.idMucDo, SoLanThaoTac, ThoiGian, Ten, md.MucDo FROM ThongKe tk INNER JOIN NguoiChoi nc ON tk.ID = nc.ID INNER JOIN MucDo md ON tk.IdMucDo = md.IdMucDo";
            SqlDataReader dr = null;
            List<ThongKe> list = new List<ThongKe>();
            try
            {
                db.OpenConnection();
                dr = scmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        ThongKe tk = new ThongKe();
                        tk.ID = (int)dr["id"];
                        tk.IDMucDo = (string)dr["idMucDo"];
                        tk.ThoiGian = (int)dr["ThoiGian"];
                        tk.SoLanThaoTac = (int)dr["SoLanThaoTac"];
                        tk.TenNguoiChoi = (string)dr["Ten"];
                        tk.LoaiMucDo = (string)dr["MucDo"];
                        list.Add(tk);
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

        public void ThemNguoiChoiVaoThongKe(ThongKe tk)
        {
            SqlCommand scmd = new SqlCommand();
            scmd.Connection = db.SqlConnection;
            scmd.CommandText = "INSERT INTO ThongKe(ID, ThoiGian, SoLanThaoTac, IdMucDo) values (@id, @thoigian, @solantt, @mucdo)";
            scmd.Parameters.Add(new SqlParameter("id", tk.ID));
            scmd.Parameters.Add(new SqlParameter("thoigian", tk.ThoiGian));
            scmd.Parameters.Add(new SqlParameter("solantt", tk.SoLanThaoTac));
            scmd.Parameters.Add(new SqlParameter("mucdo", tk.IDMucDo));
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
