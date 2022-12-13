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
    public partial class SetQuantityAlarmForm : Form
    {
        ConnInformation connClass = new ConnInformation();
        private OracleConnection odpConn = new OracleConnection();
        FoodManageForm _parent;
        public SetQuantityAlarmForm(FoodManageForm inform1)
        {
            InitializeComponent();
            _parent = inform1;
        }
        private void SetQuantityAlarmForm_Load(object sender, EventArgs e)
        {
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            string strqry = "SELECT * FROM owner WHERE owner_id=:id";
            OracleCommand OraCmdS = new OracleCommand(strqry, odpConn);
            OraCmdS.Parameters.Add("id", OracleDbType.Varchar2, 20).Value = connClass.GetOwnerId();  //임시 owner id 사용
            OracleDataReader rdr = OraCmdS.ExecuteReader();
            while (rdr.Read())
            {
                // 필드 데이타 읽기
                int n = Convert.ToInt32(rdr["limit_value"]);

                // 데이타를 리스트박스에 추가
                numericUpDown1.Value = n;
            }
            rdr.Close();
            odpConn.Close();

        }

        private int UPDATERow()
        {
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            string strqry = "UPDATE owner SET limit_value=:limit_value WHERE owner_id='oqwfhhpiow'";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("limit_value", OracleDbType.Int32).Value = numericUpDown1.Text.Trim();
            return OraCmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UPDATERow() > 0)
            {
                MessageBox.Show("정상적으로 데이터가 업데이트됨!");
            }
            else MessageBox.Show("데이터 행이 업데이트되지 않음!");
            this.Close();
        }

        
    }
}
