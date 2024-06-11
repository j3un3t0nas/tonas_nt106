using System;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;

namespace Bai01_Lab05
{
    public partial class Bai1_LAB05 : Form
    {
        public Bai1_LAB05()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String email = txtFormAdd.Text;
            String pw = "qvxn mnry iqik sagz";
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(email, pw),
                EnableSsl = true
            };


            MailAddress from = new MailAddress(txtFormAdd.Text, "22521311");
            MailMessage message = new MailMessage()
            {
                From = from,
                Subject = txtSubject.Text,
                Body = txtBody.Text
            };

            message.To.Add(txtToAdd.Text);

            client.Send(message);
            MessageBox.Show("Đã gửi mail");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubject.Clear();
            txtBody.Clear();
        }

    }
}
