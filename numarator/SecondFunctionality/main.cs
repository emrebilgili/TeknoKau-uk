using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numarator.SecondFunctionality
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        Operations _operations = new Operations();
        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i < 200; i++)
                {
                    lst_items.Items.Add(_operations.Control(i));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir şeyler ters gitti.");
            }
            
        }
    }
}
