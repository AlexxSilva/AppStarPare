using AppStarPare.ViewModel;

namespace AppStarPare.View;

public partial class Menu : ContentPage
{
	public Menu(MenuViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}