using AppStarPare.Models.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
