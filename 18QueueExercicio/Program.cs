﻿// criando a fila de pedidos
Queue<Pedido> filaPedidos = new Queue<Pedido>();

// adionar pedidos na fila
filaPedidos.Enqueue(new Pedido(101, 10.0));
filaPedidos.Enqueue(new Pedido(201, 20.0));
filaPedidos.Enqueue(new Pedido(301, 30.0));

// exibir o numero de pedidos na fila
Console.WriteLine($"\nNúmero de pedidos na fila: {filaPedidos.Count}");

// processar os  pedidos da fila
while(filaPedidos.Count > 0)
{
	Pedido proximoPedido = filaPedidos.Dequeue();
    Console.WriteLine($"Processando pedido {proximoPedido.Numero}, " +
					  $"Valor {proximoPedido.Valor}");
}

// Adicionar mais alguns pedidos à fila
filaPedidos.Enqueue(new Pedido(401, 40.0));
filaPedidos.Enqueue(new Pedido(501, 50.0));
filaPedidos.Enqueue(new Pedido(601, 60.0));

// localizar o próximo pedido na fila
int numeroPedido = 501;
Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(p=> p.Numero == numeroPedido);

if (pedidoLocalizado != null)
{
    Console.WriteLine($"Pedido {numeroPedido} localizado na fila, " +
					  $"Valor {pedidoLocalizado.Valor}");
}
else
{
    Console.WriteLine($"Pedido {numeroPedido} não encontrado na fila");
}

Console.ReadKey();
class Pedido
{
	public int Numero { get; set; }
	public double Valor { get; set; }

	public Pedido (int numero, double valor)
	{
		Numero = numero;
		Valor = valor;
	}
}