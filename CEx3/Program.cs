namespace CEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Primeiro Número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("\nDigite o Segundo Número: ");
            int num2 = int.Parse(Console.ReadLine()!);

            int maior = Math.Max(num1, num2);

            Console.WriteLine($"\nO número {maior} é o maior valor!");
        }
    }
}
