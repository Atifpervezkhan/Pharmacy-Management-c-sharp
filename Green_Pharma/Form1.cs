using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Pharma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int startpoint = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressBar1.Value = startpoint;
            Percentage.Text = startpoint + "%";
            if (ProgressBar1.Value == 100)
            {

                ProgressBar1.Value = 0;
                Timer1.Stop();
                Login Obj = new Login();
                this.Hide();
                Obj.Show();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
