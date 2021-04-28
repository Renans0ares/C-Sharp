using System;
using System.Collections.Generic; //Necessário

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<string> list = new List<string>(); //Cria uma lista vazia

            //List<string> list2 = new List<string> { "Renan", "Carlos"}; //Declarar, instanciar e atribuir

            List<string> list = new List<string>();

            list.Add("Renan");
            list.Add("Giovanni");
            list.Add("Carlos");
            list.Add("Cris");

            list.Insert(1, "Luana"); //Vai empurra para a proxima posicao

            int i = 0;
            foreach (string cont in list)
            {
                Console.WriteLine($"#{i} - {cont}");
                i++;
            }

            Console.WriteLine("List Count : " + list.Count);

            string s1 = list.Find(x => x[0] == 'C');
            Console.WriteLine("Primeiro com a Letra 'C' : " + s1);

            string s2 = list.FindLast(x => x[0] == 'C');
            Console.WriteLine("Ultimo com a Letra 'C' : " + s2);

            int posicao1 = list.FindIndex(x => x[0] == 'C');
            Console.WriteLine("Primeira posicao 'C' : " + posicao1);

            int posicao2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine("Ultima posicao 'C' : " + posicao2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            foreach(string cont in list2)
            {
                Console.WriteLine(cont);
            }

            list.Remove("Giovanni");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            foreach (string cont in list)
            {
                Console.WriteLine(cont);
            }

            list.RemoveAll(x => x[0] == 'L');
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            foreach (string cont in list)
            {
                Console.WriteLine(cont);
            }

            list.RemoveAt(0);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            foreach (string cont in list)
            {
                Console.WriteLine(cont);
            }

            list.RemoveRange(1, 1);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            foreach (string cont in list)
            {
                Console.WriteLine(cont);
            }



        }

        static bool Teste(string s) //Ou a função no lugar do X
        {
            return s[0] == 'C';
        }
    }
}
