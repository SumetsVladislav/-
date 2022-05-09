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
    public partial class Form4 : Form
    {
        public int[] arr;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            arr = DataBank.Arr;
            for (int i = 0; i < arr.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, arr[i]);
            }
        }
    }
}
