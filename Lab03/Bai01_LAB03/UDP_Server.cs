using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bai01_LAB03
{
    public partial class UDP_Server : Form
    {
        private UdpClient udpClient;
        private bool isRunning = true;
        public UDP_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;

            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        public void serverThread()
        {
            int listenPort = Int32.Parse(txtPort.Text);
            udpClient = new UdpClient(listenPort);

            while (isRunning)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, listenPort);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.ToString() + " : " + returnData.ToString();
                InfoMessage(mess);
            }
        }

        public void InfoMessage(string message)
        {
            if (lstReiMessages.InvokeRequired)
            {
                lstReiMessages.BeginInvoke(new Action<string>(InfoMessage), message);
                lstReiMessages.Items.Add(message);
            }
        }
    }
}
