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
    public partial class FrmCrearCliente : Form
    {
        public FrmCrearCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.NombreApellido = txtNombreApellido.Text;
            cliente.Domicilio = txtDomicilio.Text;
            cliente.Telefono = txtTelefono.Text;

            ClienteBussiness.CrearCliente(cliente);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void FrmCrearCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
