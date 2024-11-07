using HotelProgram.RepositorioDoHotel;

namespace HotelProgram.InterfaceDeUsuario;

public class CadastroDoCheckout()
{
     public Checkout CadastrarCheckOut(List<Checkin> lista)
     {
        RepositorioDeQuartos repquarto = new();
        string nomeoucpf;
        Checkin checkin = null;
        DateTime data = DateTime.Now;
        if(lista.Count == 0)
        {
            Console.WriteLine("Nenhum checkin registrado no sistema");
            return null;
        }
        else
        {
            Console.WriteLine("Digite o nome ou cpf do cliente");
            nomeoucpf = Console.ReadLine();
            foreach(var Checkin in lista)
            {
                if(nomeoucpf == Checkin.reserva.ReservaHospede.Nome || nomeoucpf == Checkin.reserva.ReservaHospede.CPF )
                {
                   
                    checkin = Checkin;
                    break;
                }
            }
            return new(checkin,data);
        }
     }  
}
