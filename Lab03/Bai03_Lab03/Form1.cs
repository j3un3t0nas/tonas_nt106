using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03_Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTCPServer_Click(object sender, EventArgs e)
        {
            TCP_Server server1 = new TCP_Server();
            server1.Show();
        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
            TCP_Client client1 = new TCP_Client();
            client1.Show();
        }
    }
}
