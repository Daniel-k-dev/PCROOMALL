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
    public partial class FoodManageForm : Form
    {
        ConnInformation connClass = new ConnInformation();
        private int intID; //ID 필드 설정
        private OracleConnection odpConn = new OracleConnection();
        public int getintID
        { get { return intID; } }
        private void showDataGridView() //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = connClass.GetConnStr();
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT * from foods", odpConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }

        
        public FoodManageForm()
        {
            InitializeComponent();
            
        }
        private void FoodManageForm_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }

        private void button1_Click(object sender, EventArgs e) //확인
        {
            Close();
        }

       private void button2_Click(object sender, EventArgs e)  //재고변경
        {
            intID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            QuantityChangeForm qcForm = new QuantityChangeForm(this);
            qcForm.ShowDialog();
            qcForm.Dispose();
            showDataGridView();
        }

        private void button3_Click(object sender, EventArgs e) //음식추가
        {
            addFoodDataForm afForm = new addFoodDataForm(this);
            afForm.ShowDialog();
            afForm.Dispose();
            showDataGridView();
        }

        private void 이메일주소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetInformationForm iFrm = new SetInformationForm(this);
            iFrm.ShowDialog();
            iFrm.Dispose();
            showDataGridView();
        }

        private void 알림수량ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetQuantityAlarmForm qFrm = new SetQuantityAlarmForm(this);
            qFrm.ShowDialog();
            qFrm.Dispose();
            showDataGridView();
        }

        
    }
}
