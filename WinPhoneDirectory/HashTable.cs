using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPhoneDirectory
{
    // Разрешение коллизий будет осуществляться при помощи метода открытой адресации
    internal class HashTable : IEnumerable
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
        private void HashInit() 
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
        public int AddItem(string FIO, string phoneNumer) 
        {
            int index = -1;

            if (_curSize < SizeTable) // таблица не переполнена
            {
                index = HashFunction(phoneNumer);

                while (!_hashTable[index]._empty)
                    index = (index + _step) % SizeTable;

                _hashTable[index]._empty = false;
                _hashTable[index]._visit = true;
                _hashTable[index]._person.FIO = FIO;
                _hashTable[index]._person.PhoneNumber = phoneNumer;
                ++_curSize;
            }

            return index;
        }
        private void ClearVisit() // метод отчистки полей посещения
        {
            for (int i = 0; i < SizeTable; ++i)
                _hashTable[i]._visit = false;
        }
        public bool RemoveItem(string phoneNumber, out int index) 
        {
            bool result = false;
            index = 0;
            if (_curSize != 0)
            {
                index = HashFunction(phoneNumber);

                if (_hashTable[index]._person.PhoneNumber == phoneNumber)
                {
                    _hashTable[index]._empty = true;
                    result = true;
                    --_curSize;
                }
                else
                {
                    index = this.FindItem(phoneNumber, out _, out _);

                    if (index != -1)
                    {
                        _hashTable[index]._empty = true;
                        result = true;
                        --_curSize;
                    }
                }
            }
            return result;
        }
        public int FindItem(string phoneNumber, out string FIO, out int index) 
        {
            int result  = -1;
            bool flagOK;
            FIO = String.Empty;

            ClearVisit();

            index = HashFunction(phoneNumber);
            flagOK  = (_hashTable[index]._person.PhoneNumber == phoneNumber);

            while (!flagOK && !_hashTable[index]._visit)
            {
                _hashTable[index]._visit = true;
                index = (index + _step) % SizeTable; // продолжаем поиск

                flagOK = (_hashTable[index]._person.PhoneNumber == phoneNumber);
            }

            if (flagOK)
            {
                FIO = _hashTable[index]._person.FIO;
                result = index;
            }
            return result;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _hashTable)
                yield return item;
        }
    }
}
