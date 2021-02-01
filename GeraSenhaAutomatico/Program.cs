using System;

namespace GeraSenhaAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho da senha: \n");
            var tamanho = Console.ReadLine();
            Console.WriteLine("Senha -> " + SenhaHelper.GeraSenhaAutomatico(Convert.ToInt32(tamanho)));
            Console.ReadKey();
        }
    }
}
