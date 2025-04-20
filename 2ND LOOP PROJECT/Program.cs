using System;
using System.Collections.Generic;
using System.IO;

namespace consoleApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++) { 
                Console.WriteLine("Name of student");
                string x= Console.ReadLine();
                Console.WriteLine("Marks of student");
                int y;
                y=int.Parse(Console.ReadLine());
                if (y > 100)
                {
                    Console.WriteLine("A+\n");
                    Console.WriteLine(x);
                }

                else if (y >= 80)
                {
                    Console.WriteLine("A");
                    Console.WriteLine(x);
                }

                else if (y >= 70)
                {
                    Console.WriteLine("B");
                    Console.WriteLine(x);
                }
                else if (y >= 50)
                {
                    Console.WriteLine("D");
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("Fail");
                    Console.WriteLine(x);
                }

            }
        }
    }
}

