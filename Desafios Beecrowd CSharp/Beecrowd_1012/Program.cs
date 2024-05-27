using Microsoft.VisualBasic.FileIO;

namespace Desafios_Beecrowd_CSharp;

static class Beecrowd_1012
{
    public const double pi = 3.141519;
    private static void Main(string[] args)
    {
        String x = Console.ReadLine();
        string[] valores = x.Split(' ');
        double A = Convert.ToDouble(valores[0]);
        double B = Convert.ToDouble(valores[1]);
        double C = Convert.ToDouble(valores[2]);

        double triangulo = (A * C) / 2;
        double circulo = pi * Math.Pow(C, 2);
        double trapezio = ((A + B) * C) / 2;
        double quadrado = Math.Pow(B, 2);
        double retangulo = A * B;
        
        Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
        Console.WriteLine($"CIRCULO: {circulo:0.000}");
        Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
        Console.WriteLine($"QUADRADO: {quadrado:0.000}");
        Console.WriteLine($"RETANGULO: {retangulo:0.000}");
    }
}