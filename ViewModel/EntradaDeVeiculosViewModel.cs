using ApiStarPare.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace AppStarPare.ViewModel
{
    public partial class EntradaDeVeiculosViewModel : ObservableObject
    {

        private readonly HttpClient _httpClient;

        [ObservableProperty]
        private string marca;

        [ObservableProperty]
        private string modelo;

        [ObservableProperty]
        private string placa;

        [ObservableProperty]
        private int totalPassageiros;

        public EntradaDeVeiculosViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [RelayCommand]
        private void Cancelar()
        {

        }
        [RelayCommand]
        private async void Registrar()
        {
            try
            {
                var carro = new Carro
                {
                    Placa = Placa,
                    Marca = Marca,
                    Modelo = Modelo,
                    TotalPassageiros = TotalPassageiros
                };

                var response = await _httpClient.PostAsJsonAsync("http://192.168.10.17:5094/api/carro", carro);

                if (response.IsSuccessStatusCode)
                {
                    await Shell.Current.DisplayAlert("Sucesso!", "Veículo registrado", "OK");
                }
                else
                {
                    await Shell.Current.DisplayAlert("Erro", $"Falha: {response.StatusCode}", "OK");
                }
            }
            catch (Exception ex)
            {
                string e = ex.ToString();

            }
        }
    }
}
