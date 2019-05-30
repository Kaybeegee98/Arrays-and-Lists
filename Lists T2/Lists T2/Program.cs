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
            List<int> total = new List<int>();
            int count = 0;
            int num;
            int y;
            string input = "yes";


            Console.WriteLine("Please enter 5 unique numbers!");

            while (count < 5)
            {
                num = int.Parse(Console.ReadLine());

                if (!list.Contains(num))
                {
                    Console.WriteLine(num + " Added to List!");
                    list.Add(num);
                    total.Add(num);
                    count++;
                }
                else
                {
                    Console.WriteLine(num + " is already in the List!  Please make sure these numbers are unique.");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("5 Numbers Entered!");

            while (input != "no")
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a Number!");
                num = int.Parse(Console.ReadLine());
                total.Add(num);

                if (!list.Contains(num))
                {
                    Console.WriteLine();
                    Console.WriteLine(num + " Added to List!");
                    list.Add(num);
                }

                else
                {
                    Console.WriteLine(num + " is already in the List!");
                    y = 0;
                    foreach(int x in total)
                    {
                        if (x == num)
                        {
                            y++;
                        }
                    }
                    
                    Console.WriteLine("You have Entered the Number " + num + " " + y + " Times" );
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to enter a new number?");
                input = Console.ReadLine();

            }
            Console.ReadKey();
        }
    }
}