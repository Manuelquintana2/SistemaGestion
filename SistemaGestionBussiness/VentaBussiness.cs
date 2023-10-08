using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> ListarVentas()
        {
            return VentasData.ListarVentas();
        }
        public static Venta ObtenerVenta(int id)
        {
            return VentasData.ObtenerVenta(id);
        }
        public static void CrearVenta(Venta venta)
        {
            VentasData.CrearVentas(venta);
        }
        public static void ModificarVenta(Venta venta)
        {
            VentasData.ModificarVentas(venta);
        }
        public static void EliminarVenta(Venta venta)
        {
            VentasData.EliminarVenta(venta);
        }
    }
}
