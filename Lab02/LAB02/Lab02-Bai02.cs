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

namespace LAB02
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string fileName;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if( !string.IsNullOrEmpty( ofd.FileName ) ) 
            {
                fileName = ofd.SafeFileName.ToString();
                FileStream fs = new FileStream( ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                rtbData.Text = sr.ReadToEnd();
                txtFileName.Text = fileName;
                txtPath.Text = fs.Name.ToString();
                txtSize.Text = fs.Length.ToString() + " bytes";
                txtLineCount.Text = lineCount(sr).ToString();
                txtWordCount.Text = wordCount(sr).ToString();
                txtCharCount.Text = charCount(sr).ToString();
                
                sr.Close();
                fs.Close();
            }
        }

        private int lineCount( StreamReader sr )
        {
            int lineCount = 0;
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            return lineCount;
        }

        private int wordCount(StreamReader sr)
        {
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string context = sr.ReadToEnd();
            if (string.IsNullOrEmpty(context))
            {
                return 0;
            }

            int wordCount = 1;
            foreach (char c in context)
            {
                if (c == ' ' || c == '\n')
                    wordCount++;
            }

            return wordCount;


            /*
            int wordCount = 0;

            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string line;


            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                wordCount += words.Length;
            }
            */
        }

        private int charCount(StreamReader sr)
        {
            sr.BaseStream.Seek(0,SeekOrigin.Begin);
            string context = sr.ReadToEnd();
            int charCount = context.Length;

            return charCount;

        }

    }
}
