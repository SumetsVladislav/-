using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static ClassLibrary3.Class1;

namespace WindowsFormsApp2
{
    public partial class OllDiagramForm : Form
    {
        public int[] arr;
        public OllDiagramForm()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void OllDiagramForm_Load(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////
            ///Графік на якому має бути 2 різних графіка на 1 області
            //////////////////////////////////////////////////////////
            chart1.Series[0].Points.Clear();
            arr = DataBank.Arr;
            for (int i = 0; i < arr.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, arr[i]);
            }
            chart1.Series[1].Points.Clear();
            arr = DataBank.Arr;
            for (int i = 0; i < arr.Length; i++)
            {
                chart1.Series[1].Points.AddXY(i, arr[i]);
            } //////////////////////////////////////////////////////////
            ///Графік на якому має бути 2 однакових  графіка на 1 області
            //////////////////////////////////////////////////////////
           
           
            chart2.Series[0].Points.Clear();
            arr = DataBank.Arr;
            for (int i = 0; i < arr.Length; i++)
            {
                chart2.Series[0].Points.AddXY(i, arr[i]);
            }
            chart2.Series[1].Points.Clear();
            arr = DataBank.Arr;
            for (int i = 0; i < arr.Length; i++)
            {
                chart2.Series[1].Points.AddXY(i, arr[i]);
            }

            //////////////////////////////////////////////////////////
            ///Графік на якому має бути 2 серії разом/////////////////
            //////////////////////////////////////////////////////////
            ///
            chart4.BackColor = Color.DeepSkyBlue;   //Задній фон усого чарта
            chart4.Series[0].Points.Clear();
            arr = DataBank.Arr;
            for (int i = 0; i < arr.Length; i++)
            {
                chart4.Series[0].Points.AddXY(i, arr[i]);
            }
            chart4.Series[1].Points.Clear();
            arr = DataBank.Arr;
            for (int i = 0; i < arr.Length; i++)
            {
                chart4.Series[1].Points.AddXY(i, arr[i]);
            }
            //////////////////////////////////////////////////////////
            ///Графік намальований за допомогою примітивів////////////
            //////////////////////////////////////////////////////////
                



        }

        private void chart4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
