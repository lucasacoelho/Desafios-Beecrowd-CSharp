namespace Desafios_Beecrowd_CSharp;

static class Beecrowd_1006
{
    private static void Main(string[] args)
    {
        Double A = Convert.ToDouble(Console.ReadLine());
        Double B = Convert.ToDouble(Console.ReadLine());
        Double C = Convert.ToDouble(Console.ReadLine());
        Double Media = ((A * 2) + (B * 3) + (C * 5)) / 10;
        Console.WriteLine($"MEDIA = {Media.ToString("0.0")}");
    }
}