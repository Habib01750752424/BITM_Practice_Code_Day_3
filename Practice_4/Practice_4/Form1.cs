using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_4
{
    public partial class Form1 : Form
    {
        string result1 = "";
        string result2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void arrayCopyButton_Click(object sender, EventArgs e)
        {
            int[] arr1 = new int[] { 15, 10, 12};
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                result1 += arr1[i]+"  ";
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] += arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                result2 += arr2[i]+"  ";
            }


            MessageBox.Show("Array1:  "+result1+"\nArray2: "+result2);
        }
    }
}
