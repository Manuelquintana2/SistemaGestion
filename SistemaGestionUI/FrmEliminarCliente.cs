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
    public partial class FrmEliminarCliente : Form
    {
        public FrmEliminarCliente()
        {
            InitializeComponent();
        }
        private Cliente cliente;
        public FrmEliminarCliente(Cliente cliente) : this()
        {
            this.cliente = cliente;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteBussiness.EliminarCliente(cliente.Id);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void FrmEliminarCliente_Load(object sender, EventArgs e)
        {
            this.txtNombreApellido.Text = this.cliente.NombreApellido;
            this.txtDomicilio.Text = this.cliente.Domicilio;
            this.txtTelefono.Text = this.cliente.Telefono;
        }
    }
}
