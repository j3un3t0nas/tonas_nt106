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
    public partial class Lab01_Bai031 : Form
    {
        public Lab01_Bai031()
        {
            InitializeComponent();
        }

        private string docSoNangCao(long n)
        {
            if (n == 0)
                return "Không";

            string words = "";
            bool isNegative = false;

            if (n < 0)
            {
                isNegative = true;
                n = -n;
            }

            string[] ones = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
            string[] powersOfTen = { "", "Mươi", "Trăm", "Nghìn", "Mươi", "Trăm", "Triệu", "Mươi", "Trăm", "Tỷ", "Mươi", "Trăm", "Nghìn" };

            int powerIndex = 0;
            while (n > 0)
            {
                int group = (int)(n % 1000);
                if (group > 0)
                {
                    string groupWords = GetGroupWords(group, ones, powerIndex, powersOfTen);
                    words = groupWords + " " + words;
                }
                n /= 1000;
                powerIndex += 3;
            }

            if (isNegative)
                words = "Âm " + words;

            return words.Trim();
        }

        private string GetGroupWords(int group, string[] ones, int powerIndex, string[] powersOfTen)
        {
            string groupWords = "";

            int hundreds = group / 100;
            if (hundreds > 0)
            {
                groupWords += ones[hundreds] + " Trăm";
            }

            int tensUnits = group % 100;
            if (tensUnits > 0)
            {
                if (tensUnits < 20)
                {
                    groupWords += " " + ones[tensUnits];
                }
                else
                {
                    groupWords += " " + ones[tensUnits / 10] + " mươi";
                    if (tensUnits % 10 > 0)
                    {
                        groupWords += " " + ones[tensUnits % 10];
                    }
                }
            }

            if (groupWords.Length > 0)
            {
                groupWords += " " + powersOfTen[powerIndex];
            }

            return groupWords.Trim();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            long longNum = 0;
            if( long.TryParse(txtInput.Text.Trim(), out longNum) == false)
            {
                MessageBox.Show("Số bạn nhập vào không hợp lê, vui lòng nhập lại!");
                return;
            }    

            longNum = long.Parse(txtInput.Text.Trim());
            txtOutput.Text = docSoNangCao(longNum);
        }
    }
}
