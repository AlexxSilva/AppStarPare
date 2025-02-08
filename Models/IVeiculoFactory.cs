using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Models
{
    public interface IVeiculoFactory
    {
         Veiculo CriarVeiculo(string placa);
    }
}
