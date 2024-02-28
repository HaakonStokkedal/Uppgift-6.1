namespace Uppgift_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal:");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett till heltal:");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett sista heltal:");
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Summan är {Summa(tal1, tal2, tal3)}");
        }

        static int Summa(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            return summa;
        }
    }
}