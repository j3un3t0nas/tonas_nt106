using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newFood = txtInput.Text;
            lstbFoods.Items.Add(newFood);
            txtInput.Clear();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int randomNum = rd.Next(0 , lstbFoods.Items.Count);
            txtOutput.Text = (string)lstbFoods.Items[randomNum];
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
