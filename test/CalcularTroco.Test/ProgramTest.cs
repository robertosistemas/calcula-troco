namespace CalcularTroco.Test;

public class ProgramTest
{
    [Fact]
    public void MainTest()
    {
        using StringReader reader = new("21,45");
        Console.SetIn(reader);
        using StringWriter writer = new();
        Console.SetOut(writer);
        Program.Main(Array.Empty<string>());
        writer.Flush();
        var result = writer.GetStringBuilder().ToString().Trim();
        var resultArray = result.Split(Environment.NewLine).ToList();

        var expected = new List<string>
            {
                "Entre com o valor maior que zero:",
                "Calculando o menor número de notas e moedas para o troco de: 21.45",
                "1 nota de 20 reais",
                "1 moeda de 1 real",
                "1 moeda de 25.00 centavos",
                "2 moedas de 10.00 centavos"
            };
        Assert.Equal(expected.Count, resultArray.Count);
        Assert.Equal(expected, resultArray);
    }
}
