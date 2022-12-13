namespace PCRppm
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.compaerPasswordTextbox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.doubleCheck = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idTextBox.Location = new System.Drawing.Point(459, 285);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(400, 63);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Click += new System.EventHandler(this.idTextBox_Click);
            this.idTextBox.Leave += new System.EventHandler(this.idTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordTextBox.Location = new System.Drawing.Point(459, 386);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(400, 63);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            // 
            // compaerPasswordTextbox
            // 
            this.compaerPasswordTextbox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.compaerPasswordTextbox.Location = new System.Drawing.Point(459, 471);
            this.compaerPasswordTextbox.Name = "compaerPasswordTextbox";
            this.compaerPasswordTextbox.Size = new System.Drawing.Size(400, 63);
            this.compaerPasswordTextbox.TabIndex = 3;
            this.compaerPasswordTextbox.Click += new System.EventHandler(this.compaerPasswordTextbox_Click);
            this.compaerPasswordTextbox.Leave += new System.EventHandler(this.compaerPasswordTextbox_Leave);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(218, 832);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(400, 100);
            this.submit.TabIndex = 6;
            this.submit.Text = "확인";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(152, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(152, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "패스워드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(152, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "패스워드 확인";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(510, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 86);
            this.label4.TabIndex = 7;
            this.label4.Text = "회원가입";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(152, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "생년월일 6자리";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateOfBirth.Location = new System.Drawing.Point(459, 558);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(400, 63);
            this.dateOfBirth.TabIndex = 4;
            this.dateOfBirth.Click += new System.EventHandler(this.dateOfBirth_Click);
            this.dateOfBirth.Leave += new System.EventHandler(this.dateOfBirth_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(152, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 50);
            this.label6.TabIndex = 9;
            this.label6.Text = "생년월일 6자리";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(704, 832);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(400, 100);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "취소";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameTextBox.Location = new System.Drawing.Point(459, 199);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(400, 63);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(152, 202);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(96, 50);
            this.name.TabIndex = 12;
            this.name.Text = "이름";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phoneNumber.Location = new System.Drawing.Point(459, 645);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(400, 63);
            this.phoneNumber.TabIndex = 5;
            this.phoneNumber.Click += new System.EventHandler(this.phoneNumber_Click);
            this.phoneNumber.Leave += new System.EventHandler(this.phoneNumber_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(152, 648);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 50);
            this.label7.TabIndex = 14;
            this.label7.Text = "전화번호";
            // 
            // doubleCheck
            // 
            this.doubleCheck.Location = new System.Drawing.Point(896, 285);
            this.doubleCheck.Name = "doubleCheck";
            this.doubleCheck.Size = new System.Drawing.Size(191, 63);
            this.doubleCheck.TabIndex = 15;
            this.doubleCheck.Text = "중복 확인";
            this.doubleCheck.UseVisualStyleBackColor = true;
            this.doubleCheck.Click += new System.EventHandler(this.doubleCheck_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 722);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(475, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "전화번호는 \"-\" 없이 숫자만 입력해 주세요.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(666, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "아이디와 패스워드는 영문 대소문자 숫자만 입력 가능합니다.";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 1009);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doubleCheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.compaerPasswordTextbox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.idTextBox);
            this.Name = "Register";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox compaerPasswordTextbox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button doubleCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}