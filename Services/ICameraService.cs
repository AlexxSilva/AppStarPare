using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Services
{
    public interface ICameraService
    {
        public  Task<FileResult?> TirarFotoAsync();
    }
}
