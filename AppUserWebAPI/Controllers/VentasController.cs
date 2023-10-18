using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> Get()
        {
            return VentaBussiness.ListarVentas().ToArray();
        }
        [HttpDelete(Name = "EliminarVentas")]
        public void Delete([FromBody] int id)
        {
            VentaBussiness.EliminarVenta(id);
        }

        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody] Venta venta)
        {
            VentaBussiness.ModificarVenta(venta);
        }
        [HttpPost(Name = "AltaVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.CrearVenta(venta);
        }
    }
}
