using System;
using HotelProgram.Modelo;

namespace HotelProgram.InterfaceDeUsuario;

public class CadastroDoHospede
{
    public Hospede CadastrarHospede()
    {
        
       System.Console.Write("Nome: ");
       string nome = Console.ReadLine();

        System.Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        System.Console.Write("Data de nascimento: ");
        string nascimento = Console.ReadLine();

        System.Console.Write("Endereco de rezidencia: ");
        string endereco = Console.ReadLine();
        
        System.Console.Write("Numero do Quarto: ");
        string numerodoquarto = Console.ReadLine();
        
        return new Hospede(nome,cpf,nascimento,endereco,int.Parse(numerodoquarto));
    }
}
