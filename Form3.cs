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
    public partial class Form3 : Form
    {
        public static int A1 = 0;
        public static int B1 = 0;
        public static int N1 = 0;

        public static int A2 = 0;
        public static int B2 = 0;
        public static int N2 = 0;
        public int[] arr;
        public int[] arr2;
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Author frm2 = new Author();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Перший графік
            N1 = Convert.ToInt32(InputN1.Text);
            A1 = Convert.ToInt32(InputA1.Text);
            B1 = Convert.ToInt32(InputB1.Text);
            //Другий графік
            N2 = (int)InputN2.Value;
            A2 = (int)InputA2.Value;
            B2 = (int)InputB2.Value;
           GenetateMass.Generation2(ref arr, N1,A1,B1);
            GenetateMass.Generation2(ref arr2, N2,A2,B2);

            //Генерація 1 матриці
            dataGridView1.ColumnCount = 2;//Добавляем столбцы, в количестве равным количеству элементов массива.
            dataGridView1.Rows.Add(arr.Length);//Добавляем 2 строки.
                                             //Заповняємо масив
            for (int j = 0; j < arr.Length; j++) //Додаємо нумерацію
            {
                for (int i = 0; i < arr.Length; i++)// Додаємо елементи
                {
                    dataGridView1.Rows[j].Cells[0].Value = j++;// Заносимо у кожну комірку нумерацію
                    dataGridView1.Rows[i].Cells[1].Value = arr[i];//Заносимо у кожну  комірку елемент
                }
            }
            //Генерація 2 матриці
            dataGridView2.ColumnCount = 2;//Добавляем столбцы, в количестве равным количеству элементов массива.
            dataGridView2.Rows.Add(arr2.Length);//Добавляем 2 строки.
                                               //Заповняємо масив
            for (int j = 0; j < arr2.Length; j++) //Додаємо нумерацію
            {
                for (int i = 0; i < arr2.Length; i++)// Додаємо елементи
                {
                    dataGridView2.Rows[j].Cells[0].Value = j++;// Заносимо у кожну комірку нумерацію
                    dataGridView2.Rows[i].Cells[1].Value = arr2[i];//Заносимо у кожну  комірку елемент
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OllDiagramForm fr6 = new OllDiagramForm();
            fr6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenetateMass.SortTMass(ref arr2);   //Сортування масивів
            GenetateMass.SortTMass(ref arr);    //Сортування масивів


            dataGridView1.ColumnCount = 2;//Добавляем столбцы, в количестве равным количеству элементов массива.
            dataGridView1.Rows.Add(arr.Length);//Добавляем 2 строки.
                                               //Заповняємо масив
            for (int j = 0; j < arr.Length; j++) //Додаємо нумерацію
            {
                for (int i = 0; i < arr.Length; i++)// Додаємо елементи
                {
                    dataGridView1.Rows[j].Cells[0].Value = j++;// Заносимо у кожну комірку нумерацію
                    dataGridView1.Rows[i].Cells[1].Value = arr[i];//Заносимо у кожну  комірку елемент
                }
            }
            //Генерація 2 матриці
            dataGridView2.ColumnCount = 2;//Добавляем столбцы, в количестве равным количеству элементов массива.
            dataGridView2.Rows.Add(arr2.Length);//Добавляем 2 строки.
                                                //Заповняємо масив
            for (int j = 0; j < arr2.Length; j++) //Додаємо нумерацію
            {
                for (int i = 0; i < arr2.Length; i++)// Додаємо елементи
                {
                    dataGridView2.Rows[j].Cells[0].Value = j++;// Заносимо у кожну комірку нумерацію
                    dataGridView2.Rows[i].Cells[1].Value = arr2[i];//Заносимо у кожну  комірку елемент
                }
            }
        }
    }
}
