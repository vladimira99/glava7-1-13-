﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arraysEqual = true;

            Console.Write("Въведи: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arrA = new int[length];

            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Въведи първия елемент{0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter lenght of second array: ");

            if (length != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
            else
            {
                int[] arrB = new int[length];

                for (int i = 0; i < arrB.Length; i++)
                {
                    Console.Write("Въведи елемент {0}: ", i);
                    arrB[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] != arrB[i])
                    {
                        Console.WriteLine("\nArrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("\nArrays are the same.");
            }
        }
    }
}
