using System.Collections.Generic;

namespace src.Models;

public class Pessoa
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Cpf { get; set; }
    public bool Ativado { get; set; }
    public List<Contrato> contratos { get; set; }

    public Pessoa() { }

    public Pessoa(string nome, int idade, string cpf, bool ativado)
    {
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
        Ativado = true;
        contratos = new List<Contrato>();
    }


}