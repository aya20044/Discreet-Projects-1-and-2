// See https://aka.ms/new-console-template for more information
// converion using casting operation
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System;
namespace Projectone
{
    class project1
    {
        static void Main(string[] args)
        { // project one discreet task // prime numbers //start

            int i = 0, j = 0;
            Console.WriteLine("enter the first number,please");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number,please");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" These are the prime numbers between your range:");
            for (i = num1; i <= num2; i++)
            {
                if (i == 0 || i == 1)
                    continue;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0) break;
                    if (i % j != 0) ;

                }
                if (i == j) Console.Write(i+ "\t");
            }
            Console.ReadLine();
        }
    }
}
//End 
