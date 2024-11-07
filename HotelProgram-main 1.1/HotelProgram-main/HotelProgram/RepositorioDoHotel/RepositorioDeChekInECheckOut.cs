
public class RepositoriodeCheckin()
{
    private List<Checkin> cadastrocheckin = [];
    
    public void RelizarCheckin(Checkin checkin)
    {
        cadastrocheckin.Add(checkin);
    }
    public List<Checkin> Obterlista()
    {
        return cadastrocheckin;
    }
}

public class RepositoriodeCheckOut()
{
    private List<Checkout> cadastrocheckout = [];

    public void RealizarCheckout(Checkout checkout)
    {
        cadastrocheckout.Add(checkout);
    }
    public List<Checkout> Obterlista()
    {
        return cadastrocheckout;
    }
}