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
using System.Text.RegularExpressions;
using Oracle.DataAccess.Client;
using System.Data.Common;
using System.Management.Instrumentation;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using System.Windows.Input;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Runtime.Remoting.Messaging;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace PCRppm
{

    public partial class Register : Form
    {
        private bool double_check = false;
        private void LoadKeyboard()
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

        private void regularExpressionEN_NUM(TextBox text)
        {
            Regex regex = new Regex(@"([a-zA-Z0-9]){8,16}\w+");
            Boolean ismatch = regex.IsMatch(idTextBox.Text);
            if (!ismatch)
            {
                MessageBox.Show("영문 소문자, 대문자 숫자 8자리에서 16자리 까지만 입력 가능합니다.");
                text.Focus();
            }
        }

        private void regularExpressionNUM(int col, TextBox text)
        {
            Regex regex = new Regex(@"([0-9]){6}\w+");
            Boolean ismatch = regex.IsMatch(text.Text);
            if (!ismatch)
            {
                MessageBox.Show("숫자 6자리 까지만 입력 가능합니다.");
                text.Focus();
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

        private void DB_Open()
        {
            try
            {
                string connectionString = ConnectionClass.returnConnectionString();
                string commandString = "select * from USER_DATA ";

                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);

                DS = new DataSet();
                DBAdapter.Fill(DS);
                userData = DS.Tables["USER_DATA"];
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public Register()
        {
            InitializeComponent();
            DB_Open();
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            LoadKeyboard();
        }

        private void idTextBox_Click(object sender, EventArgs e)
        {
            LoadKeyboard();
        }
        private void doubleCheck_Click(object sender, EventArgs e)
        {
            if (double_check == false)
            {

                string connectionString = ConnectionClass.returnConnectionString();
                string query = "select * from USER_DATA";
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                OracleCommand comm = new OracleCommand(query, conn);
                OracleDataReader sr = comm.ExecuteReader();

                List <String> idlist = new List<string> ();

                int rowCount = 0;
                while (sr.Read())
                {
                    rowCount++;
                    idlist.Add((String) sr.GetString(0));
                }

                Console.WriteLine(idlist);

                for (int index = 0; index < rowCount;index++)
                {
                    if (idTextBox.Text.Equals(""))
                    {
                        MessageBox.Show((String)"입력란이 공백입니다.");
                        idTextBox.Focus();
                        break;
                    }
                    if (idlist[index].Equals(idTextBox.Text))
                    {
                        MessageBox.Show((String)"이미 사용중인 아이디 입니다.");
                        break;
                    }
                    else if (rowCount -1 == index)
                    {
                        double_check = true;
                        MessageBox.Show((String)"사용 가능한 아이디 입니다.");
                        break;
                    }
                }
                
                sr.Close();
                conn.Close();

            }
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            LoadKeyboard();
        }
        private void compaerPasswordTextbox_Click(object sender, EventArgs e)
        {
            LoadKeyboard();
        }
        private void dateOfBirth_Click(object sender, EventArgs e)
        {
            LoadKeyboard();
        }
        private void phoneNumber_Click(object sender, EventArgs e)
        {
            LoadKeyboard();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            killKeyboard();
            List <TextBox> list = new List <TextBox>(new TextBox[]
            {
                nameTextBox, idTextBox, passwordTextBox, compaerPasswordTextbox,
                dateOfBirth, phoneNumber
            });
            List<String> msglist = new List<String>(new String[]
            {
                "이름을 입력해주세요", "id를 입력해주세요", "비밀번호를 입력해주세요",
                "비밀번호 확인을 입력해주세요","생년월일을 입력해주세요","전화번호를 입력해주세요"
            });

            for (int index = 0; index < list.Count ; index++)
            {
                if (list[index].Text == "")
                {
                    MessageBox.Show((String)msglist[index]);
                    list[index].Focus();
                    break;
                }

                if (index == list.Count - 1)
                {
                    if (double_check == false)
                    {
                        MessageBox.Show((String)"중복확인을 해주세요");
                    }
                    else if (passwordTextBox.Text != compaerPasswordTextbox.Text)
                    {
                        MessageBox.Show((String)"비밀번호가 다릅니다.");
                        passwordTextBox.Focus();
                    }
                    else
                    {
                        try
                        {
                            DS.Clear();

                            DBAdapter.Fill(DS, "USER_DATA");
                            userData = DS.Tables["USER_DATA"];//*
                            DataRow newRow = userData.NewRow();

                            newRow["USER_ID"] = idTextBox.Text;
                            newRow["USER_NAME"] = nameTextBox.Text;
                            newRow["PHONENUMBER"] = phoneNumber.Text;
                            newRow["LEFT_TIME"] = 0;
                            newRow["USER_PASSWORD"] = passwordTextBox.Text;

                            userData.Rows.Add(newRow);
                            DBAdapter.Update(DS, "USER_DATA");
                            DS.AcceptChanges();//*

                        }
                        catch (DataException DE)
                        {
                            MessageBox.Show(DE.Message);
                        }
                        catch (Exception DE)
                        {
                            MessageBox.Show(DE.Message);
                        }
                    }
                }
            }
            Close();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("이름이 공백입니다.");
                nameTextBox.Focus();
            }
        }

        private void idTextBox_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(){1,16}\w+");
            Boolean ismatch = regex.IsMatch(idTextBox.Text);
            if (!ismatch)
            {
                MessageBox.Show("아이디는 자리에서 16자리까지 가능합니다.");
                idTextBox.Focus();
            }
        }

        private void compaerPasswordTextbox_Leave(object sender, EventArgs e)
        {
            regularExpressionEN_NUM(compaerPasswordTextbox);
        }

        private void dateOfBirth_Leave(object sender, EventArgs e)
        {

            Regex regex = new Regex(@"([0-9]){6}");
            Boolean ismatch = regex.IsMatch(dateOfBirth.Text);
            if (!ismatch)
            {
                MessageBox.Show("숫자 6자리 까지만 입력 가능합니다.");
                dateOfBirth.Focus();
            }
        }

        private void phoneNumber_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"([0-9]){11}");
            Boolean ismatch = regex.IsMatch(phoneNumber.Text);
            if (!ismatch)
            {
                MessageBox.Show("'-' 제외 숫자만 입력해 주세요.");
                phoneNumber.Focus();
            }
        }

        
    }
}
