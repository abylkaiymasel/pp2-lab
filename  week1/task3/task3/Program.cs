using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());                                            //Get the number of numbers
                int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);     //Create an array of read numbers
            for (int i=0; i<a.Length; i++)                                                          //Output of the received array
            {
                         Console.Write(a[i] + " " + a[i] + " ");                                    //the output
            }

        }
    }
}
