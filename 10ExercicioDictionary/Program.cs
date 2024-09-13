Dictionary<int, Aluno> dicNotas = new Dictionary<int, Aluno>();
dicNotas.Add(1, new Aluno("Maria", 7));
dicNotas.Add(2, new Aluno("Eric", 8));
dicNotas.Add(3, new Aluno("Ana", 9));
dicNotas.Add(4, new Aluno("Alex", 6));
dicNotas.Add(5, new Aluno("Diná", 5));

ExibirColecao(dicNotas);

do
{
    Console.WriteLine("\n### Informe o código do aluno a ser localizado (99 sai) ###");
	int codigo = Convert.ToInt32(Console.ReadLine());

	if (codigo == 99)
	{
		break;
	}
	var resultado = dicNotas.ContainsKey(codigo);
	if(resultado)
	{
        Console.WriteLine("Informe a nota de 1 a 10");
		var notaInformada = Convert.ToInt32(Console.ReadLine());
		dicNotas[codigo].Nota = notaInformada;
	}
	else
	{
        Console.WriteLine("Aluno Não localizado");
    }
	
} while (true);
ExibirColecao(dicNotas);

Console.WriteLine("\n### Informe o código do Aluno a remover ###");
int cod = Convert.ToInt32(Console.ReadLine());
if (dicNotas.ContainsKey(cod))
{
	dicNotas.Remove(cod);
    Console.WriteLine("\nAluno removido com sucesso");
}
else
{
	Console.WriteLine("Aluno não localizado");
}
ExibirColecao(dicNotas);

Console.WriteLine("\n### Incluindo um novo aluno ###");
Console.WriteLine("\nInforme o nome do aluno");
string novoNome = Console.ReadLine();

Console.WriteLine("Informe a nota do aluno");
int novaNota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o código do Aluno");
int novoCodigo = Convert.ToInt32(Console.ReadLine());

if(!dicNotas.ContainsKey(novoCodigo))
{
	dicNotas.Add(novoCodigo, new Aluno(novoNome, novaNota));
    Console.WriteLine("Aluno incluído com sucesso");
}

else
{
	Console.WriteLine("Código já existente");
}
ExibirColecao(dicNotas);

Console.WriteLine("\nAlunos ordenados por nome");
var alunosOrdenados = dicNotas.OrderBy(x => x.Value.Nome);
foreach (var aluno in dicNotas)
{
	Console.WriteLine($"{aluno.Key}:\nNome: {aluno.Value.Nome}\nNota: {aluno.Value.Nota}\n");
}

dicNotas.Clear();
ExibirColecao(dicNotas);
Console.WriteLine("Fim do exercício");

Console.ReadKey();

static void ExibirColecao(Dictionary<int, Aluno> dicNotas)
{
	foreach (var aluno in dicNotas)
	{
		Console.WriteLine($"{aluno.Key}:\nNome: {aluno.Value.Nome}\nNota: {aluno.Value.Nota}\n");
	}
}

public class Aluno
{
    public string? Nome { get; set; }
    public int Nota { get; set; }

    public Aluno(string? nome, int nota )
    {
		Nome = nome;
		Nota = nota;
	}
}
