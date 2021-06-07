using System;
using System.IO;

namespace FileStreamandStremReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\renan.sousa\Documents\File.txt";
            
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
