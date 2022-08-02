using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter your name:");
            string Username = Console.ReadLine();

            Console.WriteLine("You have typed {0}", Username);
            Console.Write("What is your age:");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("What is your height in meter:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Your name is {0}, and you reply your age as {1}, and your height is {}", Username, Age.ToString(), height);

            Console.ReadKey(); //this is needed if we start with debugging
        }

    }
}
