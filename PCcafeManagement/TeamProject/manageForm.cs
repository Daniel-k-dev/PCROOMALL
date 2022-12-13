using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TeamProject
{
    public partial class ManageForm : Form
    {
        ConnInformation connClass = new ConnInformation();
        private OracleConnection odpConn = new OracleConnection();
        public ManageForm()
        {
            InitializeComponent();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            DateTime date_time = dateTimePicker1.Value;
            string date = Convert_date(date_time);
            day_income.Text = Get_income_of_the_day(date).ToString() + "원"; //현재 날짜 기준 일일 매출
            mon_income.Text = Get_income_of_the_month().ToString() + "원"; //현재 날짜 기준 월간 매출
        }
        private string Convert_date(DateTime date_time) //날짜 형식 db방식으로 전환 ex) 2022-12-11
        {
            string text;
            string year = date_time.Year.ToString();
            text = year + '-' + date_time.Month.ToString() + '-' + date_time.Day.ToString();
            return text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //달력 날짜 변경 시 동작
        {
            string date = Convert_date(dateTimePicker1.Value);
            day_income.Text = Get_income_of_the_day(date).ToString() + "원"; //달력 날짜 기준 일일 매출 

        }
        private int Get_income_of_the_month() //월간 매출 계산
        {
            DateTime now = DateTime.Now;
            DateTime firstDay = new DateTime(now.Year, now.Month, 1); //현재 달 기준 첫번째 날
            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1); //현재 달 기준 마지막 날
            int sum = 0;
            for (DateTime date=firstDay; date <= lastDay; date=date.AddDays(1)) //첫번째 날 부터 마지막 날까지 반목문 수행
            {
                string date_data = Convert_date(date);
                int cost = Get_income_of_the_day(date_data);
                sum += cost;
            }
            return sum;
        }
        private int Get_income_of_the_day(string date) //일일 매출 계산
        {
            int[] menu_id_arr = Get_menu_id_arr_for_day(date);
            int[] quan_arr = Get_order_quan_arr_for_day(date);
            int sum = 0;
            for (int i=0; i<menu_id_arr.Length; i+=1)
            {
                if (menu_id_arr[i] != 0)
                {
                    int price = Get_menu_price(menu_id_arr[i]);
                    int quantity = quan_arr[i];
                    int cost = price * quantity;
                    sum += cost;
                }         
            }
            return sum;
        }
        private int[] Get_menu_id_arr_for_day(string day) //menu_id 배열 형태로 가져오기
        {
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            try
            {
                string strqry = "SELECT * from orderlist WHERE orderdate=:setd";
                OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
                OraCmdS.Parameters.Add("setd", OracleDbType.Char).Value = day;
                OracleDataReader rdr = OraCmdS.ExecuteReader();
                int i = 0;
                int[] menu_id_arr = new int[rdr.RowSize];
                while (rdr.Read())
                {
                    // 필드 데이터 읽기
                    int menu_id = Convert.ToInt32(rdr["menu_id"]); //menu_id
                    menu_id_arr[i] = menu_id;
                    i += 1;
                }
                odpConn.Close();
                rdr.Close();
                return menu_id_arr;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                odpConn.Close();
                int[] t = new int[1];
                return t;
            }
        }
        private int[] Get_order_quan_arr_for_day (string day) //order_quntity 배열 형태로 가져오기
        {
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            try
            {
                string strqry = "SELECT * from orderlist WHERE orderdate=:setd";
                OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
                OraCmdS.Parameters.Add("setd", OracleDbType.Char).Value = day;
                OracleDataReader rdr = OraCmdS.ExecuteReader();
                int i = 0;
                int[] quantity_arr = new int[rdr.RowSize];
                while (rdr.Read())
                {
                    // 필드 데이터 읽기
                    int quantity = Convert.ToInt32(rdr["order_quantity"]); //주문량
                    quantity_arr[i] = quantity;
                    i += 1;
                }
                odpConn.Close();
                rdr.Close();
                return quantity_arr;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                odpConn.Close();
                int[] t = new int[1];
                return t;
            }
        }
        
        private int Get_menu_price(int menu_id) //메뉴 가격 data 반환
        {
            int result = 0;
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            string strqry = "SELECT * from foods WHERE id=:id";
            OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
            OraCmdS.Parameters.Add("id", OracleDbType.Int32).Value = menu_id;
            OracleDataReader rdr = OraCmdS.ExecuteReader();
            while (rdr.Read())
            {
                result = Convert.ToInt32(rdr["foodvalue"]);
            }
            odpConn.Close();
            rdr.Close();
            return result;
        }
     
        private void foodManageBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
