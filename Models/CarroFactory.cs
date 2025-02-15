using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Models
{
    public class CarroFactory : VeiculoFactory
    {
        public override IVeiculo CriarVeiculo(string placa)
        {
            return new Carro(placa);
        }
    }
}
