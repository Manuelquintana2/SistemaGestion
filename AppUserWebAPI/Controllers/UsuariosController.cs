using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return UsuariosBussiness.ListarUsuarios().ToArray();
        }
        [HttpDelete(Name = "EliminarUsuarios")]
        public void Delete([FromBody] int id)
        {
            UsuariosBussiness.EliminarUsuario(id);
        }

        [HttpPut(Name = "ModificarUsuario")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuariosBussiness.ModificarUsuario(usuario);
        }
        [HttpPost(Name = "AltaUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuariosBussiness.CrearUsuario(usuario);
        }
    }
}
