using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 10;
        int i = 0;
        string result;

        private void showButton_Click(object sender, EventArgs e)
        {
            int[] number = new int[n];

            number[0] = 1;
            number[1] = 1;
            number[2] = 2;
            number[3] = 3;
            number[4] = 4;
            number[5] = 5;
            number[6] = 6;
            number[7] = 7;
            number[8] = 8;
            number[9] = 9;

            for (int i = 0; i < number.Length; i++)
            {
                result += number[i]+"  ";
            }

            MessageBox.Show(result);

        }
    }
}
