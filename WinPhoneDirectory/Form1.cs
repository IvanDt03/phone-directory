using System.IO;

namespace WinPhoneDirectory
{
    public partial class Form1 : Form
    {
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
            btnAdd.Visible      = false;
            btnRemove.Visible   = false;
        }
    }
}
