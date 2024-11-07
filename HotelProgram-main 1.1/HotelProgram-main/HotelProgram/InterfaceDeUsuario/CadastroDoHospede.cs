using System;
using HotelProgram.Modelo;

namespace HotelProgram.InterfaceDeUsuario;

public class CadastroDoHospede
{
    public Hospede CadastrarHospede()
    {

        System.Console.Write("Nome: ");
        string nome = Console.ReadLine();

        System.Console.Write("CPF (formato xxx.xxx.xxx-xx): ");
        string cpf = Console.ReadLine();

        System.Console.Write("Data de nascimento (formato DD/MM/YYYY): ");
        DateTime nascimento = DateTime.Parse(Console.ReadLine());

        System.Console.Write("Endereco de rezidencia: ");
        string endereco = Console.ReadLine();

        return new Hospede(nome, cpf, nascimento, endereco);
    }
}
