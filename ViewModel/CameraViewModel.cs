using AppStarPare.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.ViewModel
{
    public partial class  CameraViewModel : ObservableObject
    {
        private readonly ICameraService _cameraService;

        [ObservableProperty]
        private ImageSource fotoSource;

        public CameraViewModel(ICameraService cameraService)
        {
            _cameraService = cameraService;
        }

        [RelayCommand]
        private async Task TirarFoto()
        {
            var foto = await _cameraService.TirarFotoAsync();
            if (foto != null)
            {
                FotoSource = ImageSource.FromFile(foto.FullPath);
            }
        }

    }
}
