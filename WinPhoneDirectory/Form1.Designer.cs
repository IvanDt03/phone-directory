namespace WinPhoneDirectory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnFill = new Button();
            btnSearch = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(477, 609);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(500, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(707, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 27);
            textBox2.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(500, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить абонента";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(500, 249);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(168, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Удалить абонента";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnFill
            // 
            btnFill.Location = new Point(707, 249);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(190, 29);
            btnFill.TabIndex = 5;
            btnFill.Text = "Заполнить таблицу";
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += btnFill_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(707, 190);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(190, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Найти абонента";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(838, 569);
            button5.Name = "button5";
            button5.Size = new Size(126, 29);
            button5.TabIndex = 7;
            button5.Text = "Завершить";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(500, 80);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 8;
            label1.Text = "Номер абонента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(707, 80);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 9;
            label2.Text = "ФИО абонента";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 610);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(btnSearch);
            Controls.Add(btnFill);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnFill;
        private Button btnSearch;
        private Button button5;
        private Label label1;
        private Label label2;
    }
}
