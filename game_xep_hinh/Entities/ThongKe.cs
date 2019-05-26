using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_xep_hinh.Entities
{
    public class ThongKe
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _thoiGian;

        public int ThoiGian
        {
            get { return _thoiGian; }
            set { _thoiGian = value; }
        }

        private int _soLanThaoTac;

        public int SoLanThaoTac
        {
            get { return _soLanThaoTac; }
            set { _soLanThaoTac = value; }
        }

        private string _idMucDo;

        public string IDMucDo
        {
            get { return _idMucDo; }
            set { _idMucDo = value; }
        }

        private string _tenNguoiChoi;

        public string TenNguoiChoi
        {
            get { return _tenNguoiChoi; }
            set { _tenNguoiChoi = value; }
        }

        private string _mucDo;

        public string LoaiMucDo
        {
            get { return _mucDo; }
            set { _mucDo = value; }
        }

    }
}
