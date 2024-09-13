﻿Console.WriteLine("\n### Criando o SortedDictionary ###");

var brics = new SortedDictionary<int, string>()
{
	{ 20, "Brasil" },
	{ 10, "China" },
	{ 40, "India" },
	{ 30, "URSS" }
};

Console.WriteLine("\n-Incluindo o elemento de chave = 70 e valor = África do Sul");
if (brics.ContainsKey(70))
	Console.WriteLine("Chave já existe");
else
	brics.Add(70, "África do Sul");
Console.WriteLine($"\n-Número de pares de chaves (elementos) no dicionário: {brics.Count}");

Console.WriteLine("\nAcessando um elemento pela chave -> brics[20]");
Console.WriteLine($"Chave 20 -> {brics[20]}");

brics[20] = "Argentina";
Console.WriteLine($"Chave 20 -> {brics[20]}");

Console.WriteLine("\nRemovendo chave 10: brics.Remove(10) -> China");
brics.Remove(10);

Console.WriteLine("\nVerificando se uma chave existe com ConstainsKey");
Console.WriteLine($"Existe a chave: 30? -> {brics.ContainsKey(30)}");

Console.WriteLine("\n-Verificando se um valor existe com ConstainsValue");
Console.WriteLine($"Existe o valor: 'URSS'? -> {brics.ContainsValue("URSS")}");
Console.WriteLine($"Existe o valor: 'Chile'? -> {brics.ContainsValue("Chile")}");

Console.WriteLine("\nObtendo o valor da chave 30 usando o tryGetValue");

if(brics.TryGetValue(30, out string? valor))
{
    Console.WriteLine($"Valor da chave 30: {valor}");
}
else
{
    Console.WriteLine("A chave não existe.");

    Console.WriteLine("\n-Percorrendo um SortedDictionary com foreach\n");
}

foreach (var pais in brics)
{
	Console.WriteLine($"Chave: {pais.Key} - Valor: {pais.Value}");
}

Console.ReadKey();