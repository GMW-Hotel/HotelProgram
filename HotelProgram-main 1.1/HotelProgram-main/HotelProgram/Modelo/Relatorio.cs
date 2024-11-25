using System;
using System.Collections.Generic;

namespace HotelManagement
{
    public class Relatorio
    {
        public string Titulo { get; set; }
        public DateTime DataGeracao { get; private set; }
        public string GeradoPor { get; set; }
        public List<string> Conteudo { get; set; }

        public Relatorio(string titulo, string geradoPor)
        {
            Titulo = titulo;
            GeradoPor = geradoPor;
            DataGeracao = DateTime.Now;
            Conteudo = new List<string>();
        }

        public void AdicionarLinha(string linha)
        {
            Conteudo.Add(linha);
        }

        public void ExibirRelatorio()
        {
            Console.WriteLine($"--- {Titulo} ---");
            Console.WriteLine($"Gerado por: {GeradoPor}");
            Console.WriteLine($"Data de Geração: {DataGeracao}");
            Console.WriteLine();

            foreach (var linha in Conteudo)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine("\n--- Fim do Relatório ---");
        }

        private string GerarTextoRelatorio()
        {
            var relatorioTexto = $"--- {Titulo} ---\n";
            relatorioTexto += $"Gerado por: {GeradoPor}\n";
            relatorioTexto += $"Data de Geração: {DataGeracao}\n\n";

            foreach (var linha in Conteudo)
            {
                relatorioTexto += linha + "\n";
            }

            relatorioTexto += "\n--- Fim do Relatório ---";
            return relatorioTexto;
        }
    }
}
