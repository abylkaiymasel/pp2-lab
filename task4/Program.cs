using System.IO;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           string file = "input.txt.rtf";
            string path = @"/Users/ukadan.ali/Desktop/lab2/task4/task4/path/" + file ;
            string path1 = @"/Users/ukadan.ali/Desktop/lab2/task4/task4/path1/" + file;

         FileStream FS = new FileStream(path, FileMode.Create, FileAccess.Write);
          FS.Close();
            File.Copy(path, path1);
            File.Delete(path);
            }
    }
}
