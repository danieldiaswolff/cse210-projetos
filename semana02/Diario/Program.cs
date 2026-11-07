using System;

// Criatividade / além dos requisitos básicos:
// 1) Pergunta o humor do dia e salva junto com cada registro.
// 2) Usa DateTime.Now para preencher a data automaticamente.
// 3) Mostra o total de registros ao exibir o diário.
// 4) Inclui mais de 5 perguntas no gerador.
class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        string escolha = "";

        while (escolha != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Por favor, escolha uma das opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");
            escolha = Console.ReadLine();

            if (escolha == "1")
            {
                string pergunta = gerador.ObterPerguntaAleatoria();
                Console.WriteLine(pergunta);
                Console.Write("> ");
                string resposta = Console.ReadLine();

                Console.Write("Como está seu humor hoje? ");
                string humor = Console.ReadLine();

                Registro registro = new Registro();
                registro._data = DateTime.Now.ToShortDateString();
                registro._textoPergunta = pergunta;
                registro._textoResposta = resposta;
                registro._humor = humor;

                diario.AdicionarRegistro(registro);
            }
            else if (escolha == "2")
            {
                diario.ExibirTodos();
            }
            else if (escolha == "3")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine();
                diario.CarregarDoArquivo(arquivo);
                Console.WriteLine("Diário carregado.");
            }
            else if (escolha == "4")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string arquivo = Console.ReadLine();
                diario.SalvarNoArquivo(arquivo);
                Console.WriteLine("Diário salvo.");
            }
            else if (escolha == "5")
            {
                Console.WriteLine("Até logo!");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}
