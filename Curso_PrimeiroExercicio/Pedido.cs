using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_PrimeiroExercicio
{
    class Pedido
    {
        public string Codigo { get; set;}
        public string Dia { get; set; }
        public string Mes { get; set; }
        public string Ano { get; set; }
        public string QtItem { get; set; }
        public string CodProd { get; set; }
        public string Porc { get; set; }

        public void fazerPedido()
        {
            List<Pedido> ListPedido = new List<Pedido>();
            Console.WriteLine("Digite os dados do Pedido:");
            Console.WriteLine("Código:");
            var codigo = Console.ReadLine();



            Console.WriteLine("Quantos itens tem o Pedido?");
            var ItQtd = Console.ReadLine();

            for (int x = 1; x <= int.Parse(ItQtd); x++)
            {

                Pedido ped = new Pedido();
                ped.Codigo = codigo;
                Console.WriteLine("Código:");
                ped.Codigo = Console.ReadLine();
                //Console.WriteLine("Descricao:");
                //ped.Descricao = Console.ReadLine();
                //Console.WriteLine("Preco:");
                //ped.Preco = Console.ReadLine();

                ListPedido.Add(ped);
            }

        }
    }
}
