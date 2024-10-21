using System;
using HotelProgram.Modelo;

namespace HotelProgram.InterfaceDeUsuario;

public class CadastroDoQuarto
{
    public Quarto CadastrarQuarto()
    {
        Quarto quarto = new();

        System.Console.Write("Numero: ");
        quarto.Numero = int.Parse(Console.ReadLine());

        System.Console.Write("Tipo: ");
        quarto.Tipo = Console.ReadLine();

        System.Console.Write("Valor: ");
        quarto.Valor = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Ocupação do quarto:");
        System.Console.WriteLine("-------------------");
        System.Console.WriteLine("1. Quarto alugado.");
        System.Console.WriteLine("2. Quarto Livre. ");
         quarto.Status = int.Parse(Console.ReadLine());

        return quarto;
    }
}
