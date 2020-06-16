namespace _13_Aron_PA9
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
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_selectcurrency = new System.Windows.Forms.Label();
            this.rdb_JapaneseYen = new System.Windows.Forms.RadioButton();
            this.rdb_USdollars = new System.Windows.Forms.RadioButton();
            this.lbl_value = new System.Windows.Forms.Label();
            this.txt_convertedAmt = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(200, 95);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(65, 20);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount\r\n";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(356, 97);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(154, 20);
            this.txt_amount.TabIndex = 1;
            // 
            // lbl_selectcurrency
            // 
            this.lbl_selectcurrency.AutoSize = true;
            this.lbl_selectcurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectcurrency.Location = new System.Drawing.Point(175, 159);
            this.lbl_selectcurrency.Name = "lbl_selectcurrency";
            this.lbl_selectcurrency.Size = new System.Drawing.Size(121, 20);
            this.lbl_selectcurrency.TabIndex = 2;
            this.lbl_selectcurrency.Text = "Select Currency";
            // 
            // rdb_JapaneseYen
            // 
            this.rdb_JapaneseYen.AutoSize = true;
            this.rdb_JapaneseYen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_JapaneseYen.Location = new System.Drawing.Point(365, 158);
            this.rdb_JapaneseYen.Name = "rdb_JapaneseYen";
            this.rdb_JapaneseYen.Size = new System.Drawing.Size(117, 21);
            this.rdb_JapaneseYen.TabIndex = 4;
            this.rdb_JapaneseYen.TabStop = true;
            this.rdb_JapaneseYen.Text = "Japanese Yen";
            this.rdb_JapaneseYen.UseVisualStyleBackColor = true;
            // 
            // rdb_USdollars
            // 
            this.rdb_USdollars.AutoSize = true;
            this.rdb_USdollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_USdollars.Location = new System.Drawing.Point(365, 203);
            this.rdb_USdollars.Name = "rdb_USdollars";
            this.rdb_USdollars.Size = new System.Drawing.Size(86, 21);
            this.rdb_USdollars.TabIndex = 5;
            this.rdb_USdollars.TabStop = true;
            this.rdb_USdollars.Text = "US Dollar";
            this.rdb_USdollars.UseVisualStyleBackColor = true;
            this.rdb_USdollars.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.Location = new System.Drawing.Point(200, 264);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(50, 20);
            this.lbl_value.TabIndex = 6;
            this.lbl_value.Text = "Value";
            // 
            // txt_convertedAmt
            // 
            this.txt_convertedAmt.Location = new System.Drawing.Point(356, 266);
            this.txt_convertedAmt.Name = "txt_convertedAmt";
            this.txt_convertedAmt.Size = new System.Drawing.Size(126, 20);
            this.txt_convertedAmt.TabIndex = 7;
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.Location = new System.Drawing.Point(591, 159);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(113, 30);
            this.btn_convert.TabIndex = 8;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(591, 214);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(113, 31);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_convertedAmt);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.rdb_USdollars);
            this.Controls.Add(this.rdb_JapaneseYen);
            this.Controls.Add(this.lbl_selectcurrency);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_selectcurrency;
        private System.Windows.Forms.RadioButton rdb_JapaneseYen;
        private System.Windows.Forms.RadioButton rdb_USdollars;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.TextBox txt_convertedAmt;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
    }
}

