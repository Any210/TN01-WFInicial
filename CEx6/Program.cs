namespace CEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("\nInforme o número de horas trabalhadas: ");
            int quantHoras = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o valor da hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            double resultado = valorHora * quantHoras;

            Console.WriteLine($"A renda total de {nome} é R$ {resultado:F2}");
        }
    }
}
