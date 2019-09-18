using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_5
{
    public partial class Form1 : Form
    {
        string duplicate = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void duplicateButton_Click(object sender, EventArgs e)
        {
            int[] number = new int[] { 5, 4, 5, 2, 3, 3 };

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i+1; j < number.Length; j++)
                {
                    if (number[i] == number[j])
                    {
                        duplicate += number[j] + "  ";
                    }                    
                }
            }
            MessageBox.Show(duplicate);
        }
    }
}
