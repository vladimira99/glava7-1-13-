﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] arr = new int[20];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i * 5;
                    Console.WriteLine(arr[i]);
                }
        }
    }
}
