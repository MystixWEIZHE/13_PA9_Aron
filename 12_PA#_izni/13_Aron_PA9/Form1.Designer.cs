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
            this.rdb_MalaysianRinggit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(267, 117);
            this.lbl_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(80, 25);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount\r\n";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(475, 119);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(204, 22);
            this.txt_amount.TabIndex = 1;
            // 
            // lbl_selectcurrency
            // 
            this.lbl_selectcurrency.AutoSize = true;
            this.lbl_selectcurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectcurrency.Location = new System.Drawing.Point(233, 196);
            this.lbl_selectcurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectcurrency.Name = "lbl_selectcurrency";
            this.lbl_selectcurrency.Size = new System.Drawing.Size(152, 25);
            this.lbl_selectcurrency.TabIndex = 2;
            this.lbl_selectcurrency.Text = "Select Currency";
            // 
            // rdb_JapaneseYen
            // 
            this.rdb_JapaneseYen.AutoSize = true;
            this.rdb_JapaneseYen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_JapaneseYen.Location = new System.Drawing.Point(487, 194);
            this.rdb_JapaneseYen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_JapaneseYen.Name = "rdb_JapaneseYen";
            this.rdb_JapaneseYen.Size = new System.Drawing.Size(135, 24);
            this.rdb_JapaneseYen.TabIndex = 4;
            this.rdb_JapaneseYen.TabStop = true;
            this.rdb_JapaneseYen.Text = "Japanese Yen";
            this.rdb_JapaneseYen.UseVisualStyleBackColor = true;
            // 
            // rdb_USdollars
            // 
            this.rdb_USdollars.AutoSize = true;
            this.rdb_USdollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_USdollars.Location = new System.Drawing.Point(487, 250);
            this.rdb_USdollars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_USdollars.Name = "rdb_USdollars";
            this.rdb_USdollars.Size = new System.Drawing.Size(103, 24);
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
            this.lbl_value.Location = new System.Drawing.Point(267, 325);
            this.lbl_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(63, 25);
            this.lbl_value.TabIndex = 6;
            this.lbl_value.Text = "Value";
            // 
            // txt_convertedAmt
            // 
            this.txt_convertedAmt.Location = new System.Drawing.Point(475, 327);
            this.txt_convertedAmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_convertedAmt.Name = "txt_convertedAmt";
            this.txt_convertedAmt.Size = new System.Drawing.Size(167, 22);
            this.txt_convertedAmt.TabIndex = 7;
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.Location = new System.Drawing.Point(788, 196);
            this.btn_convert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(151, 37);
            this.btn_convert.TabIndex = 8;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(788, 263);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(151, 38);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rdb_MalaysianRinggit
            // 
            this.rdb_MalaysianRinggit.AutoSize = true;
            this.rdb_MalaysianRinggit.Location = new System.Drawing.Point(487, 299);
            this.rdb_MalaysianRinggit.Name = "rdb_MalaysianRinggit";
            this.rdb_MalaysianRinggit.Size = new System.Drawing.Size(167, 21);
            this.rdb_MalaysianRinggit.TabIndex = 10;
            this.rdb_MalaysianRinggit.TabStop = true;
            this.rdb_MalaysianRinggit.Text = "MALAYSIAN RINGGIT";
            this.rdb_MalaysianRinggit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rdb_MalaysianRinggit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_convertedAmt);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.rdb_USdollars);
            this.Controls.Add(this.rdb_JapaneseYen);
            this.Controls.Add(this.lbl_selectcurrency);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_amount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.RadioButton rdb_MalaysianRinggit;
    }
}

