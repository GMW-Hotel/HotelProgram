using System;

namespace HotelProgram.Modelo;

public class Hospede
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string DataDeNascimento { get; set; }
    public string Endereco { get; set; }
    public int NumeroDoQuarto { get; set; }

    public override string ToString()
    {
        return $"[Nome: {Nome}, CPF: {CPF}, Data de nascimento: {DataDeNascimento}, endereço de residencia: {Endereco}, numero do quarto hospedado: {NumeroDoQuarto}]";
    }
}
