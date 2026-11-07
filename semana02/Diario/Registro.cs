using System;

// Representa um único registro do diário.
public class Registro
{
    public string _data = "";
    public string _textoPergunta = "";
    public string _textoResposta = "";
    // Extra: humor do dia (além dos requisitos básicos).
    public string _humor = "";

    public void Exibir()
    {
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"Pergunta: {_textoPergunta}");
        Console.WriteLine($"Resposta: {_textoResposta}");
        Console.WriteLine($"Humor: {_humor}");
        Console.WriteLine();
    }
}
