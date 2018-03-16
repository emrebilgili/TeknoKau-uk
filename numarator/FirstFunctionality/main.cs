using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numarator.FirstFunctionality
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        Operations _operation = new Operations();


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Controlling only digits in textboxes
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void validate_number(object sender, EventArgs e)
        {
            try
            {
                if (txt_s1.Text == "" || txt_s2.Text == "" || txt_s3.Text == "")
                {
                    MessageBox.Show("Tüm sayı alanlarını doldurunuz");
                }
                else
                {
                    txt_sonuc.Text = _operation.multiplication(_operation.add(Convert.ToDecimal(txt_s1.Text), Convert.ToDecimal(txt_s2.Text)), Convert.ToDecimal(txt_s3.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir şeyler ters gitti");
            }
        }


    }
}
