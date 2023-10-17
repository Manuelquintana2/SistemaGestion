using SistemaGestion;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Cliente cliente = ClienteBussiness.ListarClientes().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                FrmModificarCliente modificar = new FrmModificarCliente(cliente);
                modificar.FormClosed += FrmClientes_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                FrmEliminarCliente eliminar = new FrmEliminarCliente(cliente);
                eliminar.FormClosed += FrmClientes_FormClosed;
                eliminar.ShowDialog();
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarCliente();
        }

        private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarCliente();
        }
        private void CargarCliente()
        {
            List<Cliente> lista = ClienteBussiness.ListarClientes();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmCrearCliente cliente = new FrmCrearCliente();
            cliente.FormClosed += FrmClientes_FormClosed;
            cliente.ShowDialog();
        }
    }
}
