using System.Collections;
using System.Diagnostics;
using HotelProgram.InterfaceDeUsuario;
using HotelProgram.Modelo;
using HotelProgram.RepositorioDoHotel;

RepositorioDeHospedes repositorioDeHospedes = new();
RepositorioDeQuartos repositorioDeQuartos = new();
RepositorioDeReservas repositorioDeReservas = new();
RepositoriodeCheckin repositoriodecheckin = new();
RepositoriodeCheckOut repositoriodecheckout = new();

do
{
    Console.WriteLine("\nAperte enter para continuar:\n");
    string qualquertecla = Console.ReadLine();
    Console.Clear();
    string OpcoesMenu = Menu.Exibir();
    if (OpcoesMenu == "0")
    {
        Console.WriteLine("\nTermino do programa.\n");
        break;
    }
    switch (OpcoesMenu)
    {
        case "1":
            CadastroDoHospede cadastroHospede = new();
            Hospede hospede = cadastroHospede.CadastrarHospede();
            repositorioDeHospedes.Hospedar(hospede);
            break;
        case "2":
            CadastroDoQuarto cadastroQuarto = new();
            Quarto quarto = cadastroQuarto.CadastrarQuarto();
            repositorioDeQuartos.Cadastrar(quarto);
            break;
        case "3":
            CadastroDaReserva cadastroReserva = new();
            Reserva reserva = cadastroReserva.CadastrarReserva(repositorioDeHospedes.CadastroDeHospedes(), repositorioDeQuartos.CadastroDeQuarto());
            repositorioDeReservas.Reservar(reserva);
            break;
        case "4":
        CadastroDoCheckIn cadastrocheckin = new();
        Checkin chckin = cadastrocheckin.CadastroCheckin(repositorioDeReservas.CadastroDeReservas());
        repositoriodecheckin.RelizarCheckin(chckin);
            break;
        case "5":
            break;
        case "6":
            for (int i = 0; i < repositorioDeQuartos.CadastroDeQuarto().Count; i++)
            {
                Quarto quartos = repositorioDeQuartos.CadastroDeQuarto()[i];
                Console.WriteLine(quartos);
            }
            break;
        case "7":
            Console.WriteLine("Digite o CPF ou nome que deseja pesquisar:");
            string pesquisaHospede = Console.ReadLine();
            bool hospedeEncontrado = false;
            foreach (var Hospede in repositorioDeHospedes.CadastroDeHospedes())
            {
                if (pesquisaHospede == Hospede.CPF || Hospede.Nome.Contains(pesquisaHospede, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Hospede);
                    hospedeEncontrado = true;
                }
            }
            if (hospedeEncontrado == false)
            {
                Console.WriteLine("Hospede não encontrado.");
            }
            break;
        case "8":
            for (int i = 0; i < repositorioDeReservas.CadastroDeReservas().Count; i++)
            {
                Reserva reservas = repositorioDeReservas.CadastroDeReservas()[i];
                Console.WriteLine(reservas);
            }
            if (repositorioDeReservas.CadastroDeReservas().Count == 0)
            {
                Console.WriteLine("Ainda não possuí reservas");
            }
            break;
            case "9":
            if (repositoriodecheckin.Obterlista().Count == 0)

            {
                Console.WriteLine("Ainda não possuí reservas");
            }
            foreach(var Checkin in repositoriodecheckin.Obterlista())
            {
                Checkin.ExibeCheckin();
            }
            
            break;
        
    }
} while (true);