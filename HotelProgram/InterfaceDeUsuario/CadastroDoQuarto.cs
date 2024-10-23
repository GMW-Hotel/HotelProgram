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

        System.Console.WriteLine("Ocupação do quarto:");
        System.Console.WriteLine("-------------------");
        System.Console.WriteLine("1. Quarto alugado.");
        System.Console.WriteLine("2. Quarto Livre. ");
         string Status = Console.ReadLine();

        return new Quarto(int.Parse(Numero),Tipo,float.Parse(Valor),int.Parse(Status));
    }
}
