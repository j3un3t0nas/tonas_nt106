using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02_LAB03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread)); 
            serverThread.Start();
        }

        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            
            // Khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];

            // Tạo socket bên gởi
            Socket clientSocket;

            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);

            listenerSocket.Listen(-1);

            clientSocket = listenerSocket.Accept();

            lstCommand.Items.Add(new ListViewItem("Đã có kết nối đến!"));

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv); 
                    text += Encoding.UTF8.GetString(recv);
                } while (text[text.Length - 1] != '\n');

                lstCommand.Items.Add(new ListViewItem(text));
            }

            listenerSocket.Close();
        }
    }
}
