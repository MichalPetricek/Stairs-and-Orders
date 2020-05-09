using System;
using System.Collections.Generic;
using System.Text;

namespace Stairs
{
    class Stairs
    {
        private List<int> values;
        public Stairs(int first, int height, int stair)
        {
            values = new List<int>();
            do
            {
                values.Add(first);
                first += stair;
            } while (height + stair > first);
            Console.WriteLine(this);
            Console.WriteLine("Prostor pro schodiště:"+(63 - (2 * stair)) * values.Count);
            Console.ReadKey();
        }
        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < values.Count; i++)
            {
                temp += (i+1) + "." + values[i] + "cm ";
            }
            return temp;
        }
    }
}
