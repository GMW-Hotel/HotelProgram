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

        System.Console.WriteLine("1. Cadastrar novo hospede.");
        System.Console.WriteLine("2. Cadastrar novo quarto.");
        System.Console.WriteLine("3. Cadastrar nova reserva.");
        System.Console.WriteLine("4. Realizar check-in.");
        System.Console.WriteLine("5. Realizar check-out.");
        System.Console.WriteLine("6. Exibir lista de quartos.");
        System.Console.WriteLine("7. Pesquisar hopsede cadastrado por CPF ou nome.");
        System.Console.WriteLine("8. Exibir reservas.");
        
        System.Console.WriteLine("0. Sair.");
        System.Console.WriteLine();
        System.Console.WriteLine("Qual opção deseja seguir?");
        string resposta = System.Console.ReadLine();
        Console.Clear();

        if (resposta == null || resposta == string.Empty || int.Parse(resposta) < 0 || int.Parse(resposta) > 8)
        {
            System.Console.WriteLine("Opcao Invalida!");
        }
        return resposta;
    }
}
