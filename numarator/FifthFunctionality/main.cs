using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numarator.FifthFunctionality
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void validate_number(object sender, KeyPressEventArgs e)
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

        Operations _operations = new Operations();
        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txt_number.Text);
            MessageBox.Show("sonuç : " + _operations.GetNthFibonacci_Rec(number-1));
        }
    }
}
