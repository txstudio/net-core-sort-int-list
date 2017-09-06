using System;
using System.Collections.Generic;

namespace net_core_sort_int_list
{
    class Program
    {
        static List<int> GetIntArray()
        {
            List<int> _items;

            _items = new List<int>();
            _items.Add(25);
            _items.Add(5);
            _items.Add(7);
            _items.Add(18);
            _items.Add(21);
            _items.Add(14);
            _items.Add(11);

            return _items;
        }

        static void Main(string[] args)
        {
            List<int> _items;

            _items = GetIntArray();

            Console.WriteLine("orginal array");
            Console.WriteLine(String.Join(",", _items.ToArray()));
            Console.WriteLine();

            _items = GetIntArray();
            _items.Sort();

            Console.WriteLine("sort with asc");
            Console.WriteLine(String.Join(",", _items.ToArray()));
            Console.WriteLine();

            _items = GetIntArray();
            _items.Sort();
            _items.Reverse();

            Console.WriteLine("sort with desc");
            Console.WriteLine(String.Join(",", _items.ToArray()));
            Console.WriteLine();
        }
    }
}
