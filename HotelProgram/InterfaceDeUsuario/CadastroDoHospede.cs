using System;
using HotelProgram.Modelo;

namespace HotelProgram.InterfaceDeUsuario;

public class CadastroDoHospede
{
    public Hospede CadastrarHospede()
    {
        Hospede hospede = new();

        System.Console.Write("Nome: ");
        hospede.Nome = Console.ReadLine();

        System.Console.Write("CPF: ");
        hospede.CPF = Console.ReadLine();

        System.Console.Write("Data de nascimento: ");
        hospede.DataDeNascimento = Console.ReadLine();

        System.Console.Write("Endereco de rezidencia: ");
        hospede.Endereco = Console.ReadLine();
        
        System.Console.Write("Numero do Quarto: ");
        hospede.NumeroDoQuarto = int.Parse(Console.ReadLine());
        
        return hospede;
    }
}
