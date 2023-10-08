using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class UsuariosBussiness
    {
        public static List<Usuario> ListarUsuarios()
        {
            return UsuariosData.ListarUsuarios();
        }
        public static Usuario ObtenerUsuario(int id)
        {
            return UsuariosData.ObtenerUsuario(id);
        }
        public static void CrearUsuario(Usuario usuario)
        {
            UsuariosData.CrearUsuario(usuario);
        }
        public static void ModificarUsuario(Usuario usuario)
        {
            UsuariosData.ModificarUsuario(usuario);
        }
        public static void EliminarUsuario(Usuario usuario)
        {
            UsuariosData.EliminarUsuario(usuario);
        }
    }
}
