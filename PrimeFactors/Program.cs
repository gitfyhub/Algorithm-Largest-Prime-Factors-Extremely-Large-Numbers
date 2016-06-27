using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Largest prime factor
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
*/

namespace PrimeFactors
{
    class Program
    {
        class MainClass6
        {
            static void Main()
            {
                long NumberToCheck = 600851475143; //13195;

                HashSet<long> primeNumber = new HashSet<long>();
                HashSet<long> finalPrimeNumbers = new HashSet<long>();

                for (long i = 1; i < 10000; i++)
                {

                    if (NumberToCheck % i == 0)
                    {
                        primeNumber.Add(i);
                        //Console.WriteLine(i);
                    }
                }

                int addCount = 0;

                foreach (int p in primeNumber)
                {
                    addCount = 0;
                    for (long i = 1; i < 10000; i++)
                    {

                        if (p % i == 0)
                        {
                            addCount++;
                        }
                    }

                    if (addCount == 2)
                    {
                        finalPrimeNumbers.Add(p);
                    }
                }

                Console.WriteLine(finalPrimeNumbers.Max());
            }
        }
    }
}
