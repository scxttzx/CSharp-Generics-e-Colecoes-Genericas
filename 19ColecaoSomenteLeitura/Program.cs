
using System.Collections.ObjectModel;

var planetas = new List<string>()
{
	"Mercúrio", "Vênus", "Terra", "Marte"
};

var listaPlanetas = new ReadOnlyCollection<string>(planetas);
//var novaLista = planetas.AsReadOnly();
foreach (var planeta in listaPlanetas)
{
	Console.WriteLine($"{planeta} ");
}

Console.WriteLine($"\n\nPlanetas na coleção: {listaPlanetas.Count}");

Console.Write($"Júpiter esta na coleção?");
Console.WriteLine(listaPlanetas.Contains("Jupiter") ? "Sim" : "Não");

Console.WriteLine($"\nPlaneta de índice 3: {listaPlanetas[3]}");

Console.WriteLine($"\nIndice do planeta Terra: {listaPlanetas.IndexOf("Terra")}");

Console.WriteLine("\nInserindo um novo elemento na Lista original (índice 4)");
planetas.Insert(4, "Plutão");
Console.WriteLine("\nExibindo o novo planeta na lista");
foreach (var planeta in listaPlanetas)
{
	Console.WriteLine($"{planeta} ");
}

Console.WriteLine("\n\nCopiando os elementos da coleção para um Array unidimensional");
string[] planetasArray = new string[listaPlanetas.Count + 2];
listaPlanetas.CopyTo(planetasArray, 1);
Console.WriteLine($"\nO Array copiado possui {planetasArray.Length} elementos");
foreach (var planeta in listaPlanetas)
{
	Console.WriteLine($"\"{planeta}\"");
}


Console.ReadKey();