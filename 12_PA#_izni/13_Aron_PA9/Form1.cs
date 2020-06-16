using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Aron_PA9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double convertedValue;
            //checking for null value
            if(rdb_USdollars.Checked == false || (rdb_JapaneseYen.Checked == false))
            {
                txt_convertedAmt.Text = "Selected at least one type of currency to convert";
            }
                    
            try
            {
                if (rdb_USdollars.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedValue = AmountEntered * 0.74;

                    txt_convertedAmt.Text = convertedValue.ToString();
                }
            }catch(FormatException)
            {
                txt_amount.Text = "Please enter a valid amount!";
            }
            try
            {
                if (rdb_JapaneseYen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedValue = AmountEntered * 1.5;

                    txt_convertedAmt.Text = convertedValue.ToString();
                }
            }catch
            {
                txt_amount.Text = "Please enter a valid amount!";
                txt_convertedAmt.Text = "";
            }
            try
            {
                if(rdb_MalaysianRinggit.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedValue = AmountEntered * 3.01;

                    txt_convertedAmt.Text = convertedValue.ToString();
                }
            }catch
            {
                txt_amount.Text = "Please enter a valid amount!";
                txt_convertedAmt.Text = "";
            }
             
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Clear();
            txt_convertedAmt.Clear();
        }
    }
}
