using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB02
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 bai01 = new Lab02_Bai01();
            bai01.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 bai02 = new Lab02_Bai02();
            bai02.Show();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 bai03 = new Lab02_Bai03();
            bai03.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 bai04 = new Lab02_Bai04();
            bai04.Show();
        }

        private void btnBai07_Click(object sender, EventArgs e)
        {
            Lab02_Bai07 bai07 = new Lab02_Bai07();
            bai07.Show();
        }
    }
}
