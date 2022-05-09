using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClassLibrary3.Class1;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
       public int[] arr; 
        public int n = 0;
        public int[] a;
        public Form1 f1;
       
        public Form5()
            {
            
            InitializeComponent();
            }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            arr = DataBank.Arr;
            for (int i = 0; i < arr.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, arr[i]);
            }
        }
    }
}
