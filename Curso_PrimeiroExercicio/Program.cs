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

            // Cadastramento de produtos
            List<Produto> ProdList = new List<Produto>();
           
            for (int x = 1; x <=2; x++)
            {
                Produto prod = new Produto();
                Console.WriteLine("Digite os dados do Produto:");
                Console.Write("Código: ");
                prod.Codigo = Console.ReadLine();
                Console.Write("Descricao:");
                prod.Descricao = Console.ReadLine();
                Console.Write("Preco:");
                prod.Preco = Console.ReadLine();

                ProdList.Add(prod);
            }

            Console.WriteLine();

            // listando os PRODUTOS CADASTRADOS
            foreach (Produto p in ProdList)
            {
                Console.WriteLine($"Codigo : {p.Codigo}  ,Descricao: {p.Descricao}  ,Preco: {p.Preco}");
            }
        
            //Cadastramento de um pedido

            Console.WriteLine();

            Console.WriteLine("Digite os dados do pedido");

            Console.Write("Código do pedido: ");
            int Codigo= Convert.ToInt16( Console.ReadLine());

            Console.Write("Dia: ");
            var dia = Console.ReadLine();

            Console.Write("mês: ");
            var mes = Console.ReadLine();

            Console.Write("ano: ");
            var ano = Console.ReadLine();

            Console.Write("Quantos itens tem o pedido: ");
            int qtItem = Convert.ToInt16(Console.ReadLine());

            List<Pedido> Cadastramentopedido = new List<Pedido>();
            for (int x = 1; x <= qtItem; x++)
            {
                Pedido pedido = new Pedido();
                Console.Write("Digite os dados do" + x +"item");
                Console.Write("Código:");
                pedido.codigo = Console.ReadLine();
                Console.Write("Quantidade:");
                pedido.qta = Console.ReadLine();
                Console.Write("Porcentagem de desconto: ");
                pedido.Porcent = Console.ReadLine();

                Cadastramentopedido.Add(pedido);
            }


            Console.WriteLine();

            // Exibição dos dados de um pedido

            Console.WriteLine("Digite o código do pedido:");
            int numeroPedido =Console.Read();


            if (numeroPedido == Codigo)
            {
                
                    Console.WriteLine("Pedido : " + Codigo+ "    Data:"+ dia+"/" +mes+"/"+ano);
                    Console.WriteLine("Itens:");

                foreach (Pedido cadPedido in Cadastramentopedido)
                {
                    foreach (Produto p in ProdList)
                    {
                        Console.WriteLine(p.Descricao + "Preço: " + p.Preco + "Quantidade: " + cadPedido.qta+ "Desconto: "+ cadPedido.Porcent );
                    }
                    Console.ReadLine();
                }
            }


            

        }
    }
}
