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
    public partial class FrmModificarCliente : Form
    {
        public FrmModificarCliente()
        {
            InitializeComponent();
        }
        private Cliente cliente;
        public FrmModificarCliente(Cliente cliente) : this()
        {
            this.cliente = cliente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.cliente.NombreApellido = txtNombreApellido.Text;
            this.cliente.Domicilio = txtDomicilio.Text;
            this.cliente.Telefono = txtTelefono.Text;

            ClienteBussiness.ModificarCliente(this.cliente);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            this.txtNombreApellido.Text = cliente.NombreApellido;
            this.txtDomicilio.Text = cliente.Domicilio;
            this.txtTelefono.Text = cliente.Telefono;
        }
    }
}
