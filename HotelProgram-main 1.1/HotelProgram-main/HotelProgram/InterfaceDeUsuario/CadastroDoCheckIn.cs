using HotelProgram.Modelo;
using HotelProgram.RepositorioDoHotel;

namespace HotelProgram.InterfaceDeUsuario;

public class CadastroDoCheckIn
{
    public Checkin CadastroCheckin(List<Reserva> reserva)
    {
        Reserva reserv = null;
        string nomeoucpf;
        DateTime data = DateTime.Now;
        RepositorioDeQuartos repquarto = new();
        if(reserva.Count == 0)
        {
            Console.WriteLine("Nenhuma reserva registrada");
            return null;
        }  
        else
        {
            Console.WriteLine("\nDigite o nome/cpf do cliente para realizar o check in");
           nomeoucpf =  Console.ReadLine();
            foreach(var Reserva in reserva)
            {
                if(nomeoucpf == Reserva.ReservaHospede.Nome || nomeoucpf == Reserva.ReservaHospede.CPF)
                {
                    repquarto.OcuparQuarto(Reserva.ReservaQuarto.Numero);
                    reserv = Reserva;
                    break;
                }
            }

            return new (reserv,data);
        }
    }
}
