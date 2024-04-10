using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB02
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName))
                return;

            StreamReader sr = new StreamReader(ofd.FileName);
            rtbData.Text = sr.ReadToEnd();
            sr.Close();
        }




        private void btnWrite_Click(object sender, EventArgs e)
        {
            string[] lines = rtbData.Lines;
            FileStream fs = new FileStream("output3.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (string line in lines)
            {
                double result = Compute(line);
                sw.WriteLine($"{line} = {result}");
            }
            sw.Flush();
            fs.Close();
        }


        static double Compute(string line)
        {
            string[] part = line.Split(' ');
            part = part.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            double result = double.Parse(part[0]);
            for (int i = 1; i < part.Length; i++)
            {
                switch (part[i])
                {
                    case "+":
                        result += double.Parse(part[i + 1]);
                        break;
                    case "-":
                        result -= double.Parse(part[i + 1]);
                        break;
                    case "*":
                        result *= double.Parse(part[i + 1]);
                        break;
                    case "/":
                        result /= double.Parse(part[i + 1]);
                        break;
                }
            }
            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
