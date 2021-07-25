namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double money)
        {
            _name = name;
            _money = money;
        }

        public double withdrawal(double i)
        {
            _money -= i;
            return i;
        }

        public void deposit(double i)
        {
            _money += i;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }
    }
}
