using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Renan", "Carlos", "Giovanni" };

            /*for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }*/

            int i = 1;
            foreach(string cont in vetor)
            {
                Console.WriteLine($"#{i} Nome = {cont}");
                i++;
            }
        }
    }
}
