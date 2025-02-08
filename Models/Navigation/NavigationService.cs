using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStarPare.Models.Navigation
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

    
        public async Task NavigateToAsync<T>() where T : Page
        {
            var page = _serviceProvider.GetService<T>();
            if (page != null)
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(page);
            }
            else
            {
                throw new Exception($"Não foi possível resolver a página {typeof(T).Name}");
            }
        }

        public async Task GoBackAsync()
        {
            if (Application.Current.MainPage.Navigation.NavigationStack.Count > 1)
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            }
        }

    }
}
