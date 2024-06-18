using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    internal class Cliente
    {
        // Atributos
        public string NomeCliente { get; set; }
        public string MoradaCliente { get; set; }
        
        public List<Pedido> HistoricoPedidos { get; set; } = new List<Pedido>();

        // Construtor
        public Cliente(string nomeCliente, string moradaCliente ) 
        { 
            NomeCliente = nomeCliente;
            MoradaCliente = moradaCliente;
        }






    }
}
