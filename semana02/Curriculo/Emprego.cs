using System;

// Responsabilidade: guardar e exibir os dados de um emprego.
public class Emprego
{
    public string _cargo = "";
    public string _empresa = "";
    public int _anoInicio;
    public int _anoFim;

    public void Exibir()
    {
        Console.WriteLine($"{_cargo} ({_empresa}) {_anoInicio}-{_anoFim}");
    }
}
