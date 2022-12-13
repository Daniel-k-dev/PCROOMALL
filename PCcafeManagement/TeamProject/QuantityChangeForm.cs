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
    public partial class QuantityChangeForm : Form       
    {
        ConnInformation connClass = new ConnInformation();
        private OracleConnection odpConn = new OracleConnection();
        FoodManageForm _parent;
        public QuantityChangeForm(FoodManageForm inform1)
        {
            InitializeComponent();
            _parent = inform1;
        }
        public string AmmText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e) //confirm
        {
            if (UPDATERow() > 0)
            {
                MessageBox.Show("정상적으로 데이터가 업데이트됨!");
            }
            else MessageBox.Show("데이터 행이 업데이트되지 않음!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int UPDATERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = connClass.GetConnStr();
            odpConn.Open();
            string strqry = "UPDATE foods SET quntity =:amm WHERE id =:id";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("amm", OracleDbType.Varchar2, 20).Value = textBox1.Text.Trim();
            OraCmd.Parameters.Add("id", OracleDbType.Int32).Value = _parent.getintID;

            return OraCmd.ExecuteNonQuery(); //업데이트되는 행수 반환 }
        }
    }
}
