using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_PA9_Raul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double convertedAmount;

            try
            {
                if ((rdb_usdollar.Checked == false) || (rdb_japaneseyen.Checked == false))
                {
                    txt_convertedamount.Text = "Select at least one type of currency to convert";
                }

                if (rdb_usdollar.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedAmount = AmountEntered * 0.74;

                    txt_convertedamount.Text = convertedAmount.ToString();
                }

                if (rdb_japaneseyen.Checked == true)
                {
                    AmountEntered = double.Parse(txt_amount.Text);
                    convertedAmount = AmountEntered * 81.97;

                    txt_convertedamount.Text = convertedAmount.ToString();
                }
            }

            catch (System.FormatException)
            {
                txt_convertedamount.Text = "Numbers only.";
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_amount.Text = string.Empty;
            txt_convertedamount.Text = string.Empty;
            rdb_japaneseyen.Checked = false;
            rdb_usdollar.Checked = false;
        }
    }
}
