using System.Diagnostics;
using System.IO;


namespace WinPhoneDirectory
{

    public partial class Form1 : Form
    {
        HashTable hashtable = new HashTable(200);
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Номер", "Номер");
            dataGridView1.Columns["Номер"].Width = 70;

            dataGridView1.Columns.Add("Телефон", "Телефон");
            dataGridView1.Columns["Телефон"].Width = 140;

            dataGridView1.Columns.Add("ФИО", "ФИО");
            dataGridView1.Columns["ФИО"].Width = 170;

            dataGridView1.AllowUserToAddRows = false;
            btnAdd.Visible = false;
            btnRemove.Visible = false;
        }

        private void FillHashTable()
        {
            FileStream file = new FileStream("C:\\Users\\vanya\\Desktop\\Программы C#\\PhoneDirectory\\WinPhoneDirectory\\phoneList.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);

            dataGridView1.RowCount = hashtable.SizeTable;

            string? curFIO, curPhoneNumber;

            for (int i = 0; i < hashtable.SizeTable; ++i)
                dataGridView1[0, i].Value = Convert.ToString(i);


            while ((curFIO = reader.ReadLine()) != null &&
                   (curPhoneNumber = reader.ReadLine()) != null)
                hashtable.AddItem(curFIO, curPhoneNumber);

            reader.Close();
        }
        private void ShowHash()
        {
            int row = 0;
            foreach (var item in hashtable)
            {
                if (!((HashItem)item)._empty)
                {
                    dataGridView1["Телефон", row].Value = ((HashItem)item)._person.PhoneNumber;
                    dataGridView1["ФИО", row].Value = ((HashItem)item)._person.FIO;
                }
                else
                {
                    dataGridView1["Телефон", row].Value = String.Empty;
                    dataGridView1["ФИО", row].Value = String.Empty;
                }
                row++;
            }
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            FillHashTable();
            ShowHash();
            btnFill.Visible = false;
            btnAdd.Visible = true;
            btnRemove.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            hashtable.AddItem(FIOtextBox.Text, phoneTextBox.Text);
            ShowHash();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            hashtable.RemoveItem(phoneTextBox.Text, out _);
            ShowHash();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            hashtable.FindItem(phoneTextBox.Text, out _, out int index);
            dataGridView1.Rows[index].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = index;
        }
    }
}
