using System.Collections;
using System.Diagnostics;
using HotelProgram.InterfaceDeUsuario;
using HotelProgram.Modelo;
using HotelProgram.RepositorioDoHotel;

RepositorioDeHospedes repositorioDeHospedes = new();
RepositorioDeQuartos repositorioDeQuartos = new();
do
{
    string OpcoesMenu = Menu.Exibir();
    if (OpcoesMenu == "0")
    {
        break;
    }
    switch (OpcoesMenu)
    {
        case "1":
            CadastroDoHospede cadastroHospede = new();
            Hospede hospede = cadastroHospede.CadastrarHospede();
            repositorioDeHospedes.Cadastrar(hospede);
            break;
        case "2":
            CadastroDoQuarto cadastroQuarto = new();
            Quarto quarto = cadastroQuarto.CadastrarQuarto();
            repositorioDeQuartos.hospedar(quarto);
            break;
        case "3":
            for(int i=0; i<repositorioDeQuartos.CadastroDeQuarto().Count; i++)
            {
                Quarto quartos = repositorioDeQuartos.CadastroDeQuarto()[i];
                Console.WriteLine(quartos);
            }
            break;
        case "4":
            Console.WriteLine("Digite o CPF que deseja pesquisar:");
            string pesquisaHospede = Console.ReadLine();
            for (int i = 0; i < repositorioDeHospedes.CadastroDeHospedes().Count; i++)
            {
                if (pesquisaHospede == repositorioDeHospedes.CadastroDeHospedes()[i].CPF)
                {
                    Hospede hospedes = repositorioDeHospedes.CadastroDeHospedes()[i];
                    Console.WriteLine(hospedes);
                    break;
                }
                else
                {
                    Console.WriteLine("CPF não encontrado.");
                }
            }
            break;
    }
} while (true);