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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormChoiGame frmPlay = new FormChoiGame();
            frmPlay.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frmPlay.Show();
            this.Hide();
        }

        public void frm_FormClosed (object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            FormXepHang frmXepHang = new FormXepHang();
            frmXepHang.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frmXepHang.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
