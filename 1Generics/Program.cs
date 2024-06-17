Teste teste = new();

int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

teste.Comparar(i1, i2);
teste.Comparar(i1, f2);
teste.Comparar(f1, f2);
teste.Comparar(f1, i2);

Console.ReadKey();

public class Teste
{
    public void Comparar<T>(T p1, T p2)
    {
        Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2); // Equals compara se o conteudo são iguais enquanto o  " == " compara se a referência é igual
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}\n");
    }
}