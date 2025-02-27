using AppStarPare.Models;
using AppStarPare.Models.Navigation;
using AppStarPare.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace AppStarPare.ViewModel
{
    public partial class MenuViewModel : ObservableObject
    {
        private readonly INavigationService _navigationService;

        public MenuViewModel(INavigationService navigationService)
        {
            this._navigationService = navigationService;
        }

        [RelayCommand]
        private async void EntradaVeiculo()
        {
            await _navigationService.NavigateToAsync<EntradaDeVeiculos>();
        }

        [RelayCommand]
        private void SaidaVeiculo()
        {

        }

        [RelayCommand]
        private void VeiculosEstacionados()
        { 
        
        }

        [RelayCommand]
        private void HistoricoVeiculos()
        {

        }

    }
}
