namespace Console_Revisao_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, resul;
            
            Console.WriteLine("Digite a primeira nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());

            resul = (nota1 + nota2) / 2;

            Console.WriteLine("A média é:" + resul);

            if (resul >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (resul < 5)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
