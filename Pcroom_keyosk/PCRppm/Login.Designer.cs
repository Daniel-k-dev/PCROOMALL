namespace PCRppm
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(181, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "패스워드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(181, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "아이디";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("굴림", 18F);
            this.passwordTextbox.Location = new System.Drawing.Point(488, 274);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(400, 63);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.Click += new System.EventHandler(this.passwordTextbox_Click);
            this.passwordTextbox.Leave += new System.EventHandler(this.passwordTextbox_Leave);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("굴림", 18F);
            this.idTextBox.Location = new System.Drawing.Point(488, 155);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(400, 63);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.Click += new System.EventHandler(this.idTextBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(438, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 86);
            this.label4.TabIndex = 10;
            this.label4.Text = "로그인";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(99, 419);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(400, 100);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "확인";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(597, 419);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(400, 100);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(488, 366);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(194, 28);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "패스워드 표시";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 557);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.idTextBox);
            this.Name = "Login";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}