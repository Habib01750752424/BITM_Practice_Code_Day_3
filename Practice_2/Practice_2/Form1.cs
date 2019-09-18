using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2
{
    public partial class Form1 : Form
    {
        const int size = 3;
        string result = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            int[] number = new int[size];
            number[0] = 2;
            number[1] = 5;
            number[2] = 7;

            for (int i = size-1; i >= 0; i--)
            {
                result += number[i]+"  ";
            }
            MessageBox.Show(result);
        }
    }
}
