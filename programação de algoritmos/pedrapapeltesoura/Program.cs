using System;

namespace ppt
{
    public class Programa
    {
        public static void Main()
        {
            string[] at =
            {
                "pedra",
                "papel",
                "tesoura"
            };
            int[] counter = { 1, 2, 0 };
            Console.WriteLine(@"
1- Pedra
2- Papel
3- Tesoura
");
            string winner = "PC";
            bool empate = false;
            int opt = int.Parse(Console.ReadLine()) - 1;
            int pc = new Random().Next(at.Length);
            Console.WriteLine($"Você escolheu: {at[opt]}.");
            Console.WriteLine($"O computador escolheu: ...");
            Thread.Sleep(2000);
            Console.WriteLine(at[pc]);
            if (opt == counter[pc]) winner = "Você";
            if (opt == pc) empate = true;
            if (!empate)
            {
                Console.WriteLine($"Vencedor: {winner}!");
            } else
            {
                Console.WriteLine("Empate!");
            }
            Console.ReadKey();
        }
    }
}