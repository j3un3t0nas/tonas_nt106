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
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void display( double[] arr)
        {
            for( int i = 0; i< arr.Length; i++ )
            {
                if( i == arr.Length - 1 )
                {
                    txtOutput.Text += "Môn " + (i+1) + " : " + arr[i] + "\r\n";
                    break;
                }

                txtOutput.Text += "Môn " + (i+1) + " : " + arr[i] + " || ";
            }    
        }
        
        private double calOverall( double[] arr )
        {
            double sum = 0;
            for( int i = 0; i< arr.Length;i++ )
            {
                sum += arr[i];
            }

            return sum / arr.Length;
        }

        private int countPassedSubjects(double[] arr )
        {
            int count = 0;
            for( int i = 0; i< arr.Length ; i++ )
            {
                if(arr[i] >= 5 )
                    count++;
            }
            return count;
        }

        private int countFailedSubjects(double[] arr )
        {
            int count = 0;
            for( int i = 0; i< arr.Length ; i++ )
            {
                if (arr[i] < 5)
                    count++;
            }
            return count;
        }

        private void displayHighestGradeSubjs(double[] arr)
        {
            double maxGrade = arr[0];
            for( int i = 1; i< arr.Length ; i++ )
            {
                if (arr[i] > maxGrade)
                    maxGrade = arr[i];
            }

            for(int i = 0; i< arr.Length ; i++ )
            {
                if (arr[i] == maxGrade)
                {
                    txtOutput.Text += "Môn học " + (i + 1) + " : " + arr[i] + " || ";
                }
            }
            txtOutput.Text += "\r\n";
        }

        private void displayLowestGradeSubjs(double[] arr)
        {
            double minGrade = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minGrade)
                    minGrade = arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == minGrade)
                {
                    txtOutput.Text += "Môn học " + (i + 1) + " : " + arr[i] + " || ";
                }
            }
            txtOutput.Text += "\r\n";
        }

        private void ranked(double[] arr)
        {
            double minGrade = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minGrade)
                    minGrade = arr[i];
            }

            if(calOverall(arr) >= 8 && minGrade >= 6.5)
            {
                txtOutput.Text += "Xếp loại học lực Giỏi.";
            }
            else if(calOverall(arr) >= 6.5 && minGrade >=5 )
            {
                txtOutput.Text += "Xếp loại học lực Khá.";
            }
            else if(calOverall(arr) >= 5 && minGrade >= 3.5)
            {
                txtOutput.Text += "Xếp loại học lực Trung Bình.";
            }
            else if(calOverall(arr) >= 3.5 && minGrade >= 2)
            {
                txtOutput.Text += "Xếp loại học lực Yếu.";
            }
            else
            {
                txtOutput.Text += "Xếp loại học lực Kém.";
            }    
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            if(txtInput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
                return;
            }

            string input = txtInput.Text;
            string[] tmp = input.Split(',');
            int n = tmp.Length;
            double[] marks = new double[n-1];
            string name = tmp[0];

            for( int i = 1; i < n; i++)
            {
                if (double.Parse(tmp[i]) > 10 || double.Parse(tmp[i]) < 0)
                {
                    MessageBox.Show("Điểm nhập không hợp lệ. Hãy nhập lại!");
                    return;
                }
                marks[i-1] = Double.Parse(tmp[i]);
            }

            txtOutput.Text = "Họ và tên : " + tmp[0] + "\r\n";
            display(marks);
            txtOutput.Text += "Điểm trung bình : " + calOverall(marks) + "\r\n";
            txtOutput.Text += "Môn học cao điểm nhất : \r\n";
            displayHighestGradeSubjs(marks);
            txtOutput.Text += "Môn học thấp điểm nhất : \r\n";
            displayLowestGradeSubjs(marks);
            txtOutput.Text += "Số môn học đậu : " + countPassedSubjects(marks) + "\r\n";
            txtOutput.Text += "Số môn học rớt : " + countFailedSubjects(marks) + "\r\n";
            ranked(marks);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach( Control ctrl in this.Controls )
            {
                if(ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
            }    
            txtOutput.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
