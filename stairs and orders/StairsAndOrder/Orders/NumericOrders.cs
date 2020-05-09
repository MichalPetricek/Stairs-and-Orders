using System;
using System.Collections.Generic;
using System.Text;

namespace Orders
{
    class NumericOrders
    {
        public int Radix{get; private set;}
        public int Order{get; set;}
        private List<int> Numbers { get; set; }

        public NumericOrders(int radix, int order)
        {
            Numbers = new List<int>();
            Radix = radix;
            Order = order;
            int x = 1;
            Console.Write("Základ soustavy: "+ Order +" Váhy: ");
            for (int i = 1; i < Radix; i++)
            {
                x *= order;
                Numbers.Add(x);
            }
            Numbers.Reverse();
            foreach(int y in Numbers)
            {
                Console.Write(y);
                Console.Write("; ");
            }
            Console.Write("1;");
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
