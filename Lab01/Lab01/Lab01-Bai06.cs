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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            int dd, mm, yy;
            if(int.TryParse(txtDate.Text.Trim(), out dd) && int.TryParse(txtMonth.Text.Trim(), out mm) && int.TryParse(txtYear.Text.Trim(), out yy))
            {
                DateTime curentTime = DateTime.Now;
                string cungHoangDao = "";
                dd = Int32.Parse(txtDate.Text.Trim());
                mm = Int32.Parse(txtMonth.Text.Trim());

                switch (mm)
                {
                    case 1:
                        if( dd >= 1 && dd <=20 )
                        {
                            cungHoangDao = "Cung Ma Kết";
                        }
                        else
                        {
                            cungHoangDao = "Cung Bảo Bình";
                        }
                        break;
                    case 2:
                        if( dd >= 1 && dd <= 19)
                        {
                            cungHoangDao = "Cung Bảo Bình";
                        }
                        else
                        {
                            cungHoangDao = "Cung Song Ngư";
                        }
                        break;
                    case 3:
                        if (dd >= 1 && dd <= 20)
                        {
                            cungHoangDao = "Cung Song Ngư";
                        }
                        else
                        {
                            cungHoangDao = "Cung Bạch Dương";
                        }
                        break;
                    case 4:
                        if (dd >= 1 && dd <= 20)
                        {
                            cungHoangDao = "Cung Bạch Dương";
                        }
                        else
                        {
                            cungHoangDao = "Cung Kim Ngưu";
                        }
                        break;
                    case 5:
                        if (dd >= 1 && dd <= 21)
                        {
                            cungHoangDao = "Cung Kim Ngưu";
                        }
                        else
                        {
                            cungHoangDao = "Cung Song Tử";
                        }
                        break;
                    case 6:
                        if (dd >= 1 && dd <= 21)
                        {
                            cungHoangDao = "Cung Song Tử";
                        }
                        else
                        {
                            cungHoangDao = "Cung Cự Giải";
                        }
                        break;
                    case 7:
                        if (dd >= 1 && dd <= 22)
                        {
                            cungHoangDao = "Cung Cự Giải";
                        }
                        else
                        {
                            cungHoangDao = "Cung Sư Tử";
                        }
                        break;
                    case 8:
                        if (dd >= 1 && dd <= 22)
                        {
                            cungHoangDao = "Cung Sư Tử";
                        }
                        else
                        {
                            cungHoangDao = "Cung Xử Nữ";
                        }
                        break;
                    case 9:
                        if (dd >= 1 && dd <= 23)
                        {
                            cungHoangDao = "Cung Xử Nữ";
                        }
                        else
                        {
                            cungHoangDao = "Cung Thiên Bình";
                        }
                        break;
                    case 10:
                        if (dd >= 1 && dd <= 23)
                        {
                            cungHoangDao = "Cung Thiên Bình";
                        }
                        else
                        {
                            cungHoangDao = "Cung Thần Nông";
                        }
                        break;
                    case 11:
                        if (dd >= 1 && dd <= 22)
                        {
                            cungHoangDao = "Cung Thần Nông";
                        }
                        else
                        {
                            cungHoangDao = "Cung Nhân Mã";
                        }
                        break;
                    case 12:
                        if (dd >= 1 && dd <= 21)
                        {
                            cungHoangDao = "Cung Nhân Mã";
                        }
                        else
                        {
                            cungHoangDao = "Cung Ma Kết";
                        }
                        break;
                    default:
                            MessageBox.Show("Ngày hoặc tháng không hợp lê. Vui lòng nhập lại!");
                            return;
                }

                txtKetQua.Text = "Cung hoàng đạo của bạn là : " + cungHoangDao + "\r\n";
                txtKetQua.Text += "Tuổi hiện tại của bạn là : " + (curentTime.Year - yy);
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng định dạng ngày , tháng, năm !");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach( Control ctrl in this.Controls )
            {
                if( ctrl is TextBox )
                {
                    ((TextBox)ctrl).Clear();
                }
                txtKetQua.Clear();
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
