using HotelProgram.Modelo;

public class Checkin()
{
    public Reserva reserva {get;set;}
    public DateTime datacheckin {get;set;}
    public Checkin(Reserva reservation,DateTime data) : this()
    {
        reserva = reservation;
        datacheckin = data;
    }
    public void ExibeCheckin()
    {
        Console.WriteLine("Dados do checkin:");
        reserva.ExibeReserva();
        Console.Write("");
        Console.WriteLine("Data do check in:");
        Console.WriteLine($"{datacheckin}");
         Console.Write("");

    }

}