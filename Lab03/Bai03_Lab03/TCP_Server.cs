using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Bai03_Lab03
{
    public partial class TCP_Server : Form
    {
        TcpListener server;
        IPEndPoint ep;
        public TCP_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {

            ep = new IPEndPoint(IPAddress.Any, 8080);
            server = new TcpListener(ep);
            Thread lis = new Thread(() => Listen(server));
            lis.Start();

            btnListen.Enabled = false;
        }

        void Listen(TcpListener listener)
        {
            listener.Start();
            CheckForIllegalCrossThreadCalls = false;
            btnListen.Enabled = false;
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                txtMessages.Text += "Kết nối từ : " + client.Client.RemoteEndPoint + "\r\n";
                Receive(client);
                txtMessages.Text += "Ngắt kết nối từ : " + client.Client.RemoteEndPoint + "\r\n";
            }
        }

        void Receive(TcpClient client)
        {
            byte[] Data = new byte[256];
            String Mes = null;
            NetworkStream stream = client.GetStream();
            int i;
            while ((i = stream.Read(Data, 0, Data.Length)) != 0)
            {
                Mes = System.Text.Encoding.UTF8.GetString(Data, 0, i);
                txtMessages.Text += "Client: " + Mes + "\r\n";
            }
        }
    }
}
