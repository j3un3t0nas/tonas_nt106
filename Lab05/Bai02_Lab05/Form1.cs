using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Search;
using MimeKit;

namespace Bai02_Lab05
{
    public partial class Form1 : Form
    {
        private ImapClient imapClient;
        private Pop3Client pop3Client;
        public Form1()
        {
            InitializeComponent();
            btnLogout.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            imapClient = new ImapClient();
            imapClient.Connect("imap.gmail.com", 993, true);
            imapClient.Authenticate(txtEmail.Text, txtPass.Text);


            dataGridView1.Columns.Add("Subject", "Subject");
            dataGridView1.Columns.Add("From", "From");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns["Subject"].ReadOnly = true;
            dataGridView1.Columns["From"].ReadOnly = true;
            dataGridView1.Columns["Date"].ReadOnly = true;
            dataGridView1.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["From"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            int limit = 0;
            var inbox = imapClient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            for (int i = inbox.Count - 1; i > 0; i--)
            {
                limit++;
                var message = inbox.GetMessage(i);
                string subject = message.Subject;
                string from = message.From.ToString();
                DateTime date = message.Date.DateTime;
                dataGridView1.Rows.Add(subject, from, date);
                if (limit == 6)
                {
                    break;
                }
            }

            btnLogout.Enabled = true;
            btnIMAP.Enabled = false;
            btnPOP.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imapClient != null)
                imapClient.Disconnect(true);

            if (pop3Client != null)
                imapClient.Disconnect(true);

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            btnLogout.Enabled = false;
            btnIMAP.Enabled = true;
            btnPOP.Enabled = true;
            
            MessageBox.Show("Đã ngắt kết nối");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            pop3Client = new Pop3Client();
            pop3Client.Connect("pop.gmail.com", 995, true);
            pop3Client.Authenticate(txtEmail.Text, txtPass.Text);


            dataGridView1.Columns.Add("Subject", "Subject");
            dataGridView1.Columns.Add("From", "From");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns["Subject"].ReadOnly = true;
            dataGridView1.Columns["From"].ReadOnly = true;
            dataGridView1.Columns["Date"].ReadOnly = true;
            dataGridView1.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["From"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            int count = 0;
            for (int i = 0; i < pop3Client.Count && count < 6; i++)
            {
                var message = pop3Client.GetMessage(i);
                string subject = message.Subject;
                string from = message.From.ToString();
                DateTime date = message.Date.DateTime;
                dataGridView1.Rows.Add(subject, from, date);
                count++;
            }

            btnLogout.Enabled = true;
            btnIMAP.Enabled = false;
            btnPOP.Enabled = false;
        }
    }
}
