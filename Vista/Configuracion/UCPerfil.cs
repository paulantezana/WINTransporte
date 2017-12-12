using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Entidad;
using System.IO;
using Modelo;

namespace Vista.Configuracion
{
    public partial class UCPerfil : UserControl
    {
        private Usuario usuario = UsuarioController.usuario;

        private UsuarioModel usuarioModel = new UsuarioModel();

        public UCPerfil()
        {
            InitializeComponent();
        }

        private void UCPerfil_Load(object sender, EventArgs e)
        {
            textUsuario.Text = usuario.usuario;
            textNombre.Text = usuario.nombre;
            textEmail.Text = usuario.email;
            textFoto.Text = usuario.foto;
            loadImage();
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textFoto.Text = openFileDialog1.FileName;
            loadImage();
        }

        private void loadImage()
        {
            if (textFoto.Text == string.Empty)
            {
                pbxPerfil.Image = null;
            }
            else
            {
                if (File.Exists(textFoto.Text))
                {
                    pbxPerfil.Load(textFoto.Text);
                }
                else
                {
                    pbxPerfil.Image = null;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                errorProvider1.SetError(textUsuario, "El campo usuario esta vacía");
                textUsuario.Focus();
                return;
            }
            errorProvider1.Clear();

            if (textNombre.Text == "")
            {
                errorProvider1.SetError(textNombre, "El campo nombre esta vacía");
                textNombre.Focus();
                return;
            }
            errorProvider1.Clear();

            if (textEmail.Text != textEmail.Text)
            {
                errorProvider1.SetError(textEmail, "Las email no coinciden");
                textEmail.Focus();
                return;
            }
            errorProvider1.Clear();
            errorProvider1.Clear();
            usuarioModel.updateUsuario(textUsuario.Text,textNombre.Text, textEmail.Text, textFoto.Text, usuario.rool, usuario.idUsuario);
            MessageBox.Show("El usuario se actualizo exitosamente. \n para ver los cambios reinicie la aplicacion", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarClave_Click(object sender, EventArgs e)
        {
            if (textOldClave.Text == "")
            {
                errorProvider1.SetError(textOldClave, "El campo contraseña anterior esta vacía");
                textOldClave.Focus();
                return;
            }
            errorProvider1.Clear();

            if (textNewClave.Text == "")
            {
                errorProvider1.SetError(textNewClave, "El campo nueva contraseña esta vacía");
                textNewClave.Focus();
                return;
            }
            errorProvider1.Clear();

            if (textConfirmNewClave.Text == "")
            {
                errorProvider1.SetError(textConfirmNewClave, "El campo confirmar nueva contraseña esta vacía");
                textConfirmNewClave.Focus();
                return;
            }
            errorProvider1.Clear();

            if (textOldClave.Text != usuario.clave)
            {
                errorProvider1.SetError(textOldClave, "La contraseña anterior que ha ingresado es incorrecta");
                textOldClave.Focus();
                return;
            }
            errorProvider1.Clear();

            if (textNewClave.Text != textConfirmNewClave.Text)
            {
                errorProvider1.SetError(textConfirmNewClave, "Las contraseñas no coinciden");
                textConfirmNewClave.Focus();
                return;
            }
            errorProvider1.Clear();

            errorProvider1.Clear();
            usuarioModel.cambiarClave(textNewClave.Text, usuario.idUsuario);
            MessageBox.Show("La contraseña se cambio exitosamente", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textOldClave.Clear();
            textNewClave.Clear();
            textConfirmNewClave.Clear();
        }
    }
}
