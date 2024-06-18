using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class Pedido
    // A classe "pedido" vai encapsular a informação relacionada com o pedido
    // incluindo a informação do cliente associado ao pedido

    {
        public Cliente cliente { get; set; }
        public List<Produto> ProdutosPedidos { get; set; }

        // construtor


        // receber um objeto cliente e uma lista de produto
        public Pedido(Cliente Cliente, List<Produto>produtosPedidos) // inicializamos a lista dentro do construtor
            {
            cliente = Cliente;
            ProdutosPedidos = produtosPedidos;
            }







    }


}
