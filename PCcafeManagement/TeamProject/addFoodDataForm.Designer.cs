
namespace TeamProject
{
    partial class addFoodDataForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.ammTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imgTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(80, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(158, 38);
            this.idTxt.Multiline = true;
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(234, 36);
            this.idTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(49, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "음식이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(49, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "재고수량";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(158, 96);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(234, 35);
            this.nameTxt.TabIndex = 6;
            // 
            // ammTxt
            // 
            this.ammTxt.Location = new System.Drawing.Point(158, 204);
            this.ammTxt.Multiline = true;
            this.ammTxt.Name = "ammTxt";
            this.ammTxt.Size = new System.Drawing.Size(234, 36);
            this.ammTxt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("새굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(116, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("새굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(241, 370);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11F);
            this.label4.Location = new System.Drawing.Point(68, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "가격";
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(158, 254);
            this.priceText.Multiline = true;
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(234, 36);
            this.priceText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11F);
            this.label5.Location = new System.Drawing.Point(49, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "카테고리";
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(158, 147);
            this.categoryTxt.Multiline = true;
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(234, 35);
            this.categoryTxt.TabIndex = 13;
            this.categoryTxt.TextChanged += new System.EventHandler(this.categoryTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11F);
            this.label6.Location = new System.Drawing.Point(59, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "이미지";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // imgTxt
            // 
            this.imgTxt.Location = new System.Drawing.Point(158, 299);
            this.imgTxt.Multiline = true;
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.Size = new System.Drawing.Size(234, 36);
            this.imgTxt.TabIndex = 15;
            // 
            // addFoodDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 417);
            this.Controls.Add(this.imgTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ammTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label1);
            this.Name = "addFoodDataForm";
            this.Text = "addFoodDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox ammTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imgTxt;
    }
}