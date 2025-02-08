using AppStarPare.ViewModel;

namespace AppStarPare.View;

public partial class Login : ContentPage
{
	public Login(LoginViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}