using System;

namespace ClassProduct1
{
    class Product
    {
        private string _name;
        private decimal _price;
        private int _amount;

        public Product(string name, decimal priceAtStart, int amountAtStart)
        {
            _name = name;
            _amount = amountAtStart;
            _price = priceAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name} | price: {_price} | quantity: {_amount}");
            Console.WriteLine();
        }

        public void NewPrice(decimal price)
        {
            _price = price;
        }

        public void NewQuantity()
        {
            _amount--;
        }
    }
}
