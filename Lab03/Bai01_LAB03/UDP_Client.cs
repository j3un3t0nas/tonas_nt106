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

namespace Bai01_LAB03
{
    public partial class UDP_Client : Form
    {
        public UDP_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int sendPort = Int32.Parse(txtPort.Text);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(txtHostIP.Text), sendPort);
            UdpClient udpClient = new UdpClient();

            Byte[] sendBytes = Encoding.UTF8.GetBytes(txtMessages.Text);
            udpClient.Send(sendBytes, sendBytes.Length, endPoint);

            txtMessages.Clear();
        }
    }
}
