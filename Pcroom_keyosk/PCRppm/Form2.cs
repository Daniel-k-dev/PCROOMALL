using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PCRppm
{
    public partial class Form2 : Form
    {
        // 접속한 사용자 아이디
        String userId;
        new Login Parent;
        // Data Provider인 DBAdapter 입니다.
        OracleDataAdapter DBAdapter;

        // DataSet 객체입니다.
        DataSet DS;

        // 추가, 수정, 삭제시에 필요한 명령문을 
        // 자동으로 작성해주는 객체입니다.
        OracleCommandBuilder myCommandBuilder;

        // ataTable 객체입니다.
        DataTable userData;

        private void DB_Open()
        {
            try
            {
                string connectionString = ConnectionClass.returnConnectionString();
                string commandString = "select * from USER_DATA ";

                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);

                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public Form2()
        {
            InitializeComponent();
            DB_Open();
        }

        // 폼 종료
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 확인버튼 클릭 이벤트
        private void confirm_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            // 사용자가 선택한 상품의 시간 
            int time = form1.getClickTime();
            
            // 값 넘겨받아 시간 처리
            DS.Clear();
            DB_Open();
            DBAdapter.Fill(DS, "USER_DATA");
            userData = DS.Tables["USER_DATA"];
            int rowCount = DS.Tables[0].Rows.Count;
            // 탐색
            for (int index = 0; index < rowCount; index++)
            {
               // 사용자의 아이디를 찾아 충전
                if (userData.Rows[index]["USER_ID"].ToString().Equals(userId))
                {
                    int lefttime = Convert.ToInt32(userData.Rows[index]["LEFT_TIME"].ToString());
                    userData.Rows[index]["LEFT_TIME"] = (time * 60 * 60 ) + lefttime;
                    DBAdapter.Update(DS, "USER_DATA");
                    DS.AcceptChanges();//*
                }
            }
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            // 사용자가 선택한 상품의 시간을 받음
            int clickTime = form1.getClickTime();
            Login login = new Login();
            Parent = (Login) Owner;
            // 접속한 사용자의 아이디
            userId = login.getUserId();
            label1.Text = userId + " 님에게 " + clickTime + " 시간을 충전합니다.";
        }
    }
}
