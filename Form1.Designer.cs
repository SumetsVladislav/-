namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GoToDiagrams = new System.Windows.Forms.Button();
            this.AboutAuthor = new System.Windows.Forms.Button();
            this.gen = new System.Windows.Forms.Button();
            this.GoToMatrix = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.InputN = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).BeginInit();
            this.SuspendLayout();
            // 
            // GoToDiagrams
            // 
            this.GoToDiagrams.Location = new System.Drawing.Point(9, 213);
            this.GoToDiagrams.Name = "GoToDiagrams";
            this.GoToDiagrams.Size = new System.Drawing.Size(195, 35);
            this.GoToDiagrams.TabIndex = 0;
            this.GoToDiagrams.Text = "Побачити діаграму";
            this.GoToDiagrams.UseVisualStyleBackColor = true;
            this.GoToDiagrams.Click += new System.EventHandler(this.GoToDiagrams_Click);
            // 
            // AboutAuthor
            // 
            this.AboutAuthor.Location = new System.Drawing.Point(9, 294);
            this.AboutAuthor.Name = "AboutAuthor";
            this.AboutAuthor.Size = new System.Drawing.Size(195, 34);
            this.AboutAuthor.TabIndex = 1;
            this.AboutAuthor.Text = "Про автора";
            this.AboutAuthor.UseVisualStyleBackColor = true;
            this.AboutAuthor.Click += new System.EventHandler(this.AboutAuthor_Click);
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(12, 48);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(192, 23);
            this.gen.TabIndex = 2;
            this.gen.Text = "Сгенерувати";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // GoToMatrix
            // 
            this.GoToMatrix.Location = new System.Drawing.Point(9, 254);
            this.GoToMatrix.Name = "GoToMatrix";
            this.GoToMatrix.Size = new System.Drawing.Size(195, 34);
            this.GoToMatrix.TabIndex = 3;
            this.GoToMatrix.Text = "Більше діаграм";
            this.GoToMatrix.UseVisualStyleBackColor = true;
            this.GoToMatrix.Click += new System.EventHandler(this.GoToMatrix_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Типи діаграм";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Вертикальна гистограмма";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Кругова";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(210, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(170, 377);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кількість чисел";
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(105, 22);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(99, 20);
            this.InputN.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Очистити данні";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(9, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ану відсортуй😑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(385, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GoToMatrix);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.AboutAuthor);
            this.Controls.Add(this.GoToDiagrams);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Тут мав бути якийсь текст але я не знаю який";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToDiagrams;
        private System.Windows.Forms.Button AboutAuthor;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.Button GoToMatrix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown InputN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

