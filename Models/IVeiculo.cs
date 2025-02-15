namespace AppStarPare.Models
{
    public interface IVeiculo
    {
        string Placa { get; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; }

    }
}