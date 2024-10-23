using System;
using HotelProgram.Modelo;

namespace HotelProgram.InterfaceDeUsuario;

public class CadastroDoQuarto
{
    public Quarto CadastrarQuarto()
    {

        System.Console.Write("Numero: ");
        string Numero = Console.ReadLine();

        System.Console.Write("Tipo: ");
        string Tipo = Console.ReadLine();

        System.Console.Write("Valor: ");
        string Valor =Console.ReadLine();

        return new Quarto(int.Parse(Numero),Tipo,float.Parse(Valor));
    }
}
