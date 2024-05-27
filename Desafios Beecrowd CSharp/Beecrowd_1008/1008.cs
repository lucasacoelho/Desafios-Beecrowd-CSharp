namespace Desafios_Beecrowd_CSharp;

static class Beecrowd1008
{
    private static void Main(string[] args)
    {
        int funcionario_id = Convert.ToInt32(Console.ReadLine());
        int horas = Convert.ToInt32(Console.ReadLine());
        double valor_hora = Convert.ToDouble(Console.ReadLine());
        Double salario = horas * valor_hora;
        Console.WriteLine($"NUMBER = {funcionario_id}");
        Console.WriteLine($"SALARY = U$ {salario.ToString("0.00")}");
    }
}