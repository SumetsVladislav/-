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
    public partial class Form1 : Form
    {
        public Form5 f5;
      
        public  int n = 0;
        public int[] a;
        public Form1()
        {
            InitializeComponent();
        }
        private void AboutAuthor_Click(object sender, EventArgs e)
        {
            Author frm2 = new Author();// Перехід до автора
            frm2.Show();
        }
        private void GoToMatrix_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();// Перехід до двійних масивів
            frm3.Show();
        }
        private void gen_Click(object sender, EventArgs e)
        {
            
            n = Convert.ToInt32(InputN.Text);
            GenetateMass.Generation(ref a, n);// Створення масиву
           
            dataGridView1.ColumnCount = 2;//Добавляем столбцы, в количестве равным количеству элементов массива.
            dataGridView1.Rows.Add(a.Length);//Добавляем 2 строки.
                          //Заповняємо масив
            for (int j = 0; j < a.Length; j++) //Додаємо нумерацію
            {
                for (int i = 0; i < a.Length; i++)// Додаємо елементи
                {
                    dataGridView1.Rows[j].Cells[0].Value = j++;// Заносимо у кожну комірку нумерацію
                    dataGridView1.Rows[i].Cells[1].Value = a[i];//Заносимо у кожну  комірку елемент
                }
            }
            DataBank.Arr = a;
        }
        private void GoToDiagrams_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                
                Form5 f5 = new Form5(); // Побачити кругову діаграмму
                f5.Show();
               
            }
            if (radioButton2.Checked == true)
            {

                Form4 frm4 = new Form4();// Побачити гистограму
                frm4.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();  // удаление всех строк
            int count = this.dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов
            {
                this.dataGridView1.Columns.RemoveAt(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenetateMass.SortTMass(ref a);
            dataGridView1.ColumnCount = 2;//Добавляем столбцы, в количестве равным количеству элементов массива.
            dataGridView1.Rows.Add(a.Length);//Добавляем 2 строки.
                                             //Заповняємо масив
            for (int j = 0; j < a.Length; j++) //Додаємо нумерацію
            {
                for (int i = 0; i < a.Length; i++)// Додаємо елементи
                {
                    dataGridView1.Rows[j].Cells[0].Value = j++;// Заносимо у кожну комірку нумерацію
                    dataGridView1.Rows[i].Cells[1].Value = a[i];//Заносимо у кожну  комірку елемент
                }
            }
            DataBank.Arr = a; //Збереження масиву задля наступного переносу його в інші форми
        }
    }
}
