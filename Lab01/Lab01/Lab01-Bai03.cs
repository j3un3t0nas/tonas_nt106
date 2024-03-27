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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            short num = short.Parse(txtInput.Text.Trim());

            switch (num)
            {
                case 0:
                    txtOutput.Text = "Không";
                    break;
                case 1:
                    txtOutput.Text = "Một";
                    break;
                case 2:
                    txtOutput.Text = "Hai";
                    break;
                case 3:
                    txtOutput.Text = "Ba";
                    break;
                case 4:
                    txtOutput.Text = "Bốn";
                    break;
                case 5:
                    txtOutput.Text = "Năm";
                    break;
                case 6:
                    txtOutput.Text = "Sáu";
                    break;
                case 7:
                    txtOutput.Text = "Bảy";
                    break;
                case 8:
                    txtOutput.Text = "Tám";
                    break;
                case 9:
                    txtOutput.Text = "Chín";
                    break;
                default:
                    txtOutput.Text = "Số nhập vào không hợp lệ";
                    break;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }
    }
}
