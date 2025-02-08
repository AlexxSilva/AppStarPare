using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Models.Navigation
{
    public interface INavigationService
    {
        Task NavigateToAsync<T>() where T : Page;
        Task GoBackAsync();
    }
}
