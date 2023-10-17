using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace AppUserWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet(Name = "GetClientes")]
        public IEnumerable<Cliente> Get()
        {
            return ClienteBussiness.ListarClientes().ToArray();
        }

        [HttpDelete(Name = "EliminarCliente")]
        public void Delete([FromBody] int id)
        {
            ClienteBussiness.EliminarCliente(id);
        }

        [HttpPut(Name = "ModificarCliente")]
        public void Put([FromBody] Cliente cliente)
        {
            ClienteBussiness.ModificarCliente(cliente);
        }
        [HttpPost(Name = "AltaCliente")]
        public void Post([FromBody] Cliente cliente)
        {
            ClienteBussiness.CrearCliente(cliente);
        }

    }
}
