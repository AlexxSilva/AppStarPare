using AppStarPare.Models.Navigation;
using AppStarPare.Models.Usuario;
using AppStarPare.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppStarPare.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IUsuario _usuario;
        private readonly INavigationService _navigationService;

        [ObservableProperty]
        private string? _nome;
        [ObservableProperty]
        private string _senha;
        [ObservableProperty]
        private string _mensagemErro;
        [ObservableProperty]
        private bool _isBusy;

        public LoginViewModel(IUsuario usuario, INavigationService navigationService)
        {
            _usuario = usuario;
            _navigationService = navigationService;
            IsBusy = true;
        }

        [RelayCommand]
        private async void Login()
        {

            IsBusy = false;
            try
            {
                if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(Senha))
                {
                    MensagemErro = "Por favor, preencha todos os campos.";
                }
                else
                {

                    _usuario.Nome = Nome;
                    _usuario.Senha = Senha;

                    await _navigationService.NavigateToAsync<Menu>();

                }
            }
            catch (Exception ex)
            {
            }

            IsBusy = true;
        }
    }
}
