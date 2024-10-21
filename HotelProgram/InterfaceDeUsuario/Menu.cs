using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProgram.InterfaceDeUsuario;

public class Menu
{
    public static string Exibir()
    {
        System.Console.WriteLine("MENU PRINCIPAL");
        System.Console.WriteLine("--------------");
        System.Console.WriteLine();

        System.Console.WriteLine("1. Cadastrar novo Hospede.");
        System.Console.WriteLine("2. Cadastrar novo quarto.");
        System.Console.WriteLine("3. Exibir lista de quartos.");
        System.Console.WriteLine("4. Pesquisar hospedagem por CPF.");
        System.Console.WriteLine("0. Sair.");

        System.Console.WriteLine();
        System.Console.WriteLine("Qual opção deseja seguir?");

        string resposta = System.Console.ReadLine();
        if (resposta == null || resposta == string.Empty)
        {
            System.Console.WriteLine("Opcao nulla.");
        }
        return resposta;
    }
}
