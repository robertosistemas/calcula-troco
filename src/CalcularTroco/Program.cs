using CalcularTrocoUtils;

namespace CalcularTroco;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre com o valor!");
        var valor = Console.ReadLine();
        Console.WriteLine(string.Concat("Calculando o menor número de notas e moedas para o troco de: ", valor));
        var troco = CaculadorTroco.CalculaTroco(Convert.ToDecimal(valor));
        foreach (var item in troco)
        {
            Console.WriteLine(item);
        }
    }
}