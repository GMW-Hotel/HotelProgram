using System;
using System.Text;

namespace HotelProgram.Modelo;

public class Hospede
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public string Endereco { get; set; }

    public override string ToString()
    {
        return $"[Nome: {Nome}, CPF: {CPF}, Data de nascimento: {DataDeNascimento}, endereço de residencia: {Endereco}]";
    }

    public Hospede(string nome, string cpf, DateTime nascimento, string endereco)
    {
        Nome = nome;
        CPF = cpf;
        DataDeNascimento = nascimento;
        Endereco = endereco;
    }
    public void ExibeHospede()
    {
        Console.Write("");
        Console.WriteLine($"Nome: {Nome}, CPF: {CPF}, Data de nascimento: {DataDeNascimento}, endereço de residencia: {Endereco}");
    }
}
