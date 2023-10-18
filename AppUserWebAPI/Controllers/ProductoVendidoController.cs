using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductosVendidosBussiness.ListarProductosVendidos().ToArray();
        }

        [HttpDelete(Name = "EliminarProductoVendido")]
        public void Delete([FromBody] int id)
        {
            ProductosVendidosBussiness.EliminarProductoVendido(id);
        }

        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductosVendidosBussiness.ModificarProductoVendido(productoVendido);
        }
        [HttpPost(Name = "AltaProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductosVendidosBussiness.CrearProductoVendido(productoVendido);
        }
    }
}
