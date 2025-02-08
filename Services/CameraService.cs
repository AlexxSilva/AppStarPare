using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Services
{
    public class CameraService : ICameraService
    {
        public async Task<FileResult?> TirarFotoAsync()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                try
                {
                    var foto = await MediaPicker.CapturePhotoAsync();

                    if (foto != null)
                    {
                        var novoCaminho = Path.Combine(FileSystem.CacheDirectory, foto.FileName);
                        using  var stream = await foto.OpenReadAsync();
                        using var novoArquivo  = File.OpenWrite(novoCaminho);
                        await stream.CopyToAsync(novoArquivo);

                        return  foto;
                    }
                }
                catch (Exception ex)
                {
                    //erro
                }
            }

            return null;
        }
    }
}
