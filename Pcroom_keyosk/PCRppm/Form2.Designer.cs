namespace PCRppm
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(111, 257);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(294, 107);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "확인";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(175, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 50);
            this.label1.TabIndex = 14;
            this.label1.Text = "USER1 님에게 1 시간을 충전합니다.";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(557, 257);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(294, 107);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 456);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "충전";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
    }
}