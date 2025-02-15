using AppStarPare.Models;
using AppStarPare.Models.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppStarPare.ViewModel
{
    public partial class EstacionarViewModel : ObservableObject
    {
        public CameraViewModel CameraVM { get; }
        private readonly INavigationService _navigationService;

        [ObservableProperty]
        private bool opcaoMenu;
        [ObservableProperty]
        private bool opcaoEntrada;
         [ObservableProperty]
        private bool opcaoSaida;

        [ObservableProperty]
        private string placa1;
        [ObservableProperty]
        private string placa2;


        public EstacionarViewModel(CameraViewModel cameraVM)
        {   
            CameraVM = cameraVM;
            OpcaoMenu = true;
            OpcaoEntrada = false;
            OpcaoSaida = false;
        }

        [RelayCommand]
        private void EntradaVeiculo()
        {
            OpcaoEntrada = true;
            OpcaoMenu = false;
            OpcaoSaida = false;
        }

        [RelayCommand]
        private void SaidaVeiculo()
        {
            OpcaoEntrada = false;
            OpcaoMenu = false;
            OpcaoSaida = true;
        }

        [RelayCommand]
        private async Task Estacionar()
        {
      
            string placa = placa1 + placa2;

            VeiculoFactory carroFactory = new CarroFactory();
            IVeiculo carro1 = carroFactory.CriarVeiculo(placa);
            carro1.HoraEntrada = DateTime.Now;

            Estacionamento estacionamento = new Estacionamento();
            estacionamento.RegistrarEntrada(carro1);

        }
    }
}
