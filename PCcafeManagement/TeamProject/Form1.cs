using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace TeamProject
{
    public partial class Form1 : Form
    {
        ConnInformation connClass = new ConnInformation();
        private OracleConnection odpConn = new OracleConnection();
        private OracleConnection odpConn2 = new OracleConnection();
        private int orderIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodManageForm frm = new FoodManageForm();
            frm.ShowDialog();
            frm.Dispose();
        }
        private void manageBtn_Click(object sender, EventArgs e)
        {
            ManageForm frm = new ManageForm();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orderIndex = Get_today_order_rows();
            Get_owner_id(connClass.GetOwnerId()); //임시 id 사용
            string[] user_arr;
            int[] seat_arr;
            user_arr = Get_user_from_seat(); //select user_id from seat where is_on=1; 배열
            seat_arr = Get_seat_num_from_seat(); //select seat_id from seat where is_on=1; 배열
            for (int i = 0; i < user_arr.Length; i += 1)
            {
                string text;
                int seat_num;
                Label label;
                if (user_arr[i] != null)
                {
                    text = Get_user_name_left_time(user_arr[i]);
                    seat_num = seat_arr[i];
                    label = find_label_num(seat_num);
                    label.Text = text;
                }
            }

        }
        private void Get_owner_id(string id)
        {
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            string strqry = "SELECT owner_id FROM owner WHERE owner_id=:id";
            OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
            OraCmdS.Parameters.Add("id", OracleDbType.Char).Value = id;
            OracleDataReader rdr = OraCmdS.ExecuteReader();
            while (rdr.Read())
            {
                label62.Text = rdr["owner_id"] as string;
            }
            rdr.Close();
            odpConn.Close();
        }
        private string[] Get_user_from_seat() //자리 이용중인 유저 아이디 배열에 추가
        {
            string[] arr = new string[16];
            OracleDataReader rdr = Get_data_reader_from_seat();
            int i = 0;
            while (rdr.Read())
            {
                // 필드 데이터 읽기
                string s = rdr["USER_ID"] as string;
                arr[i] = s;
                i += 1;
            }
            rdr.Close();
            odpConn.Close();
            return arr; 
        }
        private int[] Get_seat_num_from_seat() //자리 이용중인 seat number 배열에 추가
        {
            int[] arr = new int[16];
            OracleDataReader rdr = Get_data_reader_from_seat();
            int i = 0;
            while (rdr.Read())
            {
                // 필드 데이터 읽기
                int n = Convert.ToInt32(rdr["seat_id"]);
                arr[i] = n;
                i += 1;
            }
            rdr.Close();
            odpConn.Close();
            return arr;
        }
        private OracleDataReader Get_data_reader_from_seat() //이용중인 자리 select
        {
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            string strqry = "SELECT * FROM seat WHERE is_on=:bool";
            OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
            OraCmdS.Parameters.Add("bool", OracleDbType.Char).Value = '1';
            OracleDataReader rdr = OraCmdS.ExecuteReader();
            return rdr;
        }
        private string Get_user_name_left_time(string user_id) //user 정보 select, 이름, 남은시간 리턴
        {
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            string strqry = "SELECT * FROM user_data WHERE user_id=:user_id";
            OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
            OraCmdS.Parameters.Add("user_id", OracleDbType.Char).Value = user_id;
            OracleDataReader rdr = OraCmdS.ExecuteReader();
            string text = "";
            while (rdr.Read())
            {
                string name = rdr["user_name"] as string;
                int left_time = Convert.ToInt32(rdr["left_time"]);
                text = name + "\n" + Convert_left_time(left_time);
            }
            rdr.Close();
            odpConn.Close();
            return text;
        }
        private string Convert_left_time(int seconds) //시:분:초 형식으로 변환
        {    
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            seconds = (seconds % 3600) % 60;
            string result = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            return result;
        }
        private int Get_today_order_rows()  //당일 현재 주문 수량 반환
        {
            DateTime current = DateTime.Now;
            string day = Convert_date(current);
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            string strqry = "SELECT * from orderlist WHERE ORDERDATE=:setd";
            OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
            OraCmdS.Parameters.Add("setd", OracleDbType.Char).Value = day;
            OracleDataReader rdr = OraCmdS.ExecuteReader();
            

            int rows = 0;
            while (rdr.Read())
            {
                rows++;
            }
            odpConn.Close();
            rdr.Close() ;
            return rows;
        }
        private void Print_new_order_rows(int olderIndex, int newIndex) //추가된 주문 정보 메세지박스 출력
        {
            DateTime current = DateTime.Now;
            string day = Convert_date(current);
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            string strqry = "SELECT * from orderlist WHERE orderdate=:setd";
            OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
            OraCmdS.Parameters.Add("setd", OracleDbType.Char).Value = day;
            OracleDataReader rdr = OraCmdS.ExecuteReader();
            int index = 0;
            while (rdr.Read())
            {
                if (index == olderIndex)
                {
                    olderIndex++;
                    if (olderIndex <= newIndex)
                    {
                        //출력
                        int menu_id = Convert.ToInt32(rdr["menu_id"]); //menu_id
                        int quantity = Convert.ToInt32(rdr["order_quantity"]); //order_quantity 
                        string message = rdr["message"] as string; //message
                        int seat_id = Convert.ToInt32(rdr["seat_id"]); //seat_id
                        string menu_name = Get_menu_name(menu_id); //menu이름

                        string print_to_messageBox = "새로운 주문 입니다.\n" +
                            seat_id.ToString() + "번 자리에서 " + menu_name + "상품을 " + quantity.ToString() + "개 주문 하였습니다.\n" +
                            "요구사항: " + message;
                        MessageBox.Show(print_to_messageBox, "주문 확인");
                    }
                }
                index++;
            }
            odpConn.Close();
            rdr.Close();
        }
        private string Convert_date(DateTime date_time) //날짜 형식 db방식으로 전환 ex) 2022-12-11
        {
            string text;
            string year = date_time.Year.ToString();
            text = year + '-' + date_time.Month.ToString() + '-' + date_time.Day.ToString();
            return text;
        }
        private void button1_Click_1(object sender, EventArgs e) //주문체크 버튼 클릭 시 작동
        {
            int curRows = Get_today_order_rows(); //버튼 클릭 시점 주문량
            if (curRows > orderIndex) //추가로 주문이 들어온 경우
            {
                Print_new_order_rows(orderIndex, curRows);
                orderIndex = curRows;
            }
            else                    //추가로 주문이 들어오지 않은 경우
            {
                MessageBox.Show("주문이 없습니다.");
            }
            
        }
        private string Get_menu_name(int menu_id) //메뉴 이름 data 반환
        {
            string result = "";
            odpConn2.ConnectionString = connClass.GetConnStr();
            odpConn2.Open();
            string strqry = "SELECT * from foods WHERE id=:id";
            OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
            OraCmdS.Parameters.Add("id", OracleDbType.Int32).Value = menu_id;
            OracleDataReader rdr2 = OraCmdS.ExecuteReader();
            while (rdr2.Read())
            {
                result = rdr2["foodname"] as string;
            }
            odpConn2.Close();
            rdr2.Close();
            return result;
        }
        private Label find_label_num(int s_num)
        {
            switch (s_num)
            {
                case 1:
                    return label1;
                case 2:
                    return label2;
                case 3:
                    return label3;
                case 4:
                    return label4;
                case 5:
                    return label5;
                case 6:
                    return label6;
                case 7:
                    return label7;
                case 8:
                    return label8;
                case 9:
                    return label9;
                case 10:
                    return label10;
                case 11:
                    return label11;
                case 12:
                    return label12;
                case 13:
                    return label13;
                case 14:
                    return label14;
                case 15:
                    return label15;
                case 16:
                    return label16;
            }
            return label16;
        }
        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
