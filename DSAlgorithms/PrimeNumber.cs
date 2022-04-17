using System;
namespace DSAlgorithms
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            
            for (int number = 1; number < 1000; number++)
            {
                int count = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(number);
                }
            }
            
        }
    }
}
