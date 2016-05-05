using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str, Revstr = "";
            Console.Write("Enter a string: ");
            Str = Console.ReadLine();

            for (int i = Str.Length - 1; i >= 0; i--)
            {
                Revstr = Revstr + Str[i];
            }

            Console.WriteLine("Reverse string is: {0}", Revstr);
            Console.ReadLine();
        }
    }
}
