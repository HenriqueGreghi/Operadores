using System;
using System.Globalization;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Double  salario, horas, total;
            int funcionario;

            Console.WriteLine("digite o numero do funcionário: ");
            funcionario = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o número de horas trabalhadas: ");
            horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor por hora que o funcionário recebe: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = horas * salario;

            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = U$ " + total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
