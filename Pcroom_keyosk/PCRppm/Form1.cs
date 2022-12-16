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

    // import 부분은 제외하였습니다.
    public partial class Form1 : Form
    {
        // 충전 시간
        public static int time;
        // 사용자에게 결제 받아야할 금액
        public static int price;
        // 시간 객체
        DateTime nowTime;
        private static System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();
            //1초 마다 폼의 시간을 갱신
            timer1.Interval = 1000;
            nowTime = DateTime.Now;
        }

        // 사용자가 결제할 상품의 시간을 반환하는 메서드
        public int getClickTime()
        {
            return time;
        }
        // 사용자가 결제할 상품의 금액을 반환하는 메서드
        public int getClickPrcie()
        {
            return price;
        }
        // 현재 시간을 반환하는 메서드
        public DateTime getTime ()
        {
            return nowTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 로드시 시작
            timer1.Start();
            // 폼의 우측 상단 시간을 최신화
            label1.Text = DateTime.Now.ToShortTimeString(); ;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 폼의 우측 상단 시간을 최신화
            label1.Text = DateTime.Now.ToShortTimeString();
        }

        // 회원가입버튼
        private void button11_Click(object sender, EventArgs e)
        {
            // Register 객체 생성 후 폼 로드
            Register register = new Register();
            register.ShowDialog();
        }
        // button1 부터 button10까지는 시간 충전 버튼, 
        private void button1_Click(object sender, EventArgs e)
        {
            // 금액과 시간을 지정
            price = 1000;
            time = 1;
            // Login 객체 생성 후 폼 로드
            Login login = new Login();
            login.ShowDialog();
        }
        // button1 부터 button10까지 내부 구조가 같으므로 주석 생략, 
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

    }
}
