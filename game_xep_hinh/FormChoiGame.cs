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
                Arr[i - 1] = i;
            }
        }

        public void init()
        {
            x = 2;
            y = 2;
            Diem = 0;
            Time = 0;
            Level = 0;
            initArr();
            pbMain.Image = game_xep_hinh.Properties.Resources.Untitled_1;
            lbDiem.Text = "0";
            lbThoiGian.Text = (Time / 60).ToString() + " phút : " + (Time % 60).ToString() + " giây";
            timer1.Start();
        }

        public int getVT(int x, int y)
        {
            return x + 3 * y;
        }

        public void getAnh(PictureBox pb, int a)
        {
            switch (a)
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

        private void showpb()
        {
            getAnh(pb1, Arr[0]);
            getAnh(pb2, Arr[1]);
            getAnh(pb3, Arr[2]);
            getAnh(pb4, Arr[3]);
            getAnh(pb5, Arr[4]);
            getAnh(pb6, Arr[5]);
            getAnh(pb7, Arr[6]);
            getAnh(pb8, Arr[7]);
            getAnh(pb9, Arr[8]);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChoiGame_Load(object sender, EventArgs e)
        {
            init();
            setmap();
            lbDiem.Text = "0";
            lbMucChoi.Text = "Dễ";
            timer1.Start();
        }

        public void go_Left()
        {
            if (x > 0)
            {
                int temp = Arr[getVT(x, y)];
                Arr[getVT(x, y)] = Arr[getVT(x - 1, y)];
                Arr[getVT(x - 1, y)] = temp;

                x--;
                Diem++;
                showpb();
            }
        }

        public void go_Right()
        {
            if (x < 2)
            {
                int temp = Arr[getVT(x, y)];
                Arr[getVT(x, y)] = Arr[getVT(x + 1, y)];
                Arr[getVT(x + 1, y)] = temp;

                x++;
                Diem++;
                showpb();
            }
        }

        public void go_top()
        {
            if (y > 0)
            {
                int temp = Arr[getVT(x, y)];
                Arr[getVT(x, y)] = Arr[getVT(x, y - 1)];
                Arr[getVT(x, y - 1)] = temp;

                y--;
                Diem++;
                showpb();
            }
        }

        public void go_bottom()
        {
            if (y < 2)
            {
                int temp = Arr[getVT(x, y)];
                Arr[getVT(x, y)] = Arr[getVT(x, y + 1)];
                Arr[getVT(x, y + 1)] = temp;

                y++;
                Diem++;
                showpb();
            }
        }

        Random rd = new Random();

        private void btnTamDung_Click(object sender, EventArgs e)
        {
            if (TT_Game == true)
            {
                TT_Game = false;
                btnTamDung.Text = "Chơi tiếp";
                timer1.Stop();
            }
            else
            {
                TT_Game = true;
                btnTamDung.Text = "Tạm dừng";
                timer1.Start();
            }
        }

        private void btnTroChoiMoi_Click(object sender, EventArgs e)
        {
            TT_Game = true;
            btnTamDung.Text = "Tạm dừng";
            init();
            setmap();
        }

        private void btnHoanThanhNhanh_Click(object sender, EventArgs e)
        {
            pb1.Image = game_xep_hinh.Properties.Resources.Anh1;
            pb2.Image = game_xep_hinh.Properties.Resources.Anh2;
            pb3.Image = game_xep_hinh.Properties.Resources.Anh3;
            pb4.Image = game_xep_hinh.Properties.Resources.Anh4;
            pb5.Image = game_xep_hinh.Properties.Resources.Anh5;
            pb6.Image = game_xep_hinh.Properties.Resources.Anh6;
            pb7.Image = game_xep_hinh.Properties.Resources.Anh7;
            pb8.Image = game_xep_hinh.Properties.Resources.Anh8;
            pb9.Image = null; pb9.BackColor = Color.White;

            timer1.Stop();
            MessageBox.Show("Bạn đã thắng..... Thời gian: " + lbThoiGian.Text, "Congratulation!!!", MessageBoxButtons.OK);
            init();
            setmap();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time++;
            lbThoiGian.Text = (Time / 60).ToString() + " phút : " + (Time % 60).ToString() + " giây";
        }

        private void setmap()
        {
            //Xáo trộn 200 lần 
            for (int i = 0; i < 200; i++)
            {
                int rdn = rd.Next(1, 5); //Trả về từ 1 - 4
                switch (rdn)
                {
                    case 1: go_top(); break;
                    case 2: go_bottom(); break;
                    case 3: go_Left(); break;
                    case 4: go_Right(); break;
                }
            }
            int temp = Arr[getVT(x, y)];
            Arr[getVT(x, y)] = Arr[8];
            Arr[8] = temp;

            x = 2;
            y = 2;
            showpb();
        }

        private void btnTamDung_KeyUp(object sender, KeyEventArgs e)
        {
            if (TT_Game == true)
            {
                if (e.KeyCode == Keys.Left)
                {
                    go_Right(); //sang phải
                }
                else if (e.KeyCode == Keys.Right)
                {
                    go_Left(); //sang trái
                }
                else if (e.KeyCode == Keys.Up)
                {
                    go_bottom(); //xuống dưới
                }
                else if (e.KeyCode == Keys.Down)
                {
                    go_top(); //lên trên
                }
            }

            if (check_win() == true)
            {
                timer1.Stop();
                MessageBox.Show("Bạn đã thắng..... Thời gian: ", "Congratulation!!!", MessageBoxButtons.OK);
                init();
                setmap();
            }
            lbDiem.Text = Diem.ToString();
        }
        
        public bool check_win()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (Arr[i - 1] != i)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
