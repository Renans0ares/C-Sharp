using System;

namespace ExercicioAula03
{
    class Program
    {
        static void Main(string[] args)
        {
            DancaComun dancaC = new DancaComun();
            dancaC.PaisDeOrigem = "Estados Unidos";
            dancaC.DescricaoPassos = "BreakDance";
            dancaC.Ritmo = "HipHop";

            DancaCamilinho dancaCamilo = new DancaCamilinho();
            dancaCamilo.PaisDeOrigem = "Brasil";
            dancaCamilo.DescricaoPassos = "Passos Curtos feitos com os pés";
            dancaCamilo.Relatorio = "O que eu fiz durante a Dança? Desenhei passos curtos com os pés\n" +
                "Quais foram minhas limitações? Não realizar passos longos\n" +
                "O que pretendo fazer durante a proxíma dança? Deixar os passos mais fluídos";

            Console.WriteLine(dancaC.Dancar());
            Console.WriteLine("-------------------------------");
            Console.WriteLine(dancaCamilo.Dancar());
        }
    }
}
