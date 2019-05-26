using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_xep_hinh.Entities
{
    public class MucDo
    {
        private string _id;

        public string IDMucDo
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _mucDo;

        public string LoaiMucDo
        {
            get { return _mucDo; }
            set { _mucDo = value; }
        }

    }
}
