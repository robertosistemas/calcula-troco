﻿namespace CalcularTrocoUtils
{
    public class Moedas
    {
        public void CalculaTroco(decimal valor)
        {
            Console.WriteLine(string.Concat("Calculando o menor número de notas e moedas para o troco de: ", valor));
            decimal[] tipoDinheiros = new decimal[] { 100, 50, 20, 10, 5, 2, 1, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M };
            decimal soma = 0;
            for (int i = 0; i < tipoDinheiros.Length; i++)
            {
                decimal tipoDinheiro = tipoDinheiros[i];
                if (soma + tipoDinheiro <= valor)
                {
                    int quantidadeTipoDinheiro = 0;

                    while (soma + tipoDinheiro <= valor)
                    {
                        quantidadeTipoDinheiro += 1;
                        soma += tipoDinheiro;
                    }
                    string tipoDinheiroTexto = "moeda";

                    if (tipoDinheiro > 1)
                        tipoDinheiroTexto = "nota";

                    if (quantidadeTipoDinheiro > 1)
                        tipoDinheiroTexto += "s";

                    string tipoDinheiroComplemento = "centavo";

                    if (tipoDinheiro < 1 && tipoDinheiro > 0.01M)
                        tipoDinheiroComplemento += "s";

                    if (tipoDinheiro == 1)
                        tipoDinheiroComplemento = "real";

                    if (tipoDinheiro > 1)
                        tipoDinheiroComplemento = "reais";

                    decimal tipoDinheiroMostrar = tipoDinheiro;

                    if (tipoDinheiroMostrar < 1)
                        tipoDinheiroMostrar *= 100;

                    Console.WriteLine(string.Concat(quantidadeTipoDinheiro, " ", tipoDinheiroTexto, " de ", tipoDinheiroMostrar, " ", tipoDinheiroComplemento));
                }
            }
        }
    }
}