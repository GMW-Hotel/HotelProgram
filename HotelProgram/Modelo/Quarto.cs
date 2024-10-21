using System;
using System.ComponentModel;
using System.Dynamic;
using System.Net;
using System.Net.Security;

namespace HotelProgram.Modelo;

public class Quarto
{

    public int Numero { get; set; }
    public string Tipo { get; set; }
    public float Valor { get; set; }
    public int Status { get; set; }
    public string Ocupacao { get; set; }

    public override string ToString()
    {
        if (Status == 2)
        {
            Ocupacao = "Livre";
        }
        else if (Status == 1)
        {
            Ocupacao = "Alugado";
        }
        return $"[Quarto numero: {Numero}, tipo: {Tipo}, valor: R${Valor}, ocupacao: {Ocupacao}]";
    }
}
