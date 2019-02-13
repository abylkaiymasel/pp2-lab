using System;
using System.IO;

namespace task1
{
    class MainClass
    {
       public static bool CheckPolindrom(string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
                if (text[i] != text[text.Length - i - 1])
                    return false;

            return true;
        }
        public static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"/Users/ukadan.ali/Desktop/lab2/task1/task1/bin/Debug/pal.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadLine();



            if (CheckPolindrom(text))
                Console.WriteLine("Yes");

            else
                Console.WriteLine("No");
        }
       
               

        }


    }


