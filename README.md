# Loja Online 🛒

Bem-vindo ao projeto da Loja Online! Este projeto foi desenvolvido para criar um sistema de loja online com funcionalidades essenciais, utilizando Programação Orientada a Objetos (POO) em C#. 

## Funcionalidades

- **Produtos:** Cada produto possui nome, preço e quantidade em stock.
- **Clientes:** Os clientes têm nome, endereço e histórico de pedidos.
- **Carrinhos de Compras:** Permite que os clientes adicionem e removam itens, calculem o total da compra e finalizem o pedido.
- **Histórico de Pedidos:** Armazena o histórico dos pedidos de cada cliente, permitindo que eles visualizem seus pedidos anteriores.

## Estrutura do Projeto

O sistema é composto por classes para representar os diferentes componentes:

1. **Produto:** Armazena informações como nome, preço e quantidade em stock.
2. **Cliente:** Armazena detalhes como nome, endereço e histórico de pedidos.
3. **Carrinho de Compras:** Permite a adição e remoção de itens, cálculo do total da compra e finalização do pedido.

## Exemplo de Dados de Entrada

```csharp
Produto produto1 = new Produto("camisa", 29.99, 10);
Produto produto2 = new Produto("calça", 39.99, 10);
Produto produto3 = new Produto("camisola", 35.00, 10);
Produto produto4 = new Produto("meias", 3.50, 10);
Produto produto5 = new Produto("saia", 29.99, 10);
