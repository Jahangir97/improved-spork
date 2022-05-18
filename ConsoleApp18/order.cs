using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    class order
    {
        public List<product> Products;
        public int price;
        public DateTime Date;

        public order(DateTime datetime)
        {
            Products = new List<product>();
            Date = datetime;
        }
    }
}
