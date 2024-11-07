using System;
using HotelProgram.Modelo;

namespace HotelProgram.RepositorioDoHotel;

public class RepositorioDeReservas
{
    private List<Reserva> cadastroDeReserva = [];

    public void Reservar(Reserva cadastroDeReservas)
    {
        cadastroDeReserva.Add(cadastroDeReservas);
    }
    public List<Reserva> CadastroDeReservas()
    {
        return cadastroDeReserva;
    }
}