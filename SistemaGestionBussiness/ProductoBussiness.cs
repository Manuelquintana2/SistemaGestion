using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> ListarProductos()
        {
            return ProductosData.ListarProductos();
        }
        public static Producto ObtenerProducto(int id)
        {
            return ProductosData.ObtenerProducto(id);
        }
        public static void CrearProducto(Producto producto)
        {
            ProductosData.CrearProducto(producto);
        }
        public static void ModificarProductos(Producto producto)
        {
            ProductosData.ModificarProducto(producto);
        }
        public static void EliminarProductos(int id)
        {
            ProductosData.EliminarProducto(id);
        }

    }
}