namespace Desafios_Beecrowd_CSharp;

static class Beecrowd1011
{
    public const double pi = 3.14159;
    private static void Main(string[] args)
    {
        double r = Convert.ToDouble(Console.ReadLine());
        double volume = (4 / 3.0) * pi * (Math.Pow(r, 3));
        Console.WriteLine($"VOLUME = {volume.ToString("0.000")}");
    }
};


