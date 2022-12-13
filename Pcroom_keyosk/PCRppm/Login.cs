using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Oracle.DataAccess.Client;
using System.Xml.Linq;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.NetworkInformation;

namespace PCRppm
{
    public partial class Login : Form
    {
        public static String userId;
        private void loadKeyboard()
        {
            var path64 = System.IO.Path.Combine(Directory.GetDirectories(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "winsxs"), "amd64_microsoft-windows-osk_*")[0], "osk.exe");
            var path32 = @"C:\windows\system32\osk.exe";
            var path = (Environment.Is64BitOperatingSystem) ? path64 : path32;
            if (File.Exists(path))
            {
                Process.Start(path);
            }
        }

        private void killKeyboard()
        {
            System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName("osk");
            for (int i = 0; i < procs.Length; i++)
            {
                procs[i].Kill();
            }
        }
        // Data Provider인 DBAdapter 입니다.
        OracleDataAdapter DBAdapter;

        // DataSet 객체입니다.
        DataSet DS;

        // 추가, 수정, 삭제시에 필요한 명령문을 
        // 자동으로 작성해주는 객체입니다.
        OracleCommandBuilder myCommandBuilder;

        // ataTable 객체입니다.
        DataTable userData;

        public String getUserId ()
        {
            return userId;
        }

        private void DB_Open()
        {
            try
            {
                string connectionString = ConnectionClass.returnConnectionString();
                string commandString = "select USER_ID, USER_PASSWORD from USER_DATA ";

                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);

                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public Login()
        {
            InitializeComponent();
            DB_Open();
        }     

        private void idTextBox_Click(object sender, EventArgs e)
        {
            loadKeyboard();
        }

        private void passwordTextbox_Click(object sender, EventArgs e)
        {
            loadKeyboard();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passwordTextbox.PasswordChar = default(char);
            }
            else
            {
                passwordTextbox.PasswordChar = '*';
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            killKeyboard();
            DS.Clear();
            DBAdapter.Fill(DS, "USER_DATA");
            userData = DS.Tables["USER_DATA"];
            int rowCount = DS.Tables[0].Rows.Count;

            for (int index = 0; index < rowCount;index++)
            {
                if (idTextBox.Text.Equals(""))
                {
                    MessageBox.Show((String)"아이디가 공백입니다.");
                    idTextBox.Focus();
                    break;
                }
                else if (passwordTextbox.Text.Equals(""))
                {
                    MessageBox.Show((String)"패스워드가 공백입니다.");
                    passwordTextbox.Focus();
                    break;
                }
                else if (userData.Rows[index]["USER_ID"].ToString().Equals(idTextBox.Text) && userData.Rows[index]["USER_PASSWORD"].ToString().Equals(passwordTextbox.Text))
                {
                    userId = idTextBox.Text;
                    MessageBox.Show((String)"로그인 되었습니다.");
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    Close();
                    break;   
                }
                else if (rowCount - 1 == index)
                {
                    MessageBox.Show((String)"아이디 혹은 비밀번호가 틀렸습니다.");
                    idTextBox.Focus();
                    break;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            killKeyboard();
            Close();
        }
        public String TxtS
        {
            get { return idTextBox.Text; }
            set { idTextBox.Text = value.ToString(); }
        }

        

        private void passwordTextbox_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"([a-zA-Z0-9]){8,16}\w+");
            Boolean ismatch = regex.IsMatch(idTextBox.Text);
            if (!ismatch)
            {
                MessageBox.Show("영문자만 입력해 주세요.");
            }
        }
    }
}
