using System;
using Microsoft.VisualBasic;

namespace HotelProgram.Modelo;

public class Reserva()
{
    public Hospede ReservaHospede { get; set; }
    public Quarto ReservaQuarto { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaida { get; set; }
    public override string ToString()
    {
        return $"Informações do hospede:{ReservaHospede}\n" +
                $"Informações do quarto: {ReservaQuarto}\n" +
                $"Data de entrada: {DataEntrada}\n" +
                $"Data de saída: {DataSaida}\n";
    }
    public Reserva(Hospede hospede, Quarto quarto, DateTime dateE, DateTime dateS) : this()
    {
        ReservaHospede = hospede;
        ReservaQuarto = quarto;
        DataEntrada = dateE;
        DataSaida = dateS;
    }
    public void ExibeReserva()
    {
        Console.WriteLine("Informações do hóspede: ");
        ReservaHospede.ExibeHospede();
        Console.WriteLine("Informações do quarto: ");
        ReservaQuarto.ExibeQuarto();
        Console.WriteLine($"Data de entrada: {DataEntrada:dd/MM/yyyy} ");
        Console.WriteLine($"Data de saída: {DataSaida:dd/MM/yyyy}");
    }
}
