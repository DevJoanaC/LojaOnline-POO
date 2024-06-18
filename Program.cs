using LojaOnline;

internal class Program
{
    private static void Main(string[] args)
    {

        Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();

        // adicionar produtos ao dicionário
        // keyvalue
        produtos["camisa"] = new Produto("camisa", 29.99, 10);
        produtos["calça"] = new Produto("calça", 39.99, 10);
        produtos["camisola"] = new Produto("camisola", 35.00, 10);
        produtos["meias"] = new Produto("meias", 3.50, 10);
        produtos["saia"] = new Produto("saia", 29.99, 10);   

        // criar o cliente 

        Cliente cliente1 = new Cliente("Joana Cardoso", "Braga, 124");

        // criar carrinho de compras

        CarrinhoCompras carrinhoCompras1 = new CarrinhoCompras();   

        // adicionar os produtos ao carrinho

        carrinhoCompras1.AdicionarProdutoCarrinho(produtos["camisola"]);
        carrinhoCompras1.AdicionarProdutoCarrinho(produtos["meias"]);

        // finalizar a compra 

        Pedido pedido1 = new Pedido(cliente1,carrinhoCompras1.ProdutosNoCarrinho);

        // adicionar o histórico so carrinho
        cliente1.HistoricoPedidos.Add(pedido1);
        Console.WriteLine($"Histórico do pedido dos clientes: {cliente1.NomeCliente}");
        // percorrer a lista com foreach

        foreach (var pedidoCliente in cliente1.HistoricoPedidos)
        {
            Console.WriteLine("Pedidos em "+DateTime.Now);
            Console.WriteLine();
            
            foreach (var ListaProdutos in pedidoCliente.ProdutosPedidos)
            {
                Console.WriteLine(ListaProdutos.NomeProduto+": "+ListaProdutos.PrecoProduto.ToString("F2")+"euros");
            }
            double totalCustoPedido = carrinhoCompras1.CalcularTotal();

            Console.WriteLine("Total: "+totalCustoPedido.ToString("F2")+" euros");
        }


        // Mostrar o stock 

        Console.WriteLine("Stock restante após compra:");

        foreach (var produto in produtos.Values)
        {
            Console.WriteLine("Produto: "+produto.NomeProduto+", Stock restante: "+produto.QuantidadeStock);
        }




    }
}