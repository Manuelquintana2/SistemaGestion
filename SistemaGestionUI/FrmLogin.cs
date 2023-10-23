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
    public partial class FrmLogin : Form
    {
        private List<Usuario> listaUsuarios;
        private Usuario ingresar;
        private int cantIntentos;
        public FrmLogin()
        {
            InitializeComponent();
            this.listaUsuarios = new List<Usuario>();
            this.cantIntentos = 3;
            this.ingresar = new Usuario();
            this.txtContraseña.UseSystemPasswordChar = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.listaUsuarios = UsuariosBussiness.ListarUsuarios();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.ingresar.Mail = txtUsuario.Text;
            this.ingresar.Contraseña = txtContraseña.Text;
            bool retorno = false;

            foreach (Usuario usuario in listaUsuarios)
            {
                if (this.ingresar.Mail == usuario.Mail && this.ingresar.Contraseña == usuario.Contraseña)
                {
                    this.ingresar = usuario;
                    MessageBox.Show($"Bienvenido {this.ingresar.Nombre}", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmProducto frm = new FrmProducto();
                    retorno = true;
                    this.Hide();
                    frm.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    break;
                }
            }
            if (retorno == false && this.cantIntentos > 1)
            {
                cantIntentos--;
                MessageBox.Show($"Contraseña incorrecta, quedan {this.cantIntentos} intentos", "Incorrecto");
            }
            else
            {
                this.Close();
            }
        }

        private void btnMosrar_Click(object sender, EventArgs e)
        {
            if (this.txtContraseña.UseSystemPasswordChar)
            {
                this.txtContraseña.UseSystemPasswordChar = !this.txtContraseña.UseSystemPasswordChar;
                this.btnMosrar.Text = "Ocultar";
            }
            else
            {
                this.txtContraseña.UseSystemPasswordChar = !this.txtContraseña.UseSystemPasswordChar;
                this.btnMosrar.Text = "Mostrar";
            }
        }
    }
}
