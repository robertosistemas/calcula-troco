using CalcularTrocoUtils;

namespace CalcularTroco;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre com o valor!");
        var valor = Console.ReadLine();
        new Moedas().CalculaTroco(Convert.ToDecimal(valor));
    }
}
