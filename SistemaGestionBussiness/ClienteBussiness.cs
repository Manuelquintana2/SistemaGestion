using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ClienteBussiness
    {
        public static List<Cliente> ListarClientes()
        {
            return ClientesData.ListarClientes();
        }
        public static Cliente ObtenerCliente(int id)
        {
            return ClientesData.ObtenerCliente(id);
        }
        public static void CrearCliente(Cliente cliente)
        {
            ClientesData.CrearCliente(cliente);
        }
        public static void ModificarCliente(Cliente cliente)
        {
            ClientesData.ModificarCliente(cliente);
        }
        public static void EliminarCliente(int id)
        {
            ClientesData.EliminarCliente(id);
        }
    }
}
