using System;
using System.Collections.Generic;

// Fornece perguntas aleatórias para o diário.
public class GeradorDePerguntas
{
    public List<string> _perguntas = new List<string>
    {
        "Quem foi a pessoa mais interessante com quem interagi hoje?",
        "Qual foi a melhor parte do meu dia?",
        "Como vi a mão do Senhor em minha vida hoje?",
        "Qual foi a emoção mais forte que senti hoje?",
        "Se eu pudesse fazer uma coisa hoje, o que seria?",
        "Por qual bênção eu me senti mais grato hoje?",
        "O que aprendi sobre mim mesmo hoje?"
    };

    public string ObterPerguntaAleatoria()
    {
        Random aleatorio = new Random();
        int indice = aleatorio.Next(_perguntas.Count);
        return _perguntas[indice];
    }
}
