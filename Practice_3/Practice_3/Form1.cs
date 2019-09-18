using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3
{
    public partial class Form1 : Form
    {
        int sum = 0;
        const int size = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int[] number = new int[size];
            number[0] = 2;
            number[1] = 5;
            number[2] = 8;

            for (int i = 0; i < size; i++)
            {
                sum += number[i];
            }

            MessageBox.Show(sum.ToString());
        }
    }
}
