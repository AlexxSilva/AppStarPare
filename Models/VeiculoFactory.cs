using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Models
{
    public class VeiculoFactory : IVeiculoFactory
    {
        public Veiculo CriarVeiculo(string placa)
        {
            return new Veiculo(placa);
        }
    }
}
