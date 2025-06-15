using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagemHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = new List<Pessoa>();
            if (Suite.Capacidade > hospedes.Count())
            {
                foreach (Pessoa hospede in hospedes)
                {
                    Hospedes.Add(hospede);
                }
                Console.WriteLine("Hóspedes adicionados com sucesso!");
            }
            else
            {
                Console.WriteLine("A capacidade da suíte não comporta essa quantidade de hóspedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {            
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;

            // Desconto de 10% para ficar 10 dias ou mais
            if (DiasReservados >= 10)
            {
                valorDiaria = valorDiaria - (10 * valorDiaria / 100);
                return valorDiaria;
            }
            else
            {
                return valorDiaria;
            }
        }
    }
}