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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;

            if(int.TryParse(txtb1.Text.Trim(),out num1) && int.TryParse(txtb2.Text.Trim(), out num2))
            {
                num1 = Int32.Parse(txtb1.Text.Trim());
                num2 = Int32.Parse(txtb2.Text.Trim());

                sum = num1 + num2;
                txtbKQ.Text = sum.ToString();
            }    
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }    
        }
    }
}
