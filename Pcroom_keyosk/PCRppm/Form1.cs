using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PCRppm
{
   
    public partial class Form1 : Form
    {
        public static int time;
        public static int price;
        DateTime nowTime;
        private static System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            nowTime = DateTime.Now;
        }
        public int getClickTime()
        {
            return time;
        }
        public int getClickPrcie()
        {
            return price;
        }
        public DateTime getTime ()
        {
            return nowTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            label1.Text = DateTime.Now.ToShortTimeString(); ;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            price = 1000;
            time = 1;
            Login login = new Login();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            price = 2000;
            time = 2;
            Login login = new Login();
            login.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            price = 3000;
            time = 3;
            Login login = new Login();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            price = 5000;
            time = 5;
            Login login = new Login();
            login.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            price = 7000;
            time = 7;
            Login login = new Login();
            login.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            price = 9500;
            time = 10;
            Login login = new Login();
            login.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            price = 10500;
            time = 12;
            Login login = new Login();
            login.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            price = 16000;
            time = 18;
            Login login = new Login();
            login.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            price = 20000;
            time = 24;
            Login login = new Login();
            login.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            price = 30000;
            time = 36;
            Login login = new Login();
            login.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
