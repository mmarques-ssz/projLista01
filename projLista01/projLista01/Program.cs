using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLista01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes;
            nomes = new List<string>();

            // Adicionando elementos à lista (ao final)
            nomes.Add("Joao");
            nomes.Add("Jose");
            nomes.Add("Antonio");
            nomes.Add("Pedro");
            nomes.Add("Paulo");
            listaNomes(nomes);

            // Inserindo o nome Maria na 3º posição da lista
            nomes.Insert(2, "Maria");
            listaNomes(nomes);

            nomes.Add("Maria");
            listaNomes(nomes);
            
            Console.WriteLine("Posição de Maria na lista: {0}", nomes.IndexOf("Maria"));
            Console.WriteLine("Posição de Carlos na lista: {0}", nomes.IndexOf("Carlos"));
            Console.WriteLine("Posição de Maria na lista: {0}", nomes.LastIndexOf("Maria"));
            Console.WriteLine("======================");

            // Remover elementos pelo valor
            Console.WriteLine(nomes.Remove("Pedro") ? "Foi removido" : "Não encontrado");
            Console.WriteLine(nomes.Remove("Carlos") ? "Foi removido" : "Não encontrado");
            listaNomes(nomes);

            // Remover elementos pela posição. No caso, o 1º elemento da lista
            nomes.RemoveAt(0);
            listaNomes(nomes);

            Console.WriteLine(nomes.Find(x => x == "Maria"));
            Console.WriteLine(nomes.FindIndex(x => x == "Maria"));


            Console.ReadKey();
        }

        static void listaNomes(List<string> ls)
        {
            Console.WriteLine("= Qtde: {0} ============", ls.Count);
            foreach (String s in ls)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("======================");
        }

    }
}
