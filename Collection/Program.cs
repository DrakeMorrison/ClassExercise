using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var list = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(random.Next(51));
            }

            var squaredList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                squaredList.Add(list[i] * list[i]);
            }

            squaredList.RemoveAll(x => x % 2 != 0);
        }
    }
}
