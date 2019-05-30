using System;
using System.Collections.Generic;

namespace Arrays_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> list = new List<int>();
            int count = 0;
            int num;
            string input = "yes";


            Console.WriteLine("Please enter 5 unique numbers!");

            while (count < 5)
            {
                list.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Number Entered!");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("5 Numbers Entered!");

            while (input != "no")
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a Number!");
                num = int.Parse(Console.ReadLine());

                if (!list.Contains(num))
                {
                    Console.WriteLine(num + " Added to List!");
                    list.Add(num);
                }

                else
                {
                    Console.WriteLine(num + " is already in the List!");
                }

                Console.WriteLine("Would you like to enter a new number?");
                input = Console.ReadLine();

            }
            Console.ReadKey();
        }
    }
}
