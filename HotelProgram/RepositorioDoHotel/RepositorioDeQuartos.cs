using System;
using HotelProgram.Modelo;

namespace HotelProgram.RepositorioDoHotel;

public class RepositorioDeQuartos
{
    private List<Quarto> cadastroDeQuarto = [];

    public void Cadastrar(Quarto cadastrarQuarto)
    {
        cadastroDeQuarto.Add(cadastrarQuarto);
    }
    public List<Quarto> CadastroDeQuarto()
    {
        return cadastroDeQuarto;
    }
}
