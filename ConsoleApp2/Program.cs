 using System;

 using System.Security.Cryptography.X509Certificates;
 using Microsoft.VisualBasic.CompilerServices;
 


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string f = Console.ReadLine();
            Console.WriteLine("enter your category");
            var d= Console.ReadLine();
             
            if (d.Contains("vip"))
            {
              Console .WriteLine("your paymen is equal to 2500");
            }
            else
            {
                Console.WriteLine("your paymet is equal to 1500");
            }
            Console.ReadKey();
        }
        
    }
}