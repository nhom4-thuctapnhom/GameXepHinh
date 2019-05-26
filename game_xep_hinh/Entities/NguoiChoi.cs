using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_xep_hinh.Entities
{
    public class NguoiChoi
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _ten;

        public string TenNguoiChoi
        {
            get { return _ten; }
            set { _ten = value; }
        }

    }
}
