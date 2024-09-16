var timesSP = new HashSet<string> { "Santos", "Palmeiras", "São Paulo" };

var timesRJ = new HashSet<string> { "Vasco", "Flamengo", "Fluminense" };

var timesBA = new HashSet<string> { "Bahia", "Vitória", "Juazeiro" };

var timesMundiais = new HashSet<string> { "Santos", "São Paulo", "Flamengo" };

if(!timesSP.Contains("Corinthians"))
{
	timesSP.Add("Corinthians");
	timesSP.Add("Santos");
}

var resultado = timesBA.Remove("Juazeiro");

if(timesSP.IsSubsetOf(timesMundiais)) // timesSp não é um sub conjunto de timesMundiais
{
	Console.WriteLine("SP é subconjunto de Mundiais");
}
else
{
    Console.WriteLine("SP não é um subconjunto de Mundiais, pois o Palmeiras não tem Mundial.");
}

if(timesMundiais.IsSupersetOf(timesSP)) // timesMundiais é um super conjunto de timesSP
{
	Console.WriteLine("timesMundiais é superconjunto de SP");
}

if(timesRJ.Overlaps(timesMundiais)) // Se dois conjuntos possuem elementos em comum
{
    Console.WriteLine("Pelo menos um time do RJ tem título Mundial");
}

if(!timesSP.SetEquals(timesRJ))
{
    Console.WriteLine("\ntimesSP e timesBA não contém os memsmos elementos");
}

Console.WriteLine("\n-Juntando os HashSet<T>: SP, RJ, BA");
timesSP.UnionWith(timesRJ);
timesSP.UnionWith(timesBA);

ExibirColecao(timesSP);

Console.WriteLine("\nJuntando os Times de SP, RJ e BA ordenados");
var todosTimes = new SortedSet<string>(timesSP);
ExibirColecao(todosTimes);

Console.WriteLine("\nInterseção de dois HashSet<T>: timesSP e timesMundiais");
timesSP.IntersectWith(timesMundiais);
ExibirColecao(timesSP);

Console.WriteLine("\nDiferença de dois HashSet<T>: timesMundiais e timesSP");
timesMundiais.ExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nDiferença de dois HashSet<T>: timesMundiais e timesSP com SymmetricExceptWith ");
timesMundiais.SymmetricExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nRemove todos os elementos de timesMundiais");
timesMundiais.Clear();
ExibirColecao(timesMundiais);
Console.WriteLine("Fim do processamento...");

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao)
	{
		Console.WriteLine($"{item} ");
	}
}