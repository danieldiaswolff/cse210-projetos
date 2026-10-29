using System;

class Program
{
    static void Main(string[] args)
    {
        string jogarDeNovo = "sim";

        while (jogarDeNovo.ToLower() == "sim")
        {
            Random geradorAleatorio = new Random();
            int numeroMagico = geradorAleatorio.Next(1, 101);

            int palpite = -1;
            int contagemPalpites = 0;

            while (palpite != numeroMagico)
            {
                Console.Write("Qual é o seu palpite? ");
                palpite = int.Parse(Console.ReadLine());
                contagemPalpites++;

                if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else if (palpite > numeroMagico)
                {
                    Console.WriteLine("Mais baixo");
                }
                else
                {
                    Console.WriteLine("Você adivinhou!");
                }
            }

            Console.WriteLine($"Você precisou de {contagemPalpites} palpites.");

            Console.Write("Deseja jogar de novo? ");
            jogarDeNovo = Console.ReadLine();
        }
    }
}
