// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

namespace Perfectnumbersapplication
{
    class App2
    {
        static void Main(string[] args)
        { /* project 2 */
            // start

            Console.WriteLine(" Please, Enter Your Range Number from n1 to n2");
            Console.WriteLine(" Enter n1 ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(" These are the peerfect numbers between your range: ");
            int sum = 0;
            for ( int a=x; a<=y;a++)
            {
                for(int k = 1; k < a; k++)
                {
                    if (a % k == 0)
                    { sum = sum + k; }
                    else continue;
                }
                if (sum == a) { Console.Write(a + "\t"); sum = 0; }
                if (sum != a) sum = 0;
            }
            Console.ReadKey();
            // end 
           
          






        }


    }
}
