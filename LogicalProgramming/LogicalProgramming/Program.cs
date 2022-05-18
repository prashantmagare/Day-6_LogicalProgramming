﻿using System;

namespace Day6LogicalPrograms
{
    internal class Program
    {
        public class ReverseNumber
        {
            int reverse = 0, rem;
            public void Reverse_number(int number)
            {
                while (number != 0)
                {
                    rem = number % 10;
                    reverse = reverse * 10 + rem;
                    number /= 10;
                }
                Console.Write("Reversed Number: " + reverse);
            }
        }

        public class Reverse

        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Reverse Number Program");
                Console.Write("Enter a number: \n ");
                int number = Convert.ToInt32(Console.ReadLine());
                ReverseNumber r = new ReverseNumber();
                r.Reverse_number(number);

            }
        }

    }
}

