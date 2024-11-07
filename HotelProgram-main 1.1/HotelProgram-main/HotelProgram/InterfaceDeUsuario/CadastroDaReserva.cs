using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using HotelProgram.Modelo;
using HotelProgram.RepositorioDoHotel;

namespace HotelProgram.InterfaceDeUsuario;

public class CadastroDaReserva
{
    public Reserva CadastrarReserva(List<Hospede> hospedes, List<Quarto> quartos)
    {
        string auxiliarDeResposta;
        Hospede hospedeEncontrado = null;
        do
        {
            System.Console.Write("Digite o CPF do hospede: ");
            auxiliarDeResposta = Console.ReadLine();
            foreach (var hospede in hospedes)
            {
                if (auxiliarDeResposta == hospede.CPF)
                {
                    Console.WriteLine(hospede);
                    hospedeEncontrado = hospede;
                    break;
                }
            }
            if (hospedeEncontrado == null)
            {
                Console.WriteLine("Hospede não encontrado.");
            }
        } while (hospedeEncontrado == null);
        Quarto quartoEscolhido = null;
        do
        {
            System.Console.Write("Digite o numero do quarto: ");
            auxiliarDeResposta = Console.ReadLine();
            foreach (var quarto in quartos)
            {
                if (int.Parse(auxiliarDeResposta) == quarto.Numero)
                {
                    Console.WriteLine(quarto);
                    quartoEscolhido = quarto;
                    break;
                }
            }
            if (quartoEscolhido == null)
            {
                Console.WriteLine("quarto não encontrado.");
            }
        } while (quartoEscolhido == null);

        Console.WriteLine("Digite a data de entrada (formato DD/MM/YYYY)");
        DateTime dataEntrada = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Digite a data de saída (formato DD/MM/YYYY)");
        DateTime dataSaida = DateTime.Parse(Console.ReadLine());

        return new Reserva(hospedeEncontrado, quartoEscolhido, dataEntrada, dataSaida);
    }
}
