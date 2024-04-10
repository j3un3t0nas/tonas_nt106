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
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        double findMaxNum( double a, double b, double c )
        {
            double maxNum = a;
            if(a < b)
            {
                maxNum = b;
                if(b < c)
                {
                    maxNum = c;
                }    
            }
            else if(a<c)
            {
                maxNum = c;
            }
            return maxNum;
        }

        double findMinMun( double a, double b, double c )
        {
            double minNum = a;
            
            if(minNum > b)
            {
                minNum = b;
                if (minNum > c)
                {
                    minNum = c;
                }    
            } 
            else if(minNum > c)
            {
                minNum = c;
            }
            return minNum;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;

            num1 = double.Parse(txtSoThu1.Text.Trim());
            num2 = double.Parse(txtSoThu2.Text.Trim());
            num3 = double.Parse(txtSoThu3.Text.Trim());

            txtMaxNum.Text = findMaxNum(num1, num2, num3).ToString();
            txtMinNum.Text = findMinMun(num1, num2, num3).ToString();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach( Control ctrl in this.Controls )
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
