namespace Desafios_Beecrowd_CSharp;

static class Constants
{
    public const double N = 3.14159;
    private static void Main(string[] args)
    {
        double raio = Math.Round(Convert.ToDouble(Console.ReadLine()),2);
        double area = Math.Pow(raio, 2) * N;
        Console.WriteLine($"A={Math.Round(area, 4).ToString("0.0000")}");
    }
}