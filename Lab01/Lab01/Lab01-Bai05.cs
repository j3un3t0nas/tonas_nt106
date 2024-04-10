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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        int factorial( int n )
        {
            if (n == 1|| n == 0)
                return 1;
            
            return n*(n-1);
        }


        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumA.Text) == true || string.IsNullOrEmpty(txtNumB.Text) == true)
            {
                MessageBox.Show("Vui lòng nhập các giá trị hợp lệ");
                return;
            }

            int num1 = 0, num2 = 0;

            if( int.TryParse(txtNumA.Text.Trim(), out num1) && int.TryParse(txtNumB.Text.Trim(), out num2))
            {
                num1 = Int32.Parse(txtNumA.Text.Trim());
                num2 = Int32.Parse(txtNumB.Text.Trim());
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên !");
                return;
            }

            if(cboChucNang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức năng thực hiện!");
                return;
            }  
            else
            {
                if(cboChucNang.SelectedIndex == 0)
                {
                    string str1 = "";
                    int diff = num2 - num1;
                    str1 = "Bảng cửu chương B - A : \r\n";
                    for (int i = 1; i <= 10; i++)
                    {
                        str1 += (num2 - num1) + " x " + i + " = " + (diff * i) + "\r\n";
                    }

                    txtKetQua.Text = str1;
                } 
                if(cboChucNang.SelectedIndex == 1)
                {
                    if (num1 < num2)
                    {
                        MessageBox.Show("Không thể tính giai thừa do A < B !");
                        return;
                    }

                    double ans1 = factorial(num1 - num2);
                    double ans2 = 0;
                    String str1 = " ";
                    for(int i = 1; i <= num2; i++)
                    {
                        ans2 += Math.Pow(num1, i);
                    }

                    str1 = "(A - B)! = " + ans1 + "\r\n";
                    str1 += "Tổng S = " + ans2 + "\r\n";
                    txtKetQua.Text = str1;

                }    
            }    
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach( Control ctrl in this.Controls )
            {
                if( ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
            txtKetQua.Clear();
        }
    }
}
