using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBussiness.ListarProductos().ToArray();
        }
    
        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int id)
        {
            ProductoBussiness.EliminarProductos(id);
        }

        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto)
        {
            ProductoBussiness.ModificarProductos(producto);
        }
        [HttpPost(Name = "AltaProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.CrearProducto(producto);
        }
    }
}
