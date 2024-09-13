
// criação coleção hashset com itens
var numeros = new HashSet<int> { 1, 2, 3, 4, 5 };

var frutas = new HashSet<string> { "uva", "banana", "pera" };

HashSet<int> pares = new HashSet<int>();

for (int i = 0; i < 6; i++)
{
	pares.Add(i * 2);
}

// construtor usando IEnumebrable
var lista1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
var conjunto = new HashSet<int>(lista1);

var lista2 = new List<string>() { "uva", "banana", "pera" };
HashSet<string> minhasFrutas = new HashSet<string>(lista2);

var impares = new int[] { 1, 3 , 5, 7, 9, 11, 13 };
HashSet<int> meuHashSet = new HashSet<int>(impares);

Console.ReadKey();