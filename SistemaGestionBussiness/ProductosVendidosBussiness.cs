﻿using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductosVendidosBussiness
    {
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }
        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            return ProductoVendidoData.ObtenerProductoVendido(id);
        }
        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }
        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }
        public static void EliminarProductoVendido(int id)
        {
            ProductoVendidoData.EliminarProductoVendido(id);
        }
    }
}
