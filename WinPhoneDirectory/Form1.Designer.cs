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
            phoneTextBox = new TextBox();
            FIOtextBox = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnFill = new Button();
            btnSearch = new Button();
            btnClose = new Button();
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
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(500, 117);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(168, 27);
            phoneTextBox.TabIndex = 1;
            // 
            // FIOtextBox
            // 
            FIOtextBox.Location = new Point(707, 117);
            FIOtextBox.Name = "FIOtextBox";
            FIOtextBox.Size = new Size(257, 27);
            FIOtextBox.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(500, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить абонента";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(500, 249);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(168, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Удалить абонента";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnFill
            // 
            btnFill.Location = new Point(707, 249);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(190, 52);
            btnFill.TabIndex = 5;
            btnFill.Text = "Получить данные из файла";
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
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(838, 569);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "Завершить";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button5_Click;
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
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(btnFill);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(FIOtextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox phoneTextBox;
        private TextBox FIOtextBox;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnFill;
        private Button btnSearch;
        private Button btnClose;
        private Label label1;
        private Label label2;
    }
}
