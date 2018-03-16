using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numarator.FourthFunctionality
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_file_dialog = new OpenFileDialog();
            open_file_dialog.InitialDirectory = @"C:\Users\huseyin\Desktop\Kauçuk\numarator\numarator";
            open_file_dialog.Filter = "txt files (*.txt)|*.txt";
            open_file_dialog.RestoreDirectory = true;

            if (open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                string path = open_file_dialog.FileName.ToString();
                string alltext = System.IO.File.ReadAllText(path);
                int n = 0;
                MatchCollection matches = Regex.Matches(alltext, @"[+-]?\d+(\,\d+)?");
                decimal[] numbers = new decimal[matches.Count];

                foreach (Match m in matches)
                {
                    numbers[n] = decimal.Parse(m.Value);
                    n++;
                }
                decimal temp;
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int t = 0; t < numbers.Length; t++)
                    {
                        if (numbers[t] < numbers[i])
                        {
                            temp = numbers[i];
                            numbers[i] = numbers[t];
                            numbers[t] = temp;

                        }
                    }
                }

                foreach (var item in numbers)
                {
                    lst_numbers.Items.Add(item);
                }

            }
        }
    }
}
