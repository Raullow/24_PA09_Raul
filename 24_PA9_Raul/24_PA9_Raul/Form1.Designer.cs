﻿namespace _24_PA9_Raul
{
    partial class Form1
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
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.rdb_japaneseyen = new System.Windows.Forms.RadioButton();
            this.rdb_usdollar = new System.Windows.Forms.RadioButton();
            this.txt_convertedamount = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rdb_MalaysianRinggit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(250, 90);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(240, 26);
            this.txt_amount.TabIndex = 0;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(50, 90);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(65, 20);
            this.lbl_amount.TabIndex = 1;
            this.lbl_amount.Text = "Amount";
            this.lbl_amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.Location = new System.Drawing.Point(50, 225);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(121, 20);
            this.lbl_currency.TabIndex = 2;
            this.lbl_currency.Text = "Select Currency";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(50, 358);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(50, 20);
            this.lbl_value.TabIndex = 3;
            this.lbl_value.Text = "Value";
            // 
            // rdb_japaneseyen
            // 
            this.rdb_japaneseyen.AutoSize = true;
            this.rdb_japaneseyen.Location = new System.Drawing.Point(250, 188);
            this.rdb_japaneseyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_japaneseyen.Name = "rdb_japaneseyen";
            this.rdb_japaneseyen.Size = new System.Drawing.Size(137, 24);
            this.rdb_japaneseyen.TabIndex = 4;
            this.rdb_japaneseyen.TabStop = true;
            this.rdb_japaneseyen.Text = "Japanese Yen";
            this.rdb_japaneseyen.UseVisualStyleBackColor = true;
            // 
            // rdb_usdollar
            // 
            this.rdb_usdollar.AutoSize = true;
            this.rdb_usdollar.Location = new System.Drawing.Point(250, 223);
            this.rdb_usdollar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_usdollar.Name = "rdb_usdollar";
            this.rdb_usdollar.Size = new System.Drawing.Size(99, 24);
            this.rdb_usdollar.TabIndex = 5;
            this.rdb_usdollar.TabStop = true;
            this.rdb_usdollar.Text = "Us Dollar";
            this.rdb_usdollar.UseVisualStyleBackColor = true;
            // 
            // txt_convertedamount
            // 
            this.txt_convertedamount.Location = new System.Drawing.Point(250, 358);
            this.txt_convertedamount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_convertedamount.Name = "txt_convertedamount";
            this.txt_convertedamount.ReadOnly = true;
            this.txt_convertedamount.Size = new System.Drawing.Size(134, 26);
            this.txt_convertedamount.TabIndex = 6;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(613, 188);
            this.btn_convert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(84, 29);
            this.btn_convert.TabIndex = 7;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(613, 269);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 29);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rdb_MalaysianRinggit
            // 
            this.rdb_MalaysianRinggit.AutoSize = true;
            this.rdb_MalaysianRinggit.Location = new System.Drawing.Point(250, 254);
            this.rdb_MalaysianRinggit.Name = "rdb_MalaysianRinggit";
            this.rdb_MalaysianRinggit.Size = new System.Drawing.Size(158, 24);
            this.rdb_MalaysianRinggit.TabIndex = 9;
            this.rdb_MalaysianRinggit.TabStop = true;
            this.rdb_MalaysianRinggit.Text = "Malaysian Ringgit";
            this.rdb_MalaysianRinggit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.rdb_MalaysianRinggit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_convertedamount);
            this.Controls.Add(this.rdb_usdollar);
            this.Controls.Add(this.rdb_japaneseyen);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_currency);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.txt_amount);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.RadioButton rdb_japaneseyen;
        private System.Windows.Forms.RadioButton rdb_usdollar;
        private System.Windows.Forms.TextBox txt_convertedamount;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rdb_MalaysianRinggit;
    }
}

