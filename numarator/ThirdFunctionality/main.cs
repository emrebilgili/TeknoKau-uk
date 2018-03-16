using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numarator.ThirdFunctionality
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
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int capacity = Convert.ToInt32(txt_capacity.Text)+1;
            int[,] items = new int[capacity, capacity];
            tableLayoutPanel1.Controls.Clear();

            //Clear out the existing row and column styles
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = capacity+1;
            tableLayoutPanel1.ColumnCount = capacity+1;
            try
            {
                for (int i = 0; i < capacity; i++)
                {
                    items[0, i] = i;
                }
                for (int i = 1; i < capacity; i++)
                {
                    items[i, 0] = i;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Dizi doldurulurken hatayla karşılaşıldı.");
            }

            try
            {
                for (int i = 0; i < capacity - 1; i++)
                {
                    for (int k = 0; k < capacity - 1; k++)
                    {
                        items[i + 1, k + 1] = items[0, k + 1] * items[i + 1, 0];
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Çarpım işlemleri sırasında bir hatayla karşılaşıldı.");
            }

            try
            {
                for (int i = 0; i < capacity; i++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    for (int k = 0; k < capacity; k++)
                    {
                        if (i == 0)
                        {
                            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        }
                        Label result = new Label();
                        result.Text = items[i, k].ToString();

                        tableLayoutPanel1.Controls.Add(result, i, k);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Gösterim aşamasında bir hatayla karşılaşıldı.");
            }
            


            
        }
    }
}
