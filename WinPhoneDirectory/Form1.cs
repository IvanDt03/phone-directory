using System.IO;

namespace WinPhoneDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("�����", "�����");
            dataGridView1.Columns["�����"].Width = 50;

            dataGridView1.Columns.Add("�������", "�������");
            dataGridView1.Columns["�������"].Width = 80;

            dataGridView1.Columns.Add("���", "���");
            dataGridView1.Columns["���"].Width = 140;

            dataGridView1.AllowUserToAddRows = false;
            btnAdd.Visible      = false;
            btnRemove.Visible   = false;
        }
    }
}
