namespace Desafios_Beecrowd_CSharp;

static class Beecrowd1008
{
    private static void Main(string[] args)
    {
        String line1 = Console.ReadLine();
        String line2 = Console.ReadLine();
        
        String[] valor1 = line1.Split(' ');
        int cod1 = Convert.ToInt32(valor1[0]);
        int quant1 = Convert.ToInt32(valor1[1]);
        double values1 = Convert.ToDouble(valor1[2]);
        
        String[] valor2 = line2.Split(' ');
        int cod2 = Convert.ToInt32(valor2[0]);
        int quant2 = Convert.ToInt32(valor2[1]);
        double values2 = Convert.ToDouble(valor2[2]);

        double total = (quant1 * values1) + (quant2 * values2);
        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("0.00")}");
    }
};