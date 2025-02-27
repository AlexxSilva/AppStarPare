

namespace ApiStarPare.Models
{
    public class Estacionamento
    {

        public int Id { get; set; }

        public DateTime DataEntrada { get; set; } = DateTime.Now;
        public DateTime? DataSaida { get; set; }
        public int? CarroId { get; set; }
        public Carro? CarroEstacionado { get; set; }
    }
}
