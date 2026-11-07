using System;
using System.Collections.Generic;

// Responsabilidade: guardar o nome da pessoa e a lista de empregos, e exibir o currículo.
public class Curriculo
{
    public string _nome = "";
    public List<Emprego> _empregos = new List<Emprego>();

    public void Exibir()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine("Empregos:");

        foreach (Emprego emprego in _empregos)
        {
            emprego.Exibir();
        }
    }
}
