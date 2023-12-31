﻿using SistemaGestion;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProductoVendido productoVendido = new FrmProductoVendido();
            productoVendido.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();
            frmVenta.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios frmUsuario = new FormUsuarios();
            frmUsuario.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Producto producto = ProductoBussiness.ListarProductos().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmMdificarProducto modificar = new frmMdificarProducto(producto);
                modificar.FormClosed += FrmProducto_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmEliminarProducto eliminar = new frmEliminarProducto(producto);
                eliminar.FormClosed += FrmProducto_FormClosed;
                eliminar.ShowDialog();
            }
        }
        private void CargarProductos()
        {
            List<Producto> lista = ProductoBussiness.ListarProductos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaProducto frmAltaProducto = new frmAltaProducto();
            frmAltaProducto.FormClosed += FrmProducto_FormClosed;
            frmAltaProducto.ShowDialog();
        }

        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarProductos();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmCliente = new FrmClientes();
            frmCliente.ShowDialog();
        }
    }
}
