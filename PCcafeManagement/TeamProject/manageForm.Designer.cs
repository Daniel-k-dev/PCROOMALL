namespace TeamProject
{
    partial class ManageForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.day_income = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mon_income = new System.Windows.Forms.Label();
            this.foodManageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 27);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(202, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "매출: ";
            // 
            // day_income
            // 
            this.day_income.AutoSize = true;
            this.day_income.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day_income.Location = new System.Drawing.Point(271, 40);
            this.day_income.Name = "day_income";
            this.day_income.Size = new System.Drawing.Size(33, 20);
            this.day_income.TabIndex = 2;
            this.day_income.Text = "cal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(128, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "이번 달 매출: ";
            // 
            // mon_income
            // 
            this.mon_income.AutoSize = true;
            this.mon_income.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mon_income.Location = new System.Drawing.Point(271, 95);
            this.mon_income.Name = "mon_income";
            this.mon_income.Size = new System.Drawing.Size(33, 20);
            this.mon_income.TabIndex = 4;
            this.mon_income.Text = "cal";
            // 
            // foodManageBtn
            // 
            this.foodManageBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.foodManageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.foodManageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.foodManageBtn.Location = new System.Drawing.Point(98, 151);
            this.foodManageBtn.Name = "foodManageBtn";
            this.foodManageBtn.Size = new System.Drawing.Size(183, 46);
            this.foodManageBtn.TabIndex = 5;
            this.foodManageBtn.Text = "확인";
            this.foodManageBtn.UseVisualStyleBackColor = false;
            this.foodManageBtn.Click += new System.EventHandler(this.foodManageBtn_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(376, 221);
            this.Controls.Add(this.foodManageBtn);
            this.Controls.Add(this.mon_income);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.day_income);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ManageForm";
            this.Text = "manageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label day_income;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mon_income;
        private System.Windows.Forms.Button foodManageBtn;
    }
}