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
using Newtonsoft.Json;


namespace LAB02
{
    public partial class Lab02_Bai04 : Form
    {
        public class SinhVien
        {
            public string hoTen { get; set; }
            public int mssv { get; set; }
            public string sdt { get; set; }
            public float[] Marks { get; set; }
            public float dtb { get; set; }
        }
        List<SinhVien> lst = new List<SinhVien>();
        int stt;
        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        public Boolean checkPhoneNumber( string sdt )
        {
            if (sdt.Length == 10)
                return true;

            return false;
        }

        public Boolean checkID( string mssv )
        {
            if (mssv.Length == 8)
                return true;

            return false;
        }

        public Boolean checkMarks( string a,  string b, string c)
        {
            float m1, m2, m3;

            if (!float.TryParse(a, out m1) || m1 < 0 || m1 > 10 || !float.TryParse(b, out m2) || m2 < 0 || m2 > 10 || !float.TryParse(c, out m3) || m3 < 0 || m3 > 10)
                return false;

            return true;
        }

        private void hienThongTin()
        {
            if (stt >= 0 && stt < lst.Count)
            {
                var sv1 = lst[stt];
                txtOutName.Text = sv1.hoTen;
                txtOutID.Text = sv1.mssv.ToString();
                txtOutPhone.Text = sv1.sdt;
                txtOutMark1.Text = sv1.Marks[0].ToString();
                txtOutMark2.Text = sv1.Marks[1].ToString();
                txtOutMark3.Text = sv1.Marks[2].ToString();
                txtOutDTB.Text = sv1.dtb.ToString("F2");
            }
        }

        private void ShowInputFileContent()
        {
            try
            {
                string inputContent = File.ReadAllText("input4.txt");
                rtbList.Clear();

                List<SinhVien> lst1 = JsonConvert.DeserializeObject<List<SinhVien>>(inputContent);
                foreach (var sv in lst1 )
                {
                    if (checkPhoneNumber(sv.sdt) && checkID(sv.mssv.ToString()))
                    {
                        StringBuilder studentInfo = new StringBuilder();
                        studentInfo.AppendLine(sv.hoTen);
                        studentInfo.AppendLine($"{sv.mssv}");
                        studentInfo.AppendLine(sv.sdt);
                        for (int i = 0; i < sv.Marks.Length; i++)
                        {
                            if (i == sv.Marks.Length - 1)
                                studentInfo.AppendLine($"{sv.Marks[i]}0");
                            else studentInfo.AppendLine($"{sv.Marks[i]}");
                        }
                        rtbList.AppendText(studentInfo.ToString() + "\n\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc tệp tin: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtInName.Text) || !checkID(txtInID.Text)  || !checkPhoneNumber(txtInPhone.Text)  || !checkMarks(txtInMark1.Text, txtInMark2.Text, txtInMark3.Text))
            {
                MessageBox.Show("Thông tin không hợp lệ.Hãy nhập lại thông tin!");
                return;
            }

            SinhVien sv = new SinhVien
            {
                hoTen = txtInID.Text,
                mssv = int.Parse(txtInID.Text),
                sdt = txtInPhone.Text,
                Marks = new float[]
                {
                    float.Parse(txtInMark1.Text),
                    float.Parse(txtInMark2.Text),
                    float.Parse(txtInMark3.Text)
                }
            };
            lst.Add(sv);

            string json = JsonConvert.SerializeObject(lst);
            File.WriteAllText("input4.txt", json);

            MessageBox.Show("Sinh viên đã được thêm!");

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (stt < lst.Count - 1)
            {
                stt++;
                txtSTT.Text = stt.ToString(); 
                hienThongTin();
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if( stt >0 )
            {
                stt--;
                txtSTT.Text = stt.ToString();
                hienThongTin();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                ShowInputFileContent();
                string json = File.ReadAllText("input4.txt");
                lst = JsonConvert.DeserializeObject<List<SinhVien>>(json);

                foreach (var sv in lst)
                {
                    sv.dtb = sv.Marks.Average();
                }

                using (StreamWriter writer = new StreamWriter("output4.txt"))
                {
                    foreach (var sv in lst)
                    {
                        string studentInfo = $"{sv.hoTen}\r\n" +
                                                $"{sv.mssv}\r\n" +
                                                $"{sv.sdt}\r\n" +
                                                $"{sv.dtb:F2}\r\n";

                        writer.WriteLine(studentInfo);
                        writer.WriteLine();
                    }
                }
                stt = 0;
                hienThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc tệp tin: " + ex.Message);
            }
        }
    }
}
