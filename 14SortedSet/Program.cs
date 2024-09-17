
var numeros = new SortedSet<int>(){ 1, 5, 3, 4, 2 };
ExibirColecao(numeros);

var frutas = new SortedSet<string> { "uva", "banana", "pera", "kiwi" };
ExibirColecao(frutas);

SortedSet<int> pares = new SortedSet<int>();
for (int i = 6; i > 0;i--)
{
    pares.Add(i);
}
ExibirColecao(pares);

var numeros2 = new List<int>() { 1, 7, 3, 6, 5, 4, 2 };
SortedSet<int> conjunto = new SortedSet<int>(numeros2);
ExibirColecao(conjunto);

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
		Console.WriteLine(item);
}