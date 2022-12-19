using app_productos_prueba.ViewModels;

namespace app_productos_prueba.Views;

public partial class VistaCrearEditarProducto : ContentPage
{
	public VistaCrearEditarProducto(VistaCrearEditarProductoViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}