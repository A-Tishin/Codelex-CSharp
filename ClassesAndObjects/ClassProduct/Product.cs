using System;

namespace ClassProduct1
{
    public class Product
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

        public decimal Price
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price cannot be less, than zero.");
                }
                else
                {
                    _price = value;
                }
            }
            get => _price;
        }

        public int Stock => _amount;

        public void NewPrice(decimal newPrice)
        {
            Price = newPrice;
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
        }
    }
}
