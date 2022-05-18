using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    class product
    {
        static int _count;
        public static int Count { get => _count; }
        int _id;
        public int Id { get => _id; }
        public string Name;
        public double Price;
        public int ProductCount;
        static product()
        {
            _count = default(int);
        }
        public product(string name, double price, int productCount)
        {
            _count++;
            _id = _count;
            Name = name;
            Price = price;
            ProductCount = productCount;
        }

        public override string ToString()
        {
            return "ID: " + Id + ", Name: " + Name + ", Price: " + Price + ", Count: " + ProductCount;
        }
    }
}
