using System;
using System.Linq;

namespace GeraSenhaAutomatico
{
    public static class SenhaHelper
    {
        public static string GeraSenhaAutomatico(int tamanho)
        {
            var chars = "abcdefghijklmnopqrstuvxyzçABCDEFGHIJKLMNOPQRSTUVWXYZÇ0123456789";
            var random = new Random();
            var senha = new string(Enumerable.Repeat(chars, tamanho).Select(s => s[random.Next(s.Length)]).ToArray());
            return senha;
        }
    }
}
