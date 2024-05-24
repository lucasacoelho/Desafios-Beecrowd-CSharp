namespace Desafios_Beecrowd_CSharp;

static class Beecrowd_1005
{
    private static void Main(string[] args)
    {
        Double A = Convert.ToDouble(Console.ReadLine());
        Double B = Convert.ToDouble(Console.ReadLine());
        Double Media = ((A * 3.5) + (B * 7.5)) / 11;
        Console.WriteLine($"MEDIA = {Media.ToString("0.00000")}");
    }
}

