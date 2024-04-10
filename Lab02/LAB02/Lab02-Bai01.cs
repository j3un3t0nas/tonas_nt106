using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Lab02_Bai01 : Form
    {
        private string fileName;
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                if(string.IsNullOrEmpty(ofd.FileName))
                {
                    return;
                }    

                fileName = ofd.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                rtbOutput.Text = sr.ReadToEnd();
                fs.Close();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(rtbOutput.Text.ToUpper());
            sw.Flush();
            sw.Close();
        }
    }
}
