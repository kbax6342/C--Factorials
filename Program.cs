using System;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)

        {
            int total = 1;
            Console.WriteLine("Please enter a number to factorial:");
            int factorial = int.Parse(Console.ReadLine());

            for(int i = factorial; i >= 1; i--){
                
                    Console.Write($"{i}\tx\t");
                     total *= i;
                

              
            }
            
            Console.WriteLine($" {total}");
            
                    }
    }
}
