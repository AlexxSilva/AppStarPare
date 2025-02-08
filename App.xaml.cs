using AppStarPare.View;

namespace AppStarPare
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new Login());
            return new Window(_serviceProvider.GetRequiredService<Login>());
        }
    }
}