using app_productos_prueba.Views;

namespace app_productos_prueba;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(VistaCrearEditarProducto), typeof(VistaCrearEditarProducto));
		Routing.RegisterRoute(nameof(VistaDetalles), typeof(VistaDetalles));
	}
}
