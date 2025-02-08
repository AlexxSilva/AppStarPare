using AppStarPare.ViewModel;

namespace AppStarPare.View;

public partial class Estacionar : ContentPage
{
	public Estacionar(EstacionarViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}