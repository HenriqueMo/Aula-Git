using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int qte;
            Produto P;
           

            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome:  ");
            string nome = Console.ReadLine();
            Console.Write("Preço:  ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade em Estoque:  ");   para usar o construtor de SOBRECARGA
            //int quantidade = int.Parse(Console.ReadLine());

            P = new Produto(nome, preco);  // instanciar PRODUTO

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + P.nome + ", R$" + P.preco + ", " + P.quantidadeEmEstoque + ", unidades, Total: R$: "
                + P.valorTotalEmEstoque());

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");

            qte = int.Parse(Console.ReadLine());
            P.realizarEntrada(qte); // chamando o método RealizarEntrada

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P.nome + ", R$" + P.preco + ", " + P.quantidadeEmEstoque + ", unidades, Total: R$: "
                + P.valorTotalEmEstoque());
                
            // Sairam do ESTOQUE
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que Sairam do estoque: ");

            qte = int.Parse(Console.ReadLine());
            P.realizarSaida(qte); // chamando o método RealizarSaida

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P.nome + ", R$" + P.preco + ", " + P.quantidadeEmEstoque + ", unidades, Total: R$: "
                + P.valorTotalEmEstoque());



            Console.ReadLine();


        }
    }
}
