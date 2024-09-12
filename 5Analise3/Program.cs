using System.Collections;

ClasseGenerica<int> obj1 = new ClasseGenerica<int>();
obj1.Adicionar(10);

ClasseGenerica<string> obj2 = new();
obj2.Adicionar("Generics");

ClasseGenerica<Aluno> obj3 = new();
obj3.Adicionar(new Aluno { Nome = "Generics" });

// Análise da reutilizaçãp de código

Console.ReadKey();

public class ClasseGenerica<T>
{
	// definição do array com 5 elementos
	T[] obj = new T[5];
	int contador = 0;
	// adicionar elementos
	public void Adicionar(T item)
	{
		if (contador < 5)
		{
			obj[contador] = item;
		}
		contador++;
	}
	// indexador para a iteração da instrução foreach
	public T this[int index]
	{
		get { return obj[index]; }
		set { obj[index] = value; }
	}
}

public class Aluno
{
	public string? Nome { get; set; }
}