using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPhoneDirectory
{
    // Разрешение коллизий будет осуществляться при помощи метода открытой адресации
    internal class HashTable
    {
        private int _sizeTable; // размер таблицы
        public int SizeTable
        {
            get => _sizeTable;
            set
            {
                if (value < 0 || value < _curSize) 
                    throw new ArgumentException("The length of the hash table cannot be less than zero");
                _sizeTable = value;
            }
        }
        private readonly static int _step = 37; // шаг для разрешения коллизий
        private int _curSize; // количество элментов в таблице
        private HashItem[] _hashTable; // хеш-таблица

        public HashTable(int sizeTable) 
        {
            SizeTable = sizeTable;
            _hashTable = new HashItem[SizeTable];
            HashInit();
        }
        public void HashInit() 
        {
            _curSize = 0;

            for (int i = 0; i < SizeTable; ++i)
            {
                this._hashTable[i]._empty = true;
                this._hashTable[i]._visit = false;
            }
        }
        private int HashFunction(string s) 
        {
            int result = 0;

            for (int i = 0; i < s.Length; ++i) 
            {
                result += Convert.ToInt32(s[i]) * i;
                result %= _sizeTable;
            }

            return result;
        }
        public int AddItem(string FIO, string phoneNumer) { }
        private void ClearVisit() { } // метод отчистки полей посещения
        public bool RemoveItem(string phoneNumber, out int index) { }
        public int FindItem(string phoneNumber, out string FIO, out int count) { }
    }
}
