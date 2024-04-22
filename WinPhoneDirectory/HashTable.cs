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
        private readonly static int _step = 37; // шаг для разрешения коллизий
        private int _curSize; // количество элментов в таблице
        private HashItem[] _hashTable; // хеш-таблица

        public HashTable(int sizeTable) { }
        public void HashInit() { }
        private int HashFunction(string s) { }
        public int AddItem(string FIO, string phoneNumer) { }
        private void ClearVisit() { } // метод отчистки полей посещения
        public bool RemoveItem(string phoneNumber, out int index) { }
        public int FindItem(string phoneNumber, out string FIO, out int count) { }
    }
}
