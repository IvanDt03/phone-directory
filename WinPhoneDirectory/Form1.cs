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
            dataGridView1.Columns["Номер"].Width = 50;

            dataGridView1.Columns.Add("Телефон", "Телефон");
            dataGridView1.Columns["Телефон"].Width = 80;

            dataGridView1.Columns.Add("ФИО", "ФИО");
            dataGridView1.Columns["ФИО"].Width = 140;

            dataGridView1.AllowUserToAddRows = false;
            btnAdd.Visible = false;
            btnRemove.Visible = false;
        }

        private void FillHashTable()
        {
            FileStream file = new FileStream("phoneList.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);

            dataGridView1.RowCount = hashtable.SizeTable;

            string? curFIO, curPhoneNumber;

            for (int i = 0; i < hashtable.SizeTable; ++i)
                dataGridView1[0, i].Value = Convert.ToString(i);

            while ((curFIO = reader.ReadLine()) != null &&
                   (curPhoneNumber = reader.ReadLine()) != null)
                hashtable.AddItem(curFIO, curPhoneNumber);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            FillHashTable();
            ShowHash();
            btnFill.Visible     = false;
            btnAdd.Visible      = true;
            btnRemove.Visible   = false;
        }
    }
}
