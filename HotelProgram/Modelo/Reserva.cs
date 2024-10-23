using HotelProgram.Modelo;

public class Reserva()
{
    Hospede NomeReserva {get;set;}
    Quarto QuartoReserva {get;set;}
    DateTime DataReserva {get;set;}

                                                        // O this aqui apararentemente chama o construtor
                                                        // que nao tem parametro?
                                                        // ou seja a liçao de hoje é se voce criou um construtor
                                                        // que tem uma variavel que nao tem parametro se for relacionar
                                                        // com outra classe precisa fazer desse jeito por que sim
 public Reserva(Hospede nome, Quarto quarto, DateTime data) : this()
    {
        NomeReserva = nome;
        QuartoReserva = quarto;
        DataReserva = data;
    }
    public  void ExibeReserva()
    {
        Console.WriteLine("Informacoes do hospede:");
        Console.Write("");
        NomeReserva.ExibeHospede();
        Console.WriteLine("Informaçoes do quarto:");
        Console.Write("");
        QuartoReserva.ExibeQuarto();
        Console.Write("");
        Console.WriteLine($"Data da reserva: {DataReserva}");
    }

}
