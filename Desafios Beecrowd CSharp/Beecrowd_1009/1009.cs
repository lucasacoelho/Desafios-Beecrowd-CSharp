namespace Desafios_Beecrowd_CSharp;

static class Beecrowd1008
{
    private static void Main(string[] args)
    {
        string funcionario_nome = Console.ReadLine();
        double salario_base = Convert.ToDouble(Console.ReadLine());
        double vendas_mes = Convert.ToDouble(Console.ReadLine());
        double comissao = (15 * vendas_mes) / 100;
        double salario_final = salario_base + comissao;
        
        Console.WriteLine($"TOTAL = R$ {salario_final.ToString("0.00")}");
        
    }
}