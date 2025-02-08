using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Models.Usuario
{
    public class Usuario : IUsuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
