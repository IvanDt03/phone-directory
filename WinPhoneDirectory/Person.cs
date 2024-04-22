namespace WinPhoneDirectory
{
    internal class Person
    {
        public Person(string phoneNUmber, string FIO)
        {
            _phoneNumber = phoneNUmber;
            this.FIO = FIO;
        }
        public Person() : this(String.Empty, String.Empty) { }

        private string _phoneNumber;
        public string FIO { get; set; }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value.Length != 11) throw new ArgumentException("Invalid phone number");
                _phoneNumber = value;
            }
        }
    }
}
