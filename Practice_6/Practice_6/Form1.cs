using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_6
{
    public partial class Form1 : Form
    {
        int min, max;
        public Form1()
        {
            InitializeComponent();
        }

        private void uniqueButton_Click(object sender, EventArgs e)
        {
            int[] number = new int[] { 15, 14, 51, 21, 31, 13, 1 };

            min = number[0];
            max = number[0];

            for (int i = 0; i < number.Length; i++)
            {
                if (min > number[i])
                {
                    min = number[i];
                }
                else if(max < number[i])
                {
                    max = number[i];
                }
            }

            MessageBox.Show("Minimum value:  "+min.ToString()+"\nMaximum value:  "+max.ToString());
        }
    }
}
