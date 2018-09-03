using System;

namespace curso
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public Produto(string nome, double preco, int quantidadeEmEstoque)  // o CONSTRUTOR sempre com o nome da CLASSE
        {
            this.nome = nome;  // o THIS esta referenciando o OBEJETO nome = nome
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public Produto(string nome, double preco)  // o CONSTRUTOR com SOBRECARGA, foi tirado o parametro int quantidadeEmEstoque
        {
            this.nome = nome;  // o THIS esta referenciando o OBEJETO nome = nome
            this.preco = preco;
            this.quantidadeEmEstoque =0;
        }

        public double valorTotalEmEstoque() // metodo
        {
            return preco * quantidadeEmEstoque;
        }
        public void realizarEntrada(int quantidade) // o metodo VOID não tem retorno
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }
        public void realizarSaida(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }

    }
}
