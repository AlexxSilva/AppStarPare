using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Models
{
    public class Estacionamento
    {
        private static Estacionamento _instancia;
        private readonly List<IVeiculo> _veiculos = new List<IVeiculo>();
        public event Action<String> NotificarEvento;
        private readonly ICalculadoraPreco _calculadorapreco;

        public Estacionamento(ICalculadoraPreco calculadoraPreco)
        {
            this._calculadorapreco = calculadoraPreco;

        }

        public Estacionamento()
        {
        }
        public static Estacionamento Instancia(ICalculadoraPreco calculadoraPreco = null)
        {
            return _instancia ??= new Estacionamento(calculadoraPreco);
        }

        public void RegistrarEntrada(IVeiculo veiculo)
        {
            {
                veiculo.HoraEntrada = DateTime.Now;
                _veiculos.Add(veiculo);
                NotificarEvento?.Invoke($"Veiculo {veiculo.Placa} entrou às {veiculo.HoraEntrada}");
            }
        }

        public void RegistrarSaida(string Placa)
        {
            var veiculo = _veiculos.Find(v =>  v.Placa == Placa);
            if (veiculo != null) return;

            veiculo.HoraSaida = DateTime.Now;
            decimal valor = _calculadorapreco.Calcular(veiculo);
            _veiculos.Remove(veiculo);
            NotificarEvento?.Invoke($"Veículo {veiculo.Placa} saiu às {veiculo.HoraSaida}. Valor a pagar: R$ {valor}");

        }
    }
}
