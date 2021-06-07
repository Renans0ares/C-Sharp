using System;
using System.IO;

namespace TrabalhandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {                        //Colocar caminho
            string sourcePath = @"";
            string targetPath = @"";

            try
            {
                //FileInfo fileinfo = new FileInfo(sourcePath);
                //fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An erro occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
