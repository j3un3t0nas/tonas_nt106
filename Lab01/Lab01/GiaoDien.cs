using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 bai01 = new Lab01_Bai01();
            bai01.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 bai02 = new Lab02_Bai02();
            bai02.Show();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 bai03 = new Lab01_Bai03();
            bai03.Show();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 bai05 = new Lab01_Bai05();
            bai05.Show();
        }

        private void btnBai06_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 bai06 = new Lab01_Bai06();
            bai06.Show();
        }

        private void btnBai07_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 bai07 = new Lab01_Bai07();
            bai07.Show();
        }

        private void btnBai08_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 bai08 = new Lab01_Bai08();
            bai08.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bài 4 em chịu không hình dung giao diện làm anh ơi :((");
        }

        private void btnBai31_Click(object sender, EventArgs e)
        {
            Lab01_Bai031 bai031 = new Lab01_Bai031();
            bai031.Show();
        }
    }
}
    