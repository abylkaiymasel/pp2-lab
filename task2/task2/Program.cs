using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static bool CheckPrime(int x)
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

        public static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"/Users/ukadan.ali/Desktop/lab2/task2/task2/bin/Debug/input.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadLine();
            FileStream fss = new FileStream(@"/Users/ukadan.ali/Desktop/lab2/task2/task2/bin/Debug/ouput.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fss);
            sr.Close();
            string[] a = s.Split();
            for (int i = 0; i < a.Length; i++)
            {
                if (CheckPrime(int.Parse(a[i])) == true)
                    sw.Write(a[i] + " ");

            }
                sw.Close();



        }
    }
}