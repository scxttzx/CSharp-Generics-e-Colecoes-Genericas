string a = "José";
string b = "José";

int x = 100;
int y = 100;

Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(x.GetHashCode());
Console.WriteLine(y.GetHashCode());

Console.WriteLine(a.Equals(b));
Console.WriteLine(x.Equals(y));

var pessoa1 = new Pessoa(1, "Ana");
var pessoa2 = new Pessoa(1, "Ana");

Console.WriteLine(pessoa1.GetHashCode());
Console.WriteLine(pessoa2.GetHashCode());

Console.WriteLine(pessoa1.Equals(pessoa2));

Console.ReadKey();

public class Pessoa
{
	public Pessoa(int id, string? nome)
	{
		Id = id;
		Nome = nome;
	}
    public int Id { get; set; }
    public string? Nome { get; set; }
}