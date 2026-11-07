using System;
using System.Collections.Generic;
using System.IO;

// Armazena e gerencia a lista de registros do diário.
public class Diario
{
    public List<Registro> _registros = new List<Registro>();

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        if (_registros.Count == 0)
        {
            Console.WriteLine("O diário ainda não tem registros.");
            return;
        }

        Console.WriteLine($"Total de registros: {_registros.Count}");
        Console.WriteLine();

        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter saida = new StreamWriter(arquivo))
        {
            foreach (Registro registro in _registros)
            {
                // Separador | para não conflitar com vírgulas no texto.
                saida.WriteLine($"{registro._data}|{registro._textoPergunta}|{registro._textoResposta}|{registro._humor}");
            }
        }
    }

    public void CarregarDoArquivo(string arquivo)
    {
        string[] linhas = File.ReadAllLines(arquivo);
        _registros.Clear();

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split("|");

            if (partes.Length >= 3)
            {
                Registro registro = new Registro();
                registro._data = partes[0];
                registro._textoPergunta = partes[1];
                registro._textoResposta = partes[2];
                registro._humor = partes.Length >= 4 ? partes[3] : "";
                _registros.Add(registro);
            }
        }
    }
}
