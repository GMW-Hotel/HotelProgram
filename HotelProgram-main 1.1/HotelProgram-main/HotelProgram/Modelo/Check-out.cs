
using HotelProgram.Modelo;
public class Checkout()
{
   public Checkin checkin {get;set;}
   public DateTime DataCheckOut{get;set;}
    public Checkout(Checkin checkim,DateTime data) : this()
    {
        checkin = checkim;
        DataCheckOut = data;
           
    }
}