using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_8
{
    public partial class Form1 : Form
    {
        string odd = "";
        string even = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void oddEvenButton_Click(object sender, EventArgs e)
        {
            int[] number = new int[] { 15, 14, 51, 21, 30, 13, 1 };

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    odd += number[i]+"  ";
                }
                else
                {
                    even += number[i]+"  ";
                }
            }

            MessageBox.Show("Odd:  "+odd+"\nEven:  "+even);
        }
    }
}
