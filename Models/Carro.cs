using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Models
{
    public class Carro : IVeiculo
    {
        public string Placa { get; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; }

        public Carro(string placa)
        {
            this.Placa = placa; 
        }
    }
}
