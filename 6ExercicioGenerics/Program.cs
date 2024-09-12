ClasseGenerica<int> objInt = new ClasseGenerica<int>();
objInt.Adicionar(10);
objInt.Adicionar(20);
objInt.Adicionar(30);
objInt.Adicionar(40);
objInt.Adicionar(50);
objInt.Adicionar(60);

for (int i = 0; i < 5; i++)
{
	Console.WriteLine(objInt[i]);
}

Console.ReadKey();

public class ClasseGenerica<T>
{
	// Definição do array com 5 elementos
	T[] obj = new T[5];
	int Indexer = 0;
	// Adicionar elementos
	public void Adicionar(T item)
	{
		if (Indexer < 5)
		{
			obj[Indexer] = item;
			Console.WriteLine($"Adicionando {item} no index {Indexer}");
		}
		Indexer++;
	}
	// Indexador
	public T this[int index]
	{
		get { return obj[index]; }
		set { obj[index] = value; }
	}

}