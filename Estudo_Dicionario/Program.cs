using System;
using System.Collections.Generic;

namespace Estudo_Dicionario
{
    public class Livro
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Livro> livrosMaisVendidos = new Dictionary<int, Livro>();

            livrosMaisVendidos.Add(1, new Livro { Nome = "Livro 1", Autor = "Autor 1" });
            livrosMaisVendidos.Add(2, new Livro { Nome = "Livro 2", Autor = "Autor 3" });
            livrosMaisVendidos.Add(3, new Livro { Nome = "Livro 3", Autor = "Autor 3" });
            livrosMaisVendidos.Add(4, new Livro { Nome = "Livro 4", Autor = "Autor 1" });
            livrosMaisVendidos.Add(5, new Livro { Nome = "Livro 5", Autor = "Autor 1" });
            livrosMaisVendidos.Add(6, new Livro { Nome = "Livro 6", Autor = "Autor 2" });
            livrosMaisVendidos.Add(7, new Livro { Nome = "Livro 7", Autor = "Autor 2" });
            livrosMaisVendidos.Add(8, new Livro { Nome = "Livro 8", Autor = "Autor 1" });
            livrosMaisVendidos.Add(9, new Livro { Nome = "Livro 9", Autor = "Autor 3" });
            livrosMaisVendidos.Add(10, new Livro { Nome = "Livro 10", Autor = "Autor 1" });

            foreach (KeyValuePair<int, Livro> elemento in livrosMaisVendidos)
            {
                Console.WriteLine($"Chave: {elemento.Key} - Livro: {elemento.Value.Nome}");
                Console.WriteLine($"Livro: {elemento.Value}");
            }

            Console.WriteLine(livrosMaisVendidos[1].Nome);

            Console.WriteLine(livrosMaisVendidos.ContainsKey(1) ? livrosMaisVendidos[1].Nome : "");

            Livro livro1 = new Livro() { Nome = "Livro 1", Autor = "Autor 1" };
            Console.WriteLine(livrosMaisVendidos.ContainsValue(livro1) ? livrosMaisVendidos[1].Nome : "");

            if (livrosMaisVendidos.TryGetValue(9, out Livro livroRecuperado))
                Console.WriteLine(livroRecuperado.Nome);
        }
    }
}
