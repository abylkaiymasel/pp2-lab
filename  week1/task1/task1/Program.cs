using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n= Convert.ToInt32(Console.ReadLine());                                             //read the number of array
                 int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);    //create an array 
            int NoP = 0;                                                                            //create counter of prime number

            List<int> Prime = new List<int>();                                                      //create a List for prime numbers

            for (int i=0; i<a.Length; i++)                                                          //check each element of the array
            {
                if (CheckPrime(a[i]))                                                               //call the method CheckPrime, checking whether a number is prime
                {
                    Prime.Add(a[i]);                                                                //add prime number to the prime numbers array                      
                    NoP++;                                                                          //increment prime counter
                }
            }
            Console.WriteLine(NoP);                                                                 //output the total number of prime numbers
                foreach (int el in Prime)                                                           //Loop through the array                                                               

                Console.Write(el + " ");
            }


        static bool CheckPrime(int x)                                                               //create a function to check if a number is prime
    {
            if (x == 1)
            {
                return false;
            }
                    for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                         if (x % i == 0)
            {
                              return false;
            }                  
            }
                                    return true;
        }

    }
}


