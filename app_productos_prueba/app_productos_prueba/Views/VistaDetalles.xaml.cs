using app_productos_prueba.ViewModels;

namespace app_productos_prueba.Views;

public partial class VistaDetalles : ContentPage
{
	public VistaDetalles(VistaDetallesViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}