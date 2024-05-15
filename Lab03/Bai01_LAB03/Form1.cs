using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01_LAB03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            UDP_Server server1 = new UDP_Server();
            server1.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            UDP_Client client1 = new UDP_Client();
            client1.Show();
        }
    }
}
