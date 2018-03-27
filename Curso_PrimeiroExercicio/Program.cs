using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> ProdList = new List<Produto>();
           
            for (int x = 0; x <=3; x++)
            {
                Produto prod = new Produto();
                Console.WriteLine("Digite os dados do Produto:");
                Console.WriteLine("Código:");
                prod.Codigo = Console.ReadLine();
                Console.WriteLine("Descricao:");
                prod.Descricao = Console.ReadLine();
                Console.WriteLine("Preco:");
                prod.Preco = Console.ReadLine();

                ProdList.Add(prod);
            }

            foreach(Produto p in ProdList)
            {
                Console.WriteLine($"Codigo: {p.Codigo}, Descricao: {p.Descricao},Preco: {p.Preco}");
            }

           

            foreach (Produto p in ProdList)
            {
                Console.WriteLine($"Codigo: {p.Codigo}, Descricao: {p.Descricao},Preco: {p.Preco}");
            }

            Console.ReadLine();

        }
    }
}
