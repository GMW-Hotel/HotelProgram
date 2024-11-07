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
    public void OcuparQuarto(int i)
    {
          foreach(var Quarto in cadastroDeQuarto)
        {
            if(Quarto.Numero == i)
            {
                Quarto.Ocupacao = true;
            }
        }
    }
    public void LiberarQuarto(int i)
    {
        foreach(var Quarto in cadastroDeQuarto)
        {
            if(Quarto.Numero == i)
            {
                Quarto.Ocupacao = false;
            }
        }
    }
    public List<Quarto> CadastroDeQuarto()
    {
        return cadastroDeQuarto;
    }
}
