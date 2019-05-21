using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_xep_hinh
{
    public partial class FormChoiGame : Form
    {
        public FormChoiGame()
        {
            InitializeComponent();
        }

        public int x, y;
        public int[] Arr = new int[9];
        public int Diem;
        public int Time;
        public int Level;
        public bool TT_Game = true; // Biến trạng thái game. Game chạy biến = true, game tạm dừng biến = false

        public void initArr()
        {
            for (int i = 1; i <= 9; i++)
            {
                Arr[i] = i;
            }
        }

        public void init()
        {
            x = 0;
            y = 0;
            Diem = 0;
            Time = 0;
            Level = 0;
        }

        public int GetVT(int x, int y)
        {
            return x + 3 * y;
        }

        public void GetAnh(PictureBox pb, int a)
        {
            switch(a)
            {
                case 1: pb.Image = game_xep_hinh.Properties.Resources.Anh1; break;
                case 2: pb.Image = game_xep_hinh.Properties.Resources.Anh2; break;
                case 3: pb.Image = game_xep_hinh.Properties.Resources.Anh3; break;
                case 4: pb.Image = game_xep_hinh.Properties.Resources.Anh4; break;
                case 5: pb.Image = game_xep_hinh.Properties.Resources.Anh5; break;
                case 6: pb.Image = game_xep_hinh.Properties.Resources.Anh6; break;
                case 7: pb.Image = game_xep_hinh.Properties.Resources.Anh7; break;
                case 8: pb.Image = game_xep_hinh.Properties.Resources.Anh8; break;
                case 9: pb.Image = null; pb.BackColor = Color.White; break;
            }
        }
    }
}
