using System;

namespace ClassProduct1
{
    class Product
    {
        private string _name;
        private decimal _price;
        private int _amount;

        public Product(string name, decimal price, int amount)
        {
            _name = name;
            _amount = amount;
            _price = price;
        }

        public void PrintProduct()
        {
            if (_amount > 0)
            {
                Console.WriteLine($"{_name} | price: {_price} | quantity: {_amount}");
            }
            else
            {
                Console.WriteLine($"{_name} | price: {_price} | Out of stock.");
            }
        }

        public void NewPrice(decimal price)
        {
            _price = price;
        }

        public void Sold()
        {
            if (_amount == 0)
            {
                return;
            }
            _amount--;
        }

        public void Supply(int quantity)
        {
            _amount += quantity;
            Console.WriteLine($"X{quantity} {_name} has arrived to store.");
        }
    }
}
