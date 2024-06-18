using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class Produto
    {
        // atributos
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public int QuantidadeStock { get; set; }
     
        // construtor 
        public Produto(string nomeProduto, double precoProduto, int quantidadeStock) 
        {
            NomeProduto = nomeProduto;
            PrecoProduto = precoProduto;
            QuantidadeStock = quantidadeStock;
        }

        // metodos

        public void AtualizarStock(int quantidade)
        {
            if (quantidade <= QuantidadeStock) 
            {
                QuantidadeStock -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente.");
            }
        }

    }
}
