using CalcularTrocoUtils;
using System.Globalization;

namespace CalcularTroco;

public static class Program
{
    public static void Main(string[] args)
    {
        decimal valorTroco;
        do
        {
            Console.WriteLine("Entre com o valor maior que zero:");
            string? valorDigitado = Console.ReadLine();
            _ = decimal.TryParse(valorDigitado, NumberStyles.Currency, GetCultureInfo(), out valorTroco);
        } while (valorTroco <= 0);
        Console.WriteLine(string.Concat("Calculando o menor número de notas e moedas para o troco de: ", valorTroco));
        var troco = CalculadorTroco.CalculaTroco(valorTroco);
        foreach (var item in troco)
        {
            Console.WriteLine(item);
        }
    }

    private static CultureInfo GetCultureInfo()
    {
        var culture = new CultureInfo("pt-BR");
        culture.NumberFormat.NumberDecimalSeparator = ",";
        culture.NumberFormat.NumberGroupSeparator = ".";
        culture.NumberFormat.CurrencyDecimalSeparator = ",";
        culture.NumberFormat.CurrencyGroupSeparator = ".";
        return culture;
    }
}