using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class CarrinhoCompras
    {
        // atributos 
        public List<Produto> ProdutosNoCarrinho { get; set; } = new List<Produto>();


        // métodos
        public void AdicionarProdutoCarrinho(Produto produto)
        {
            ProdutosNoCarrinho.Add(produto);
            // produto.QuantidadeStock--;  // se meto um produto no carrinho, o stock diminui
            produto.AtualizarStock(1); // 1 é uma quantidade 
        }

        public void RemoverProdutoCarinho(Produto produto)
        {
            ProdutosNoCarrinho.Remove(produto);
        }

        public double CalcularTotal() 
        {
            double total = 0;
            foreach (var produto in ProdutosNoCarrinho)
            {
                total += produto.PrecoProduto;
            }
            Console.WriteLine("");
            return total;
        }   
    }
}
