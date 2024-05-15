using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03_Lab03
{
    public partial class TCP_Client : Form
    {

        TcpClient tcpClient;
        NetworkStream ns;

        public TCP_Client()
        {
            InitializeComponent();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        { 
            tcpClient = new TcpClient();

            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 8080);

            tcpClient.Connect(iPEndPoint);
            ns = tcpClient.GetStream();

            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            btnSend.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            Byte[] data = System.Text.Encoding.UTF8.GetBytes(txtMessages.Text);
            ns.Write(data, 0, data.Length);
            ns.Flush();
            txtMessages.Clear();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.UTF8.GetBytes("Client ngắt kết nối\n");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
        }

    }
}
