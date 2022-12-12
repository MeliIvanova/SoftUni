﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]<0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            
            if (numbers.Count >0)
            {
                numbers.Reverse();
                Console.Write(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
