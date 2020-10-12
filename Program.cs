using System;

namespace FundOne
{
    class Program
    {
        static void result(int N)
        {
            for (int num = 0; num < N; num++)
            {
                if (num % 3 == 0 && num % 5 == 0)
                Console.WriteLine(num + "fizzbuzz");

                else if (num % 3 == 0)
                Console.WriteLine(num + "fizz");

                else if (num % 5 == 0)
                Console.WriteLine(num + "buzz");
                
            }
                
        }
        static void Main(){
            int N = 100;
            result(N);
        }
    }
}
        
           
