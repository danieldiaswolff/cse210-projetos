using System;
using System.Collections.Generic;

// Criatividade / além dos requisitos básicos:
// 1) Biblioteca com várias escrituras; o programa escolhe uma aleatoriamente a cada execução.
// 2) Só oculta palavras que ainda estão visíveis (desafio adicional do enunciado).
// 3) Mostra quantas palavras ainda faltam memorizar a cada rodada.
class Program
{
    static void Main(string[] args)
    {
        Escritura escritura = EscolherEscrituraAleatoria();

        string resposta = "";

        while (resposta.ToLower() != "sair" && !escritura.EstaCompletamenteOculta())
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());
            Console.WriteLine();
            Console.WriteLine($"Palavras ainda visíveis: {escritura.ContarPalavrasVisiveis()}");
            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para terminar.");
            Console.Write("> ");
            resposta = Console.ReadLine();

            if (resposta.ToLower() != "sair")
            {
                escritura.OcultarPalavrasAleatorias(3);
            }
        }

        Console.Clear();
        Console.WriteLine(escritura.ObterTexto());
        Console.WriteLine();
        Console.WriteLine("Fim do exercício de memorização. Bom trabalho!");
    }

    static Escritura EscolherEscrituraAleatoria()
    {
        List<Escritura> biblioteca = new List<Escritura>();

        biblioteca.Add(new Escritura(
            new Referencia("João", 3, 16),
            "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna."
        ));

        biblioteca.Add(new Escritura(
            new Referencia("Provérbios", 3, 5, 6),
            "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."
        ));

        biblioteca.Add(new Escritura(
            new Referencia("Filipenses", 4, 13),
            "Posso todas as coisas naquele que me fortalece."
        ));

        biblioteca.Add(new Escritura(
            new Referencia("Salmos", 23, 1),
            "O Senhor é o meu pastor; nada me faltará."
        ));

        Random aleatorio = new Random();
        int indice = aleatorio.Next(biblioteca.Count);
        return biblioteca[indice];
    }
}
