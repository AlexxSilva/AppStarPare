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

        public LoginViewModel(IUsuario usuario, INavigationService navigationService)
        {
            _usuario = usuario;
            _navigationService = navigationService;
        }

        [RelayCommand]
        private async void Login()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(Senha))
                {
                    MensagemErro = "Por favor, preencha todos os campos.";
                    return;
                }

                // Atribui os valores ao usuário
                _usuario.Nome = Nome;
                _usuario.Senha = Senha;

                // Simulação de autenticação
                if (_usuario.Nome == "admin" && _usuario.Senha == "1234")
                {
                    MensagemErro = "Login bem-sucedido!";

                    await _navigationService.NavigateToAsync<Estacionar>();

                    // Aqui você pode navegar para outra página ou executar outra ação
                }
                else
                {
                    MensagemErro = "Usuário ou senha incorretos.";
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
