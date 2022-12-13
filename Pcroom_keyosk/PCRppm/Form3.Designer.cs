namespace PCRppm
{
    partial class Form3
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
            this.confirm = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(120, 302);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(203, 97);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "확인";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold);
            this.text.Location = new System.Drawing.Point(111, 66);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(565, 50);
            this.text.TabIndex = 1;
            this.text.Text = "카드 또는 현금을 투입해 주세요.";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold);
            this.price.Location = new System.Drawing.Point(208, 198);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(219, 50);
            this.price.TabIndex = 2;
            this.price.Text = "결제 금액 : ";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(453, 302);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(203, 97);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "취소";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.text);
            this.Controls.Add(this.confirm);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button cancel;
    }
}