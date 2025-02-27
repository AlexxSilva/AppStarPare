

namespace ApiStarPare.Models
{
    public class Carro 
    {

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string? Placa { get; set; }
        public int TotalPassageiros { get; set; }
    }
}
