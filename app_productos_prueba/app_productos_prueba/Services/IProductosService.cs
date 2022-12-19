using app_productos_prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_productos_prueba.Services
{
    public interface IProductosService
    {
        Task<List<Productos>> GetProductosList();

        Task<int> Addproducto(Productos producto);

        Task<int> UpdateProductos(Productos producto);

        Task<int> DeleteProductos(Productos producto);


    }
}
