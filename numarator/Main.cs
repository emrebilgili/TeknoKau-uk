using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using numarator.FirstFunctionality;
using numarator.SecondFunctionality;
using numarator.ThirdFunctionality;
using numarator.FourthFunctionality;
using numarator.FifthFunctionality;

namespace numarator
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            // instance an first_functionality form for a DialogResult
            FirstFunctionality.main first_functionality = new FirstFunctionality.main();

            //Given the form to DialogResult
            DialogResult dr_first = first_functionality.ShowDialog(this);

            //DialogResult observing for cancel
            if (dr_first == DialogResult.Cancel)
            {
                first_functionality.Close();
            }

            //DialogResult observing for OK
            else if (dr_first == DialogResult.OK)
            {
                first_functionality.Close();
            }

        }

        private void btn_second_Click(object sender, EventArgs e)
        {
            // instance an first_functionality form for a DialogResult
            SecondFunctionality.main second_functionality = new SecondFunctionality.main();

            //Given the form to DialogResult
            DialogResult dr_second = second_functionality.ShowDialog(this);

            //DialogResult observing for cancel
            if (dr_second == DialogResult.Cancel)
            {
                second_functionality.Close();
            }

            //DialogResult observing for OK
            else if (dr_second == DialogResult.OK)
            {
                second_functionality.Close();
            }
        }

        private void btn_third_Click(object sender, EventArgs e)
        {
            // instance an first_functionality form for a DialogResult
            ThirdFunctionality.main third_functionality = new ThirdFunctionality.main();

            //Given the form to DialogResult
            DialogResult dr_third = third_functionality.ShowDialog(this);

            //DialogResult observing for cancel
            if (dr_third == DialogResult.Cancel)
            {
                third_functionality.Close();
            }

            //DialogResult observing for OK
            else if (dr_third == DialogResult.OK)
            {
                third_functionality.Close();
            }
        }

        private void btn_fourth_Click(object sender, EventArgs e)
        {
            // instance an first_functionality form for a DialogResult
            FourthFunctionality.main fourth_functionality = new FourthFunctionality.main();

            //Given the form to DialogResult
            DialogResult dr_fourth = fourth_functionality.ShowDialog(this);

            //DialogResult observing for cancel
            if (dr_fourth == DialogResult.Cancel)
            {
                fourth_functionality.Close();
            }

            //DialogResult observing for OK
            else if (dr_fourth == DialogResult.OK)
            {
                fourth_functionality.Close();
            }
        }

        private void btn_fifth_Click(object sender, EventArgs e)
        {
            // instance an first_functionality form for a DialogResult
            FifthFunctionality.main fifth_functionality = new FifthFunctionality.main();

            //Given the form to DialogResult
            DialogResult dr_fifth = fifth_functionality.ShowDialog(this);

            //DialogResult observing for cancel
            if (dr_fifth == DialogResult.Cancel)
            {
                fifth_functionality.Close();
            }

            //DialogResult observing for OK
            else if (dr_fifth == DialogResult.OK)
            {
                fifth_functionality.Close();
            }
        }
    }
}
