
using PizzariaCSharp.Controller;
using PizzariaCSharp.Enums;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

Console.WriteLine("Simulando API");
Console.WriteLine();

// Criando os controllers
var controlherBebida = new BebidaController(new BebidaRepository());
var controlherSabor = new SaborController(new SaborRepository());
var controlherPizza = new PizzaController(new PizzaRepository());
var controlherCliente = new ClienteController(new ClienteRepository());
var controlherPedido = new PedidoController(new PedidoRepository());

// Simulando a API

// 1° Cadastrar duas bebidas
var bebida1 = controlherBebida.Adicionar(new Bebida("Coca Cola 2lt", 10.0));
var bebida2 = controlherBebida.Adicionar(new Bebida("H2O Limoneto", 10.0));

// 2° Cadastrar 4 Sabores
var sabor1 = controlherSabor.Adicionar(new Sabor("4 Queijos", ""));
var sabor2 = controlherSabor.Adicionar(new Sabor("Portuguesa", ""));
var sabor3 = controlherSabor.Adicionar(new Sabor("Calabresa", ""));
var sabor4 = controlherSabor.Adicionar(new Sabor("Frango com Catupiry", ""));

// 3° Cadastrar 2 clientes
var cliente1 = controlherCliente.Adicionar(new Cliente(){Nome= "Jose Francisco",Telefone="02199999999"});
var cliente2 = controlherCliente.Adicionar(new Cliente(){Nome= "Renato Silveira",Telefone="02199999988"});

// 4° Criar pizzas
var pizza1 = new Pizza(ETipoPizza.GIGANTE, ETipoBorda.COM_CHEDDAR, 40.0, new List<Sabor>(){sabor1, sabor2});
var pizza2 = new Pizza(ETipoPizza.SUPER_GIGANTE, ETipoBorda.SEM_BORDA, 50.0, new List<Sabor>(){sabor2, sabor3});
var pizza3 = new Pizza(ETipoPizza.MEDIA, ETipoBorda.COM_GORGONZOLA, 35.0, new List<Sabor>(){sabor4});
var pizza4 = new Pizza(ETipoPizza.GIGANTE, ETipoBorda.COM_MUSSARELA, 40.0, new List<Sabor>(){sabor3});


// Cadastrar pedido.

var pedido1 = new Pedido(cliente1);

var valor1 = pedido1
    .AdicionarBebida(bebida1)
    .AdicionarBebida(bebida2)
    .AdicionarPizza(pizza1)
    .AdicionarPizza(pizza2)
    .AdicionarPizza(pizza3)
    .ObterValorTodal();

pedido1.FinalizarPedido();
controlherPedido.Adicionar(pedido1);

var pedido2  = new Pedido(cliente2);

var valor2 = pedido2
    .AdicionarBebida(bebida2)
    .AdicionarPizza(pizza4)
    .ObterValorTodal();

pedido2.FinalizarPedido();
controlherPedido.Adicionar(pedido2);

Console.WriteLine();

