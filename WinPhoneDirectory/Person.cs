namespace WinPhoneDirectory
{
    internal struct Person
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
                
                _phoneNumber = value;
            }
        }
    }
}
