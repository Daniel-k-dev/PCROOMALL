﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCRppm
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            // 결제할 금액을 불러와 표시
            price.Text += form1.getClickPrcie();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            // 충전확인 폼으로 이동
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Close();
        }
    }
}
