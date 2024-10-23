using System;
using System.ComponentModel;
using System.Dynamic;
using System.Net;
using System.Net.Security;

namespace HotelProgram.Modelo;

public class Quarto
{

    public int Numero { get; set; }
    public string Tipo { get; set; }
    public float Valor { get; set; }
    public bool Ocupacao { get; set; }

    public override string ToString()
    {
        if(!Ocupacao)
        {
           return $"[Quarto numero: {Numero}, tipo: {Tipo}, valor: R${Valor}, ocupacao: Livre]"; 
        }
        else
        {
            return $"[Quarto numero: {Numero}, tipo: {Tipo}, valor: R${Valor}, ocupacao: Ocupado]";
        }
    }
    public Quarto(int numero, string tipo, float valor)
    {
        Numero = numero;
        Valor = valor;
       Ocupacao = false;
    }
    public void ExibeQuarto()
    {
         if(!Ocupacao)
        {   
            Console.Write("");
            Console.WriteLine($"Quarto numero: {Numero}, tipo: {Tipo}, valor: R${Valor}, ocupacao: Livre"); 
        }
        else
        {
             Console.Write("");
             Console.WriteLine($"Quarto numero: {Numero}, tipo: {Tipo}, valor: R${Valor}, ocupacao: Ocupado");
        }
    }
}
