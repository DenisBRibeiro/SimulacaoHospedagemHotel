using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagemHotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipo, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipo;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}