namespace Desafios_Beecrowd_CSharp;

static class Beecrowd_1007
{
    private static void Main(string[] args)
    {
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        int C = Convert.ToInt32(Console.ReadLine());
        int D = Convert.ToInt32(Console.ReadLine());
        Double diferenca = ((A * B) - (C * D));
        Console.WriteLine($"DIFERENCA = {diferenca}");
    }
}