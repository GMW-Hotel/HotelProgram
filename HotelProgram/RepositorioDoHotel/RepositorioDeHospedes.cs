using System;
using HotelProgram.Modelo;

namespace HotelProgram.RepositorioDoHotel;

public class RepositorioDeHospedes
{
    private List<Hospede> cadastroDeHospede = [];

    public void Hospedar(Hospede cadastroDeHospedes)
    {
        cadastroDeHospede.Add(cadastroDeHospedes);
    }
    public List<Hospede> CadastroDeHospedes()
    {
        return cadastroDeHospede;
    }

}
