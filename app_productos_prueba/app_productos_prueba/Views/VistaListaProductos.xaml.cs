using app_productos_prueba.ViewModels;

namespace app_productos_prueba.Views;

public partial class VistaListaProductos : ContentPage
{
	private VistaListaProductosViewModels _vm;

	public VistaListaProductos(VistaListaProductosViewModels vm)
	{
		InitializeComponent();
		_vm = vm;
		BindingContext = vm;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		_vm.ListarProductosCommand.Execute(null);
    }
}