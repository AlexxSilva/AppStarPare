using AppStarPare.ViewModel;

namespace AppStarPare.View;

public partial class EntradaDeVeiculos : ContentPage
{
	public EntradaDeVeiculos(EntradaDeVeiculosViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}