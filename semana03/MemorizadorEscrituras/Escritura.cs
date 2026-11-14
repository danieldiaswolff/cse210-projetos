using System;
using System.Collections.Generic;

// Responsabilidade: manter a referência e o texto da escritura, ocultar palavras e obter a exibição.
public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] partes = texto.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        foreach (string parte in partes)
        {
            _palavras.Add(new Palavra(parte));
        }
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        List<Palavra> visiveis = new List<Palavra>();
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                visiveis.Add(palavra);
            }
        }

        if (visiveis.Count == 0)
        {
            return;
        }

        int quantidade = Math.Min(numeroParaOcultar, visiveis.Count);
        Random aleatorio = new Random();

        for (int i = 0; i < quantidade; i++)
        {
            int indice = aleatorio.Next(visiveis.Count);
            visiveis[indice].Ocultar();
            visiveis.RemoveAt(indice);
        }
    }

    public string ObterTexto()
    {
        string texto = _referencia.ObterTexto() + "\n";

        List<string> palavrasExibidas = new List<string>();
        foreach (Palavra palavra in _palavras)
        {
            palavrasExibidas.Add(palavra.ObterTexto());
        }

        texto += string.Join(" ", palavrasExibidas);
        return texto;
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }

    public int ContarPalavrasVisiveis()
    {
        int contador = 0;
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                contador++;
            }
        }

        return contador;
    }
}
