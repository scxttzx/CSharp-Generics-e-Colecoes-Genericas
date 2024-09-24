//Stack<int> numeros = new Stack<int>();
//numeros.Push(1);

//int[] array1 = new int[] { 1, 2, 3, 4 };
//Stack<int> pilha1 = new Stack<int>(array1);

//var impares = new Stack<int>(3);
//impares.Push(1);

Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);

Console.WriteLine($"-A pilha original contém {numeros.Count} itens");

ExibirPilha(numeros);
Console.ReadKey();

// retorna sem remover
Console.WriteLine($"\n-Item obtido da pilha (Peek):  {numeros.Peek()}");

// remove e retorna
Console.WriteLine($"\n-Item removido da pilha (Pop): {numeros.Pop()}");
ExibirPilha(numeros);

if(numeros.Contains(20))
{
	Console.WriteLine("\n-20 está na pilha");
}
else
{
	Console.WriteLine("\n-20 não está na pilha");
}

Console.WriteLine("\n-Cópia da pilha usando Array");
var copia = new Stack<int>(numeros.ToArray());
ExibirPilha(copia);

Console.WriteLine("\nRemovendo todos os itens da pilha");
numeros.Clear();
Console.WriteLine($"{numeros.Count} itens");

ExibirPilha(numeros);

static void ExibirPilha<T>(IEnumerable<T> numeros)
{
	foreach (var item in numeros)
	{
        Console.WriteLine(item);
    }
}
